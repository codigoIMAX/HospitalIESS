﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login.Clases
{
    public class DataBase
    {
        public static SqlConnection obtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=ALEJANDRO-VAIO;Initial Catalog=HospitalIESS;Integrated Security=True");
                conexion.Open();
                return conexion;
            }
            catch
            {
                return null;
            }
            
        }
        public static void cerrarConexion(SqlConnection con)
        {
            con.Close();
        }
    }
}
