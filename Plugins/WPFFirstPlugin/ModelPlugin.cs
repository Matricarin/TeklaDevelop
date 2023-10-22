using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;

namespace WPFFirstPlugin
{
    [Plugin("WPFFirstPlugin")]
    [PluginUserInterface("WPFFirstPlugin.MainWindow")]
    public class ModelPlugin : PluginBase
    {
        #region Fields

        private Model _model;
        private PluginData _data;

        private string _partName = String.Empty;
        private string _partProfile = String.Empty;
        private string _partMaterial = String.Empty;

        #endregion

        #region Properties

        private Model Model
        {
            get => this._model;
            set => this._model = value;
        }

        private PluginData Data
        {
            get => this._data;
            set => this._data = value;
        }

        #endregion

        #region Constructor

        public ModelPlugin(PluginData data)
        {
            Model = new Model();
            Data = data;
        }

        #endregion

        #region Main
        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                GetValuesFromDialog();

                ArrayList Points = (ArrayList)Input[0].GetInput();
                Point StartPoint = Points[0] as Point;
                Point EndPoint = Points[1] as Point;

                Beam beam = new Beam(StartPoint, EndPoint);
                beam.Name = _partName;
                beam.Profile.ProfileString = _partProfile;
                beam.Material.MaterialString = _partMaterial;
                beam.Insert();

                Operation.DisplayPrompt("Selected component ");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return true;
        }

        public override List<InputDefinition> DefineInput()
        {
            List<InputDefinition> input = new List<InputDefinition>();
            Picker picker = new Picker();
            ArrayList points = picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS);

            input.Add(new InputDefinition(points));
            return input;
        }

        #endregion

        #region DataFromDialog

        private void GetValuesFromDialog()
        {
            _partName = Data.partName;
            _partProfile = Data.partProfile;
            _partMaterial = Data.partMaterial;

            if (IsDefaultValue(_partName))
            {
                _partName = "Beam";
            }
            if (IsDefaultValue(_partProfile))
            {
                _partProfile = "HEA200";
            }
            if (IsDefaultValue(_partMaterial))
            {
                _partMaterial = "STEEL_UNDEFINED";
            }
        }
        #endregion
    }
}
