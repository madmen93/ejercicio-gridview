using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace gridviewejercicio
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaDirecciones"] == null)
            {
                DireccionNegocio negocio = new DireccionNegocio();
                Session.Add("listaDirecciones", negocio.listar());
            }
            gdvDirecciones.DataSource = Session["listaDirecciones"];
            gdvDirecciones.DataBind();
        }

        protected void btnNuevaDireccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevaDireccion.aspx", false);
        }

        protected void gdvDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = gdvDirecciones.SelectedDataKey.Value.ToString();
            Response.Redirect("NuevaDireccion.aspx?Id=" + Id, false);
        }
    }
}