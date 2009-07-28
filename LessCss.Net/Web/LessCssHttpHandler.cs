using System.Web;

namespace LessCss.Web
{
	class LessCssHttpHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			// our unprocessed filename   
			string lessFile = context.Server.MapPath(context.Request.Url.LocalPath);
			LessDocument document = LessDocument.FromFile(lessFile);
			context.Response.ContentType = "text/css";
			context.Response.Write(document.ToCss());
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
