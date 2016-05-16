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
using System.Collections;

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
                    fi.Propietario = en.ID;//Para identificar al usuario
                    //EL griedView, mostrara un tabla con todos los datos que nos devuelva MostrarFilesUsuarioNombreEn
                    GridViewMostrarArchivos.DataSource = fi.MostrarFilesUsuarioNombreEn();
                    GridViewMostrarArchivos.DataBind();
                    
                }
            //}
        }

        protected void GridViewMostrarArchivos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HyperLink Texto_Descarga = (HyperLink)e.Row.FindControl("Descarga");
                HyperLink Texto_Borra = (HyperLink)e.Row.FindControl("Borra");
                User_EN en = (User_EN)Session["user_session_data"];
                string rutaArchivo = "Files/" + en.ID + "/" + HttpUtility.HtmlDecode(e.Row.Cells[2].Text);
                string idArchivo = e.Row.Cells[1].Text;

                Image icono = (Image)e.Row.FindControl("icono_fichero");
                string extensionArchivo = Path.GetExtension(rutaArchivo);
                extensionArchivo = extensionArchivo.Substring(1, extensionArchivo.Length-1); //quitar punto (carácter 0 del string)
                string rutaIcono = Server.MapPath("/styles/format-icons/" + extensionArchivo + ".svg");
                icono.ImageUrl = File.Exists(rutaIcono) ? "~/styles/format-icons/" + extensionArchivo + ".svg" : "~/styles/format-icons/file.svg";

                Texto_Descarga.NavigateUrl = Server.MapPath(rutaArchivo);
                Texto_Borra.NavigateUrl = Server.MapPath(rutaArchivo);
                Texto_Borra.Text = idArchivo;
            }
        }
        protected void Borrar_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HyperLink h = (HyperLink)lb.FindControl("Borra");
            string rutaborra = h.NavigateUrl;
            File_EN f_bbdd = new File_EN();
            f_bbdd.ID = Convert.ToInt32(h.Text);
            FileInfo file = new FileInfo(rutaborra);
            if (file.Exists)
            {
                file.Delete();
                f_bbdd.BorrarArchivo();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }

        protected void Descarga_Boton_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HyperLink h = (HyperLink)lb.FindControl("Descarga");
            string rutaDescarga = h.NavigateUrl;
            FileInfo fi = new FileInfo(rutaDescarga);
            if (fi.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fi.Name);
                Response.AddHeader("Content-Length", fi.Length.ToString());
                Response.ContentType = "application/octet-stream";
                Response.Flush();
                Response.TransmitFile(fi.FullName);
                Response.End();
            }
        }
    }
}