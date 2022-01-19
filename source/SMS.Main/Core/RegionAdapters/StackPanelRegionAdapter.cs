using Avalonia.Controls;
using Prism.Regions;

namespace SMS.Main.Core.RegionAdapters
{
  public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
  {
    public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
      : base(regionBehaviorFactory)
    {
    }

    protected override void Adapt(IRegion region, StackPanel regionTarget)
    {
      region.Views.CollectionChanged += (sender, e) =>
      {
        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        {
          foreach (IControl item in e.NewItems)
          {
            if (e.NewItems != null)
              regionTarget.Children.Add(item);
          }
        }

        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
        {
          foreach (IControl item in e.OldItems)
          {
            if (e.OldItems != null)
              regionTarget.Children.Remove(item);
          }
        }
      };
    }

    protected override IRegion CreateRegion() => new SingleActiveRegion() { };
  }
}