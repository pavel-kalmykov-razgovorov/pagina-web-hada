using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;

namespace Manteca_Box_develop
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("data source=(LocalDB)\\v11.0;AttachDBFilename=|DataDirectory|\\BBDD.mdf;Integrated Security=true");
            SqlConnection c2 = new SqlConnection("data source=.\\SQLEXPRESS;AttachDBFilename=|DataDirectory|\\BBDD.mdf;Integrated Security=true");
        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            User_EN en = new User_EN();
            en.NombreUsu = user_name_register.Text;
            en.Correo = correo_register.Text;
            en.Contraseña = password_register1.Text;

            en.InsertarUsuario();
        }
    }
}