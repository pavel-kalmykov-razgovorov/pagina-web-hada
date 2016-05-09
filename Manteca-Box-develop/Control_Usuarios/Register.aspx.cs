using System;
using User_EN_Class;
using System.Net.Mail;


namespace Manteca_Box_develop
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void EnviarCorreoConfirmacion()
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("mantecabox@gmail.com");
                MailAddress toAddress = new MailAddress(correo_register.Text);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Activacion de la cuenta";

                //Que nos lleve a confirmacion REgistro
                string userActiviation = Request.Url.GetLeftPart(UriPartial.Authority) + "/Control_Usuarios/ConfirmacionRegistro.aspx?email=" + correo_register.Text;

                message.Body = "Hi " + user_name_register.Text + "<br> click here to confirm your account</br> <a href = " + userActiviation + "> click Here </a>";
                message.IsBodyHtml = true;
                //smtpClient.UseDefaultCredentials = true;


                smtpClient.Credentials = new System.Net.NetworkCredential("mantecabox@gmail.com", "ElChiringuito");
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);
                //Response.Write("Correcto email");
            }
            catch (Exception ex)
            {
                //Response.Write("Incorrecto email");
                Response.Write(ex.GetBaseException());
                //Label1.Text = "No se pudo enviar el mensaje!";
                //e.GetBaseExceptio();
            }
        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            EmailExistsError_Register.Visible = 
            UsernameExistsError_Register.Visible = false; //Reiniciamos los errores para que si a la proxima le salen bien no les vuelva a salir
            User_EN busqueda = new User_EN();
            if (busqueda.BuscarUsuario(user_name_register.Text) == null) //Si no existe el usuario
            {
                if (busqueda.BuscarUsuario(correo_register.Text) == null) //Si no existe el correo
                {
                    User_EN en = new User_EN();
                    en.NombreUsu = user_name_register.Text;
                    en.Correo = correo_register.Text;
                    en.Contraseña = password_register1.Text;
                    en.InsertarUsuario();
                    EnviarCorreoConfirmacion();
                }
                else EmailExistsError_Register.Visible = true;
            }
            else UsernameExistsError_Register.Visible = true;

        }
    }
}