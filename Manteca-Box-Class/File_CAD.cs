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
using File_EN_Class;

namespace File_CAD_Class
{
    public class File_CAD
    {
        ArrayList lista = new ArrayList();

        public ArrayList MostrarFile(File_EN f)
        {
            SqlConnection c = new SqlConnection(Constants.nombreConexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Users where ID=" + f.ID, c);
            SqlDataReader dr = com.ExecuteReader();


            if (dr.Read())
            {
                File_EN archivo = new File_EN();
                archivo.ID = dr.GetInt32(0);
                archivo.Nombre = (dr["name"].ToString());
                archivo.Descripcion = (dr["description"].ToString());
                archivo.Fecha_creacion = Convert.ToDateTime(dr["creation_date"]);
                archivo.Propietario = Convert.ToByte(dr["owner"]);

                lista.Add(archivo);

            }
            dr.Close();
            c.Close();

            return lista;
        }

        public bool BuscarFile(File_EN f)
        {
            bool encontrado = false;

            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

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

        public int SubirFile(File_EN f)
        {
            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);
            int id=0;
            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into Files(name,description,creation_date,owner) VALUES ('";
                insert+= f.Nombre + "','" +  f.Descripcion  + "','" +  f.Fecha_creacion + "','" + f.Propietario + "')";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);
                com.ExecuteNonQuery();
                string select = "select ID from Files where name='" + f.Nombre + "' and creation_date='" + f.Fecha_creacion + "' and owner='" + f.Propietario + "'";
                com = new SqlCommand(select, nueva_conexion);
                SqlDataReader dr = com.ExecuteReader();
 
                if (dr.Read())
                    id = dr.GetInt32(0);

            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
            return id;
        }

        public ArrayList MostrarFilesUsuarioNombre(int propietario)
        {
            SqlConnection c = new SqlConnection(Constants.nombreConexion);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Files where owner = " + propietario, c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    File_EN archivo = new File_EN();
                    archivo.ID = Convert.ToInt16(dr["ID"]);
                    archivo.Nombre = dr["name"].ToString();
                    archivo.Descripcion = dr["description"].ToString();
                    archivo.Fecha_creacion = Convert.ToDateTime(dr["creation_date"]);
                    archivo.Propietario = Convert.ToByte(dr["owner"]);
                    lista.Add(archivo);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return lista;

        }

        public void BorrarFile(File_EN f)
        {
            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

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
}
