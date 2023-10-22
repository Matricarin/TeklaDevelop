using Tekla.Structures.Plugins;

namespace WPFFirstPlugin
{
    public class PluginData
    {
        //data in view
        #region Fields

        [StructuresField("name")]
        public string partName;

        [StructuresField("profile")]
        public string partProfile;
        
        [StructuresField("material")]
        public string partMaterial;

        #endregion
    }
}
