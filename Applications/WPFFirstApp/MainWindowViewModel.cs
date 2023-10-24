using System.ComponentModel;
using System.Runtime.CompilerServices;

using Tekla.Structures.Model;
using Tekla.Structures.Dialog;
using Tekla.Structures.Model.UI;
using TD = Tekla.Structures.Datatype;
using TSG3D = Tekla.Structures.Geometry3d;


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

        [StructuresDialog("name"), typeof(TD.String)]
        public string Name
        {
            get { return _partName; }
            set => Set(ref _partName, value);
        }

        [StructuresDialog("profile"), typeof(TD.String)]
        public string Profile
        {
            get { return _partProfile; }
            set => Set(ref _partProfile, value);
        }

        [StructuresDialog("material"), typeof(TD.String)]
        public string Material
        {
            get { return _partMaterial; }
            set => Set(ref _partMaterial, value);
        }

        #endregion

        #region Application logic
        public void CreateBeam()
        {
            Picker picker = new Picker();
            ArrayList PickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS, "Give beam points.. ");
            CheckDefaultValues();

            TSG3D.Point startPoint = PickedPoints[0] as TSG.Point;
            TSG3D.Point endPoint = PickedPoints[1] as TSG.Point;

            Beam beam = new Beam(startPoint, endPoint);
            beam.Name = this._partName;
            beam.Profile.ProfileString = this._partProfile;
            beam.Material.MaterialString = this._partMaterial;
            beam.Insert();

            new Model().CommitChanges();
        }

        #endregion

        #region Helper method

        private void CheckDefaultValues()
        {
            if (this._partName == string.Empty)
                this._partName = "TEST";
            if (this._partProfile == string.Empty)
                this._partProfile = "HEA300";
            if (this._partMaterial == string.Empty)
                this._partMaterial = "STEEL_UNDEFINED";
        }

        #endregion
    }
}
