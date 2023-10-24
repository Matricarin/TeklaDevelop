using System.Windows;

using Tekla.Structures.Dialog;

namespace WPFFirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ApplicationWindowBase
    {
        private MainWindowViewModel viewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            this.InitializeDataStorage(viewModel);
            if (this.GetConnectionStatus())
            {
                InitializeDistanceUnitDecimals();
            }
        }
    }
}
