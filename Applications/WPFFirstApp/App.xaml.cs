using System.Windows;
using TSM = Tekla.Structures.Model;

namespace WPFFirstApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private TSM.Events _events = new TSM.Events();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var window = new MainWindow();

            if (new TSM.Model().GetConnectionStatus())
            {
                _events.TeklaStructuresExit += ExitEvent;

                new System.Windows.Interop.WindowInteropHelper(window).Owner =
                    Tekla.Structures.Dialog.MainWindow.Frame.Handle;
                window.Show();
            }
        }

        void ExitEvent()
        {
            base.Shutdown();
        }
    }
}
