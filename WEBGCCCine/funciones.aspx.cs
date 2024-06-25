using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBGCCCine.ServiceReference1;

namespace WEBGCCCine
{
    public partial class funciones : System.Web.UI.Page
    {
        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            using (PeliculaClient client = new PeliculaClient())
            {
                gvFunciones.DataSource = client.GetFunciones();
                gvFunciones.DataBind();
            }
        }

        protected void gvFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}