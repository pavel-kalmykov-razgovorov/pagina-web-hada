using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Net.Mail;
using Constants_namespace;
using User_EN_Class;

namespace User_CAD_Class
{
    public class User_CAD
    {
        ArrayList lista = new ArrayList();

        public void InsertarUser(User_EN u)
        {

            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into Users(email,nombre,username,password,age,gender,locality,profile_visibility) VALUES ('" + u.Correo + "','" + u.Nombre + "','" + u.NombreUsu + "','" + u.Contraseña + "'," + u.Edad + ",'" + u.Genero + "','" + u.Localidad + "'," + u.Visibilidad_perfil + ")";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) {  }
            finally { nueva_conexion.Close(); }
        }

        public ArrayList MostrarUser(User_EN u)
        {
            SqlConnection c = new SqlConnection(Constants.nombreConexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Users where ID=" + u.ID, c);
            SqlDataReader dr = com.ExecuteReader();


            if (dr.Read())
            {
                User_EN usuario = new User_EN();
                usuario.ID = dr.GetInt32(0);
                usuario.Correo = (dr["email"].ToString());
                usuario.Nombre = (dr["nombre"].ToString());
                usuario.NombreUsu = (dr["username"].ToString());
                usuario.Contraseña = (dr["password"].ToString());
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

        public void BorrarUser(User_EN u)
        {

            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string delete = "";
                delete = "Delete from Users where Users.ID = '" + u.ID;
                SqlCommand com = new SqlCommand(delete, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }

        public bool BuscarUser(User_EN u)
        {
            bool encontrado = false;

            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string select = "";
                select = "Select id from Users where Users.ID =" + u.ID;
                SqlCommand com = new SqlCommand(select, nueva_conexion);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    encontrado = true;
                }

                dr.Close();

            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }

            return encontrado;
        }

        public ArrayList ListarAmigos()
        {
            SqlConnection c = new SqlConnection(Constants.nombreConexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Friends where Friends.User1 = ", c);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(dr["Users2"].ToString());
            }
            dr.Close();
            c.Close();

            return lista;
        }

        public void confirmacionUser(User_EN u)
        {
            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string update = "";
                update = "Update Users set verified = '1' where Users.email = '" + u.Correo + "'"; 
                SqlCommand com = new SqlCommand(update, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }

        public void addLike()
        {

        }

        public void deleteLike()
        {

        }

        public void addFriends()
        {

        }

        public void deleteFriends()
        {

        }

    }
}
