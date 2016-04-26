using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using Constants_namespace;
using Admin_EN_Class;
using User_EN_Class;

namespace Admin_CAD_Class
{
    public class Admin_CAD
    {

        ArrayList lista = new ArrayList();

        public ArrayList MostrarUsers()
        {
            SqlConnection c = new SqlConnection(Constants.nombreConexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Users", c);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                User_EN usuario = new User_EN();

                usuario.ID = dr.GetInt32(0);
                usuario.Nombre = dr["nombre"].ToString();
                usuario.NombreUsu = dr["username"].ToString();
                usuario.Correo = dr["email"].ToString();
                usuario.Contraseña = dr["password"].ToString();
                usuario.Edad = dr.GetInt16(5);
                usuario.Genero = dr.GetString(6)[0];
                usuario.Localidad = dr["locality"].ToString();
                usuario.Visibilidad_perfil = dr.GetInt16(8);

                lista.Add(usuario);
            }
            dr.Close();
            c.Close();

            return lista;
        }
    }
}
