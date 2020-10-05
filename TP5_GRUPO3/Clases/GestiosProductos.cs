using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP5_GRUPO3.Clases
{
    public class GestionProductos
    {
        public GestionProductos()
        {
        }
        private DataTable ObtenerTabla(string Nombre, string Sql)
        {
            DataSet ds = new DataSet();
            Conexion datos = new Conexion();
            SqlDataAdapter adp = datos.ejecutarConsultaAdapter(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }
        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "Select * from Productos");
        }

        private void ArmarParametrosLibros(ref SqlCommand Comando, Productos Producto)
        {
            SqlParameter sqlparametros = new SqlParameter();
            sqlparametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            sqlparametros.Value = Producto.IdProducto;
            sqlparametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar);
            sqlparametros.Value = Producto.NombreProducto;
            sqlparametros = Comando.Parameters.Add("@IdProveedor", SqlDbType.Int);
            sqlparametros.Value = Producto.IdProveedor;
            sqlparametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            sqlparametros.Value = Producto.PrecioUnidad;

        }
        public bool ActualizarLibro(Productos Pro)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosLibros(ref Comando, Pro);
            Conexion ad = new Conexion();
            int FilasIncertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActializaLibro");
            if (FilasIncertadas == 1)
                return true;
            else
                return false;
        }
        private void ArarParametrosProductosEliminar (ref SqlCommand Comando, Productos Producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = Producto.IdProducto;
        }

        public bool EliminarProducto(Productos producto)
        {
            SqlCommand Comando = new SqlCommand();
            ArarParametrosProductosEliminar(ref Comando, producto);
            Conexion ad = new Conexion();
            int filasEliminadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarProducto");
            if(filasEliminadas == 1){
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
