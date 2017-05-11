using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

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
        public int marcha_atual = 1;

        public void Acelerar(PictureBox picCarro)
        {
            int i = picCarro.Left;
            var t = Task.Delay(5000);
            if (picCarro.Left == 43)
            {
                while (i <= 403)
                {
                    Thread.Sleep(10 - marcha_atual * 2);
                    picCarro.Left = i;
                    i++;
                }
            }
            else
            {
                while (i >= 43)
                {
                    Thread.Sleep(10 - marcha_atual * 2);
                    picCarro.Left = i;
                    i--;
                }
            }
        }
        public void Virar(PictureBox picCarro)
        {
            Image flipimage = picCarro.Image;
            flipimage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picCarro.Image = flipimage;
        }
        public void Buzinar()
        {
            System.Media.SystemSounds.Beep.Play();
        }
        public int TrocarMarcha(string acao)
        {
            if (acao == "+" && marcha_atual < 5) marcha_atual += 1;

            if (acao == "-" && marcha_atual > 1) marcha_atual -= 1;

            return marcha_atual;
        }
        public void AcenderFarois(PictureBox picCarro)
        {
            picCarro.BorderStyle = (picCarro.BorderStyle == BorderStyle.FixedSingle) ? BorderStyle.None : BorderStyle.FixedSingle;
        }
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
