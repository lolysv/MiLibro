using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLibro.Services
{
    class BasicServices : IGenericService
    {
        private static BasicServices _instance;

        public static BasicServices Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new BasicServices();
                }
                return _instance;
            }
           
        }


        SqlConnection connection;

        public BasicServices()
        {
            connection = new SqlConnection(Config.Settings.UrlBase);
            connection.Open();
        }

        //Crear datos
        public bool Create(string query)
        {
            SqlCommand c = CreateCommand(query);
            try
            {
                int i = c.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Creado exitosamente");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            
        }

        //Borrar datos
        public bool Delete(string query)
        {
            SqlCommand c = CreateCommand(query);
            try
            {
                int i = c.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Borrado exitosamente");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            
        }

        //Recupera datos
        public SqlDataReader Read(string query)
        {
            SqlCommand c = CreateCommand(query);
            SqlDataReader reader;
            try
            {
                reader = c.ExecuteReader();
                if (reader != null)
                {
                    return reader;
                }
                return null;
            }

            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return null;
        }

        //Actualiza datos
        public bool Update(string query)
        {
            SqlCommand c = CreateCommand(query);
            try
            {
                int i = c.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Actualizado exitosamente");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
        }

        //Crea un comando
        private SqlCommand CreateCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            return command;
        }
    }
}
