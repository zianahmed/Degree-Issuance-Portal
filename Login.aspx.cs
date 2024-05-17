using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SE.Models;

namespace SE
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void Login_button(object sender, EventArgs e)
        {
            // Get the entered email and password
            string userEmail = email.Text.Trim();
            string userPassword = Password.Text.Trim();

            // Create an instance of DatabaseDriver with your connection string
            DatabaseDriver dbDriver = new DatabaseDriver();

            // Call the GetUserType method to retrieve the user type
            int userType = dbDriver.GetUserType(userEmail, userPassword);
            int id = dbDriver.getID(userEmail);
            // Redirect to specific page based on user type
            switch (userType)
            {
                case 0: // Admin
                    Admin admin = new Admin();
                    Users User = new Users();
                    admin.Id = id;
                    admin.Email = userEmail;
                    admin.Password = userPassword;
                    admin.Type = userType;
                    admin.Name = dbDriver.getStudentName(id);
                    Session["UserData"] = admin;
                    Response.Redirect("AdminNew.aspx");
                    break;
                case 1: // Director
                    Response.Redirect("DirectorDashboard.aspx");
                    break;
                case 2: // FYP
                    Response.Redirect("FYPDashboard.aspx");
                    break;
                case 3: // Finance
                    Response.Redirect("FinanceDashboard.aspx");
                    break;
                case 4: // Student
                    Student student = new Student();
                    student.Id = id;
                    student.Email = userEmail;
                    student.Password = userPassword;
                    student.Type = userType;
                    student.Name = dbDriver.getStudentName(id);
                    Session["UserData"] = student;
                    Response.Redirect("StudentDashboard.aspx");
                    break;
                default: // Invalid user type or login credentials
                    error.Text = "Invalid email or password";
                    break;
            }
        }
        protected void Register_button(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


    }


}