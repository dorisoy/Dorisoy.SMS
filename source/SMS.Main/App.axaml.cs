using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FluentValidation;
using MediatR;
//using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using SMS.Common;
using SMS.Data;
using SMS.Main.Core.RegionAdapters;
using SMS.MediatR.PipeLineBehavior;
using SMS.Modules.Calendar;
using SMS.Modules.Contacts;
using SMS.Modules.Mail;
using SMS.Modules.Message;
using SMS.Modules.SampleFooter;
using SMS.Repository;
using SMS.Styles.Themes;
using SMS.ViewModels;
using SMS.Views;
using Unity;
using Unity.Lifetime;
using SMS.Data.Dto;


namespace SMS
{
  public class App : PrismApplication
  {
    public override void Initialize()
    {
      AvaloniaXamlLoader.Load(this);

      //����
      Styles.Add(new DarkTheme());

      base.Initialize();
    }


    protected override void OnInitialized()
    {
      // ����ͼע�ᵽ�������ֵ�����,��Ҫ��ViewModel��ע�����ǡ�
      var regionManager = Container.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(DashboardView));


      //Test
      var userInfoToken = Container.Resolve<UserInfoToken>();
      userInfoToken.Id = Guid.Parse("4b352b37-332a-40c6-ab05-e38fcf109719");
      userInfoToken.Email = "czhcom@163.com";


      //using (var context = new SMSContext())
      //{
      //  context.Database.EnsureCreated();

      //  context.UserAccount.Add(new UserAccount {
      //    UserID = 0,
      //    RoleID = 0,
      //    StaffID = 0,
      //    StudentID = 0,
      //    EmailAddress = "czhcom@163.com",
      //    UserName = "admin",
      //    Password = "123456",
      //    AccountStatus = "",
      //    CreatedDate = DateTime.Now,
      //    CreatedBy = Guid.NewGuid(),
      //    ModifiedDate = DateTime.Now,
      //    ModifiedBy = Guid.NewGuid(),
      //    DeletedDate = DateTime.Now,
      //    DeletedBy = Guid.NewGuid(),
      //    IsDeleted = false
      //  });

      //  context.SaveChanges();
      //}

    }

    protected override IAvaloniaObject CreateShell()
    {
      return this.Container.Resolve<MainWindow>();
    }


    protected override void RegisterTypes(IContainerRegistry crg)
    {
      var container = crg.GetContainer();

      // Services
      var services = new ServiceCollection();
      services.AddLogging(logging => logging.AddConsole());
      using (var provider = services.BuildServiceProvider())
      {
        //var app = provider.GetService<Avalonia.Application>();
        //var builder = AppBuilder.Configure(app);
      };
     

      //ע��MediatR
      var assembly = AppDomain.CurrentDomain.Load("SMS.MediatR");
      container.RegisterMediator(new HierarchicalLifetimeManager());
      container.RegisterMediatorHandlers(assembly);
      container.RegisterType(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>), "ValidationBehavior");


      crg.RegisterSingleton<UserInfoToken>();


      //ע��AutoMapper
      crg.RegisterInstance(MapperConfig.GetMapperConfigs());

      //ע��ILogger
      crg.Register(typeof(ILogger<>), typeof(Logger<>));
      crg.Register<ILoggerFactory, LoggerFactory>();


      //ע��UnitOfWork
      crg.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
      crg.Register<IPropertyMappingService, PropertyMappingService>();
      crg.Register<ILoginAuditRepository, LoginAuditRepository>();
      crg.Register<INLogRespository, NLogRespository>();
      crg.Register<IUserNotificationRepository, UserNotificationRepository>();


      //ע�� Views - Generic
      crg.Register<MainWindow>();
      crg.Register<StackPanelRegionAdapter>();
      crg.Register<GridRegionAdapter>();


      //ע�� Views - Region Navigation
      crg.RegisterForNavigation<MainWindow, MainWindowViewModel>();
      crg.RegisterForNavigation<MainTabView, MainTabViewModel>();
      crg.RegisterForNavigation<DashboardView, DashboardViewModel>();
      crg.RegisterForNavigation<SettingsView, SettingsViewModel>();
      //crg.RegisterForNavigation<NavigationView, NavigationViewModel>();

    }


    /// <summary>
    /// ����ģ��
    /// </summary>
    /// <param name="moduleCatalog"></param>
    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
      base.ConfigureModuleCatalog(moduleCatalog);

      moduleCatalog.AddModule<MailModule>();
      moduleCatalog.AddModule<MessageModule>();
      moduleCatalog.AddModule<ContactsModule>();
      moduleCatalog.AddModule<CalendarModule>();
      moduleCatalog.AddModule<SampleFooterModule>();
    }


    /// <summary>
    /// AdapterMapping
    /// </summary>
    /// <param name="regionAdapterMappings"></param>
    protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
    {
      base.ConfigureRegionAdapterMappings(regionAdapterMappings);
      regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
      regionAdapterMappings.RegisterMapping(typeof(Grid), Container.Resolve<GridRegionAdapter>());
    }

  }


  /// <summary>
  /// Container ��չ
  /// </summary>
  public static class ContainerExtensions
  {
    public static bool IsMediatorHandler(this Type arg)
    {
      return arg.GetInterfaces().Where(i => i.Name.StartsWith("IRequestHandler")).Any();
    }


    /// <summary>
    /// ע��MediatR
    /// </summary>
    /// <param name="container"></param>
    /// <param name="lifetimeManager"></param>
    /// <returns></returns>
    public static IUnityContainer RegisterMediator(this IUnityContainer container, ITypeLifetimeManager lifetimeManager)
    {
      return container.RegisterType<IMediator, Mediator>(lifetimeManager)
          .RegisterInstance<ServiceFactory>(type =>
          {
            var enumerableType = type
                  .GetInterfaces()
                  .Concat(new[] { type })
                  .FirstOrDefault(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>));

            return enumerableType != null
                  ? container.ResolveAll(enumerableType.GetGenericArguments()[0])
                  : container.IsRegistered(type)
                      ? container.Resolve(type)
                      : null;
          });

    }

    /// <summary>
    /// ע��MediatR Handler
    /// </summary>
    /// <param name="container"></param>
    /// <param name="assembly"></param>
    /// <returns></returns>
    public static IUnityContainer RegisterMediatorHandlers(this IUnityContainer container, Assembly assembly)
    {
      return container.RegisterTypesImplementingType(assembly, typeof(IRequestHandler<,>))
          .RegisterNamedTypesImplementingType(assembly, typeof(INotificationHandler<>));
    }

    internal static bool IsGenericTypeOf(this Type type, Type genericType)
    {
      return type.IsGenericType &&
             type.GetGenericTypeDefinition() == genericType;
    }

    internal static void AddGenericTypes(this List<object> list, IUnityContainer container, Type genericType)
    {
      var genericHandlerRegistrations =
          container.Registrations.Where(reg => reg.RegisteredType == genericType);

      foreach (var handlerRegistration in genericHandlerRegistrations)
      {
        if (list.All(item => item.GetType() != handlerRegistration.MappedToType))
        {
          list.Add(container.Resolve(handlerRegistration.MappedToType));
        }
      }
    }

    /// <summary>
    /// Ϊ�ṩ�ĳ���ע��������͵�����ʵ��
    /// </summary>
    public static IUnityContainer RegisterTypesImplementingType(this IUnityContainer container, Assembly assembly, Type type)
    {
      foreach (var implementation in assembly.GetTypes().Where(t => t.GetInterfaces().Any(implementation => IsSubclassOfRawGeneric(type, implementation))))
      {
        var interfaces = implementation.GetInterfaces();
        foreach (var @interface in interfaces)
          container.RegisterType(@interface, implementation);
      }

      return container;
    }

    /// <summary>
    /// Ϊ�ṩ�ĳ���ע��������͵�����ʵ��.
    /// </summary>
    public static IUnityContainer RegisterNamedTypesImplementingType(this IUnityContainer container, Assembly assembly, Type type)
    {
      foreach (var implementation in assembly.GetTypes().Where(t => t.GetInterfaces().Any(implementation => IsSubclassOfRawGeneric(type, implementation))))
      {
        var interfaces = implementation.GetInterfaces();
        foreach (var @interface in interfaces)
          container.RegisterType(@interface, implementation, implementation.FullName);
      }

      return container;
    }

    /// <summary>
    /// �Ƿ�������
    /// </summary>
    /// <param name="generic"></param>
    /// <param name="toCheck"></param>
    /// <returns></returns>
    private static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
    {
      while (toCheck != null && toCheck != typeof(object))
      {
        var currentType = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
        if (generic == currentType)
          return true;

        toCheck = toCheck.BaseType;
      }

      return false;
    }
  }
}