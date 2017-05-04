using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    class Carro
    {
        public string modelo;
        public string marca;
        public string cor;
        public string motorizacao;
        public int ano_fabricacao;
        public int velocidade_maxima;
        public int quantidade_marchas;

        public void acelerar() { }
        public void virar() { }
        public void buzinar() { }
        public void trocar_marcha() { }
        public void acender_farois() { }
        public void PreencherFicha(Label lblModelo, Label lblMotorizacao, Label lblMarca, Label lblQuantidadeMarchas, Label lblAnoFabricacao, Label lblCor, Label lblVelocidadeMaxima)
        {
            lblModelo.Text = modelo;
            lblMotorizacao.Text = motorizacao;
            lblMarca.Text = marca;
            lblQuantidadeMarchas.Text = quantidade_marchas.ToString();
            lblAnoFabricacao.Text = ano_fabricacao.ToString();
            lblCor.Text = cor;
            lblVelocidadeMaxima.Text = velocidade_maxima.ToString();
        }
        public void ExibirFoto(PictureBox carro)
        {
            if (modelo == "uno")
                carro.Image = Properties.Resources.uno;
            if (modelo == "monza")
                carro.Image = Properties.Resources.monza;
        }
    }
}
