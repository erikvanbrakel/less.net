using System.Web;

namespace LessCss.Web
{
	public class LessCssHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			// our unprocessed filename   
			string lessFile = context.Server.MapPath(context.Request.Url.LocalPath);
			StyleDocument document = StyleDocument.FromFile(lessFile).Flatten().Merge();
			context.Response.ContentType = "text/css";
			context.Response.Write(document.ToCss());
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
