using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

//using System.Web.UI;
//using System.Web.UI.WebControls;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Net.Mail;
using Capa_CAD;

namespace Capa_EN
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

        public void SubirArchivo()
        {
            File_CAD upFile = new File_CAD();
            upFile.SubirFile(this);
        }

        public void BorrarArchivo()
        {
            File_CAD deleteFile = new File_CAD();
            deleteFile.BorrarFile(this);
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

    public class User_EN
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombreUsu;
        public string NombreUsu
        {
            get { return nombreUsu; }
            set { nombreUsu = value; }
        }

        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private short edad;

        public short Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private char genero;

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private string localidad;

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        private short visibilidad_perfil;

        public short Visibilidad_perfil
        {
            get { return visibilidad_perfil; }
            set { visibilidad_perfil = value; }
        }

        public void InsertarUsuario()
        {
            User_CAD userCad = new User_CAD();
            userCad.InsertarUser(this);
        }

        public ArrayList MostrarUsuario()
        {
            ArrayList a = new ArrayList();
            User_CAD c = new User_CAD();
            a = c.MostrarUser(this);

            return a;
        }

        public void BorrarUsuario()
        {
            User_CAD userDelete = new User_CAD();
            userDelete.BorrarUser(this);
        }

        public void BuscarUsuario()
        {
            User_CAD userFind = new User_CAD();
            userFind.BuscarUser(this);
        }

        public ArrayList ListarAmigos()
        {
            ArrayList a = new ArrayList();
            User_CAD c = new User_CAD();
            a = c.ListarAmigos();

            return a;
        }

        public void AñadirLike()
        {
            User_CAD addLike = new User_CAD();
            addLike.addLike();
        }

        public void BorrarLike()
        {
            User_CAD deleteLike = new User_CAD();
            deleteLike.deleteLike();
        }

        public void AgregarAmigo()
        {
            User_CAD addFriend = new User_CAD();
            addFriend.addFriends();
        }

        public void BorrarAmigo()
        {
            User_CAD deleteFriend = new User_CAD();
            deleteFriend.deleteFriends();
        }

        public User_EN()
        {
            id = 0;
            nombre = "";
            nombreUsu = "";
            correo = "";
            contraseña = "";
            edad = 0;
            genero = '\0';
            localidad = "";
            visibilidad_perfil = 0;
        }
    }

    public class Comentario_EN
    {
        private int user;

        public int User
        {
            get { return user; }
            set { user = value; }
        }

        private int file;

        public int File
        {
            get { return file; }
            set { file = value; }
        }

        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public void InsertarComentario()
        {
            Comennt_CAD insertComennt = new Comennt_CAD();
            insertComennt.InsertComennt(this);
        }

        public void BorrarComentario()
        {
            Comennt_CAD deleteComennt = new Comennt_CAD();
            deleteComennt.DeleteComennt(this);
        }

        public void MostrarComentarios()
        {
            ArrayList a = new ArrayList();

            Comennt_CAD showComennt = new Comennt_CAD();
            showComennt.ShowComennts(this);
        }
    }

    public class Admin_EN
    {

        public ArrayList MostrarUsuarios()
        {
            ArrayList a = new ArrayList();
            Admin_CAD c = new Admin_CAD();
            a = c.MostrarUsers();

            return a;
        }
    }
}