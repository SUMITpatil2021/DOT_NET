using CURD_Operation_EMP.Models;
using MySqlConnector;
using System.Collections.Generic;
namespace CURD_Operation_EMP.DAL
{
    public class EmpDAL
    {
        public List<Employee> GetEmpList()
        {
            List<Employee> emps = new List<Employee>();
            string str = "server=localhost;userid=root;password=sumit;database=knowit";
          using(MySqlConnection con=new MySqlConnection(str))   
            {
                try
                {
                    con.Open();
                    string query = "select * from emp";
                    MySqlCommand cmd=new MySqlCommand(query, con);  
                    MySqlDataReader reader= cmd.ExecuteReader();
                     while (reader.Read())
                    {
                        Employee emp = new Employee() {
                            eno = Convert.ToInt32(reader[0]),
                            ename = Convert.ToString(reader[1]),
                            job = Convert.ToString(reader[2]),
                            sal =(float) Convert.ToDecimal(reader[3]),
                        };
                        emps.Add(emp);

                    }
                }
                catch ( Exception e)
                { 
                              
                }

                return emps;
            
            }


        
        
        }

      
    }
}
