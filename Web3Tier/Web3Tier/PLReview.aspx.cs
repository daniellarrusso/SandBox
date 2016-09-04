using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web3Tier
{
    public partial class PLReview : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SearchBind();
            }
        }

        public void SearchBind()
        {
            Business boo = Session["SearchGenre"] as Business;
            searched.DataSource = boo.SearchGenre(boo.Name);
            searched.DataBind();
        }
    }
}