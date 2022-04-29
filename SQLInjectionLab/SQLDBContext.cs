using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace SQLInjectionLab
{
    internal class SQLDBContext
    {
        public static string NombreBaseDatos = "persons.sqlite";

        public SQLDBContext()
        {

            CrearBaseDatosSiNoExiste();
            CrearTablasSiNoExisten();
        }

        public static SQLiteConnection Conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;");
            return cnx;
        }

        public static void CrearBaseDatosSiNoExiste()
        {
            if (!File.Exists(NombreBaseDatos))
            {
                SQLiteConnection.CreateFile(NombreBaseDatos);
            }
        }

        public static void CrearTablasSiNoExisten()
        {
            using (SQLiteConnection cnx = new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();

                string sql = "create table if not exists Users (Id integer primary key autoincrement, username varchar(100), password varchar(100), Nombre varchar(100), NroDeCuenta varchar(100))";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
            }


            using (SQLiteConnection cnx = new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();

                string sql = "insert into Users (username, password, Nombre, NroDeCuenta) values " +
                    "('admin', 'admin123', 'Administrador', '467236752378532535783444578'), " +
                    "('pcastle', 'pcastle123', 'Peter Castle', '12323835485487358634785456347'), " +
                    "('pperez', 'pperez123', 'Pepe Perez', '898756347865786347569587346'), " +
                    "('jsanz', 'jsanz', 'Juan Santos', '3487563475678934675633485678'), " +
                    "('lshady', 'lshady123', 'Pharaon Ra', '0000000001101010010101010011');";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
