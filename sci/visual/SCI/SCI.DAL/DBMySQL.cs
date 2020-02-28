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
        /*public DBMySQL()
        {
            //string server = "localhost";
            string server = "172.29.50.1";
            string database = "db_sci";
            string uid = "usuario_sci";
            string password = "Falomay@-1";
            conexion = new MySqlConnection(string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};SslMode=none;", server, database, uid, password));
            Conetar();
        }*/
        string server = "172.29.50.1";
        string database = "db_sci";
        string uid = "usuario_sci";
        string password = "Falomay@-1";

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
                conexion = new MySqlConnection(string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};SslMode=none;", server, database, uid, password));
                conexion.Open();

                MySqlCommand cmd = new MySqlCommand(command, conexion);
                cmd.ExecuteNonQuery();
                Error = "";
                conexion.Close();
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
                conexion = new MySqlConnection(string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};SslMode=none;", server, database, uid, password));
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                Error = "";
                //conexion.Close();
                return dr;
                
            }
            catch (MySqlException ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        ~DBMySQL()
        {
            conexion.Close();
        }

    }
}
