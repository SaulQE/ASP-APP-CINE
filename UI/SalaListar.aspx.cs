using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;

namespace UI
{
    public partial class SalaListar : System.Web.UI.Page
    {
        private SalaBL salaBL = new SalaBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo una vez con el servidor
            if (!IsPostBack)
            {
                gvSalas.DataSource = salaBL.FindAll();
                gvSalas.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);

            Response.Redirect("~/SalaEditar.aspx?param=" + ID);
        }

        protected void gvSalas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSalas.PageIndex = e.NewPageIndex;

            gvSalas.DataSource = salaBL.FindAll();
            gvSalas.DataBind();
        }
    }
}