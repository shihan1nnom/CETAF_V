using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Usuario:BdComun
    {
        private int UsuarioID;
        private string Nombre;
        private int TipoIdent;
        private string NumIdent;
        private string Telefono;
        private string Correo;
        private string NombreUsuario;
        private string Contrasena;
        private int TipoUsuario;

        public int _UsuarioID { get => UsuarioID; set => UsuarioID = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public int _TipoIdent { get => TipoIdent; set => TipoIdent = value; }
        public string _NumIdent { get => NumIdent; set => NumIdent = value; }
        public string _Telefono { get => Telefono; set => Telefono = value; }
        public string _Correo { get => Correo; set => Correo = value; }
        public string _NombreUsuario { get => NombreUsuario; set => NombreUsuario = value; }
        public string _Contrasena { get => Contrasena; set => Contrasena = value; }
        public int _TipoUsuario { get => TipoUsuario; set => TipoUsuario = value; }

        public bool Login()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Select * From Usuarios where NombreUser = @user and Password = @pass";
                    comando.Parameters.AddWithValue("@user", NombreUsuario);
                    comando.Parameters.AddWithValue("@pass", Contrasena);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        #region Listar ComboBox

        public DataTable ListarTipoUser()
        {
            DataTable _tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "ListarTipoUser";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = comando.ExecuteReader();
                    _tabla.Load(leer);
                    leer.Close();
                }
            }
            return _tabla;
        }

        public DataTable ListarTipoIdent()
        {
            DataTable _tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "ListarTipoIdent";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = comando.ExecuteReader();
                    _tabla.Load(leer);
                    leer.Close();
                }
            }
            return _tabla;
        }

        #endregion

        #region CRUD Usuario

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Select * From Usuarios";
                    SqlDataReader leer = comando.ExecuteReader();
                    tabla.Load(leer);
                    leer.Close();
                }
            }
            return tabla;
        }

        public void Insertar()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Insert Into Usuarios Values('" + Nombre + "', '" + TipoIdent + "', '" + NumIdent + "', '" + Telefono + "'," +
                        " '" + Correo + "', '" + NombreUsuario + "', '" + Contrasena + "', '" + TipoUsuario + "')";
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Edirtar()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Update Usuarios Set Nombre = '" + Nombre + "', TipoIdent = '" + TipoIdent + "', NumIdent = '" + NumIdent + "', " +
                        "Telefono = '" + Telefono + "', Correo = '" + Correo + "', NombreUser = '" + NombreUsuario + "', Password = '" + Contrasena + "', " +
                        "TipoUserID = " + TipoUsuario + " Where UsuarioID = " + UsuarioID + "";
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Delete From Usuarios Where UsuarioID = " + UsuarioID + "";
                    comando.ExecuteNonQuery();
                }
            }
        }

        #endregion

    }
}
