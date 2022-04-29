using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Text;

namespace SQLInjectionLab
{
    public class UsuarioDAO
    {
        #region singleton
        private static readonly UsuarioDAO _instancia = new UsuarioDAO() { };
        public static UsuarioDAO Instancia { get { return _instancia; } }
        #endregion singleton

        public List<Usuario> ObtenerDatos(string username, string password)
        {
            List<Usuario> usuarios = null;
            _ = new SQLDBContext();

            try
            {
                usuarios = new List<Usuario>();
                using (SQLiteConnection cnx = SQLDBContext.Conectar())
                {
                    cnx.Open();
                    using (SQLiteCommand cmd = cnx.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Users WHERE username='" + username + "' AND password='" + password + "';";
                        cmd.CommandType = CommandType.Text;
                        SQLiteDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(dr["Id"]);
                            usuario.Nombre = Convert.ToString(dr["Nombre"]);
                            usuario.NroDeCuenta = Convert.ToString(dr["NroDeCuenta"]);
                            usuario.Password = Convert.ToString(dr["password"]);
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuarios;
        }
    }
}
