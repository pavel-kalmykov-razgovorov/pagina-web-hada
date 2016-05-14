using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;
using File_EN_Class;
using System.Data.SqlClient;
using System.Web.ClientServices;
using System.IO;
using System.Text;

namespace Manteca_Box_develop
{
 
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User_EN en = (User_EN)Session["user_session_data"];
            //if (en != null)
            //{
                //en.LeerUsuario();  //lee todos los datos del usuario de la base de datos, ya que la pagina solo proporciona login y password

                File_EN fi = new File_EN();
                
                GridViewMostrarLikes.DataSource = fi.MostrarLikes();
                GridViewMostrarLikes.DataBind();

            //}
        }
    }
}