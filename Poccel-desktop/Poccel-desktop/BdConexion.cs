using System;
using Npgsql;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Práctica_1_v._2._0._0
{
    public class ConfigBd
    {
        public string user { get; set; }
        public string password { get; set; }
        public string host { get; set; }
        public string port { get; set; }
        public string database { get; set; }

        public ConfigBd()
        {
            user = "fernando";
            password = "fernando";
            host = "localhost";
            port = "5432";
            database = "poccel";
        }
    }
    public static class BdConexion
    {

        private static ConfigBd configuracion = new ConfigBd();

        public static ConfigBd config
        {
            get { return configuracion; }
            set { configuracion = value; }
        }


        //objeto de conexión de base de datos
        private static NpgsqlConnection connection = new NpgsqlConnection();
        #region Conexión y Desconexión en Base de Datos
        public static bool consulta_conexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            return false;
        }
               
        

        public static bool conectar()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.ConnectionString = $"User ID={config.user}; Password={config.password}; Host={config.host}; Port={config.port}; Database={config.database};";
            bool bestado = true;
            try
            {
                connection.Open();

            }
            catch (Exception exc)
            {
                bestado = false;
                MessageBox.Show(exc.Message);

            }
            return bestado;
        }
        public static bool conectar(ConfigBd config)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.ConnectionString = $"User ID={config.user}; Password={config.password}; Host={config.host}; Port={config.port}; Database={config.database};";
            bool bestado = true;
            try
            {
                connection.Open();

            }
            catch (Exception exc)
            {
                bestado = false;
                MessageBox.Show(exc.Message);
            }
            connection.Close();
            return bestado;
        }

        public static bool desconectar()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    return true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Existe un problema al tratar de desconectr la base de datos" + exc.Message);
                return false;
            }
            return false;
        }

        #endregion
        #region Consulta de Datos

        public static DataTable consultar_datos(String cSql)
        {
            DataTable data = new DataTable();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cSql, connection);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(data);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); ;
            }
            return data;
        }

        public static  DataSet consultar_datos_carga_gria(String cSql)
        {
            DataSet data = new DataSet();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cSql, connection);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(data);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); ;
            }
            return data;
        }

        #endregion
        #region Ejecución de Consultas

        public static Boolean ejecutar(String cSql)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cSql, connection);
                command.ExecuteScalar();
                return true;
            }
            catch (NpgsqlException exc)
            {

                MessageBox.Show(exc.Message);
                return false;
            }

        }
        public static Boolean busqueda(String cSql)
        {
            DataTable data = consultar_datos(cSql);

            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Copias de Seguridad y de Restauración

        public static bool backup(string patch)
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                if (!File.Exists("pg_dump.exe"))
                {
                    MessageBox.Show("El archivo \"pg_dump.exe\" no está disponible o no se encuentra.");
                }
                cmd.StandardInput.WriteLine($"SET PGPASSWORD={config.password}");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine($"pg_dump.exe -h {config.host} -p {config.port} -U {config.user} -d {config.database} -F c -v -f {patch}");
                cmd.StandardInput.Flush();

                cmd.StandardInput.Close();
                cmd.WaitForExit();
                MessageBox.Show("Respaldo realizado con éxito");
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }

        }
        public static bool restore(string patch)
        {
            try
            {
                BdConexion.ejecutar("DROP SCHEMA public CASCADE");
                BdConexion.ejecutar("CREATE SCHEMA public");
                BdConexion.desconectar();
                patch = patch.Replace("\\", "/");
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                if(!File.Exists("pg_restore.exe"))
                    MessageBox.Show("El archivo \"pg_restore.exe\" no está disponible o no se encuentra.");
                cmd.StandardInput.WriteLine($"SET PGPASSWORD={config.password}");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine($"pg_restore.exe -h {config.host} -p {config.port} -U {config.user} -d {config.database} -v {patch}");
                cmd.StandardInput.Flush();

                cmd.StandardInput.Close();
                cmd.WaitForExit();

                BdConexion.conectar();
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }


        #endregion

    }
}
