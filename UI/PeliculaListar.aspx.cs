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
    public partial class PeliculaListar : System.Web.UI.Page
    {

        private PeliculaBL peliculaBL = new PeliculaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo una vez con el servidor
            if (!IsPostBack)
            {

                gvPeliculas.DataSource = peliculaBL.FindAll();
                gvPeliculas.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);

            Response.Redirect("~/PeliculaEditar.aspx?param=" + ID);
        }

        protected void gvPeliculas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPeliculas.PageIndex = e.NewPageIndex;

            gvPeliculas.DataSource = peliculaBL.FindAll();
            gvPeliculas.DataBind();
        }
    }
}