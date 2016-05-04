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
            User_EN user = new User_EN();
            user.NombreUsu = username_login_input.Text;
            user.Contraseña = password_login_input.Text;
            //user.BuscarUsuario();
        }
    }
}