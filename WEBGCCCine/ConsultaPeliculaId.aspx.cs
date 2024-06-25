using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBGCCCine.ServiceReference1;

namespace WEBGCCCine
{
    public partial class ConsultaPeliculaId : System.Web.UI.Page
    {
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int peliculaId;
            if (int.TryParse(txtPeliculaID.Text, out peliculaId))
            {
                using (PeliculaClient client = new PeliculaClient())
                {
                    Pelicula pelicula = client.GetPelicula(peliculaId);
                    if (pelicula != null)
                    {
                        lblNombre.Text = pelicula.Titulo;
                        lblGenero.Text = pelicula.Genero;
                        lblDuracion.Text = pelicula.Duracion;
                    }
                    else
                    {
                        lblNombre.Text = "No existe esa pelicula";
                        lblGenero.Text = string.Empty;
                        lblDuracion.Text = string.Empty;
                    }
                }
            }
            else
            {
                lblNombre.Text = "Id invalido";
                lblGenero.Text = string.Empty;
                lblDuracion.Text = string.Empty;
            }
        }
    }
}