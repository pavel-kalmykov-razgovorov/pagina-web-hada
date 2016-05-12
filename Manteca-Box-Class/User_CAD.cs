﻿using System;
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
        public ArrayList lista = new ArrayList();

        public void InsertarUser(User_EN u)
        {

            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string genre = u.Genero.HasValue ? u.Genero.Value.ToString() : "NULL";
                string insert = "insert into users(email,nombre,username,password,age,gender,locality,profile_visibility,verified) VALUES ('"
                    + u.Correo + "','" + u.Nombre + "','" + u.NombreUsu + "','" + u.Contraseña + "'," + u.Edad + "," + genre + ",'" + u.Localidad + "'," + 0 + "," + 0 + ")";
                //POR DEFECTO, VISIBILIDAD Y VERIFICACION SON FALSAS
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
                usuario.ID = Convert.ToInt16(dr["ID"]);
                usuario.Correo = dr["email"].ToString();
                usuario.Nombre = dr["nombre"].ToString();
                usuario.NombreUsu = dr["username"].ToString();
                usuario.Contraseña = dr["password"].ToString();
                usuario.Edad = Convert.ToInt16(dr["age"]);
                usuario.Genero = Convert.ToBoolean(dr["gender"]);
                usuario.Localidad = dr["locality"].ToString();
                usuario.Visibilidad_perfil = Convert.ToBoolean(dr["profile_visibility"]);
                usuario.Verified = Convert.ToBoolean(dr["verified"]);
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

        /**
         * Recibe un nombre de usuario o un correo electrónico y devuelve los datos del usuario al que pertenecen.
         * En caso de que no exista tal usuario/correo, devuelve NULL
         */
        public User_EN BuscarUser(string busqueda)
        {
            User_EN usuario = null;
            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);
            try
            {
                nueva_conexion.Open();
                string select = "Select * from Users where username ='" + busqueda + "' or email = '" + busqueda + "'";
                SqlCommand com = new SqlCommand(select, nueva_conexion);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read()) //Teóricamente solo debe de devolver una sola fila debido a que tanto el usuario como el email son claves alternativas (no nulos y no repetidos)
                {
                    usuario = new User_EN();
                    usuario.ID = Convert.ToInt16(dr["ID"]);
                    usuario.Correo = dr["email"].ToString();
                    usuario.Nombre = dr["nombre"].ToString();
                    usuario.NombreUsu = dr["username"].ToString();
                    usuario.Contraseña = dr["password"].ToString();
                    usuario.Edad = Convert.ToInt16(dr["age"]);
                    //usuario.Genero = Convert.ToBoolean(dr["gender"]);
                    usuario.Localidad = dr["locality"].ToString();
                    usuario.Visibilidad_perfil = Convert.ToBoolean(dr["profile_visibility"]);
                    usuario.Verified = Convert.ToBoolean(dr["verified"]);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }

            return usuario;
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

        public User_EN LeerUser(User_EN u)
        {

            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);
            User_EN usuario = new User_EN();

            try
            {
                nueva_conexion.Open();
                string select = "";
                select = "Select * from Users where username ='" + u.NombreUsu + "' and password = '" + u.Contraseña + "'";
                SqlCommand com = new SqlCommand(select, nueva_conexion);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {

                    usuario.ID = Convert.ToInt16(dr["ID"]);
                    usuario.Correo = dr["email"].ToString();
                    usuario.Nombre = dr["nombre"].ToString();
                    usuario.NombreUsu = dr["username"].ToString();
                    usuario.Contraseña = dr["password"].ToString();
                    usuario.Edad = Convert.ToInt16(dr["age"]);
                    usuario.Genero = Convert.ToBoolean(dr["gender"]);
                    usuario.Localidad = dr["locality"].ToString();
                    usuario.Visibilidad_perfil = Convert.ToBoolean(dr["profile_visibility"]);
                    usuario.Verified = Convert.ToBoolean(dr["verified"]);
                }

                dr.Close();

            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }

            return usuario;
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

        public void actualizarUser(User_EN u)
        {
            string genero = "NULL";
            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string update = "";
                
                if (u.Genero.Value == true)
                    genero = "1";
                else if (u.Genero.Value == false)
                    genero = "0";

                update = "Update Users set email = '" + u.Correo + "',nombre  = '" + u.Nombre + "',username = '" + u.NombreUsu + "',password = '" + u.Contraseña + "',age = " + u.Edad + ",gender = " + genero + ",locality = '" + u.Localidad + "',profile_visibility = '" + u.Visibilidad_perfil + "' where Users.ID ="+u.ID;
                SqlCommand com = new SqlCommand(update, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { ex.Message.ToString(); }
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
