using System.ComponentModel;
using System.Runtime.CompilerServices;

using Tekla.Structures.Dialog;
using TD = Tekla.Structures.Datatype;

namespace WPFFirstPlugin
{
    public class MainWindowViewModel : INotifyPropertyChanged
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

        #region Fields

        private string partName = string.Empty;
        private string partProfile = string.Empty;
        private string partMaterial = string.Empty;

        #endregion

        #region Properies

        [StructuresDialog("name", typeof(TD.String))]
        public string Name
        {
            get { return partName; }
            set => Set(value, Name);
        }

        [StructuresDialog("profile", typeof(TD.String))]
        public string Profile
        {
            get { return partProfile; }
            set => Set(value, Profile);
        }

        [StructuresDialog("material", typeof(TD.String))]
        public string Material
        {
            get { return partMaterial; }
            set => Set(value, Material);
        }

        #endregion

    }
}
