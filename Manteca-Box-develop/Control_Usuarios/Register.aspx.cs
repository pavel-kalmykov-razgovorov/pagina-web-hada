using System;
using User_EN_Class;
using System.Net.Mail;


namespace Manteca_Box_develop
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*String s = "data source=(LocalDB)\\v11.0;AttachDBFilename=|DataDirectory|\\BBDD.mdf;Integrated Security=SSPI;";
            String s2 = "data source=.\\SQLEXPRESS;AttachDBFilename=|DataDirectory|\\BBDD.mdf;Integrated Security=SSPI;";
            SqlConnection c = new SqlConnection(s);
            SqlConnection c2 = new SqlConnection(s2);
            c.Open();*/
        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            User_EN en = new User_EN();
            en.NombreUsu = user_name_register.Text;
            en.Correo = correo_register.Text;
            en.Contraseña = password_register1.Text;
            en.InsertarUsuario();

            //IF se ha insertado::
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("pepesifre@gmail.com");
                MailAddress toAddress = new MailAddress(correo_register.Text);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Activacion de la cuenta";

                //Que nos lleve a confirmacion REgistro
                string userActiviation = "http://127.0.0.1:5293/ConfirmacionRegistro.aspx?email=" + correo_register.Text;

                message.Body = "Hi " + user_name_register.Text + "<br> click here to confirm your account</br> <a href = \"" + userActiviation + "\"> click Here </a>";
                message.IsBodyHtml = true;
                //smtpClient.UseDefaultCredentials = true;


                smtpClient.Credentials = new System.Net.NetworkCredential("pepesifre@gmail.com", "8DC03NEBsaj");
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);
                Response.Write("Correcto email");
            }
            catch(Exception ex){
                Response.Write("INCorrecto email");
                Response.Write(ex.GetBaseException());
                //Label1.Text = "No se pudo enviar el mensaje!";
                //e.GetBaseExceptio();
            }

        }
    }
}