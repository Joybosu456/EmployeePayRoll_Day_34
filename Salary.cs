using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Salary
    {
        private static SqlConnection ConnectionSetup()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PayRoll_Service_01;Integrated Security=True");
        }
        public int UpdateEmployeeSalary(SalaryUpdateModel salaryUpdateModel)
        {
            SqlConnection sqlConnection = ConnectionSetup();
            int Salary = 0;
            try
            {
                using (sqlConnection)
                {
                    SalaryUpdateModel displayModel = new SalaryUpdateModel();
                     SqlCommand command=new SqlCommand("sqlUpdateEmployeeSalary",sqlConnection);
                    command.CommandType=System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id",salaryUpdateModel.SalaryId);
                    command.Parameters.AddWithValue("@month", salaryUpdateModel.Month);
                    command.Parameters.AddWithValue("@salary", salaryUpdateModel.EmployeeSalary);
                    command.Parameters.AddWithValue("@EmpId",salaryUpdateModel.EmployeeId);
                    sqlConnection.Open();

                    SqlDataAdapter dr=command.ExecuteReader();

                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            displayModel.EmployeeId = Convert.ToInt32(dr[0]);
                            displayModel.EmployeeName = dr[1].ToString();
                            displayModel.EmployeeSalary = Convert.ToInt32(dr[2]);
                            displayModel.Month = dr[3].ToString();
                            displayModel.SalaryId = Convert.ToInt32(dr[4]);

                        }
                        Console.WriteLine("{0},{1},{2},{4}",displayModel.EmployeeName,displayModel.EmployeeSalary,displayModel.Month);
                        Salary = displayModel.EmployeeSalary;
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }

                }
            }
            catch(Exception E)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
            return Salary;
        }

    }
}
