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
    public partial class FuncionRegistrar : System.Web.UI.Page
    {

        private FuncionBL funcionBL = new FuncionBL();
        private PeliculaBL peliculaBL = new PeliculaBL();
        private SalaBL salaBL = new SalaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.LoadPelicula();
                this.LoadSala();
            }
        }

        public void LoadPelicula()
        {
            ddlPeliculaID.DataSource = peliculaBL.FindAll();
            ddlPeliculaID.DataValueField = "PeliculaID";
            ddlPeliculaID.DataTextField = "Titulo";
            ddlPeliculaID.DataBind();
        }

        public void LoadSala()
        {
            ddlSalaID.DataSource = salaBL.FindAll();
            ddlSalaID.DataValueField = "SalaID";
            ddlSalaID.DataTextField = "NombreSala";
            ddlSalaID.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Entrada
            int peliculaID = Convert.ToInt32(ddlPeliculaID.SelectedValue);
            int salaID = Convert.ToInt32(ddlSalaID.SelectedValue);
            DateTime fechaHora = Convert.ToDateTime(txtFechaHora.Text);

            //Proceso
            FuncionBE funcionBE = new FuncionBE(peliculaID, salaID, fechaHora);
            funcionBL.Insert(funcionBE);

            //Salida
            Response.Redirect("~/FuncionListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FuncionListar.aspx");
        }
    }
}