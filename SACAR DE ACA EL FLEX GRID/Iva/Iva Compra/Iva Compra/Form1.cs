using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Iva_Compra
{
    public partial class Frm_Ini : Form
    {
        public Frm_Ini()
        {
            InitializeComponent();
        }

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

        private void btn_carga_Click(object sender, EventArgs e)
        {
            string cade = "server=localhost; user id=root; database=iva_compras; password=;";
            MySqlConnection Conex = new MySqlConnection();
            Conex.ConnectionString = cade;
            Conex.Open();


            MySqlDataReader drtdoc;
            MySqlCommand instru = new MySqlCommand();

            MySqlParameter prov_nomb = new MySqlParameter("@prov_nomb", MySqlDbType.Text);
            prov_nomb.Value = cmb_proveedores.Text;
            MySqlCommand busca_prov = new MySqlCommand("SELECT prov_id FROM proveedores WHERE prov_nomb = @prov_nomb");
            busca_prov.Connection = Conex;
            busca_prov.Parameters.Add(prov_nomb);
            int busca_rubro = Convert.ToInt32(busca_prov.ExecuteScalar());

            Conex.Close();
            Conex.Open();

            MySqlParameter tdoc_tdoc = new MySqlParameter("@tdoc_desc", MySqlDbType.Text);
            tdoc_tdoc.Value = cmb_tdoc.Text;
            MySqlCommand busca_tdoc = new MySqlCommand("SELECT tdoc_id FROM tipo_documento WHERE tdoc_desc = @tdoc_desc");
            busca_tdoc.Connection = Conex;
            busca_tdoc.Parameters.Add(tdoc_tdoc);
            int bus_tdoc = Convert.ToInt32(busca_tdoc.ExecuteScalar());


            Conex.Close();
            Conex.Open();

            MySqlParameter prove_id = new MySqlParameter("@prov_id", MySqlDbType.Text);
            MySqlParameter tdoc_id = new MySqlParameter("@tdoc_id", MySqlDbType.Text);
            MySqlParameter ivac_fech = new MySqlParameter("@ivac_fech", MySqlDbType.Date);
            MySqlParameter ivac_subt = new MySqlParameter("@ivac_subt", MySqlDbType.Decimal);
            MySqlParameter ivac_iva = new MySqlParameter("@ivac_iva", MySqlDbType.Decimal);

            prove_id.Value = Convert.ToInt32(busca_rubro);
            tdoc_id.Value = Convert.ToInt32(bus_tdoc);
            ivac_fech.Value = dtp_fecha.Value;
            ivac_subt.Value = txt_subtotal.Text;
            ivac_iva.Value = txt_iva.Text;

            instru.CommandText = "INSERT into iva_compras (prov_id , tdoc_id , ivac_fech , ivac_subt , ivac_iva) values (@prov_id , @tdoc_id , @ivac_fech , @ivac_subt , @ivac_iva)";
            instru.Parameters.Add(prove_id);
            instru.Parameters.Add(tdoc_id);
            instru.Parameters.Add(ivac_fech);
            instru.Parameters.Add(ivac_subt);
            instru.Parameters.Add(ivac_iva);

            instru.Connection = Conex;
            drtdoc = instru.ExecuteReader();


            

        }

        private void Frm_Ini_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iva_comprasDataSet.iva_compras' table. You can move, or remove it, as needed.
            this.iva_comprasTableAdapter.Fill(this.iva_comprasDataSet.iva_compras);
            Mod modulo = new Mod();

            string cade = "server=localhost; user id=root; database=iva_compras; password=;";
            MySqlConnection Conexion = new MySqlConnection();
            Conexion.ConnectionString = cade;
            Conexion.Open();


            //cargar combo proveedores
            MySqlDataReader dr_prov;
            MySqlCommand instru = new MySqlCommand();
            instru.CommandText = "select prov_nomb from proveedores";
            instru.Connection = Conexion;
            dr_prov = instru.ExecuteReader();
            cmb_proveedores.Items.Clear();
            string strub = "";
            while (dr_prov.Read())
            {
                strub = dr_prov.GetString(0);
                cmb_proveedores.Items.Add(strub);
            }


            Conexion.Close();
            Conexion.Open();

            //cargar combo tipo documento
            MySqlDataReader drtdoc;
            MySqlCommand instruc = new MySqlCommand();
            instruc.CommandText = "select tdoc_desc from tipo_documento";
            instruc.Connection = Conexion;
            drtdoc = instruc.ExecuteReader();
            cmb_tdoc.Items.Clear();
            string str_documento = "";
            while (drtdoc.Read())
            {
                str_documento = drtdoc.GetString(0);
                cmb_tdoc.Items.Add(str_documento);




            }
        }

        private void txt_subtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
         
       
         //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
                 {
                   e.Handled = false;
                 }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
               {
                 e.Handled = false;
               }
           else
              {
               //el resto de teclas pulsadas se desactivan
               e.Handled = true;
              }
         
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }



       }
    }

