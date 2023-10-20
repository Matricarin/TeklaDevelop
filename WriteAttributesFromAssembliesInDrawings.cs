#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Wpf.Runtime"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive
using System.Windows.Forms;
using System.Collections.Generic;
using TSM = Tekla.Structures.Model;
using TSMU = Tekla.Structures.Model.UI;
using TSD = Tekla.Structures.Drawing;
using TSDU = Tekla.Structures.Drawing.UI;
using System.Windows;

namespace Tekla.Technology.Akit.UserScript
{
    public class Script
    {
        //Наименование атрибута в сборке
        private static readonly string assemblyAttribute = "";
        //Наименование атрибута в чертеже
        private static readonly string drawingAttribute = "";

        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]
        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime)
        {
            TSM.Model model = new TSM.Model();
            if (model.GetConnectionStatus())
            {
                TSMU.ModelObjectSelector selector = new TSMU.ModelObjectSelector();

                TSM.ModelObjectEnumerator objects = selector.GetSelectedObjects();

                int objectEnumeratorSize = objects.GetSize();

                if (objectEnumeratorSize == 0)
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Не выбраны сборки в модели.");
                    return;
                }

                TSD.DrawingHandler handler = new TSD.DrawingHandler();

                TSDU.DrawingSelector drawingSelector = handler.GetDrawingSelector();

                TSD.DrawingEnumerator drawingEnumerator = drawingSelector.GetSelected();

                int drawingEnumeratorSize = drawingEnumerator.GetSize();
                if (drawingEnumeratorSize == 0)
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Не выбраны чертежи сборок в диспетчере документов.");
                    return;
                }

                List<TSM.Assembly> assemblies = GetAssemblies(objects);

                List<TSD.AssemblyDrawing> drawings = GetAssembliesDrawings(drawingEnumerator);

                SetAttributes(assemblies, drawings);

                MessageBox.Show(new Form() { TopMost = true }, "Завершено. Переоткройте диспетчер документов.");
            }
            else
            {
                MessageBox.Show(new Form() { TopMost = true }, "Нет соединения с моделью.");
            }
        }

        private static List<TSD.AssemblyDrawing> GetAssembliesDrawings(TSD.DrawingEnumerator drawings)
        {
            List<TSD.AssemblyDrawing> result = new List<TSD.AssemblyDrawing>();
            while (drawings.MoveNext())
            {
                if (drawings.Current is TSD.AssemblyDrawing)
                {
                    var dr = (TSD.AssemblyDrawing)drawings.Current;
                    result.Add(dr);
                }
            }

            return result;
        }

        private static List<TSM.Assembly> GetAssemblies(TSM.ModelObjectEnumerator objects)
        {
            List<TSM.Assembly> result = new List<TSM.Assembly>();

            while (objects.MoveNext())
            {
                if (objects.Current is TSM.Assembly)
                {
                    var assembly = (TSM.Assembly)objects.Current;
                    result.Add(assembly);
                }
            }

            return result;
        }

        private static void SetAttributes(List<TSM.Assembly> assemblies, List<TSD.AssemblyDrawing> drawings)
        {
            foreach (var drawing in drawings)
            {
                var id = drawing.AssemblyIdentifier;
                foreach (var assembly in assemblies)
                {
                    if (assembly.Identifier.ID == drawing.AssemblyIdentifier.ID)
                    {
                        string number = string.Empty;
                        assembly.GetReportProperty(assemblyAttribute, ref number);
                        drawing.SetUserProperty(drawingAttribute, number);
                    }
                }
            }
        }
    }
}
