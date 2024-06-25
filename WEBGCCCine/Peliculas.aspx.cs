using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using WEBGCCCine.ServiceReference1;

namespace WEBGCCCine
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       private void CargarPeliculas()
        {
            using (PeliculaClient client = new PeliculaClient())
            {
                GrillaPelicula.DataSource = client.GetPeliculas();
                GrillaPelicula.DataBind();
                
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CargarPeliculas();
        }
    }
}