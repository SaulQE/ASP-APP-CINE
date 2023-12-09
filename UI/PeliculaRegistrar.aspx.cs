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
    public partial class PeliculaRegistrar : System.Web.UI.Page
    {

        private PeliculaBL peliculaBL = new PeliculaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            // sin postback
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Entrada
            string titulo = txtTitulo.Text;
            string director = txtDirector.Text;
            int durMInutos = Convert.ToInt32(txtDurMInutos.Text);
            string clasificacion = txtClasificacion.Text;

            //Proceso
            PeliculaBE peliculaBE = new PeliculaBE(titulo,director,durMInutos,clasificacion);
            peliculaBL.Insert(peliculaBE);

            //Salida
            Response.Redirect("~/PeliculaListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PeliculaListar.aspx");
        }
    }
}