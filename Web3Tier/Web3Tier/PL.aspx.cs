using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLayer;
using System.Data.SqlClient;

namespace Web3Tier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Business bl = new Business();
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                GridBind();
                DropDownListBind();
            }
        }

        public void GridBind()
        {
            try
            {
                Business p = new Business();
                
                this.GridView1.DataSource = p.BL_Bind();
                this.GridView1.DataBind();
            }
            catch
            {
                txtSearchName.Text = "Error Occurred";
            }
        }

        public void DropDownListBind()
        {
            
            DropDownList1.DataSource = bl.BL_Bind();
            DropDownList1.DataBind();
        }

        protected void search_Click(object sender, EventArgs e)
        {

            SearchBind(txtSearchName.Text);
            //Session["SearchGenre"] = customer;
            //Response.Redirect("PLReview.aspx");

        }

        public void SearchBind(string searchTerm)
        {
            GridView2.DataSource = bl.SearchGenre(searchTerm);
            GridView2.DataBind();
        }
    }
}