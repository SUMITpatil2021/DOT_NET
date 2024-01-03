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
                    string query = "select * from empdot";
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

        public int InsertEmp(Employee emp)
        {

            int res = 0;
            string str = "server=localhost;userid=root;password=sumit;database=knowit";
            using(MySqlConnection  conn=new MySqlConnection(str))
            {
                try
                {
                    conn.Open();
                    string query = "insert into empdot  values(@eno,@ename,@job,@sal)";
                    MySqlCommand cmd=new MySqlCommand( query, conn);
                    cmd.Parameters.AddWithValue("@eno", emp.eno);
					cmd.Parameters.AddWithValue("@ename", emp.ename);
					cmd.Parameters.AddWithValue("@job", emp.job);
					cmd.Parameters.AddWithValue("@sal", emp.sal);
                    res = cmd.ExecuteNonQuery();
				}
				catch (Exception e )
                {

                }
            }

            return res;

        }

		public Employee GetEmp(int eno)
		{
			Employee emp = null;
			string con = "Server=localhost;userid=root;password=sumit;database=knowit";
			using (MySqlConnection conConn = new MySqlConnection(con))
			{
				try
				{
					conConn.Open();
					string Query = "Select * from empdot where eno= @eno";
					MySqlCommand cmd = new MySqlCommand(Query, conConn);
					cmd.Parameters.AddWithValue("@eno", eno);
					MySqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						emp = new Employee()
						{
							eno = Convert.ToInt32(reader[0]),
							ename = Convert.ToString(reader[1]),
							job = Convert.ToString(reader[2]),
							sal = (float)Convert.ToDecimal(reader[3])
							
						};


					}
				}
				catch (Exception ex)
				{

				}

			}
			return emp;


		}

	}
}
