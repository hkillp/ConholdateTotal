using GroupDocs.Viewer.Options;
using System;
using System.IO;
using System.Reflection;

namespace GroupDocs.Viewer.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GroupDocsViewer Test on .Net 5");
            try
            {
                var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var filePath = buildDir + @"\Test.pdf";
                Stream fs = File.OpenRead(filePath);
                using Viewer viewer = new Viewer(fs);
                HtmlViewOptions viewOptions = HtmlViewOptions.ForEmbeddedResources();
                viewOptions.RenderToSinglePage = true;
                viewer.View(viewOptions);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
