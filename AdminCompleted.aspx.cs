using SE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE
{
    public partial class AdminCompleted : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseDriver driver = new DatabaseDriver();
            DataTable dt = driver.getAdminCompleted();

            // Bind the fetched data to a GridView control or any other control suitable for displaying tabular data
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void New_Request(object sender, EventArgs e)
        {
            Response.Redirect("AdminNew.aspx");
        }

        protected void Pending_Request(object sender, EventArgs e)
        {
            Response.Redirect("AdminPending.aspx");
        }

        protected void Completed_Request(object sender, EventArgs e)
        {
            Response.Redirect("AdminCompleted.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // This event is fired for each row bound to the GridView
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Assuming the first column contains the request ID and the second column contains the request details
                string requestId = e.Row.Cells[0].Text;
                int res = Convert.ToInt32(e.Row.Cells[3].Text);
                if(res == 1)
                {
                    e.Row.Cells[3].Text = "Accepted";
                    e.Row.Cells[3].ForeColor = Color.Green;
                }
                else
                {
                    e.Row.Cells[0].Text = "Rejected";
                    e.Row.Cells[0].ForeColor = Color.Red;
                }

                // Add approve and disapprove buttons to each row
                Button btnView = new Button();
                btnView.Text = e.Row.Cells[1].Text;
                btnView.CommandArgument = requestId; // Pass the request ID as a command argument
                btnView.Command += ViewRequest_Click; // Attach a click event handler
                //btnView.Style.Add("border-radius", "15px");
                btnView.Style.Add("border", "None");
                btnView.Style.Add("background-color", "#FFFFFF");
                //btnView.Style.Add("border", "None");
                //btnView.Style.Add("margin", "5px");
                //btnView.Style.Add("padding", "10px");
                btnView.Style.Add("font-size", "14px");
                //btnView.Style.Add("color", "white");

                e.Row.Cells[1].Controls.Add(btnView);
            }
        }

        protected void ViewRequest_Click(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            Session["UserData"] = id;
            Response.Redirect("ApplicationView.aspx");

        }
    }
}