using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;

namespace Manteca_Box_develop
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User_EN en = (User_EN) Session["user_session_data"];
            if (en != null)
            {
                this.Age.Text = en.Edad.ToString();
                this.correo_profile.Text = en.Correo;
                this.password_profile1.Text = en.Contraseña;
                this.user_name_profile.Text = en.NombreUsu;
                this.Locality.Text = en.Localidad;
                this.Visibility_profile.Text = en.Visibilidad_perfil.ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void Button_Edit_Profile_Click(object sender, EventArgs e)
        {

        }
    }
}