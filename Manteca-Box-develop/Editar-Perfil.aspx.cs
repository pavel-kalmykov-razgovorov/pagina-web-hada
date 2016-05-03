using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;


namespace Manteca_Box_develop
{
    public partial class Editar_Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //Mosrar usuario (usuario y contraseña)
        }
        protected void Button_Edit_Profile_Click(object sender, EventArgs e)
        {
            User_EN en = new User_EN();
            en.NombreUsu = Usuario.Text;
            en.Contraseña = Contraseña.Text;

            en.InsertarUsuario();
            //Borrar el antiguo
        }
    }
}