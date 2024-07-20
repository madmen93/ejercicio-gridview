using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace gridviewejercicio
{
    public partial class NuevoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Direccion nuevo = new Direccion();
            nuevo.Id = int.Parse(tbxId.Text);
            nuevo.calle = tbxCalle.Text;
            nuevo.numero = int.Parse(tbxNumero.Text);
            nuevo.codigoPostal = int.Parse(tbxCodPos.Text);
            nuevo.distrito = tbxDistrito.Text;

            List<Direccion> listaTemporal = new List<Direccion>();
            listaTemporal = (List<Direccion>)Session["listaDirecciones"];
            listaTemporal.Add(nuevo);

            Response.Redirect("Default.aspx", false);
        }
    }
}