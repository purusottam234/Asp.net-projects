using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.;database=amc;integrated security = SSPI");
                SqlCommand cm = new SqlCommand("select * from Customers", con);
                con.open();
                SqlDataReader sdr = cm.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(sdr["name"] + "" + sdr["email"]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("OOPS,Something went wrong" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
