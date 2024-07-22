using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
            if (Request.QueryString["Id"] != null && IsPostBack != true)
            {
                int Id = int.Parse(Request.QueryString["Id"]);
                List<Direccion> temporal = new List<Direccion>();
                temporal = (List<Direccion>)Session["listaDirecciones"];
                Direccion seleccionada = temporal.Find(x => x.Id == Id);
                tbxId.Text = seleccionada.Id.ToString();
                tbxId.ReadOnly = true;
                tbxCalle.Text = seleccionada.calle;
                tbxNumero.Text = seleccionada.numero.ToString();
                tbxCodPos.Text = seleccionada.codigoPostal.ToString();
                tbxDistrito.Text = seleccionada.distrito;

                lbTitutlo.Text = "Modificar dirección";

            }
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

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            List<Direccion> temporal = (List<Direccion>)Session["listaDirecciones"];
            Direccion modificada = new Direccion();
            modificada.Id = int.Parse(tbxId.Text);
            modificada.calle = tbxCalle.Text;
            modificada.numero = int.Parse(tbxNumero.Text);
            modificada.codigoPostal = int.Parse(tbxCodPos.Text);
            modificada.distrito = tbxDistrito.Text;

            var Id = temporal.FindIndex(x => x.Id == modificada.Id);

            temporal[Id] = modificada;
            Response.Redirect("Default.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Direccion> temporal = (List<Direccion>)Session["listaDirecciones"];
            int Id = int.Parse(Request.QueryString["Id"]);
            var index = temporal.FindIndex(x => x.Id == Id);
            temporal.RemoveAt(index);
            Response.Redirect("Default.aspx", false);


        }
    }
}