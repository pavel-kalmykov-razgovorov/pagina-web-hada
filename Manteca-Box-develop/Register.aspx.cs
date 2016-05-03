using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;
using System.Net.Mail;


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
            //en.InsertarUsuario();

            //IF se ha insertado::
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("pepesifre@gmail.com");
                MailAddress toAddress = new MailAddress(correo_register.Text);
                //message.ANachments.Add(new ANachment("C:\\imagen1.gif")); 
                //message.ANachments.Add(new ANachment("C:\\imagen2.jpg")); 
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Activacion de la cuenta";

                //Que nos lleve a confirmacion REgistro
                string userActiviation = "http://solution.es/useractivation.aspx?email=" + correo_register.Text;

                message.Body = "hi" + user_name_register.Text + "<br> click here to confirm your account</br> <a href = '" + userActiviation + "'> click Here </a>";
                message.IsBodyHtml = true;
                smtpClient.EnableSsl = true;
                //smtpClient.UseDefaultCredentials = true;


                smtpClient.Credentials = new System.Net.NetworkCredential("pepesifre@gmail.com", "8DC03NEBsaj");
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