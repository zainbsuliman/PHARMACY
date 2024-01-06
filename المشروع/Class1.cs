using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace المشروع
{
    class Class1
    {

        public static string CONNSTR = "server=DESKTOP-P985OUU\\SQLEXPRESS; " + "database=Phar; integrated security=true ";


        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
           SqlConnection conn = new SqlConnection(CONNSTR );
            try
            {
                conn.Open();
               SqlDataAdapter da = new SqlDataAdapter( sql,conn);
                da.Fill(dt);


            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
            return dt;




        }
        public static object GETscalar(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(CONNSTR );
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();



            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
            return obj;



        }
        public static int insertupdatedelet(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(CONNSTR);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows= cmd.ExecuteNonQuery();



            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
            return rows;



        }


    }
}
