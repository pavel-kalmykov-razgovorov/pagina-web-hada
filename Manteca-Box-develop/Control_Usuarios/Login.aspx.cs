using System;
using User_EN_Class;

namespace Manteca_Box_develop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            User_EN busqueda = new User_EN();
            User_EN usuario = busqueda.BuscarUsuario(username_login_input.Text);
            if (usuario != null)
            {
                if (usuario.Contraseña == password_login_input.Text)
                {
                    if (usuario.Verified)
                    {
                        Session["user_session_data"] = usuario;
                        Response.Redirect("Editar-Perfil.aspx");
                    }
                    else UserNotVerifiedError_Login.Visible = true;
                }
                else WrongPasswordError_Login.Visible = true;
            }
            else UserNotExistsError_Login.Visible = true;
        }
    }
}