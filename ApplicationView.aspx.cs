using SE.Models;
using SE;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE
{
    public partial class ApplicationView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseDriver driver = new DatabaseDriver();
            int reqid = (int)Session["UserData"];
            if (!IsPostBack)
            {
                Request request = driver.getRequest(reqid);
                rollno.Text = request.rollno;
                rollno.ReadOnly = true;
                name.Text = request.name;
                name.ReadOnly = true;
                fname.Text = request.fathername;
                fname.ReadOnly = true;
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
        }
    }
}