using SE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace SE
{
    public partial class StudentDashboard : System.Web.UI.Page
    {
        Student student;
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseDriver driver = new DatabaseDriver();
            student = (Student)Session["UserData"];
            // Check Application Existance
            bool flag = driver.checkApplication(student.Id);
            if(flag)
            {
                Button1.Text = "Complain Form";
                Button1.BackColor = Color.Green;
                int reqid = driver.getReqID(student.Id);
                FYPRequest fyp = driver.getFYP(reqid);
                FINRequest fin = driver.getFIN(reqid);
                AdminToken token = driver.getToken(reqid);
                AdminRequest adminreq = driver.getAdmin(reqid);
                TableCell applicationUpdateCell4 = table1.Rows[1].Cells[1];
                applicationUpdateCell4.Text = token.startdate;
                if (token.status != 0)
                {
                    TableCell applicationUpdateCell = table1.Rows[2].Cells[1];
                    TableCell applicationUpdateCell1 = table1.Rows[2].Cells[2];
                    TableCell applicationUpdateCell2 = table1.Rows[2].Cells[3];
                    applicationUpdateCell.Text = token.enddate;

                    if(token.status == 2)
                    {
                        applicationUpdateCell1.Text = "Rejected";
                        applicationUpdateCell1.ForeColor = Color.Red;
                    }
                    else
                    {
                        applicationUpdateCell1.Text = "Accepted";
                        applicationUpdateCell1.ForeColor = Color.Green;
                    }
                    applicationUpdateCell2.Text = token.remarks;

                }
                if (token.status == 1 && fyp.status != 0)
                {
                    TableCell applicationUpdateCell = table1.Rows[3].Cells[1];
                    TableCell applicationUpdateCell1 = table1.Rows[3].Cells[2];
                    TableCell applicationUpdateCell2 = table1.Rows[3].Cells[3];
                    applicationUpdateCell.Text = fyp.enddate;

                    if (fyp.status == 2)
                    {
                        applicationUpdateCell1.Text = "Rejected";
                        applicationUpdateCell1.ForeColor = Color.Red;
                    }
                    else
                    {
                        applicationUpdateCell1.Text = "Accepted";
                        applicationUpdateCell1.ForeColor = Color.Green;
                    }
                    applicationUpdateCell2.Text = fyp.remarks;

                }
                if (token.status == 1 && fin.status != 0)
                {
                    TableCell applicationUpdateCell = table1.Rows[4].Cells[1];
                    TableCell applicationUpdateCell1 = table1.Rows[4].Cells[2];
                    TableCell applicationUpdateCell2 = table1.Rows[4].Cells[3];
                    applicationUpdateCell.Text = fin.enddate;

                    if (fin.status == 2)
                    {
                        applicationUpdateCell1.Text = "Rejected";
                        applicationUpdateCell1.ForeColor = Color.Red;
                    }
                    else
                    {
                        applicationUpdateCell1.Text = "Accepted";
                        applicationUpdateCell1.ForeColor = Color.Green;
                    }
                    applicationUpdateCell2.Text = fin.remarks;

                }
                if (token.status == 1 && adminreq.status != 0)
                {
                    TableCell applicationUpdateCell = table1.Rows[5].Cells[1];
                    TableCell applicationUpdateCell1 = table1.Rows[5].Cells[2];
                    TableCell applicationUpdateCell2 = table1.Rows[5].Cells[3];
                    applicationUpdateCell.Text = adminreq.enddate;

                    if (adminreq.status == 2)
                    {
                        applicationUpdateCell1.Text = "Rejected";
                        applicationUpdateCell1.ForeColor = Color.Red;
                    }
                    else
                    {
                        applicationUpdateCell1.Text = "Accepted";
                        applicationUpdateCell1.ForeColor = Color.Green;
                    }
                    applicationUpdateCell2.Text = adminreq.remarks;

                }
                
            }
            else
            {
            }
        }

        protected void Request_button(object sender, EventArgs e)
        {
            Session["UserData"] = student;
            Response.Redirect("StudentRequest.aspx");
        }
        protected void Download_button(object sender, EventArgs e)
        {

        }
    }
}