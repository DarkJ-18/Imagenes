using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int valor = 0;
            int.TryParse(textBox1.Text, out valor);

            if  (valor == 1)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("imagen1.png");
            }

            if (valor == 2)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("imagen2.png");
            }

            if (valor == 3)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("imagen3.png");
            }
            if (valor == 4)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("imagen4.png");
            }
            if (valor == 5)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("imagen5.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
