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
    public partial class FuncionListar : System.Web.UI.Page
    {

        private FuncionBL funcionBL = new FuncionBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo una vez con el servidor
            if (!IsPostBack)
            {
                gvFunciones.DataSource = funcionBL.FindAll_DataTable();
                gvFunciones.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);

            Response.Redirect("~/FuncionEditar.aspx?param=" + ID);
        }

        protected void gvFunciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvFunciones.PageIndex = e.NewPageIndex;

            gvFunciones.DataSource = funcionBL.FindAll_DataTable();
            gvFunciones.DataBind();
        }
    }
}