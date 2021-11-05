// See https://aka.ms/new-console-template for more information
using GroupDocs.Viewer;
using GroupDocs.Viewer.Options;
using System.Reflection;

Console.WriteLine("GroupDocsViewer Test on .Net 6");
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