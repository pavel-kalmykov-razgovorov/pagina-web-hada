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
            if (Request.QueryString.Count > 0)
            {
                if (Request.QueryString.Keys[0] == "Nombre")
                {
                    File_EN fi = new File_EN();
                    int User = Convert.ToInt32(Request.QueryString["Nombre"]);
                    fi.Propietario = User;
                    GridViewMostrarArchivos.DataSource = fi.MostrarFilesUsuarioNombreEn();
                    GridViewMostrarArchivos.DataBind();
                    
                }
            }
        }
    }
}