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
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string consulta = "select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos";
            Conexion conectar = new Conexion();
            
            SqlDataAdapter adap = conectar.ejecutarConsultaAdapter(consulta);

            DataSet ds = new DataSet();

            CargarGridView();
            
        }

        public void CargarGridView()
        {
            GestionProductos gPro = new GestionProductos();
            grdProductos.DataSource = gPro.ObtenerTodosLosProductos();
            grdProductos.DataBind();
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
        }


        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String idProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_it_id")).Text;
            Productos pro = new Productos();
            pro.IdProducto = Convert.ToInt32(idProducto);

            GestionProductos gPro = new GestionProductos();
            gPro.EliminarProducto(pro);

            CargarGridView();
        }
    }
}