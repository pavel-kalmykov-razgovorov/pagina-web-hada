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
            if (Session["user_session_data"] == null) Response.Redirect("~/Control_Usuarios/Login.aspx");
        }

        protected void FileUpload1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Button_Upload_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                User_EN user = (User_EN)Session["user_session_data"];
                if (FileUpload1.HasFile)
                {
                    try
                    {
                        string filesPath = Server.MapPath("~/Files/");
                        Directory.CreateDirectory(filesPath); //Crea un directorio para los archivos; si existe, no hace nada
                        FileUpload1.PostedFile.SaveAs(filesPath + FileUpload1.FileName);
                        /**
                         * TODO:
                         * · Renombrar el archivo por su ID (sin extension)
                         * · Extraer información del archivo: Nombre, fecha de última modificación, extensión
                         * · Cuando se visualice, se deberá de extraer una miniatura (de cuantos mas tipos de archivo, mejor)
                        */
                        File_EN fileBBDD = new File_EN();
                        fileBBDD.Nombre = FileUpload1.FileName;
                        fileBBDD.Propietario = user.ID;
                        fileBBDD.SubirArchivo();
                        Response.Write("Ha subido correctamente!");
                    }
                    catch (Exception ex) { Response.Write("El archivo no se puede subir."); }
                }
                else Response.Write("Cannot accept files of this type.");
            }
        }
    }
}