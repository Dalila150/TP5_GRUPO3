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
        private decimal d_PrecioUnidad;
        private string s_cantidadPorunidad;

        public Productos()
        {
        }
        public Productos(int i_IdProducto, string s_NombreProducto, string s_cantidaPorunidad, decimal d_PrecioUnidad)
        {
            this.i_IdProducto = i_IdProducto;
            this.s_NombreProducto = s_NombreProducto;
            this.s_cantidadPorunidad = s_cantidaPorunidad;
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
        public decimal PrecioUnidad
        {
            get { return d_PrecioUnidad; }
            set { d_PrecioUnidad = value; }
        }
        public string CantidadPorUnidad 
        {
            get { return s_cantidadPorunidad; }
            set { s_cantidadPorunidad = value; }
        }
    }
}
