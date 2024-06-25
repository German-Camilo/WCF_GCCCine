using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBGCCCine.ServiceReference1;

namespace WEBGCCCine
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula
            {
                Titulo = txtNombrePelicula.Text,
                Genero = txtGenero.Text,
                Duracion = txtDuracion.Text
            };

            using (PeliculaClient client = new PeliculaClient())
            {
                client.AddPelicula(pelicula);
                lblResult.Text = "Se Agrego pelicula satisfactoriamente.";
            }
        }
    }
}