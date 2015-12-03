using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ConvertPostTitleIntoUrlLab
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            HttpContext incoming = HttpContext.Current;
            string origionalpath = incoming.Request.Url.ToString();
            string subPath = string.Empty;
            string blogId = string.Empty;
            Int64 id = 0;

            if (origionalpath.Contains("Blogs"))
            {
                if (origionalpath.Length >= 37)
                {
                    subPath = origionalpath.Substring(37);
                    if (subPath.Length >= 1)
                    {
                        blogId = origionalpath.Substring(origionalpath.IndexOf("/Blogs/") + 7).Split('/')[0];
                        bool isValid = Int64.TryParse(blogId, out id);
                        if (isValid)
                        {
                            incoming.RewritePath(String.Concat("~/idPage.aspx?id=", id.ToString()), false);
                        }
                    }
                }
            }
        }
    }
}