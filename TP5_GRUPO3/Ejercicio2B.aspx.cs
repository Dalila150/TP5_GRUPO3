using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP5_GRUPO3
{
    public partial class Ejercicio2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tabla"]!= null)
            {
                grdProductosElegidos.DataSource = (DataTable)Session["tabla"];
                grdProductosElegidos.DataBind();
            }
            else
            {
                lblMensaje.Text = "No se seleccionaron productos";
            }
        }
    }
}