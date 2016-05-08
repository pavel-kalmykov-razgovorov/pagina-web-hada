using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using User_EN_Class;

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
                    User_EN en = new User_EN();
                    string email = Request.QueryString["email"].ToString();
                    en.Correo = email;
                    en.confirmacionUsuario();

                    //LLamar a un en o cad con esta sentencia, para que modifique la columna verified
                }
            }
        }
    }
}