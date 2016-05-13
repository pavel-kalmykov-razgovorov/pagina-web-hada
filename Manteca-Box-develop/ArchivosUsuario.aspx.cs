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
        protected void Descargar_Click(object sender, EventArgs e)
        {
            User_EN en = (User_EN)Session["user_session_data"];
            if (en != null)
            {
                en.LeerUsuario();  //lee todos los datos del usuario de la base de datos, ya que la pagina solo proporciona login y password

                File_EN file = new File_EN();
                file.MostrarArchivo();

                if (file != null)
                {
                    Response.Clear();
                    Response.ClearContent();
                    Response.ClearHeaders();
                    Response.Buffer = true;
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment;filename=" + file.Nombre);
                    byte[] array = Encoding.UTF8.GetBytes(file.Nombre);
                    Response.OutputStream.Write(array, 0, file.Nombre.Length);
                    Response.Flush();
                    Response.Close();
                    Response.End();
                }
            }
        }
    }
}