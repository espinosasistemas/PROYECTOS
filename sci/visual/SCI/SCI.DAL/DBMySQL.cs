using MySql.Data.MySqlClient;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.DAL
{
    public class DBMySQL : IDB
    {
        private MySqlConnection conexion;
        public DBMySQL()
        {
            string server = "localhost";
            //string server = "172.29.50.1";
            string database = "db_sci";
            string uid = "usuario_sci";
            string password = "Falomay@-1";
            conexion = new MySqlConnection(string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};SslMode=none;", server, database, uid, password));
            Conetar();
        }

        private bool Conetar()
        {
            try
            {
                conexion.Open();
                Error = "";
                return true;
            }
            catch (MySqlException ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public string Error { get; private set; }

        public bool Comando(string command)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(command, conexion);
                cmd.ExecuteNonQuery();
                Error = "";
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public object Consulta(string consulta)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                Error = "";
                return dr;
            }
            catch (MySqlException ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        ~DBMySQL()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }


    }
}
