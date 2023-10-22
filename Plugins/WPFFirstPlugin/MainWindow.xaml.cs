using Tekla.Structures.Dialog;

namespace WPFFirstPlugin
{
    public partial class MainWindow : PluginWindowBase
    {
        public MainWindowViewModel viewModel;
        public MainWindow(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            viewModel = ViewModel;
        }
    }
}
