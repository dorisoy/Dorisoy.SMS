using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
//using System.Threading.Tasks;
//using SMS.MediatR.Queries;
//using System.Reactive.Disposables;
using SMS.Common;



namespace SMS
{
  public class ViewLocator : IDataTemplate
  {
    public bool SupportsRecycling => false;

    public IControl Build(object data)
    {
      var name = data.GetType().FullName!.Replace("ViewModel", "View");
      var type = Type.GetType(name);

      if (type != null)
      {
        return (Control)Activator.CreateInstance(type)!;
      }
      else
      {
        return new TextBlock { Text = "Not Found: " + name };
      }
    }

    public bool Match(object data)
    {
      return data is ViewModelBase;
    }
  }
}
