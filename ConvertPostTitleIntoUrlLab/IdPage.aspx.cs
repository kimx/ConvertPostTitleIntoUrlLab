using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConvertPostTitleIntoUrlLab
{
    public partial class IdPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"].ToString();
                    DisplayBlog(id);
                }
            }
        }

        private void DisplayBlog(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["urlcon"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM url where id='" + id + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                divtitle.InnerHtml = "<b>" + ds.Tables[0].Rows[0]["title"].ToString() + "</b>";
                divmsg.InnerHtml = ds.Tables[0].Rows[0]["msg"].ToString();
            }
        }
    }
}