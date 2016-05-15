using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using File_EN_Class;
using User_EN_Class;

namespace Manteca_Box_develop
{
    public partial class SubirArchivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //InitInputClasses();
            User_EN en = (User_EN)Session["user_session_data"];
            if (en != null)
            {
                en.LeerUsuario();  //lee todos los datos del usuario de la base de datos, ya que la pagina solo proporciona login y password
                MostrarDirectorio(en);
            }
            else
            {
                Response.Redirect("Control_Usuarios/Login.aspx");
            }
        }

        protected void MostrarDirectorio(User_EN en)
        {

        }

        protected void FileUpload1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Button_Upload_Click(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                
                String path = Server.MapPath("Files/");
                if (FileUpload1.HasFile)
                {
                    try
                    {
                        User_EN user = (User_EN)Session["user_session_data"];
                        if (user != null)
                        {
                            
                            File_EN arx = new File_EN();
                            
                            user.LeerUsuario();
                            arx.Nombre = FileUpload1.FileName;
                            arx.Propietario = user.ID;
                            int id=arx.SubirArchivo();
                            string pathString= path + user.ID;
                            if (!Directory.Exists(pathString)) 
                                Directory.CreateDirectory(pathString);
                            FileUpload1.PostedFile.SaveAs(pathString+
                             "\\file" + id + Path.GetExtension(FileUpload1.FileName));
                        }
                        else
                            Response.Write("Error. usuario no válido");
                    }
                    catch (Exception ex)
                    {
                        Response.Write("El archivo no se puede subir.");
                    }
                }
                else
                {
                    Response.Write("Cannot accept files of this type.");
                }
            }
        }
    }
}