using SE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE
{
    public partial class StudentRequest : System.Web.UI.Page
    {
        Student student;
        bool flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseDriver driver = new DatabaseDriver();
            student = (Student)Session["UserData"];
            // Check Application Existance
            flag = driver.checkApplication(student.Id);
            if (!IsPostBack)
            {
                errorLabel.Visible = false;
                errorLabel.BackColor = Color.White;
                errorLabel.ForeColor = Color.Red;
                if (flag)
                {
                    Button1.Text = "CONFIRM CHANGES";
                    int reqid = driver.getReqID(student.Id);
                    Request request = driver.getRequest(reqid);
                    rollno.Text = request.rollno;
                    name.Text = request.name;
                    fname.Text = request.fathername;
                    if (request.gender.Equals("Male"))
                    {
                        gender.Items.FindByValue("Male").Selected = true;
                        gender.Items.FindByValue("Female").Selected = false;
                    }
                    else
                    {
                        gender.Items.FindByValue("Male").Selected = false;
                        gender.Items.FindByValue("Female").Selected = true;
                    }
                    program.Text = request.program;
                    dept.Items.FindByValue(request.degree).Selected = true;
                    program.Items.FindByValue(request.program).Selected = true;
                    if (request.dues == 1)
                    {
                        RadioButtonList1.Items.FindByValue("paid").Selected = true;
                        RadioButtonList1.Items.FindByValue("unpaid").Selected = false;
                    }
                    else
                    {
                        RadioButtonList1.Items.FindByValue("paid").Selected = false;
                        RadioButtonList1.Items.FindByValue("unpaid").Selected = true;
                    }
                    if (request.fees == 1)
                    {
                        RadioButtonList2.Items.FindByValue("paid").Selected = true;
                        RadioButtonList2.Items.FindByValue("unpaid").Selected = false;
                    }
                    else
                    {
                        RadioButtonList2.Items.FindByValue("paid").Selected = false;
                        RadioButtonList2.Items.FindByValue("unpaid").Selected = true;
                    }
                    if (request.fyp == 1)
                    {
                        RadioButtonList3.Items.FindByValue("complete").Selected = true;
                        RadioButtonList3.Items.FindByValue("incomplete").Selected = false;
                    }
                    else
                    {
                        RadioButtonList3.Items.FindByValue("complete").Selected = false;
                        RadioButtonList3.Items.FindByValue("incomplete").Selected = true;
                    }
                }
                else
                {

                }
            }
        }

        protected void Submit_button(object sender, EventArgs e)
        {
            DatabaseDriver driver = new DatabaseDriver();   
            string rollNo = rollno.Text.Trim();
            string studentName = name.Text.Trim();
            string fatherName = fname.Text.Trim();
            string gend = gender.SelectedItem.Value;
            string prog = program.SelectedItem.Value;
            string department = dept.SelectedItem.Value;
            int universityDues = RadioButtonList1.SelectedItem.Value.Equals("paid")?1:0;
            int degreeFee = RadioButtonList2.SelectedItem.Value.Equals("paid") ? 1 : 0;
            int fypStatus = RadioButtonList3.SelectedItem.Value.Equals("complete") ? 1 : 0;

            if (rollNo.Length == 7)
            {
                if ((rollNo[0] == 'i' || rollNo[0] == 'f' || rollNo[0] == 'l' || rollNo[0] == 'k' || rollNo[0] == 'p') && (rollNo[1]>='0' && rollNo[1] <= '9') && (rollNo[2] >= '0' && rollNo[2] <= '9') && (rollNo[3] >= '0' && rollNo[3] <= '9') && (rollNo[4] >= '0' && rollNo[4] <= '9') && (rollNo[5] >= '0' && rollNo[5] <= '9') && (rollNo[6] >= '0' && rollNo[6] <= '9'))
                {
                    if(studentName.Length != 0 && fatherName.Length != 0) 
                    {
                        if(flag)
                        {
                            bool updater = false;
                            int reqid = driver.getReqID(student.Id);
                            Request request = driver.getRequest(reqid);
                            if (rollNo.Equals(request.rollno) == false || studentName.Equals(request.name) == false || fatherName.Equals(request.fathername) == false || gend.Equals(request.gender) == false || department.Equals(request.degree) == false || prog.Equals(request.program) == false)
                            {
                                updater = true;
                                driver.ResetAdmin(reqid);
                                driver.ResetToken(reqid);
                            }
                            if (universityDues != request.dues || degreeFee != request.fees)
                            {
                                updater = true;
                                driver.ResetFIN(reqid);
                            }
                            if (fypStatus != request.fyp)
                            {
                                updater = true;
                                driver.ResetFYP(reqid);
                            }

                            if(updater)
                            {
                                driver.UpdateDataIntoRequest(reqid, rollNo, studentName, fatherName, gend, prog, department, universityDues, degreeFee, fypStatus);
                            }
                            
                        }
                        else
                        {
                            driver.InsertDataIntoRequest(student.Id, rollNo, studentName, fatherName, gend, prog, department, universityDues, degreeFee, fypStatus);
                        }
                        Session["UserData"] = student;
                        Response.Redirect("StudentDashboard.aspx");
                    }
                    else
                    {
                        errorLabel.Text = "Fields Cannot be Empty";
                        errorLabel.Visible = true;
                    }
                }
                else
                {
                    errorLabel.Text = "Incorrect Roll No Format";
                    errorLabel.Visible = true;
                }
            }
            else
            {
                errorLabel.Text = "Fields Cannot be Empty";
                errorLabel.Visible = true;
            }

            
        }
    }
}