using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP5_GRUPO3.Clases;

namespace TP5_GRUPO3
{
    public partial class Ejercicio2A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string consulta = "select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos";
            Conexion conectar = new Conexion();

            SqlDataAdapter adap = conectar.ejecutarConsultaAdapter(consulta);

            DataSet ds = new DataSet();

            adap.Fill(ds, "tablaProductos");
            grdProductos.DataSource = ds.Tables["tablaProductos"];
            grdProductos.DataBind();

            if (IsPostBack == false)
            {
                CargarGridView();
            }

        }
        public void CargarGridView()
        {
            GestionProductos glibros = new GestionProductos();
            grdProductos.DataSource = glibros.ObtenerTodosLosProductos();
            grdProductos.DataBind();
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        protected void grdProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string s_NombreProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_It_NombreProducto")).Text;
            lblProductoSeleccionado.Text = "Producto Agregado: " + s_NombreProducto;
        }
    }
}