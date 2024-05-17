using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // Import this namespace for working with DataTable
using SE.Models;

namespace SE
{
    public partial class AdminNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseDriver driver = new DatabaseDriver();
            DataTable dt = driver.getAdminNew();

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

                TextBox txtRemarks = new TextBox();
                txtRemarks.ID = "txtRemarks_" + requestId; // Assign unique ID to each TextBox
                txtRemarks.CssClass = "remarksTextBox";

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

                Button btnApprove = new Button();
                btnApprove.Text = "Accept";
                btnApprove.CommandArgument = requestId; // Pass the request ID as a command argument
                btnApprove.Command += ApproveRequest_Click; // Attach a click event handler
                btnApprove.Style.Add("border-radius", "15px");
                btnApprove.Style.Add("background-color", "green");
                btnApprove.Style.Add("border", "None");
                btnApprove.Style.Add("margin", "5px");
                btnApprove.Style.Add("padding", "10px");
                btnApprove.Style.Add("font-size", "14px");
                btnApprove.Style.Add("color", "white");

                Button btnDisapprove = new Button();
                btnDisapprove.Text = "Reject";
                btnDisapprove.CommandArgument = requestId; // Pass the request ID as a command argument
                btnDisapprove.Command += DisapproveRequest_Click; // Attach a click event handler
                btnDisapprove.Style.Add("border-radius", "15px");
                btnDisapprove.Style.Add("background-color", "red");
                btnDisapprove.Style.Add("border", "None");
                btnDisapprove.Style.Add("margin", "5px");
                btnDisapprove.Style.Add("padding", "10px");
                btnDisapprove.Style.Add("font-size", "14px");
                btnDisapprove.Style.Add("color", "white");

                e.Row.Cells[1].Controls.Add(btnView);
                e.Row.Cells[3].Controls.Add(btnApprove);
                e.Row.Cells[3].Controls.Add(btnDisapprove);
                e.Row.Cells[4].Controls.Add(txtRemarks);
            }
        }

        protected void ViewRequest_Click(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            Session["UserData"] = id;
            Response.Redirect("ApplicationView.aspx");
            
        }
        protected void ApproveRequest_Click(object sender, CommandEventArgs e)
        {
            Button btnApprove = (Button)sender;
            GridViewRow row = (GridViewRow)btnApprove.NamingContainer;
            TextBox txtRemarks = (TextBox)row.FindControl("txtRemarks_" + e.CommandArgument);
            string remarks = txtRemarks.Text;
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            DatabaseDriver driver = new DatabaseDriver();
            driver.setAdminToken(id, 1, remarks);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
        protected void DisapproveRequest_Click(object sender, CommandEventArgs e)
        {
            Button btnApprove = (Button)sender;
            GridViewRow row = (GridViewRow)btnApprove.NamingContainer;
            TextBox txtRemarks = (TextBox)row.FindControl("txtRemarks_" + e.CommandArgument);
            string remarks = txtRemarks.Text;
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            DatabaseDriver driver = new DatabaseDriver();
            driver.setAdminToken(id, 2, remarks);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

    }
}
