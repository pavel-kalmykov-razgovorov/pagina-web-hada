using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;
using File_EN_Class;
using System.Data.SqlClient;


namespace Manteca_Box_develop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Request.QueryString.Count > 0)
           // {
           //     if (Request.QueryString.Keys[0] == "ID")
                User_EN en = (User_EN)Session["user_session_data"];
                if (en != null)
                {
                    en.LeerUsuario();  //lee todos los datos del usuario de la base de datos, ya que la pagina solo proporciona login y password
             
                    File_EN fi = new File_EN();
                    fi.Propietario = en.ID;
                    GridViewMostrarArchivos.DataSource = fi.MostrarFilesUsuarioNombreEn();
                    GridViewMostrarArchivos.DataBind();
                    
                }
            //}
        }
    }
}