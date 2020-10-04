﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Net;
using System.Data;
using System.Web.UI.WebControls;

namespace TP5_GRUPO3.Clases
{
    public class Conexion
    {


        string ruta = "Data Source=" + Dns.GetHostName() + "\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        //string ruta = "Data Source=DESKTOP-AN768UP\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";


        public int ejecutarConsulta(string consulta) //Insertar, eliminar, modificar
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand comando = new SqlCommand(consulta, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();

            return filasAfectadas;
        }


        public SqlDataReader ejecutarConsultaReader(string consulta) //Select, devuelve un SqlDataReader
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            return dr;
        }
        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public SqlDataAdapter ejecutarConsultaAdapter(string consulta) //Select, devuelve un SqlDataAdapter
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlDataAdapter adap = new SqlDataAdapter(consulta, conexion);

            return adap;

        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, string NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexcion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexcion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexcion.Close();
            return FilasCambiadas;
        }

    }

}
