using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividades_OB
{
    public partial class Form4 : Form
    {
        private double raioCirculo;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raioCirculo = double.Parse(textBox1.Text);
            IFigura circulo = new Circulo(raioCirculo);
            textBox2.Text = circulo.calcularArea().ToString();

        }
    }
}
