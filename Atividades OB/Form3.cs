using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades_OB
{
    public partial class Form3 : Form
    {
        private double baseRetangulo;
        private double alturaRetangulo;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baseRetangulo = double.Parse(textBox1.Text);
            alturaRetangulo = double.Parse(textBox2.Text);

            IFigura Retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

            textBox3.Text = Retangulo.calcularArea().ToString();
        }
    }
}
