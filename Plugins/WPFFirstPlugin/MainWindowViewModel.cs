using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFFirstPlugin
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        #region implement property changed

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion



        #region Properies


        #endregion

    }
}
