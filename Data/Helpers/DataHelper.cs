using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Practica01.Data.Helpers
{
    public class DataHelper
    {
        private static DataHelper _instance;
        private SqlConnection _connection;

        private DataHelper()
        {
            _connection = new SqlConnection("Data Source=LAPTOP-8LJERNMB\\SQLEXPRESS;Initial Catalog=Practica01;Integrated Security=True;Encrypt=False");
        }
        public static DataHelper GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataHelper();
            }
            return _instance;
        }

        public DataTable ExecuteSpQuery(string sp, List<SpParameter>? param = null)
        {
            DataTable dt = new DataTable();
            try
            {
               
                _connection.Open();
                var cmd = new SqlCommand(sp, _connection);
                cmd.CommandType = CommandType.StoredProcedure;

                
                if (param != null)
                {
                    foreach (SpParameter p in param)
                    {
                        cmd.Parameters.AddWithValue(p.Name, p.Valor);
                    }
                }

                dt.Load(cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                
                dt = null;
            }
            finally
            {
                
                _connection.Close();
            }

            return dt;
        }

       
        public bool ExecuteSpDml(string sp, List<SpParameter>? param = null)
        {
            bool result;
            try
            {
                
                _connection.Open();
                var cmd = new SqlCommand(sp, _connection);
                cmd.CommandType = CommandType.StoredProcedure;

                
                if (param != null)
                {
                    foreach (SpParameter p in param)
                    {
                        cmd.Parameters.AddWithValue(p.Name, p.Valor);
                    }
                }

                int affectedRows = cmd.ExecuteNonQuery();

                result = affectedRows > 0;
            }
            catch (SqlException ex)
            {
                
                result = false;
            }
            finally
            {
                
                _connection.Close();
            }

            return result;
        }

        public SqlConnection GetConnection()
        {

            return _connection;
        }

        public bool ExecuteTransaction(string sp, SqlTransaction transaction, SqlConnection cnn, object parameterOut = null, List<SpParameter>? param = null)
        {
            return true;

        }
    }

}

