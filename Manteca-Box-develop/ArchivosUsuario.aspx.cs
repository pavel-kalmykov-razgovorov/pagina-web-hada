﻿using System;
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
                User_EN en = (User_EN)Session["user_session_data"];
                Texto_Descarga.NavigateUrl = Server.MapPath("Files/"+ en.ID + "/file" + e.Row.Cells[0].Text);
            }
            /*FileInfo file = new FileInfo(Server.MapPath("Files/Inicio.aspx.cs"));
            if (file.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.ContentType = "application/octet-stream";
                Response.Flush();
                Response.TransmitFile(file.FullName);
                Response.End();
            }*/
        }
        protected void Borrar_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Server.MapPath("Files/file9.md"));
            if (file.Exists)
            {
                file.Delete();
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