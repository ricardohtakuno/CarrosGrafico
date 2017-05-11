using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Carro MeuCarro = new Carro();

        private void Form1_Load(object sender, EventArgs e)
        {
            Carro monza = new Carro();
            monza.modelo = "monza";
            monza.marca = "chevrolet";
            monza.cor = "preto";
            monza.motorizacao = "2.0";
            monza.ano_fabricacao = 1990;
            monza.velocidade_maxima = 200;
            monza.quantidade_marchas = 5;

            Carro uno = new Carro();
            uno.modelo = "uno";
            uno.marca = "fiat";
            uno.cor = "vermelho";
            uno.motorizacao = "1.0";
            uno.ano_fabricacao = 1995;
            uno.velocidade_maxima = 160;
            uno.quantidade_marchas = 5;
            
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //criação do objeto carro1 que é uma instancia da classe carro preenchimento dos atributos de carro1
            MeuCarro.modelo = "uno";
            MeuCarro.motorizacao = "1.0";
            MeuCarro.ano_fabricacao = 1995;
            MeuCarro.cor = "vermelho";
            MeuCarro.marca = "fiat";
            MeuCarro.quantidade_marchas = 5;
            MeuCarro.velocidade_maxima = 160;

            MeuCarro.PreencherFicha(lblModelo, lblMotorizacao, lblMarca, lblQuantidadeMarchas, lblAnoFabricacao, lblCor, lblVelocidadeMaxima);

            MeuCarro.ExibirFoto(picCarro);
        }

        private void btnMonza_Click(object sender, EventArgs e)
        {
            //criação do objeto carro2 que é uma instancia da classe carro preenchimento dos atributos de carro2
            MeuCarro.modelo = "monza";
            MeuCarro.motorizacao = "2.0";
            MeuCarro.ano_fabricacao = 1990;
            MeuCarro.cor = "preto";
            MeuCarro.marca = "chevrolet";
            MeuCarro.quantidade_marchas = 5;
            MeuCarro.velocidade_maxima = 200;

            MeuCarro.PreencherFicha(lblModelo, lblMotorizacao, lblMarca, lblQuantidadeMarchas, lblAnoFabricacao, lblCor, lblVelocidadeMaxima);

            MeuCarro.ExibirFoto(picCarro);
        }

        private void btnBuzinar_Click(object sender, EventArgs e)
        {
            MeuCarro.Buzinar();
        }

        private void btnFarois_Click(object sender, EventArgs e)
        {
            MeuCarro.AcenderFarois(picCarro);
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MeuCarro.Acelerar(picCarro);
        }

        private void btnVirar_Click(object sender, EventArgs e)
        {
            MeuCarro.Virar(picCarro);
        }

        private void btnAumentarMarcha_Click(object sender, EventArgs e)
        {
            lblMarchaAtual.Text = MeuCarro.TrocarMarcha("+").ToString();
        }

        private void btnDiminuirMarcha_Click(object sender, EventArgs e)
        {
            lblMarchaAtual.Text = MeuCarro.TrocarMarcha("-").ToString();
        }
    }
}
