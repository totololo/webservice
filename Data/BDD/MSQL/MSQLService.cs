using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.BDD.MSQL
{
    public class MSQLService
    {
        public static string ConnectionString_WSNortia = ConfigurationManager.ConnectionStrings["dsnWSNortia"].ConnectionString;
        public static string ConnectionString_DWNortia = ConfigurationManager.ConnectionStrings["dsnDWNortia"].ConnectionString;

        public static DataTable GetDataFromQuery(string query,string ConnectionString)
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        data.Load(dr);
                    }
                    con.Close();
                }
            }
            catch(Exception)
            {
                data = new DataTable();
            }

            return data;
        }

    }
}
