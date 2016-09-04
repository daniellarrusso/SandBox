using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLayer;

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
            GridView1.DataSource = bl.BL_Bind();
            GridView1.DataBind();
        }

        public void DropDownListBind()
        {
            DropDownList1.DataSource = bl.BL_Bind();
            DropDownList1.DataBind();
        }

        protected void search_Click(object sender, EventArgs e)
        {
            var customer = new Business();
            customer.Name = txtSearchName.Text;
            Session["SearchGenre"] = customer;
            Response.Redirect("PLReview.aspx");

        }
    }
}