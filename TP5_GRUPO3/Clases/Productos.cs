using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP5_GRUPO3.Clases
{
    public class Productos
    {
        private int i_IdProducto;
        private string s_NombreProducto;
        private int i_IdProveedor;
        private decimal d_PrecioUnidad;

        public Productos()
        {
        }
        public Productos(int i_IdProducto, string s_NombreProducto, int i_IdProveedor, decimal d_PrecioUnidad)
        {
            this.i_IdProducto = i_IdProducto;
            this.s_NombreProducto = s_NombreProducto;
            this.i_IdProveedor = i_IdProveedor;
            this.d_PrecioUnidad = d_PrecioUnidad;
        }

        public int IdProducto
        {
            get { return i_IdProducto; }
            set { i_IdProducto = value; }
        }
        public string NombreProducto
        {
            get { return s_NombreProducto; }
            set { s_NombreProducto = value; }
        }
        public int IdProveedor
        {
            get { return i_IdProveedor; }
            set { i_IdProveedor = value; }
        }
        public decimal PrecioUnidad
        {
            get { return d_PrecioUnidad; }
            set { d_PrecioUnidad = value; }
        }
    }
}
