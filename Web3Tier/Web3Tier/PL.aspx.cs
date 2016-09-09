using BusinessLayer;
using System;

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
                
            }
        }

        public void DropDownListBind()
        {
            
            DropDownList1.DataSource = bl.BL_Bind();
            DropDownList1.DataBind();
        }

        //protected void search_Click(object sender, EventArgs e)
        //{

        //    SearchBind(txtSearchName.Text);
        //    //Session["SearchGenre"] = customer;
        //    //Response.Redirect("PLReview.aspx");

        //}

        protected void search_Click(object sender, EventArgs e)
        {

            string employeeId = txtEmployeeId.Text;
            GridView2.DataSource = bl.SearchGenre(Int32.Parse(employeeId.ToString()));
            GridView2.DataBind();
        }
    }
}