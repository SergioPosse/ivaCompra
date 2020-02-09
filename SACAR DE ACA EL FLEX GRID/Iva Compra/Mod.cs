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
    class Mod
    {
        public MySqlDataReader obtener_nom_prov(MySqlDataReader drcliente)
        {


            Conexion_mysql conex = new Conexion_mysql();
            conex.conectar();


            try
            {
                MySqlCommand instruccion = new MySqlCommand();

                instruccion.CommandText = "select prov_nomb from clientes";
                drcliente = instruccion.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "Error");
            }
            return drcliente;
        }
    }

}
