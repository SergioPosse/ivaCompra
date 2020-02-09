namespace Iva_Compra
{
    partial class Frm_Ini
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_carga = new System.Windows.Forms.Button();
            this.grb_ivaco = new System.Windows.Forms.GroupBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_tdoc = new System.Windows.Forms.ComboBox();
            this.cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tdoc = new System.Windows.Forms.Label();
            this.lbl_prov = new System.Windows.Forms.Label();
            this.dvg_data = new System.Windows.Forms.DataGridView();
            this.ivacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivacfechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivacsubtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivacivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivacomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iva_comprasDataSet = new Iva_Compra.iva_comprasDataSet();
            this.iva_comprasTableAdapter = new Iva_Compra.iva_comprasDataSetTableAdapters.iva_comprasTableAdapter();
            this.grb_ivaco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivacomprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iva_comprasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_carga
            // 
            this.btn_carga.Location = new System.Drawing.Point(449, 288);
            this.btn_carga.Name = "btn_carga";
            this.btn_carga.Size = new System.Drawing.Size(75, 23);
            this.btn_carga.TabIndex = 21;
            this.btn_carga.Text = "&Cargar";
            this.btn_carga.UseVisualStyleBackColor = true;
            this.btn_carga.Click += new System.EventHandler(this.btn_carga_Click);
            // 
            // grb_ivaco
            // 
            this.grb_ivaco.Controls.Add(this.txt_iva);
            this.grb_ivaco.Controls.Add(this.txt_subtotal);
            this.grb_ivaco.Controls.Add(this.dtp_fecha);
            this.grb_ivaco.Controls.Add(this.cmb_tdoc);
            this.grb_ivaco.Controls.Add(this.cmb_proveedores);
            this.grb_ivaco.Controls.Add(this.label5);
            this.grb_ivaco.Controls.Add(this.label4);
            this.grb_ivaco.Controls.Add(this.label3);
            this.grb_ivaco.Controls.Add(this.lbl_tdoc);
            this.grb_ivaco.Controls.Add(this.lbl_prov);
            this.grb_ivaco.Location = new System.Drawing.Point(12, 12);
            this.grb_ivaco.Name = "grb_ivaco";
            this.grb_ivaco.Size = new System.Drawing.Size(509, 148);
            this.grb_ivaco.TabIndex = 22;
            this.grb_ivaco.TabStop = false;
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(103, 114);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(121, 20);
            this.txt_iva.TabIndex = 28;
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(307, 114);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(121, 20);
            this.txt_subtotal.TabIndex = 30;
            this.txt_subtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_subtotal_KeyPress);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(307, 27);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha.TabIndex = 29;
            // 
            // cmb_tdoc
            // 
            this.cmb_tdoc.FormattingEnabled = true;
            this.cmb_tdoc.Location = new System.Drawing.Point(103, 70);
            this.cmb_tdoc.Name = "cmb_tdoc";
            this.cmb_tdoc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tdoc.TabIndex = 27;
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(103, 26);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(121, 21);
            this.cmb_proveedores.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "IVA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // lbl_tdoc
            // 
            this.lbl_tdoc.AutoSize = true;
            this.lbl_tdoc.Location = new System.Drawing.Point(8, 73);
            this.lbl_tdoc.Name = "lbl_tdoc";
            this.lbl_tdoc.Size = new System.Drawing.Size(89, 13);
            this.lbl_tdoc.TabIndex = 22;
            this.lbl_tdoc.Text = "Tipo Documento:";
            // 
            // lbl_prov
            // 
            this.lbl_prov.AutoSize = true;
            this.lbl_prov.Location = new System.Drawing.Point(38, 33);
            this.lbl_prov.Name = "lbl_prov";
            this.lbl_prov.Size = new System.Drawing.Size(59, 13);
            this.lbl_prov.TabIndex = 21;
            this.lbl_prov.Text = "Proveedor:";
            // 
            // dvg_data
            // 
            this.dvg_data.AutoGenerateColumns = false;
            this.dvg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ivacidDataGridViewTextBoxColumn,
            this.providDataGridViewTextBoxColumn,
            this.tdocidDataGridViewTextBoxColumn,
            this.ivacfechDataGridViewTextBoxColumn,
            this.ivacsubtDataGridViewTextBoxColumn,
            this.ivacivaDataGridViewTextBoxColumn});
            this.dvg_data.DataSource = this.ivacomprasBindingSource;
            this.dvg_data.Location = new System.Drawing.Point(12, 166);
            this.dvg_data.Name = "dvg_data";
            this.dvg_data.Size = new System.Drawing.Size(428, 150);
            this.dvg_data.TabIndex = 26;
            // 
            // ivacidDataGridViewTextBoxColumn
            // 
            this.ivacidDataGridViewTextBoxColumn.DataPropertyName = "ivac_id";
            this.ivacidDataGridViewTextBoxColumn.HeaderText = "ivac_id";
            this.ivacidDataGridViewTextBoxColumn.Name = "ivacidDataGridViewTextBoxColumn";
            // 
            // providDataGridViewTextBoxColumn
            // 
            this.providDataGridViewTextBoxColumn.DataPropertyName = "prov_id";
            this.providDataGridViewTextBoxColumn.HeaderText = "prov_id";
            this.providDataGridViewTextBoxColumn.Name = "providDataGridViewTextBoxColumn";
            // 
            // tdocidDataGridViewTextBoxColumn
            // 
            this.tdocidDataGridViewTextBoxColumn.DataPropertyName = "tdoc_id";
            this.tdocidDataGridViewTextBoxColumn.HeaderText = "tdoc_id";
            this.tdocidDataGridViewTextBoxColumn.Name = "tdocidDataGridViewTextBoxColumn";
            // 
            // ivacfechDataGridViewTextBoxColumn
            // 
            this.ivacfechDataGridViewTextBoxColumn.DataPropertyName = "ivac_fech";
            this.ivacfechDataGridViewTextBoxColumn.HeaderText = "ivac_fech";
            this.ivacfechDataGridViewTextBoxColumn.Name = "ivacfechDataGridViewTextBoxColumn";
            // 
            // ivacsubtDataGridViewTextBoxColumn
            // 
            this.ivacsubtDataGridViewTextBoxColumn.DataPropertyName = "ivac_subt";
            this.ivacsubtDataGridViewTextBoxColumn.HeaderText = "ivac_subt";
            this.ivacsubtDataGridViewTextBoxColumn.Name = "ivacsubtDataGridViewTextBoxColumn";
            // 
            // ivacivaDataGridViewTextBoxColumn
            // 
            this.ivacivaDataGridViewTextBoxColumn.DataPropertyName = "ivac_iva";
            this.ivacivaDataGridViewTextBoxColumn.HeaderText = "ivac_iva";
            this.ivacivaDataGridViewTextBoxColumn.Name = "ivacivaDataGridViewTextBoxColumn";
            // 
            // ivacomprasBindingSource
            // 
            this.ivacomprasBindingSource.DataMember = "iva_compras";
            this.ivacomprasBindingSource.DataSource = this.iva_comprasDataSet;
            // 
            // iva_comprasDataSet
            // 
            this.iva_comprasDataSet.DataSetName = "iva_comprasDataSet";
            this.iva_comprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iva_comprasTableAdapter
            // 
            this.iva_comprasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Ini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 323);
            this.Controls.Add(this.dvg_data);
            this.Controls.Add(this.grb_ivaco);
            this.Controls.Add(this.btn_carga);
            this.Name = "Frm_Ini";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Frm_Ini_Load);
            this.grb_ivaco.ResumeLayout(false);
            this.grb_ivaco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivacomprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iva_comprasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_carga;
        private System.Windows.Forms.GroupBox grb_ivaco;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cmb_tdoc;
        private System.Windows.Forms.ComboBox cmb_proveedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tdoc;
        private System.Windows.Forms.Label lbl_prov;
        private System.Windows.Forms.DataGridView dvg_data;
        private iva_comprasDataSet iva_comprasDataSet;
        private System.Windows.Forms.BindingSource ivacomprasBindingSource;
        private iva_comprasDataSetTableAdapters.iva_comprasTableAdapter iva_comprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivacidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivacfechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivacsubtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivacivaDataGridViewTextBoxColumn;
    }
}

