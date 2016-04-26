using System;
using System.Collections.Generic;
//using System.Collections.ArrayList;
using System.Linq;
//using System.Web;
using System.Collections;

//using System.Web.UI;
//using System.Web.UI.WebControls;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Net.Mail;
using Capa_EN;



namespace Capa_CAD
{
    public class File_CAD
    {
        private const string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\BBDD.mdf;User Instance=true";

        ArrayList lista = new ArrayList();

        public ArrayList MostrarFile(File_EN f)
        {
            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Users where ID=" + f.ID, c);
            SqlDataReader dr = com.ExecuteReader();


            if (dr.Read())
            {
                File_EN archivo = new File_EN();
                archivo.ID = dr.GetInt32(0);
                archivo.Nombre = (dr["name"].ToString());
                archivo.Descripcion = (dr["description"].ToString());
                archivo.Fecha_creacion = (DateTime)dr["creation_date"];
                archivo.Propietario = dr.GetInt16(4);
               

                lista.Add(archivo);

            }
            dr.Close();
            c.Close();

            return lista;
        }

        public bool BuscarFile(File_EN f)
        {
            bool encontrado = false;

            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string select = "";
                select = "Select id from Files where Files.ID =" + f.ID;
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

        public void SubirFile(File_EN f)
        {
            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into Files(name,description,creation_date,owner,is_lastversion) VALUES ('" + f.Nombre + "','" + f.Fecha_modificacion + "','" + f.Propietario +  ")";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }

        }

        public void BorrarFile(File_EN f)
        {
            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string delete = "";
                delete = "Delete from Files where Files.ID = '" + f.ID;
                SqlCommand com = new SqlCommand(delete, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }

        public void ShowVersions(File_EN f)
        {

        }

        public void showLikes(File_EN f)
        {

        }



    }

    public class User_CAD
    {
        private const string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\BBDD.mdf;User Instance=true";
        ArrayList lista = new ArrayList();

        public void InsertarUser(User_EN u)
        {

            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into Users(email,nombre,username,password,age,gender,locality,profile_visibility) VALUES ('" + u.Correo + "','" + u.Nombre + "','" + u.NombreUsu + "','" + u.Contraseña + "'," + u.Edad + ",'" + u.Genero + "','" + u.Localidad + "'," + u.Visibilidad_perfil +  ")";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }

        public ArrayList MostrarUser(User_EN u)
        {
            SqlConnection c = new SqlConnection(s);
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

            SqlConnection nueva_conexion = new SqlConnection(s);

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

            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string select = "";
                select = "Select id from Users where Users.ID =" + u.ID ;
                SqlCommand com = new SqlCommand(select, nueva_conexion);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    encontrado = true;
                }

                dr.Close();

            }
            catch (Exception ex) { }
            finally{ nueva_conexion.Close();}

            return encontrado;
        }

        public ArrayList ListarAmigos()
        {
            SqlConnection c = new SqlConnection(s); 
            c.Open(); 
            SqlCommand com = new SqlCommand("Select * from Friends where", c); 
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read()) 
            { 
                lista.Add(dr["Users1"].ToString()); 
            }
            dr.Close(); 
            c.Close(); 

            return lista;
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

    public class Comennt_CAD
    {
        private const string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\BBDD.mdf;User Instance=true";
        ArrayList lista = new ArrayList();

        public void InsertComennt(Comentario_EN c)
        {
            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into CommentsContent(User,File,Content) VALUES (" + c.User + "," + c.File + ",'" + c.Content + "')";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);

                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }

        public void DeleteComennt(Comentario_EN c)
        {
            SqlConnection nueva_conexion = new SqlConnection(s);

            try
            {
                nueva_conexion.Open();
                string delete = "";
                delete = "Delete from Files where CommentsContent.User = " + c.User + "AND CommentsContent.File" + c.File + "AND CommentsContent.Content" + c.Content;
                SqlCommand com = new SqlCommand(delete, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }

        public ArrayList ShowComennts(Comentario_EN comentario)
        {
            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlCommand com = new SqlCommand("Select Content from CommentsContent WHERE User=" + comentario.User + " AND File="+ comentario.File, c);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(dr["Content"].ToString());
            }
            dr.Close();
            c.Close();

            return lista;
        }

    }

    public class Admin_CAD
    {
        private const string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\BBDD.mdf;User Instance=true";
        
        ArrayList lista = new ArrayList();

        public ArrayList MostrarUsers()
        {
            SqlConnection c = new SqlConnection(s);
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