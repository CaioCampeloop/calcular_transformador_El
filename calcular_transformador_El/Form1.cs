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
        double SecundarioAmperes;
        double Secundario2;
        double FatorRendimento;
        double PotenciaPrimario;

        double densidadeDecorrente_J;
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
            var Primario = Convert.ToDouble(textBox_P.Text);
            var Secundario = Convert.ToDouble(textBox_S.Text);

            

            textBox_RA.Text = AreaTotal.ToString();

            var VoltasPorVolt = ConstanteG / AreaTotal;

            var PotenciaWats = AreaTotal * AreaTotal;

            textBoxPT.Text = PotenciaWats.ToString();
            textBoxVPV.Text = VoltasPorVolt.ToString();

            var VoltasPrimario = Primario * VoltasPorVolt;
            var VotasSecundario = Secundario * VoltasPorVolt;

            textBox_VP.Text = VoltasPrimario.ToString();
            textBox_VS.Text = VotasSecundario.ToString();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_FR.Text = "0,9";
            textBox_G.Text = "45";
            textBox_DC.Text = "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FatorRendimento = Convert.ToDouble(textBox_FR.Text);

            Secundario2 = Convert.ToDouble(textBox_S2.Text);

            SecundarioAmperes = Convert.ToDouble(textBox_SA.Text);

            densidadeDecorrente_J = Convert.ToDouble(textBox_DC.Text);
            
            var Primario2 = Convert.ToDouble(textBox_P2.Text);
            
            var PotenciaSecundario = Secundario2 * SecundarioAmperes;
            
            PotenciaPrimario = PotenciaSecundario / FatorRendimento;

            textBox_PP.Text = PotenciaPrimario.ToString();
            textBox_PS.Text = PotenciaSecundario.ToString();

            var CorrentePrimario = PotenciaPrimario / Primario2;

            textBox_CP.Text = CorrentePrimario.ToString();

            var BitolaPrimario = CorrentePrimario / densidadeDecorrente_J;

            var BitolaSecundario = SecundarioAmperes / densidadeDecorrente_J;

            textBox_BP.Text = BitolaPrimario.ToString();

            textBox_BS.Text = BitolaSecundario.ToString();



        }

        private void textBox_FR_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
