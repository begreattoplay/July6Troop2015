using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlVersion = null;

            try
            {
                string connString = "Integrated Security=true;Initial Catalog=aspnet-NickCafe-20150624102218;Server=(localdb)\\v11.0";

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    sqlVersion = con.ServerVersion;
                };
            }
            catch
            {
                Console.WriteLine("Sorry, unable to open that database");
            }

            Console.WriteLine(sqlVersion);
        }
    }
}
