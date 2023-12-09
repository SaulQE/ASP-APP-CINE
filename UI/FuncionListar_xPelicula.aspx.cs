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
    public partial class FuncionListar_xPelicula : System.Web.UI.Page
    {
        private FuncionBL funcionBL = new FuncionBL();
        private PeliculaBL peliculaBL = new PeliculaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo una vez con el servidor
            if (!IsPostBack)
            {
                this.LoadPeliculas();
                this.LoadFunciones("El Padrino");
            }
        }

        public void LoadFunciones(string pelicula)
        {
            gvFunciones.DataSource = funcionBL.FindAll(pelicula);
            gvFunciones.DataBind();
        }

        public void LoadPeliculas()
        {
            ddlPeliculas.DataSource = peliculaBL.FindAll();
            ddlPeliculas.DataValueField = "PeliculaID";
            ddlPeliculas.DataTextField = "Titulo";
            ddlPeliculas.DataBind();
        }

        protected void ddlPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pelicula = ddlPeliculas.SelectedItem.Text;
            this.LoadFunciones(pelicula);
        }
        protected void gvFunciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvFunciones.PageIndex = e.NewPageIndex;

            string pelicula = ddlPeliculas.SelectedItem.Text;
            this.LoadFunciones(pelicula);
        }

    }
}