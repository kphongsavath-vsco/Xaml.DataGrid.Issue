using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;
using Xaml.DataGrid.Issue.ViewModels;

namespace Xaml.DataGrid.Issue.Views
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        private readonly IHomeViewModel viewModel;

        public Home()
        {
            viewModel = Program.Services.GetRequiredService<IHomeViewModel>();
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
