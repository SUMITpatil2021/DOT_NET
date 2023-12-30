using MySqlConnector;
using MySqlConnector.Logging;

namespace ADO_ASSIGNMENTS
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //step 1
            string str = "server=localhost;userid=root;password=sumit;database=knowit";
            //step 2
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection Established");
                string query = "select EMPNO,ENAME from emp"; // query 
                //step 3
                MySqlCommand cmd = new MySqlCommand(query,conn); // here query  can be directly write but for simplicity write it seperately
                //step 4
                MySqlDataReader reader= cmd.ExecuteReader(); //give command to reader

                while (reader.Read())
                { 
                    Console.WriteLine(reader.GetInt32(0)+" "+reader.GetString(1)); //read data from table 
                }
                //step 5
                conn.Close(); // this is must!!!
                
            }
        }
    }
}
