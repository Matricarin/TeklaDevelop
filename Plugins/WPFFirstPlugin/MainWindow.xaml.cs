using System;
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
        private void WPFOkApplyModifyGetOnOffCancel_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void WPFOkApplyModifyGetOnOffCancel_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WPFOkApplyModifyGetOnOffCancel_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void WPFOkApplyModifyGetOnOffCancel_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void WPFOkApplyModifyGetOnOffCancel_OkClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        private void WPFOkApplyModifyGetOnOffCancel_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void WPFMaterialCatalog_SelectClicked(object sender, EventArgs e)
        {
            this.materialCatalog.SelectedMaterial = this.viewModel.Material;
        }

        private void WPFMaterialCatalog_SelectionDone(object sender, EventArgs e)
        {
            this.viewModel.Material = this.materialCatalog.SelectedMaterial;
        }

        private void profileCatalog_SelectClicked(object sender, EventArgs e)
        {
            this.profileCatalog.SelectedProfile = this.viewModel.Profile;
        }

        private void profileCatalog_SelectionDone(object sender, EventArgs e)
        {
            this.viewModel.Profile = this.profileCatalog.SelectedProfile;
        }
    }
}
