using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Dominio
{
    public class ModeloUsuario
    {
        Usuario _usuario = new Usuario();
        public bool LoginUser(string UserName, string Pass)
        {
            _usuario._NombreUsuario = UserName;
            _usuario._Contrasena = Pass;
            return _usuario.Login();
        }

        public DataTable ListarTipoUser()
        {
            DataTable tabla = new DataTable();
            tabla = _usuario.ListarTipoUser();

            return tabla;
        }

        public DataTable ListarTipoIdent()
        {
            DataTable tabla = new DataTable();
            tabla = _usuario.ListarTipoIdent();

            return tabla;
        }

        public DataTable MostrarUsers()
        {
            DataTable tabla = new DataTable();
            tabla = _usuario.Mostrar();
            return tabla;
        }

        public void InsertarUser(string pNombre, string pTipoIdent, string pNumIdent, string pTelefono, string pCorreo, string pNombreUser, string pPass, string pTipoUser)
        {
            _usuario._Nombre = pNombre;
            _usuario._TipoIdent = Convert.ToInt32(pTipoIdent);
            _usuario._NumIdent = pNumIdent;
            _usuario._Telefono = pTelefono;
            _usuario._Correo = pCorreo;
            _usuario._NombreUsuario = pNombreUser;
            _usuario._Contrasena = pPass;
            _usuario._TipoUsuario = Convert.ToInt32(pTipoUser);

            _usuario.Insertar();
        }

        public void EditarUser(string pNombre, string pTipoIdent, string pNumIdent, string pTelefono, string pCorreo, string pNombreUser, string pPass, string pTipoUser,
            string pID)
        {
            _usuario._Nombre = pNombre;
            _usuario._TipoIdent = Convert.ToInt32(pTipoIdent);
            _usuario._NumIdent = pNumIdent;
            _usuario._Telefono = pTelefono;
            _usuario._Correo = pCorreo;
            _usuario._NombreUsuario = pNombreUser;
            _usuario._Contrasena = pPass;
            _usuario._TipoUsuario = Convert.ToInt32(pTipoUser);
            _usuario._UsuarioID = Convert.ToInt32(pID);
            _usuario.Edirtar();
        }

        public void EliminarUser(string pID)
        {
            _usuario._UsuarioID = Convert.ToInt32(pID);
            _usuario.Eliminar();
        }
    }
}
