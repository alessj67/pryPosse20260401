using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPosse20260401
{
    public partial class Form1 : Form
    {
        //declaracion de variables globales 
        String varCodigo = "";
        String varNombre = "";
        int varStock = 0;
        int varPrecio = 0;
        String varDescripcion = "";
        String varCategoria = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Completá el nombre nerea", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
            }     
            else
            {
                if (mtbCodigo.Text == "")
                {
                        MessageBox.Show("Completá el código nerea", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtbCodigo.Focus();
                }
             
                else
                {
                    if (txtDescripcion.Text == "")
                    { 
                        MessageBox.Show("Completá la descripción nerea", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescripcion.Focus();
                    }
                    else
                    {
                        if (mtbPrecio.Text == "")
                        {
                            MessageBox.Show("Completá el precio nerea", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mtbPrecio.Focus();
                        }
                        else 
                        {
                            if (mtbStock.Text == "")
                            {
                                MessageBox.Show("Marcá el stock nerea", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mtbStock.Focus();   
                            }
                            else
                            {
                                if (cmbCategoria.Text == "")
                                {
                                    MessageBox.Show("Seleccioná la categoría nerea", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmbCategoria.Focus();   
                                }
                            }
                        }
                    }                           
                }   
                    
            }
                //desde interfaz grafica
                lblRegistroIG.Text = mtbCodigo.Text + ' ' + '/'
                    + txtNombre.Text + ' ' + '/'
                    + mtbStock.Text + ' ' + '/'
                    + mtbPrecio.Text + ' ' + '/'
                    + cmbCategoria.Text;

            varCodigo = mtbCodigo.Text;

            if (mtbStock.Text != "" && !int.TryParse(mtbStock.Text, out varStock))
            {
                MessageBox.Show("Stock inválido. Ingresa un número entero.", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbStock.Focus();
                return;
            }
            if (mtbPrecio.Text != "" && !int.TryParse(mtbPrecio.Text, out varPrecio))
            {
                MessageBox.Show("Precio inválido. Ingresa un número entero.", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPrecio.Focus();
                return;
            }

            varNombre = txtNombre.Text;
            varCategoria = cmbCategoria.Text;

            lblRegVariables.Text = varCodigo +" "+ varStock.ToString() + " " + varCategoria + " " + varDescripcion + " " + varPrecio.ToString() + " " + varNombre;
        
            string datoagregado = varCodigo.ToString() + " " + varStock.ToString() + " " + varCategoria + " " + varDescripcion + " " + varPrecio.ToString() + " " + varNombre;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void lblCargaDatos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                mtbCodigo.Enabled = true;
            }
        }

        private void mtbCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbCodigo.Text != null)
            {
                mtbStock.Enabled = true;
            }
        }

        private void mtbStock_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbCodigo.Text != null)
            {
                txtDescripcion.Enabled = true;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (mtbCodigo.Text != null)
            {
                mtbPrecio.Enabled = true;
            }
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbCodigo.Text != null)
            {
                cmbCategoria.Enabled = true;
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            mtbCodigo.Clear();
            mtbPrecio.Clear();
            mtbStock.Clear();
            txtDescripcion.Clear();

            cmbCategoria.SelectedIndex = -1;
        }
    }
}
