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
    public partial class SalaRegistrar : System.Web.UI.Page
    {

        private SalaBL salaBL = new SalaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            // sin postback
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Entrada
            string nomSala = txtNomSala.Text;
            int capacidad = Convert.ToInt32(txtCapacidad.Text);

            //Proceso
            SalaBE salaBE = new SalaBE(nomSala, capacidad);
            salaBL.Insert(salaBE);

            //Salida
            Response.Redirect("~/SalaListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SalaListar.aspx");
        }
    }
}