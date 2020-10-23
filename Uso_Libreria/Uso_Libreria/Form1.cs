using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uso_Libreria
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";

        }

        private void btDos_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";

        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";

        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";

        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";

        }

        private void btSiete_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";

        }

        private void btOcho_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";

        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";

        }

        private void btCero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";

        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";

        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
            }           
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
    }
}
