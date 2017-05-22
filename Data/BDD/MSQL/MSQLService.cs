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



        public static List<T> GetObject<T>(string ConnectionString,string clauseWhere = "") where T : new()
        {
            List<T> liteT = new List<T>();


            Type typeT = typeof(T);
            
            IList<PropertyInfo> propsT = new List<PropertyInfo>(typeT.GetProperties());

            string listField = string.Join(",", propsT.Select(x => x.Name));

            string sql = "SELECT " + listField + " FROM " + typeT.Name;
            if (!string.IsNullOrWhiteSpace(clauseWhere))
                sql += " WHERE " + clauseWhere;

            DataTable data=GetDataFromQuery(sql, ConnectionString);
            foreach(DataRow ligne in data.Rows)
            {
                T objT = new T();
                foreach(DataColumn col in data.Columns)
                {
                    PropertyInfo propertyInfo = objT.GetType().GetProperty(col.ColumnName);
                    propertyInfo.SetValue(objT, ligne[col.ColumnName]);
                }


                liteT.Add(objT);
            }

            return liteT;

        }

    }
}
