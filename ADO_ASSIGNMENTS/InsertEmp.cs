using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_ASSIGNMENTS
{
    internal class InsertEmp
    {
        static void Main(string[] args)
        {
            string str = "server=localhost;userid=root;password=sumit;database=knowit";
            int id = 5;
            string name = "meghna";
            //step 2
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection Established !!!");
                string query = "insert into emp(EMPNO,ENAME) values(@id,@name)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name",name);

                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res +"Record Inserted Succesfully ");

                conn.Close();

            }

        }
    }
}
