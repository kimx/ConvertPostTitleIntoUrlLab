using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConvertPostTitleIntoUrlLab
{
    /// <summary>
    /// http://allittechnologies.blogspot.in/2015/06/how-to-convert-post-title-into-url-by-using-asp-net-csharp-programming.html
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        protected void Btn_submit_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "yyyyMMddHHmmssfff";   // Use this format.
            string bid = time.ToString(format); // Generate ID = (date+time+MilliSeconds) { its generate Unique Id }

            string connectionString = ConfigurationManager.ConnectionStrings["urlcon"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Insert into url(id, title, msg) values('" + bid.ToString() + "','" + txt_title.Text.Trim() + "','" + txt_msg.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
          
            con.Close();
            string link = GenerateURL(txt_title.Text.Trim(), bid.ToString());
            Response.Redirect(link);
        }
        private string GenerateURL(string title, string Id)
        {
            string strTitle = title.Trim();
            strTitle = strTitle.ToLower();
            strTitle = strTitle.Replace("c#", "c-sharp");
            strTitle = strTitle.Replace(" ", "-");
            strTitle = strTitle.Trim();
            strTitle = strTitle.Trim('-');
            strTitle = "~/Blogs/" + Id.ToString() + "/" + strTitle + ".aspx";

            return strTitle;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}