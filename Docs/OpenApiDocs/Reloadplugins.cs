#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Wpf.Runtime"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace UserMacros
{
    public sealed class Macro
    {
        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]

        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartAction("dotdiaLoadDialogs", "");
            Tekla.Structures.ModelInternal.Operation.dotStartAction("dotdiaReloadDialogs", "");
            Tekla.Structures.Model.Operations.Operation.DisplayPrompt("Dialogs reloaded..");
        }
    }
}