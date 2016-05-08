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

        public void SubirFile(File_EN f)
        {
            SqlConnection nueva_conexion = new SqlConnection(Constants.nombreConexion);

            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into Files(name,description,creation_date,owner) VALUES ('";
                insert+= f.Nombre + "','" +  f.Descripcion  + "','" +  f.Fecha_creacion + "','" + f.Propietario + "')";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }

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
