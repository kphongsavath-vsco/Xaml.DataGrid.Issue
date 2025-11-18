using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Xaml.DataGrid.Issue.ViewModels;

namespace Xaml.DataGrid.Issue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMainWindowViewModel viewModel;
        public MainWindow()
        {
            viewModel = Program.Services.GetRequiredService<IMainWindowViewModel>();
            DataContext = viewModel;
            InitializeComponent();
        }
    }



}