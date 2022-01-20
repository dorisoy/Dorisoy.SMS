using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
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

      //主题
      Styles.Add(new DarkTheme());

      base.Initialize();
    }

   
    protected override void OnInitialized()
    {
      // 将视图注册到它将出现的区域,不要在ViewModel中注册它们。
      var regionManager = Container.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(DashboardView));


      var userInfoToken = Container.Resolve<UserInfoToken>();
      userInfoToken.Id = Guid.Parse("4b352b37-332a-40c6-ab05-e38fcf109719");
      userInfoToken.Email = "czhcom@163.com";


    }



    protected override void RegisterTypes(IContainerRegistry crg)
    {
      var container = crg.GetContainer();

      // Services
      var services = new ServiceCollection();

      services.AddLogging(logging => logging.AddConsole()).BuildServiceProvider();


      //注册MediatR
      var assembly = AppDomain.CurrentDomain.Load("SMS.MediatR");
      container.RegisterMediator(new HierarchicalLifetimeManager());
      container.RegisterMediatorHandlers(assembly);
      container.RegisterType(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>), "ValidationBehavior");
      //container.RegisterType(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>), "RequestPreProcessorBehavior");
      //container.RegisterType(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>), "RequestPostProcessorBehavior");
      //container.RegisterType(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>), "GenericPipelineBehavior");
      //container.RegisterType(typeof(IRequestPreProcessor<>), typeof(GenericRequestPreProcessor<>), "GenericRequestPreProcessor");
      //container.RegisterType(typeof(IRequestPostProcessor<,>), typeof(GenericRequestPostProcessor<,>), "GenericRequestPostProcessor");


      crg.RegisterSingleton<UserInfoToken>();


      //读取配置
      var configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();


      //注册AutoMapper
      crg.RegisterInstance(MapperConfig.GetMapperConfigs());

      //注册ILogger
      crg.Register(typeof(ILogger<>), typeof(Logger<>));
      crg.Register<ILoggerFactory, LoggerFactory>();


      //注册UnitOfWork
      crg.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
      crg.Register<IPropertyMappingService, PropertyMappingService>();
      crg.Register<ILoginAuditRepository, LoginAuditRepository>();
      crg.Register<INLogRespository, NLogRespository>();
      crg.Register<IUserNotificationRepository, UserNotificationRepository>();


      //注册 Views - Generic
      crg.Register<MainWindow>();
      crg.Register<StackPanelRegionAdapter>();
      crg.Register<GridRegionAdapter>();


      //注册 Views - Region Navigation
      crg.RegisterForNavigation<MainWindow, MainWindowViewModel>();
      crg.RegisterForNavigation<MainTabView, MainTabViewModel>();
      crg.RegisterForNavigation<DashboardView, DashboardViewModel>();
      crg.RegisterForNavigation<SettingsView, SettingsViewModel>();
      crg.RegisterForNavigation<NavigationView, NavigationViewModel>();

    }


    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
      base.ConfigureModuleCatalog(moduleCatalog);

      moduleCatalog.AddModule<MailModule>();
      moduleCatalog.AddModule<MessageModule>();
      moduleCatalog.AddModule<ContactsModule>();
      moduleCatalog.AddModule<CalendarModule>();
      moduleCatalog.AddModule<SampleFooterModule>();
    }

    protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
    {
      base.ConfigureRegionAdapterMappings(regionAdapterMappings);
      regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
      regionAdapterMappings.RegisterMapping(typeof(Grid), Container.Resolve<GridRegionAdapter>());
    }

    protected override IAvaloniaObject CreateShell()
    {
      return this.Container.Resolve<MainWindow>();
    }


  }


  public static class ContainerExtensions
  {
    public static bool IsMediatorHandler(this Type arg)
    {
      return arg.GetInterfaces().Where(i => i.Name.StartsWith("IRequestHandler")).Any();
    }


    /// <summary>
    /// 注册MediatR
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


      /*
       Unity.ResolutionFailedException:“Resolution failed with error: No public constructor is
      available for type Microsoft.EntityFrameworkCore.DbContextOptions.
      For more detailed information run Unity in debug mode: new UnityContainer(ModeFlags.Diagnostic)”


      Unity.ResolutionFailedException:“Resolution failed with error: No public constructor is
      available for type Microsoft.Extensions.Logging.ILogger`1[SMS.Data.UnitOfWork`1[SMS.Data.SMSContext]].


       */
    }

    /// <summary>
    /// 注册MediatR Handler
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
    ///     Register all implementations of a given type for provided assembly.
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
    ///     Register all implementations of a given type for provided assembly.
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