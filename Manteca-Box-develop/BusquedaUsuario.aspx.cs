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

namespace Manteca_Box_develop
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Buscra_Click(object sender, EventArgs e)
        {
            User_EN usuarioABuscar = new User_EN();
            User_EN usuario = usuarioABuscar.BuscarUsuario(usuario_buscar.Text);
            if (usuario != null)
            {
                GridViewMostrarArchivosUsuario.DataSource = usuario.MostrarFilesUsuarioNombreEn();
                GridViewMostrarArchivosUsuario.DataBind();
            }
        }
    }
}