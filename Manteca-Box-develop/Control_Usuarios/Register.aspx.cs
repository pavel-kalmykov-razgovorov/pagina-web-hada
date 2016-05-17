﻿using System;
using User_EN_Class;
using System.Net.Mail;


namespace Manteca_Box_develop
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user_session_data"] = null;
        }

        protected void EnviarCorreoConfirmacion()
        {
            /*
             * Una vez el usuario se ha introducido con éxito en la base de datos procedemos a 
             * enviarle el email de confirmacion
             */
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");//Creamos el cliente
            smtpClient.Port = 587;//El puerto
            MailMessage message = new MailMessage();//Cremos el menaseje que ahora rellenamos
            try
            {
                MailAddress fromAddress = new MailAddress("mantecabox@gmail.com");//Gmail, creado para el envio de correos
                MailAddress toAddress = new MailAddress(correo_register.Text);//El destinatario
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Activacion de la cuenta";//El asunto del email

                string userActiviation = Request.Url.GetLeftPart(UriPartial.Authority) + "/Control_Usuarios/ConfirmacionRegistro.aspx?email=" + correo_register.Text;//La direccion url que debe ser recargada para la activacion de la cuenta

                message.Body = "Hi " + user_name_register.Text + "<br> click here to confirm your account</br> <a href = " + userActiviation + "> click Here </a>";//Donde debe hacer click el nuevo usuario para activarla
                message.IsBodyHtml = true;//El mensaje esta en html
                //smtpClient.UseDefaultCredentials = true;


                smtpClient.Credentials = new System.Net.NetworkCredential("mantecabox@gmail.com", "ElChiringuito");//Los credenciales del cliente
                smtpClient.EnableSsl = true;//necesario para el envio
                smtpClient.Send(message);//Lo enviamos
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
            /* Una vez el usuario ha rellenado todos los campos solicitados en el apartado del registro
             * correctamente, es decir, el email tiene formato de email, las contraseñas coinciden...proceemos a
             * guardar el usuario en la base de datos
             */
            EmailExistsError_Register.Visible = 
            UsernameExistsError_Register.Visible = false; //Reiniciamos los errores para que si a la proxima le salen bien no les vuelva a salir
            User_EN busqueda = new User_EN();
            if (busqueda.BuscarUsuario(user_name_register.Text) == null) //Comprobamos que ese nombre de usuario ya este
            {
                if (busqueda.BuscarUsuario(correo_register.Text) == null) //Comprobamos que ese correo ya este
                {
                    User_EN en = new User_EN();//Si lo cumple todo, creamos un nuevo usuario
                    en.NombreUsu = user_name_register.Text;//Con su nombre de usuario
                    en.Correo = correo_register.Text;//Con su correo
                    en.Contraseña = password_register1.Text;//Con su contrasenya
                    en.InsertarUsuario();//Llamamos a InsertarUsuario de la cap EN, que se encaragra de insertarlo
                    EnviarCorreoConfirmacion();//Esto enviara un correo de confirmaacion al usuario
                }
                else EmailExistsError_Register.Visible = true;
            }
            else UsernameExistsError_Register.Visible = true;

        }
    }
}