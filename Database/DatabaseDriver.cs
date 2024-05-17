using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SE.Models;
using WebApplication1.Models;
using System.Data;
using System.Configuration;

namespace SE
{
    public class DatabaseDriver
    {
        private string connectionString = "Data Source=DESKTOP-96QO9A0\\SQLEXPRESS;Initial Catalog=se;Integrated Security=True";

        public DatabaseDriver()
        {
        }

        public int GetUserType(string email, string password)
        {
            int userType = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Type FROM [users] WHERE email = @Email AND password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userType = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }

        public int getID(string email)
        {
            int userType = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id FROM [users] WHERE email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userType = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }

        public string getStudentName(int id)
        {
            string userType = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT name FROM [student] WHERE userid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userType = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }

        public bool checkApplication(int id)
        {
            bool userType = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [request] WHERE userid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userType = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public FYPRequest getFYP(int id)
        {
            FYPRequest userType = new FYPRequest();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [fyprequest] WHERE reqid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            userType.enddate = reader["enddate"].ToString();
                            userType.startdate = reader["startdate"].ToString();
                            userType.remarks = reader["remarks"].ToString();
                            userType.status = Convert.ToInt32(reader["stat"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public FINRequest getFIN(int id)
        {
            FINRequest userType = new FINRequest();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [finrequest] WHERE reqid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            userType.enddate = reader["enddate"].ToString();
                            userType.startdate = reader["startdate"].ToString();
                            userType.remarks = reader["remarks"].ToString();
                            userType.status = Convert.ToInt32(reader["stat"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public AdminRequest getAdmin(int id)
        {
            AdminRequest userType = new AdminRequest();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [adminrequest] WHERE reqid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            userType.enddate = reader["enddate"].ToString();
                            userType.startdate = reader["startdate"].ToString();
                            userType.remarks = reader["remarks"].ToString();
                            userType.status = Convert.ToInt32(reader["stat"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public AdminToken getToken(int id)
        {
            AdminToken userType = new AdminToken();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [admintoken] WHERE reqid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            userType.enddate = reader["enddate"].ToString();
                            userType.startdate = reader["startdate"].ToString();
                            userType.remarks = reader["remarks"].ToString();
                            userType.status = Convert.ToInt32(reader["stat"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public int getReqID(int id)
        {
            int userType = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id FROM [request] WHERE userid = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userType = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public void InsertDataIntoRequest(int id, string rollNo, string studentName, string fatherName, string gender, string program, string department, int universityDues, int degreeFee, int fypStatus)
        {
            try
            {
                // Create a SqlConnection object with the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to insert data into the database
                    string query = "INSERT INTO request (userid, sname, rollno, program, fathername, gender, degree, dues, fee, fyp, complete) " +
                                   "VALUES (@ID, @StudentName, @RollNo, @Program, @FatherName, @Gender, @Department, @UniversityDues, @DegreeFee, @FypStatus,@Complete)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@RollNo", rollNo);
                        command.Parameters.AddWithValue("@StudentName", studentName);
                        command.Parameters.AddWithValue("@FatherName", fatherName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Program", program);
                        command.Parameters.AddWithValue("@Department", department);
                        command.Parameters.AddWithValue("@UniversityDues", universityDues);
                        command.Parameters.AddWithValue("@DegreeFee", degreeFee);
                        command.Parameters.AddWithValue("@FypStatus", fypStatus);
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Complete", 0);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public void UpdateDataIntoRequest(int id, string rollNo, string studentName, string fatherName, string gender, string program, string department, int universityDues, int degreeFee, int fypStatus)
        {
            try
            {
                // Create a SqlConnection object with the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to insert data into the database
                    string query = "UPDATE request SET sname = @Sname, rollno = @Roll, program = @Program, fathername = @FatherName, gender = @Gender, degree = @Department, dues = @UniversityDues, fee = @DegreeFee, fyp = @FypStatus WHERE id = @ID";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Roll", rollNo);
                        command.Parameters.AddWithValue("@Sname", studentName);
                        command.Parameters.AddWithValue("@FatherName", fatherName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Program", program);
                        command.Parameters.AddWithValue("@Department", department);
                        command.Parameters.AddWithValue("@UniversityDues", universityDues);
                        command.Parameters.AddWithValue("@DegreeFee", degreeFee);
                        command.Parameters.AddWithValue("@FypStatus", fypStatus);
                        command.Parameters.AddWithValue("@ID", id);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public Request getRequest(int id)
        {
            Request userType = new Request();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [request] WHERE id = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            userType.Complete = Convert.ToInt32(reader["complete"]);
                            userType.studentid = Convert.ToInt32(reader["userid"]);
                            userType.dues = Convert.ToInt32(reader["dues"]);
                            userType.fees = Convert.ToInt32(reader["fee"]);
                            userType.fyp = Convert.ToInt32(reader["fyp"]);
                            userType.name = reader["sname"].ToString();
                            userType.fathername = reader["fathername"].ToString();
                            userType.rollno = reader["rollno"].ToString();
                            userType.degree = reader["degree"].ToString();
                            userType.program = reader["program"].ToString();
                            userType.gender = reader["gender"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }
        public void ResetAdmin(int id)
        {
            string query = "UPDATE adminrequest SET stat = @Status, startdate = @Sdate, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", 0);
                    command.Parameters.AddWithValue("@Sdate", DateTime.Now);
                    command.Parameters.AddWithValue("@Edate", DBNull.Value);
                    command.Parameters.AddWithValue("@Remarks", "");
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void ResetToken(int id)
        {
            string query = "UPDATE admintoken SET stat = @Status, startdate = @Sdate, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", 0);
                    command.Parameters.AddWithValue("@Sdate", DateTime.Now);
                    command.Parameters.AddWithValue("@Edate", DBNull.Value);
                    command.Parameters.AddWithValue("@Remarks", "");
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void ResetFIN(int id)
        {
            string query = "UPDATE finrequest SET stat = @Status, startdate = @Sdate, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", 0);
                    command.Parameters.AddWithValue("@Sdate", DateTime.Now);
                    command.Parameters.AddWithValue("@Edate", DBNull.Value);
                    command.Parameters.AddWithValue("@Remarks", "");
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void ResetFYP(int id)
        {
            string query = "UPDATE fyprequest SET stat = @Status, startdate = @Sdate, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", 0);
                    command.Parameters.AddWithValue("@Sdate", DateTime.Now);
                    command.Parameters.AddWithValue("@Edate", DBNull.Value);
                    command.Parameters.AddWithValue("@Remarks", "");
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public string getName(int id)
        {
            string userType = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT sname FROM [request] WHERE id = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userType = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userType;
        }

        public DataTable getAdminNew()
        {
            DataTable table = new DataTable();
            table.Columns.Add("requestid", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(string));

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [admintoken] WHERE stat = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        SqlDataReader reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            int id = Convert.ToInt32(reader["reqid"]);
                            string name = getName(id);
                            string sdate = reader["startdate"].ToString();
                            table.Rows.Add(id, name, sdate);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return table;
        }
        public DataTable getAdminCompleted()
        {
            DataTable table = new DataTable();
            table.Columns.Add("requestid", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Status", typeof(int));
            table.Columns.Add("Remarks", typeof(string));

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [adminrequest] WHERE stat = 1 or stat = 2";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["reqid"]);
                            int stat = Convert.ToInt32(reader["stat"]);
                            string name = getName(id);
                            string sdate = reader["enddate"].ToString();
                            string remarks = reader["remarks"].ToString();
                            table.Rows.Add(id, name, sdate,stat,remarks);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return table;
        }
        public DataTable getAdminPending()
        {
            DataTable table = new DataTable();
            table.Columns.Add("requestid", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(string));

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ar.* FROM adminrequest ar INNER JOIN finrequest fr ON ar.reqid = fr.reqid AND fr.stat = 1 INNER JOIN fyprequest fp ON ar.reqid = fp.reqid AND fp.stat = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["reqid"]);
                            string name = getName(id);
                            string sdate = reader["startdate"].ToString();
                            table.Rows.Add(id, name, sdate);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as logging them or returning error codes
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return table;
        }
        public void setAdminToken(int id, int status,string remarks)
        {
            string query = "UPDATE admintoken SET stat = @Status, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Edate", DateTime.Now);
                    command.Parameters.AddWithValue("@Remarks", remarks);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void setAdminRequest(int id, int status, string remarks)
        {
            string query = "UPDATE adminrequest SET stat = @Status, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Edate", DateTime.Now);
                    command.Parameters.AddWithValue("@Remarks", remarks);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void setFYPRequest(int id, int status, string remarks)
        {
            string query = "UPDATE fyprequest SET stat = @Status, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Edate", DateTime.Now);
                    command.Parameters.AddWithValue("@Remarks", remarks);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void setFINRequest(int id, int status, string remarks)
        {
            string query = "UPDATE finrequest SET stat = @Status, enddate = @Edate, remarks = @Remarks WHERE reqid = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Edate", DateTime.Now);
                    command.Parameters.AddWithValue("@Remarks", remarks);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        
    }

   
}
