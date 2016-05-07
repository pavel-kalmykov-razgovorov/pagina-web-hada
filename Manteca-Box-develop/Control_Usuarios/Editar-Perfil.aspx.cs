using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User_EN_Class;

namespace Manteca_Box_develop
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        /**
         * Es necesario que los elementos CheckBox y RadioButton inicialicen sus tipos de clases
         * usando estos métodos, ya que si lo hacemos directamente desde el HTML el checkbox lo envuelve
         * en un <span></span> declarando la clase en esa etiqueta (y, por tanto, inhabilitando el checkbox)
         */
        protected void InitInputClasses()
        {
            Editar_Perfil_Visibilidad_Switch.InputAttributes.Add("class", "mdl-switch__input");
            Editar_Perfil_Hombre.InputAttributes.Add("class", "mdl-radio__button");
            Editar_Perfil_Mujer.InputAttributes.Add("class", "mdl-radio__button");
            Editar_Perfil_NoMostrar.InputAttributes.Add("class", "mdl-radio__button");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            InitInputClasses();
            User_EN en = (User_EN) Session["user_session_data"];
            if (en != null)
            {

            }
            else
            {
                //Response.Redirect("Login.aspx");
            }
        }
    }
}