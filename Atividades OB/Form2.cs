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
    public partial class Form2 : Form
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baseTriangulo = double.Parse(textBox1.Text);
            alturaTriangulo = double.Parse(textBox2.Text);

            IFigura triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

            textBox3.Text = triangulo.calcularArea().ToString();

        }
    }
}
