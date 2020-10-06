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
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        public void CargarGridView()
        {
            GestionProductos gPro = new GestionProductos();
            grdProductos.DataSource = gPro.ObtenerTodosLosProductos();
            grdProductos.DataBind();
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

        protected void grdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void grdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //SE BUSCAN LOS DATOS DEL !!!EDIT!!! ITEM TEMPLATE (NO DEL SELECT)

            string s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("llb_eit_IdProducto")).Text;
            string s_NombreProducto = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_NombrePro")).Text;
            string s_cantidadPorunidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_CantXUnidad")).Text;
            string s_PrecioU = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;

            Productos prod = new Productos();
            prod.IdProducto = Convert.ToInt32(s_IdProducto);
            prod.NombreProducto = s_NombreProducto;
            prod.CantidadPorUnidad = s_cantidadPorunidad;
            prod.PrecioUnidad = Convert.ToDecimal(s_PrecioU);

            GestionProductos gprod = new GestionProductos();
            gprod.ActualizarLibro(prod);

            grdProductos.EditIndex = -1;
            CargarGridView();

        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }
    }
}