using System;
using System.Collections.Generic;

namespace SQLInjectionLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert username");
            string username = Console.ReadLine();
            Console.WriteLine("Insert password");
            string password = Console.ReadLine();

            Usuario.Login(username, password);
        }
    }

    #region Usuario.cs
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string NroDeCuenta { get; set; }

        public static void Login(string username, string password)
        {
            List<Usuario> users = UsuarioDAO.Instancia.ObtenerDatos(username, password);
            if (users == null || users.Count == 0)
                Console.WriteLine("No se pudo acceder");
            else
            {
                foreach(Usuario user in users)
                {
                    Console.WriteLine("El Nombre es: " + user.Nombre);
                    Console.WriteLine("El Nro de Cuenta Bancaria es: " + user.NroDeCuenta);
                    Console.WriteLine("El password es: " + user.Password);
                    Console.WriteLine("___________________________________________________");
                }
            }
        }
    }
    #endregion Usuario.cs

}
