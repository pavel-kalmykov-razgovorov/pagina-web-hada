using System;
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

        }

        protected void FileUpload1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Button_Upload_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                
                String path = Server.MapPath("~/Files/");
                if (FileUpload1.HasFile)
                {
                    try
                    {
                        User_EN user = new User_EN(); ;
                        //user=Session["user_session_data"];
                        FileUpload1.PostedFile.SaveAs(path
                            + FileUpload1.FileName);
                        File_EN arx = new File_EN();
                        arx.Nombre = FileUpload1.FileName;
                        user.ID = 9;
                        arx.Propietario = 9;
                        
                        arx.SubirArchivo();
                        Response.Write("Ha subido correctamente!");
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