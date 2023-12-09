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
    public partial class FuncionEditar : System.Web.UI.Page
    {

        private FuncionBL funcionBL = new FuncionBL();
        private PeliculaBL peliculaBL = new PeliculaBL();
        private SalaBL salaBL = new SalaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ID = Convert.ToInt32(Request.QueryString["param"]);

                //Busqueda
                FuncionBE funcionBE = funcionBL.FindById(ID);

                //Imprimir
                txtID.Text = funcionBE.funcionID.ToString();
                ddlPeliculaID.SelectedValue = funcionBE.peliculaID.ToString();
                ddlSalaID.SelectedValue = funcionBE.salaID.ToString();
                txtFechaHora.Text = funcionBE.fechaHora.ToString();

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

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Entrada
            int ID = Convert.ToInt32(txtID.Text);
            int peliculaID = Convert.ToInt32(ddlPeliculaID.SelectedValue);
            int salaID = Convert.ToInt32(ddlSalaID.SelectedValue);
            DateTime fechaHora = Convert.ToDateTime(txtFechaHora.Text);

            //Proceso
            FuncionBE funcionBE = new FuncionBE(ID,peliculaID, salaID, fechaHora);
            funcionBL.Update(funcionBE);

            //Salida
            Response.Redirect("~/FuncionListar.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            //Entrada
            int ID = Convert.ToInt32(txtID.Text);

            //Proceso
            funcionBL.Delete(ID);

            //Salida
            Response.Redirect("~/FuncionListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FuncionListar.aspx");
        }
    }
}