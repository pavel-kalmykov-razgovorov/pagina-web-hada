using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Net.Mail;
using File_CAD_Class;


namespace File_EN_Class
{
    public class File_EN
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fecha_creacion;

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        private DateTime fecha_modificacion;

        public DateTime Fecha_modificacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        private int propietario;

        public int Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }


        private string lista_etiquetas;
        public string Lista_etiquetas
        {
            get { return lista_etiquetas; }
            set { lista_etiquetas = value; }
        }

        public ArrayList MostrarArchivo()
        {
            ArrayList a = new ArrayList();
            File_CAD c = new File_CAD();
            a = c.MostrarFile(this);

            return a;
        }

        public void BuscarArchivo()
        {
            File_CAD findFile = new File_CAD();
            findFile.BuscarFile(this);
        }

        public int SubirArchivo()
        {
            File_CAD upFile = new File_CAD();
            return upFile.SubirFile(this);
        }

        public void BorrarArchivo()
        {
            File_CAD deleteFile = new File_CAD();
            deleteFile.BorrarFile(this);
        }

        public ArrayList MostrarFilesUsuarioNombreEn()
        {
            File_CAD ListaArchivos = new File_CAD();
            ArrayList a = new ArrayList();
            a = ListaArchivos.MostrarFilesUsuarioNombre(this.Propietario);
            return a;
        }

        public void MostrarVersiones()
        {
            File_CAD showVersion = new File_CAD();
            showVersion.ShowVersions(this);
        }

        public void MostrarLikes()
        {
            File_CAD showFile = new File_CAD();
            showFile.showLikes(this);
        }

        public File_EN()
        {
            id = 0;
            nombre = "";
            descripcion = "";
            fecha_creacion = new DateTime();
            fecha_modificacion = new DateTime();
            lista_etiquetas = "";
        }

    }
}
