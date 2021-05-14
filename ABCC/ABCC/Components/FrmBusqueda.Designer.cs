
namespace ABCC.Components
{
    partial class FrmBusqueda
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlDCF = new System.Windows.Forms.Panel();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlSku = new System.Windows.Forms.Panel();
            this.pnlArticulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.Articulo = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.cmbOptions = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDCF.SuspendLayout();
            this.pnlSku.SuspendLayout();
            this.pnlArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlArticulo);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpiar);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSku);
            this.splitContainer1.Panel1.Controls.Add(this.cmbOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1369, 450);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlDCF
            // 
            this.pnlDCF.Controls.Add(this.cmbFamilia);
            this.pnlDCF.Controls.Add(this.cmbClase);
            this.pnlDCF.Controls.Add(this.cmbDepartamento);
            this.pnlDCF.Controls.Add(this.label5);
            this.pnlDCF.Controls.Add(this.label6);
            this.pnlDCF.Controls.Add(this.label3);
            this.pnlDCF.Location = new System.Drawing.Point(94, 0);
            this.pnlDCF.Name = "pnlDCF";
            this.pnlDCF.Size = new System.Drawing.Size(747, 100);
            this.pnlDCF.TabIndex = 4;
            this.pnlDCF.Visible = false;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilia.Enabled = false;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(537, 40);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(207, 24);
            this.cmbFamilia.TabIndex = 11;
            this.cmbFamilia.SelectionChangeCommitted += new System.EventHandler(this.cmbFamilia_SelectionChangeCommitted);
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.Enabled = false;
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(287, 40);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(205, 24);
            this.cmbClase.TabIndex = 10;
            this.cmbClase.SelectionChangeCommitted += new System.EventHandler(this.cmbClase_SelectionChangeCommitted);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(3, 40);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(236, 24);
            this.cmbDepartamento.TabIndex = 9;
            this.cmbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartamento_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Familia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Clase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Departamento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1291, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Salir";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlSku
            // 
            this.pnlSku.Controls.Add(this.label1);
            this.pnlSku.Controls.Add(this.txtSku);
            this.pnlSku.Location = new System.Drawing.Point(275, 11);
            this.pnlSku.Name = "pnlSku";
            this.pnlSku.Size = new System.Drawing.Size(607, 100);
            this.pnlSku.TabIndex = 3;
            this.pnlSku.Visible = false;
            // 
            // pnlArticulo
            // 
            this.pnlArticulo.Controls.Add(this.pnlDCF);
            this.pnlArticulo.Controls.Add(this.label4);
            this.pnlArticulo.Controls.Add(this.label2);
            this.pnlArticulo.Controls.Add(this.txtModelo);
            this.pnlArticulo.Controls.Add(this.txtMarca);
            this.pnlArticulo.Controls.Add(this.Articulo);
            this.pnlArticulo.Controls.Add(this.txtArticulo);
            this.pnlArticulo.Location = new System.Drawing.Point(201, 8);
            this.pnlArticulo.Name = "pnlArticulo";
            this.pnlArticulo.Size = new System.Drawing.Size(607, 100);
            this.pnlArticulo.TabIndex = 4;
            this.pnlArticulo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(495, 36);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModelo_KeyDown);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(293, 39);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
            // 
            // Articulo
            // 
            this.Articulo.AutoSize = true;
            this.Articulo.Location = new System.Drawing.Point(17, 45);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(55, 17);
            this.Articulo.TabIndex = 1;
            this.Articulo.Text = "Articulo";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(78, 42);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 22);
            this.txtArticulo.TabIndex = 2;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sku";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(65, 35);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(100, 22);
            this.txtSku.TabIndex = 2;
            this.txtSku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSku_KeyDown);
            // 
            // cmbOptions
            // 
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Items.AddRange(new object[] {
            "Sku",
            "Articulo",
            "DCF"});
            this.cmbOptions.Location = new System.Drawing.Point(43, 47);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(121, 24);
            this.cmbOptions.TabIndex = 0;
            this.cmbOptions.SelectionChangeCommitted += new System.EventHandler(this.cmbOptions_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1369, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmBusqueda";
            this.Text = "FrmBusqueda";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDCF.ResumeLayout(false);
            this.pnlDCF.PerformLayout();
            this.pnlSku.ResumeLayout(false);
            this.pnlSku.PerformLayout();
            this.pnlArticulo.ResumeLayout(false);
            this.pnlArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlSku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.ComboBox cmbOptions;
        private System.Windows.Forms.Panel pnlArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label Articulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Panel pnlDCF;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
    }
}