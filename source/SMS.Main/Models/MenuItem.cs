using System.Windows.Input;

namespace SMS.Main.Models
{
  public class MenuItem
  {
    public ICommand Command { get; set; }

    public string Icon { get; set; } = "";

    public string Label { get; set; } = "";

    public string MenuName { get; set; } = "";

    public string ParentName { get; set; } = "";
  }
}