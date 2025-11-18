using System.Windows;

namespace Xaml.DataGrid.Issue
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() : base()
        {
            InitializeComponent();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new();
            //ShutdownMode = ShutdownMode.OnExplicitShutdown;

            mainWindow.Show();


            //ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
    }

}
