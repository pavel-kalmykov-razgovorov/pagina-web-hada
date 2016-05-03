using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Manteca_Box_develop
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count > 0)
            {
                if (Request.QueryString.Keys[0] == "email")
                {
                    string email = Request.QueryString["email"].ToString();
                    string QueryActivate = "Update Users set verified = '1' where email = '" + email + "'";

                    //LLamar a un en o cad con esta sentencia, para que modifique la columna verified
                }
            }
        }
    }
}