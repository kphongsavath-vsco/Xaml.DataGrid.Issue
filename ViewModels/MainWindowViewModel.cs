using Microsoft.Extensions.DependencyInjection;
using Xaml.DataGrid.Issue.Models;

namespace Xaml.DataGrid.Issue.ViewModels
{
    public interface IMainWindowViewModel
    {
        object CurrentView { get; set; }
        IEnumerable<LineItem> LineItems { get; }
    }
    public partial class MainWindowViewModel: IMainWindowViewModel
    {
        public MainWindowViewModel()
        {
            LineItems = DataGen.GetData;
            CurrentView = Program.Services.GetRequiredService<IHomeViewModel>();
        }
        public IEnumerable<LineItem> LineItems { get; }

        public object CurrentView { get; set;  } 

    }
}
