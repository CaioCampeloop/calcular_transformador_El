using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_transformador_El
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ConstanteG = Convert.ToDouble(textBox_G.Text);
            var AreaA = Convert.ToDouble(textBox_AA.Text);
            var AreaB= Convert.ToDouble(textBox_AB.Text);
            var AreaTotal = AreaA * AreaB;
            textBox_RA.Text = AreaTotal.ToString();

            var VoltasPorVolt = ConstanteG / AreaTotal;

            var PotenciaWats = AreaTotal * AreaTotal;

            textBoxPT.Text = PotenciaWats.ToString();
            textBoxVPV.Text = VoltasPorVolt.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
