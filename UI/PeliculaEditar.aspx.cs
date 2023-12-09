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
    public partial class PeliculaEditar : System.Web.UI.Page
    {
        private PeliculaBL peliculaBL = new PeliculaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ID = Convert.ToInt32(Request.QueryString["param"]);

                //Busqueda
                PeliculaBE peliculaBE = peliculaBL.FindById(ID);

                //Imprimir
                txtID.Text = peliculaBE.peliculaID.ToString();
                txtTitulo.Text = peliculaBE.titulo;
                txtDirector.Text = peliculaBE.director;
                txtDurMInutos.Text = peliculaBE.durMInutos.ToString();
                txtClasificacion.Text= peliculaBE.clasificacion;
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Entrada
            int ID = Convert.ToInt32(txtID.Text);
            string titulo = txtTitulo.Text;
            string director = txtDirector.Text;
            int durMInutos = Convert.ToInt32(txtDurMInutos.Text);
            string clasificacion = txtClasificacion.Text;

            //Proceso
            PeliculaBE peliculaBE = new PeliculaBE(ID,titulo, director, durMInutos, clasificacion);
            peliculaBL.Update(peliculaBE);

            //Salida
            Response.Redirect("~/PeliculaListar.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            //Entrada
            int ID = Convert.ToInt32(txtID.Text);

            //Proceso
            peliculaBL.Delete(ID);

            //Salida
            Response.Redirect("~/PeliculaListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PeliculaListar.aspx");
        }
    }
}