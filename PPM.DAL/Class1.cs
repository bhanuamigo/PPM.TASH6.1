using System;
using MySql.Data.MySqlClient;
namespace AdoNetConsoleApplication
{
    public class EmployeeDal
    {
        public void InsertIntoEmployeeTable(int employeeId,string firstName,string lastName,string email,string mobile,string address,int roleId)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("Server=10.11.50.58;User ID=tempuser;Password=Admin@1234;Database=ppm_prolifics_1");
                MySqlCommand cm = new   MySqlCommand("insert into employee values("+employeeId+", '"+firstName+"', '"+lastName+"', '"+email+"', '"+mobile+"', '"+address+"', "+roleId+")", con);
                
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
            }
        }

        public class RoleDal
        {
            public void InsertIntoRoleTable(int roleId,string roleName)
            {
            try
            {

            using(MySqlConnection con = new MySqlConnection("Server=10.11.50.58;User ID=tempuser;Password=Admin@1234;Database=ppm_prolifics_1"))
            {
                string commandString = "insert into roles values ("+roleId+", '"+roleName+"')";
                MySqlCommand cm = new   MySqlCommand(commandString, con);
                
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");

            }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            }
            public void DeleteRoleData(int roleId)
            {
            MySqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new MySqlConnection("Server=10.11.50.58;User ID=tempuser;Password=Admin@1234;Database=ppm_prolifics_1");
                // writing sql query  
                string commandString = "insert into roles values ("+roleId+")";
                MySqlCommand cm = new MySqlCommand(commandString, con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}


