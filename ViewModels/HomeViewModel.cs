using Xaml.DataGrid.Issue.Models;

namespace Xaml.DataGrid.Issue.ViewModels
{
    public interface IHomeViewModel
    {
        IEnumerable<LineItem> LineItems { get; }
    }
    public partial class HomeViewModel: IHomeViewModel
    {
        public HomeViewModel()
        {
            LineItems = DataGen.GetData;
        }
        public IEnumerable<LineItem> LineItems { get; }
    }
}
