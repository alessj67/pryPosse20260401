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
            //desde interfaz grafica
            lblRegistroIG.Text = mtbCodigo.Text + ' ' + '/' 
                + txtNombre.Text + ' ' + '/'
                + mtbStock.Text + ' ' + '/'
                + mtbPrecio.Text + ' ' + '/'
                + cmbCategoria.Text;

            varCodigo = mtbCodigo.Text;
            //pasar un texto a numero 2 formas:
            varStock = Convert.ToInt16(mtbStock.Text);
            varPrecio = int.Parse(mtbPrecio.Text);
            varNombre = txtNombre.Text;
            varCategoria = cmbCategoria.Text;

            lblRegVariables.Text = varCodigo +" "+ varStock.ToString() + " " + varCategoria + " " + varDescripcion + " " + varPrecio.ToString() + " " + varNombre;
        
            string datoagregado = varCodigo.ToString() + " " + varStock.ToString() + " " + varCategoria + " " + varDescripcion + " " + varPrecio.ToString() + " " + varNombre;
            MessageBox.Show(datoagregado);
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
            txtNombre.Enabled = true;
            mtbCodigo.Enabled = true; 
        }

        private void mtbCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtbStock.Enabled = true;
        }

        private void mtbStock_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtDescripcion.Enabled = true;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            mtbPrecio.Enabled = true;
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cmbCategoria.Enabled = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
