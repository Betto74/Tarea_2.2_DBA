﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection conexion;
        public static bool Conectar()
        {


            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open) return true;

                conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=WindowServer\\libreria;Initial Catalog=LIBRARY;User ID=sa;Password=Mysql4S6A123";
                conexion.Open();

                return true;
            }
            catch (SqlException ex)
            {

                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public static void Desconectar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();

        }
    }
}

