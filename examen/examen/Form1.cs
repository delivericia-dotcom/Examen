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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(textusuario.Text == "Santiago" && textcontra.Text=="33")
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }



        private void button1_Click(object sender, EventArgs e)
                {

                }
    }
}
