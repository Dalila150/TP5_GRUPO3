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
            string consulta = "select * from Productos";
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
            string s_IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_It_IdProducto")).Text;
            string s_NombreProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_It_NombreProducto")).Text;
            string s_IdProveedor = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Idprov")).Text;
            string s_PrecioU = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_It_PrecioUnidad")).Text;

            lblProductoSeleccionado.Text = "Producto Agregado: " + s_NombreProducto;

            if (Session["tabla"]==null)
            {
                Session["tabla"] = crearTabla();
            }

            Agregarfila((DataTable)Session["tabla"], s_IdProducto, s_NombreProducto, s_IdProveedor, s_PrecioU);
        }

        public  DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("IdProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("IdProveedor", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }

        public void Agregarfila(DataTable tabla, string id_Producto, string Nombre_Producto, string Id_Proveedor, string pu)
        {
            DataRow dr = tabla.NewRow();

            dr["IdProducto"] = id_Producto;
            dr["NombreProducto"] = Nombre_Producto;
            dr["idProveedor"] = Id_Proveedor;
            dr["PrecioUnidad"] = pu;
            tabla.Rows.Add(dr);

        }
    }
}