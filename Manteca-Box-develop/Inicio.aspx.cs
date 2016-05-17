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
        //Mostraremos los archivos al cargar la pagina
        protected void Page_Load(object sender, EventArgs e)
        {
                File_EN fi = new File_EN();
                GridViewMostrarTodo.DataSource = fi.MostrarAllFiles();
                GridViewMostrarTodo.DataBind();
        }
    }
}