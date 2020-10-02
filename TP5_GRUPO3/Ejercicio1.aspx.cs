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

            adap.Fill(ds, "tablaProductos");
            grdProductos.DataSource = ds.Tables["tablaProductos"];
            grdProductos.DataBind();
            


        }
    }
}