using System.IO;
using System.Web;
using LessCss.Loaders;

namespace LessCss.Web
{
	public class LessCssHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			var loader = new LessDocumentLoader();
			// our unprocessed filename   
			string lessFile = context.Server.MapPath(context.Request.Url.LocalPath);
			StyleDocument document = loader.LoadFromString(File.ReadAllText(lessFile)).Flatten().Merge();
			context.Response.ContentType = "text/css";
			context.Response.Write(document.ToCss());
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
