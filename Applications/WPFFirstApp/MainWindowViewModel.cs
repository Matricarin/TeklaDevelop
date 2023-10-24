using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFFirstApp
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Implement PropertyChanged interface

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

        #region Fields

        private string _partName = string.Empty;
        private string _partProfile = string.Empty;
        private string _partMaterial = string.Empty;

        #endregion

        #region Properties

        public string Name
        {
            get { return _partName; }
            set => Set(ref _partName, value);
        }

        public string Profile
        {
            get { return _partProfile; }
            set => Set(ref _partProfile, value);
        }

        public string Material
        {
            get { return _partMaterial; }
            set => Set(ref _partMaterial, value);
        }

        #endregion
    }
}
