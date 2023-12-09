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
    public partial class SalaEditar : System.Web.UI.Page
    {

        private SalaBL salaBL = new SalaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ID = Convert.ToInt32(Request.QueryString["param"]);

                //Busqueda
                SalaBE salaBE = salaBL.FindById(ID);

                //Imprimir
                txtID.Text = salaBE.salaID.ToString();
                txtNomSala.Text = salaBE.nomSala;
                txtCapacidad.Text = salaBE.capacidad.ToString();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Entrada
            int ID = Convert.ToInt32(txtID.Text);
            string nomSala = txtNomSala.Text;
            int capacidad = Convert.ToInt32(txtCapacidad.Text);

            //Proceso
            SalaBE salaBE = new SalaBE(ID, nomSala, capacidad);
            salaBL.Update(salaBE);

            //Salida
            Response.Redirect("~/SalaListar.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            //Entrada
            int ID = Convert.ToInt32(txtID.Text);

            //Proceso
            salaBL.Delete(ID);

            //Salida
            Response.Redirect("~/SalaListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SalaListar.aspx");
        }
    }
}