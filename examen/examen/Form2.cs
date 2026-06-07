using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte nota1 = byte.Parse(Textnota1.Text);//aqui estamos guardando una variable utilizando nuestro TextBox
            byte nota2 = byte.Parse(Textnota2.Text);//aqui estamos guardando una variable utilizando nuestro TextBox
            byte nota3 = byte.Parse(Textnota3.Text);//aqui estamos guardando una variable utilizando nuestro TextBox
            byte nota4 = byte.Parse(Textnota4.Text);//aqui estamos guardando una variable utilizando nuestro TextBox
            float Promedio = ((nota1 + nota2 + nota3 + nota4) / 4);//esta es la formula de nuestro Promedio
            MessageBox.Show ("El resultado es " + Promedio);// Muestra el mensaje en pantalla

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
