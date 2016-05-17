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

        private bool? genero;

        public bool? Genero
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

        private bool visibilidad_perfil;

        public bool Visibilidad_perfil
        {
            get { return visibilidad_perfil; }
            set { visibilidad_perfil = value; }
        }

        private bool verified;

        public bool Verified
        {
            get { return verified; }
            set { verified = value; }
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

        public User_EN BuscarUsuario(string clave)
        {
            User_CAD busqueda = new User_CAD();
            User_EN usuarioBuscado = busqueda.BuscarUser(clave);
            return usuarioBuscado;
        }

        public ArrayList ListarAmigos()
        {
            ArrayList a = new ArrayList();
            User_CAD c = new User_CAD();
            a = c.ListarAmigos();

            return a;
        }

        public void LeerUsuario()
        {
            User_CAD cad = new User_CAD();
            User_EN en = new User_EN();
            en = cad.LeerUser(this);
            if (en != null)
            {
                id = en.id;
                nombre = en.nombre;
                nombreUsu = en.nombreUsu;
                correo = en.correo;
                edad = en.edad;
                genero = en.genero;
                localidad = en.localidad;
                visibilidad_perfil = en.visibilidad_perfil;
                verified = en.verified;
            }
        }

        public bool confirmacionUsuario()
        {
            User_CAD confirmUser = new User_CAD();
            confirmUser.confirmacionUser(this);
            return true;
        }

        public void actualizarUsuario()
        {
            User_CAD actUser = new User_CAD();
            actUser.actualizarUser(this);
        }

        

        public User_EN()
        {
            id = 0;
            nombre = "";
            nombreUsu = "";
            correo = "";
            contraseña = "";
            edad = 0;
            genero = null;
            localidad = "";
            visibilidad_perfil = false;
            verified = false;
        }
    }
}
