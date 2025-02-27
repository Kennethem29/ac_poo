using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uzuuchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Matematicas mat;
        private void btncalcular_Click(object sender, EventArgs e)
        {

            calcularOperacion();

        }


        private void calcularOperacion()
        {
            mat = new Matematicas(int.Parse(tbnumero1.Text), int.Parse(tbnumero2.Text));

            if (Sumar.Checked)
            {
                MessageBox.Show("La suma es: " + mat.Sumar());
            }

            if (Restar.Checked)
            {
                MessageBox.Show("La resta es: " + mat.Restar());
            }

            if (Multiplicar.Checked)
            {
                MessageBox.Show("La multiplicación es: " + mat.Multiplicar());
            }

            if (Dividir.Checked)
            {
                MessageBox.Show("La división es: " + mat.Dividir());
            }
            if (Modulo.Checked)
            {
                MessageBox.Show("La modulo es: " + mat.Modulo());
            }


        }
    }

}
