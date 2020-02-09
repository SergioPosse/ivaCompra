using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Iva_Compra
{
    class Conexion_mysql
    {
        public void conectar()
        {
            string cade = "server=localhost; user id=root; database=iva_compras; password=;";


            MySqlConnection Conexion = new MySqlConnection();
            try
            {
                Conexion.ConnectionString = cade;
                Conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "Error");
            }


         
        }
    }
}
