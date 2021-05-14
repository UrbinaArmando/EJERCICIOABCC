using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCC.Models;

namespace ABCC.Components
{
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();
        }
        #region Funciones
        private int getid()
        {
            return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ABCC.Form1 form1 = new Form1(getid());
            form1.Show();
            this.Close();
        }
        #endregion
        #region Estilos
        private void EstiloFila(DataGridView dataGridView)
        {
            foreach (DataGridViewRow rowp in dataGridView.Rows)
            {
                if (int.Parse(dataGridView.Rows[rowp.Index].Cells[9].Value.ToString()) < 3)
                {
                    rowp.DefaultCellStyle.BackColor = Color.Red;

                }
                if (int.Parse(dataGridView.Rows[rowp.Index].Cells[10].Value.ToString()) == 1)
                {
                    rowp.DefaultCellStyle.BackColor = Color.Gray;

                }

            }
        }
        #endregion
        #region Controles
        private void cmbOptions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlSku.Visible = false;
            pnlArticulo.Visible = false;
            pnlDCF.Visible = false;
            switch (cmbOptions.SelectedItem)
            {
                case "Sku":
                    pnlSku.Visible = true;
                    break;
                case "Articulo":
                    pnlArticulo.Visible = true;
                    break;
                case "DCF":
                    pnlDCF.Visible = true;
                    using (abcEntities db = new abcEntities())
                    {

                        string numero;
                        string nombre;
                        var lst = from d in db.Departamento select d;

                        cmbDepartamento.Items.Clear();
                        foreach (var element in lst)
                        {
                            numero = element.IdDepartamento.ToString();
                            nombre = element.NombreDepartamento;

                            cmbDepartamento.Items.Add(numero + "-" + nombre);
                        }
                    };
                    break;
            }
        }

        private void txtSku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                using (abcEntities db = new abcEntities())
                {

                    var lst = from d in db.ABCC.Where(p => p.Sku.ToString().Contains(txtSku.Text))

                              select d;
                    dataGridView1.DataSource = lst.ToList();
                    EstiloFila(dataGridView1);
                }
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                using (abcEntities db = new abcEntities())
                {

                    var lst = from d in db.ABCC.Where(p => p.Articulo.Contains(txtArticulo.Text))

                              select d;
                    dataGridView1.DataSource = lst.ToList();
                    EstiloFila(dataGridView1);
                }
            }
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {

            using (abcEntities db = new abcEntities())
            {

                var lst = from d in db.ABCC.Where(p => p.Marca.Contains(txtMarca.Text))

                          select d;
                dataGridView1.DataSource = lst.ToList();
                EstiloFila(dataGridView1);
            }
        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            using (abcEntities db = new abcEntities())
            {

                var lst = from d in db.ABCC.Where(p => p.Modelo.Contains(txtModelo.Text))

                          select d;
                dataGridView1.DataSource = lst.ToList();
                EstiloFila(dataGridView1);
            }
        }
        private void cmbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbClase.Enabled = true;
            int indice = int.Parse(cmbDepartamento.SelectedItem.ToString().Substring(0, 1));
            using (abcEntities db = new abcEntities())
            {
                string numero;
                string nombre;

                var lstClase = from d in db.Clase select d;

                cmbClase.Items.Clear();
                cmbFamilia.Items.Clear();
                foreach (var element in lstClase)
                {
                    if (element.IdDepartamento == indice)
                    {
                        numero = element.IdClase.ToString();
                        nombre = element.NombreClase;

                        cmbClase.Items.Add(numero + " - " + nombre);
                    }
                }

                var lst = from d in db.ABCC.Where(p => p.Departamento.ToString().Contains(indice.ToString())) select d;
                dataGridView1.DataSource = lst.ToList();
                EstiloFila(dataGridView1);

            }
        }

        private void cmbClase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indice = int.Parse(cmbClase.SelectedItem.ToString().Substring(0, 1));
            int indice2 = int.Parse(cmbDepartamento.SelectedItem.ToString().Substring(0, 1));


            using (abcEntities db = new abcEntities())
            {
                string numero;
                string nombre;

                var lstClase = from d in db.Familia select d;

                cmbFamilia.Items.Clear();
                foreach (var element in lstClase)
                {
                    if (element.IdClase == indice && element.IdDepartamento == indice2)
                    {
                        numero = element.IdFamilia;
                        nombre = element.NombreFamilia;

                        cmbFamilia.Items.Add(numero + " - " + nombre);
                    }
                }
                var lst = from d in db.ABCC.Where(p => p.Departamento.ToString().Contains(indice2.ToString()) && p.Clase.ToString().Contains(indice.ToString())) select d;
                dataGridView1.DataSource = lst.ToList();
                EstiloFila(dataGridView1);
            }
            cmbFamilia.Enabled = true;


        }

        private void cmbFamilia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indice = int.Parse(cmbClase.SelectedItem.ToString().Substring(0, 1));
            int indice2 = int.Parse(cmbDepartamento.SelectedItem.ToString().Substring(0, 1));
            string indice3 = cmbFamilia.SelectedItem.ToString().Substring(0, 2);
            using (abcEntities db = new abcEntities())
            {
                var lst = from d in db.ABCC.Where(p => p.Departamento.ToString().Contains(indice2.ToString()) && p.Clase.ToString().Contains(indice.ToString()) && p.Familia.Contains(indice3)) select d;
                dataGridView1.DataSource = lst.ToList();

                EstiloFila(dataGridView1);

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion   
    }
}
