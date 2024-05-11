using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorTransformador
{
    public partial class Simulador : Form
    {
        private bool luzLigada = false;

        private void LigarDesligarLuz()
        {
            if (luzLigada == false)
            {
                box_ligado.BackColor = Color.Yellow;
                luzLigada = true;

            }

            else
            {
                box_ligado.BackColor = Color.FromArgb(64,64,0);
                luzLigada = false;
                txt_Saida.Text = " ";

            }
        }

        float CalcularResultado()
        {
            float relacao = float.Parse(txt_EspPri.Text)/ float.Parse(txt_EspSec.Text);

            return float.Parse(txt_Entrada.Text)/relacao;
        }

        bool Verificar(string dado)
        {
            if (float.TryParse(dado, out float resultado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        string Resultado()
        {
            if (Verificar(txt_Entrada.Text) && Verificar(txt_EspPri.Text) && Verificar(txt_EspSec.Text))
            {
                return Convert.ToString( CalcularResultado());
            }
            else
            {
                return "ERRO";
            }

        }

        public Simulador()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            LigarDesligarLuz();

            if (luzLigada)
            {
                txt_Saida.Text = Resultado();

            }

        }

    
    }
}
