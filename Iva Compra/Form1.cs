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
        public static string cade = "server=localhost; user id=root; database=iva_compras; password=root;";
        public MySqlConnection conexion = new MySqlConnection(cade);
        public void conectar()
        {  
            string cade = "server=localhost; user id=root; database=iva_compras; password=root;";
            conexion = new MySqlConnection(cade);
        }
        private void btn_carga_Click(object sender, EventArgs e)
        {
//BUSQUEDA DE EL ID DE PROVEEDOR SEGUN LO QUE ELEGI EN EL COMBOBOX
                conexion.Open();
                //parametros para busqueda de proveedor id asi inserto
                MySqlParameter prov_nomb = new MySqlParameter("@prov_nomb", MySqlDbType.Text);
                prov_nomb.Value = cmb_proveedores.Text;

                MySqlCommand busca_prov = new MySqlCommand("SELECT prov_id FROM proveedores WHERE prov_nomb = @prov_nomb");
                busca_prov.Connection = conexion;
                busca_prov.Parameters.Add(prov_nomb);
                int prov_id = Convert.ToInt32(busca_prov.ExecuteScalar()); //guardo el id de proveedor que busque en una variable
                conexion.Close();      
//BUSQUEDA DE EL ID DE TIPO DE DOCUMENTO SEGUN LO QUE ELEGI EN EL COMBOBOX
                conexion.Open();
                MySqlParameter tipo_doc = new MySqlParameter("@tipo_doc_desc", MySqlDbType.Text);
                tipo_doc.Value = cmb_tdoc.Text;
                MySqlCommand busca_tipo_doc_id = new MySqlCommand("SELECT tdoc_id FROM tipo_documento WHERE tdoc_desc = @tipo_doc_desc");
                busca_tipo_doc_id.Connection = conexion;
                busca_tipo_doc_id.Parameters.Add(tipo_doc);
                int tipo_doc_id = Convert.ToInt32(busca_tipo_doc_id.ExecuteScalar());
                conexion.Close();
//INSERTAR REGISTRO EN LA TABLA IVA_COMPRA
            try{
            conexion.Open();
            MySqlParameter prove_id = new MySqlParameter("@prov_id", MySqlDbType.Int32);
            MySqlParameter tip_doc_id = new MySqlParameter("@tdoc_id", MySqlDbType.Int32);
            MySqlParameter ivac_fech = new MySqlParameter("@ivac_fech", MySqlDbType.Date);
            MySqlParameter ivac_subt = new MySqlParameter("@ivac_subt", MySqlDbType.Decimal);
            MySqlParameter ivac_iva = new MySqlParameter("@ivac_iva", MySqlDbType.Decimal);
            Random ran = new Random(DateTime.Now.Millisecond);

            prove_id.Value = ran.Next(1, 3);//obtener el maximo registro de proveedores y tipo de documento para que no sea una constante
            tip_doc_id.Value = ran.Next(1, 3);
                // usar un if para controlar el numero random en los meses segun sean de 29,30,31 dias
            int anio = ran.Next(1995, 2012);
            int mes = (ran.Next(1,12));
            int dia = 0;
            if (mes==1|mes==5|mes==3|mes==5|mes==7|mes==8|mes==10| mes==12) { //los meses con 31 dias
                dia = ran.Next(1, 31);   
            }
            if (mes == 4 | mes == 6| mes == 9 | mes == 11) //los meses con 30 dias
            {
                dia = ran.Next(1, 30);
            }
            if (mes == 2) //febrero con 28 o 29 dias..
            {
                if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0) // si es bisiesto o no
                {
                    dia = ran.Next(1, 28);
                }
                else
                {
                    dia = ran.Next(1, 29);
                }
            }
            ivac_fech.Value = Convert.ToDateTime(Convert.ToString(anio)+"-"+Convert.ToString(mes)+"-"+Convert.ToString(dia));
            double total = ran.Next(1, 10000) * (ran.NextDouble());
                //random iva
            ivac_subt.Value = total;
            ivac_iva.Value = (21*total)/100;
            //creo el comando de insertar
            MySqlCommand insertar_iva_compra = new MySqlCommand();
            insertar_iva_compra.CommandText = "INSERT into iva_compras (prov_id , tdoc_id , ivac_fech , ivac_subt , ivac_iva) values (@prov_id , @tdoc_id , @ivac_fech , @ivac_subt , @ivac_iva)";
            insertar_iva_compra.Parameters.Add(prove_id);
            insertar_iva_compra.Parameters.Add(tip_doc_id);
            insertar_iva_compra.Parameters.Add(ivac_fech);
            insertar_iva_compra.Parameters.Add(ivac_subt);
            insertar_iva_compra.Parameters.Add(ivac_iva);

            insertar_iva_compra.Connection = conexion;
            
            insertar_iva_compra.ExecuteNonQuery();
            conexion.Close();
            }
            catch (Exception er){
                MessageBox.Show("ERROR INSERTAR EN IVA COMPRA "+er);
                conexion.Close();
            }
        }

        private void Frm_Ini_Load(object sender, EventArgs e)
        {
//This line of code loads data into the 'iva_comprasDataSet.iva_compras' table. You can move, or remove it, as needed.
            this.iva_comprasTableAdapter.Fill(this.iva_comprasDataSet.iva_compras);

            
//cargar combo proveedores
            try
            {
                conexion.Open();
                MySqlDataReader datareader_prov;
                MySqlCommand busca_prov = new MySqlCommand();
                busca_prov.CommandText = "SELECT prov_nomb FROM proveedores";
                busca_prov.Connection = conexion;
                datareader_prov = busca_prov.ExecuteReader();
                cmb_proveedores.Items.Clear();
                string proveedor = "";

                while (datareader_prov.Read())
                {
                    proveedor = datareader_prov.GetString(0);
                    cmb_proveedores.Items.Add(proveedor);
                }
                conexion.Close();
            }
            catch (Exception er){
                MessageBox.Show("ERROR COMBO PROVEEDORES "+er);
                conexion.Close();
            }
//cargar combo tipo documento
            try
            {
                conexion.Open();
                MySqlDataReader datareader_tipo_doc;
                MySqlCommand busca_doc = new MySqlCommand();
                busca_doc.CommandText = "SELECT tdoc_desc FROM tipo_documento";
                busca_doc.Connection = conexion;
                datareader_tipo_doc = busca_doc.ExecuteReader();
                cmb_tdoc.Items.Clear();
                string documento = "";

                while (datareader_tipo_doc.Read())
                {
                    documento = datareader_tipo_doc.GetString(0);
                    cmb_tdoc.Items.Add(documento);
                }
                conexion.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("ERROR COMBO PROVEEDORES " + er);
                conexion.Close();
            }
//FIN
        }
       }
    }

