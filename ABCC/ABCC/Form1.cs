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
using ABCC.Components;


namespace ABCC
{
    public partial class Form1 : Form
    {
        int? id;
        public string bandera = "";
        public Form1(int? id=null)
        {
            this.id = id;
            InitializeComponent();
            if(id != null)
            {
                Consulta(id);
                txtSku.Text = id.ToString();
            }
        }
        
        #region Metodos
        private void Alta()
        {
            using(abcEntities db = new abcEntities())
            {
                ABCC.Models.ABCC oTabla = new Models.ABCC();            
                db.spAlta(
                    int.Parse(txtSku.Text),
                    txtArticulo.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    int.Parse(cmbDepartamento.Text.Substring(0,1)),
                    int.Parse(cmbClase.Text.Substring(0, 1)),
                    cmbFamilia.Text.Substring(0, 2),
                    int.Parse(txtStock.Text),
                    int.Parse(txtCantidad.Text),
                    dtpFA.Value,
                    dtpFB.Value,
                    "0"
                    ) ;
                db.SaveChanges();
            }
        }
        public void Consulta(int? id)
        {
            using (abcEntities db = new abcEntities())
            {
                var lst = db.spConsulta(id);
                foreach (var element in lst)
                {
                    cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDown;
                    cmbClase.DropDownStyle = ComboBoxStyle.DropDown;
                    cmbFamilia.DropDownStyle = ComboBoxStyle.DropDown;

                    txtArticulo.Text = element.Articulo;
                    txtMarca.Text = element.Marca;
                    txtModelo.Text = element.Modelo;                  
                    txtStock.Text = element.Stock.ToString();
                    txtCantidad.Text = element.Cantidad.ToString();
                    dtpFA.Value = element.Fecha_Alta;
                    dtpFB.Value = element.Fecha_Baja.Value;
                    var lst2 = db.Departamento.Single(p => p.IdDepartamento.ToString().Contains(element.Departamento.ToString()));
                    var lst3 = db.Clase.Single(p => p.IdClase.ToString().Contains(element.Clase.ToString()) && p.IdDepartamento.ToString().Contains(element.Departamento.ToString()));
                    var lst4 = db.Familia.Single(p => p.IdClase.ToString().Contains(element.Clase.ToString()) && p.IdDepartamento.ToString().Contains(element.Departamento.ToString()) && p.IdFamilia.Contains(element.Familia.ToString()));
                    cmbDepartamento.Text = lst2.IdDepartamento.ToString() + " - " + lst2.NombreDepartamento.ToString();
                    cmbClase.Text = lst3.IdClase.ToString() + " - " + lst3.NombreClase.ToString();
                    cmbFamilia.Text = lst4.IdFamilia.ToString() + " - " + lst4.NombreFamilia.ToString();
                    if (element.Descontinuado == "1")
                    {
                        cbxDescontinuado.Checked = true;
                    }
                    else
                    {
                        cbxDescontinuado.Checked = false;
                    }
                    
                  



                    btnEliminar.Enabled = true;
                    btnEditar.Enabled = true;
            }
            } 
        }

        private void Cambio(int id)
        {
            using (abcEntities db = new abcEntities())
            {
                ABCC.Models.ABCC oTabla = new Models.ABCC();
                string d = "0";
                if (cbxDescontinuado.Checked == true)
                {
                    d = "1";
                    db.spCambio(
                   int.Parse(txtSku.Text),
                   txtArticulo.Text,
                   txtMarca.Text,
                   txtModelo.Text,
                   int.Parse(cmbDepartamento.Text.Substring(0, 1)),
                   int.Parse(cmbClase.Text.Substring(0, 1)),
                   cmbFamilia.Text.Substring(0, 2),
                   int.Parse(txtStock.Text),
                   int.Parse(txtCantidad.Text),
                   dtpFA.Value,
                   dtpFA.Value,
                   d
                   );
                }
                else
                {
                    db.spCambio(
                    int.Parse(txtSku.Text),
                    txtArticulo.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    int.Parse(cmbDepartamento.Text.Substring(0, 1)),
                    int.Parse(cmbClase.Text.Substring(0, 1)),
                    cmbFamilia.Text.Substring(0, 2),
                    int.Parse(txtStock.Text),
                    int.Parse(txtCantidad.Text),
                    dtpFA.Value,
                    dtpFB.Value,
                    d
                    );
                }
                
                
            }
        }
        private void Baja(int id)
        {
            using (abcEntities db = new abcEntities())
            {
                db.spBaja(id);
            }
        }
        #endregion
        #region Botones

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarCampos()==false)
            {
                if (bandera == "nuevo")
                {
                    if (int.Parse(txtCantidad.Text) > int.Parse(txtStock.Text))
                    {
                        MessageBox.Show("La cantidad no debe ser mayor al stock");
                    }
                    else
                    {
                        Alta();
                        MessageBox.Show("Añadido con exito");
                        Application.Restart();
                    }

                }
                else
                {
                    Cambio(int.Parse(txtSku.Text));
                    MessageBox.Show("Modificado con Exito");
                    Application.Restart();
                }
            }else
            {
                MessageBox.Show("Es necesario llenar todos los campos","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                         
        }

       

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (abcEntities db = new abcEntities())
            {
                
                ABCC.Models.ABCC oTabla = new Models.ABCC();
                var lst = from d in db.ABCC.Where(p => p.Sku.ToString().Contains(txtSku.Text)) select d;
                if (lst.Count() > 0)
                {
                    Consulta(int.Parse(txtSku.Text));
                   bandera = "consulta";
                }
                else
                {
                    txtArticulo.Enabled = true;
                    txtMarca.Enabled = true;
                    txtModelo.Enabled = true;
                    cmbDepartamento.Enabled = true;                 
                    txtCantidad.Enabled = true;
                    txtStock.Enabled = true;
                    btnAceptar.Enabled = true;

                    string numero;
                    string nombre;
                    var lst2 = from d in db.Departamento select d;

                    cmbDepartamento.Items.Clear();
                    foreach (var element in lst2)
                    {
                        numero = element.IdDepartamento.ToString();
                        nombre = element.NombreDepartamento;

                        cmbDepartamento.Items.Add(numero + "-" + nombre);
                    }


                    bandera = "nuevo";
                }

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtArticulo.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            cmbDepartamento.Enabled = true;
            txtCantidad.Enabled = true;
            txtStock.Enabled = true;
            btnAceptar.Enabled = true;
            cbxDescontinuado.Enabled = true;

            using(abcEntities db = new abcEntities()) {
            string numero;
            string nombre;
            var lst2 = from d in db.Departamento select d;

            cmbDepartamento.Items.Clear();
            foreach (var element in lst2)
            {
                numero = element.IdDepartamento.ToString();
                nombre = element.NombreDepartamento;

                cmbDepartamento.Items.Add(numero + "-" + nombre);
                }
            }

            bandera = "cambio";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar eliminar el Registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Baja(int.Parse(txtSku.Text));
                MessageBox.Show("Registro Eliminado");
                Application.Restart();

            }

            else

            {

                MessageBox.Show("No se elimino el Registro");

            }

        }
        #endregion
        #region VALIDACIONES DEL FORMULARIO
        private void txtSku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >=32) && (e.KeyChar <=47))||(e.KeyChar >= 58) && (e.KeyChar <= 255)){
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private bool validarCampos()
        {
            if(
                txtArticulo==null||
                txtMarca==null||
                txtModelo==null||
                cmbDepartamento==null||
                cmbClase==null||
                cmbFamilia==null||
                txtCantidad==null||
                txtStock == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Controles ComboBox

      

        private void cmbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            int indice = int.Parse(cmbDepartamento.SelectedItem.ToString().Substring(0, 1));

            using (abcEntities db = new abcEntities())
            {
                string numero;
                string nombre;

                var lstClase = from d in db.Clase select d;

                cmbClase.Items.Clear();
                foreach (var element in lstClase)
                {
                    if (element.IdDepartamento == indice)
                    {
                        numero = element.IdClase.ToString();
                        nombre = element.NombreClase;

                        cmbClase.Items.Add(numero + " - " + nombre);
                    }
                }
            }
            cmbDepartamento.Text = cmbDepartamento.SelectedItem.ToString();
            cmbClase.Enabled = true;
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
                    if (element.IdClase == indice&& element.IdDepartamento==indice2)
                    {
                        numero = element.IdFamilia;
                        nombre = element.NombreFamilia;

                        cmbFamilia.Items.Add(numero + " - " + nombre);
                    }
                }
            }
            cmbFamilia.Enabled = true;
        }
        #endregion
        //Ingreso al siguiente formulario
        private void txtSku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
                Components.FrmBusqueda frmBusqueda = new Components.FrmBusqueda();                
               frmBusqueda.Show();

                this.Close();
            }
        }

 

        private void cmbDepartamento_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int indice = int.Parse(cmbDepartamento.SelectedItem.ToString().Substring(0, 1));

            using (abcEntities db = new abcEntities())
            {
                string numero;
                string nombre;

                var lstClase = from d in db.Clase select d;

                cmbClase.Items.Clear();
                foreach (var element in lstClase)
                {
                    if (element.IdDepartamento == indice)
                    {
                        numero = element.IdClase.ToString();
                        nombre = element.NombreClase;

                        cmbClase.Items.Add(numero + " - " + nombre);
                    }
                }
            }
            cmbClase.Enabled = true;
        }
    }
}
