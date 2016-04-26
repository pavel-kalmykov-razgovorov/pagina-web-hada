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

using User_CAD_Class;

namespace User_EN_Class
{
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
}
