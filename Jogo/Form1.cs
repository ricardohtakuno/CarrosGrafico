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
            Carro carro1 = new Carro();
            carro1.modelo = "uno";
            carro1.motorizacao = "1.0";
            carro1.ano_fabricacao = 1995;
            carro1.cor = "vermelho";
            carro1.marca = "fiat";
            carro1.quantidade_marchas = 5;
            carro1.velocidade_maxima = 160;

            //preenchimento da ficha do carro
            lblModelo.Text = carro1.modelo;
            lblMotorizacao.Text = carro1.motorizacao;
            lblMarca.Text = carro1.marca;
            lblQuantidadeMarchas.Text = carro1.quantidade_marchas.ToString();
            lblAnoFabricacao.Text = carro1.ano_fabricacao.ToString();
            lblCor.Text = carro1.cor;
            lblVelocidadeMaxima.Text = carro1.velocidade_maxima.ToString();

            //mostra somente a imagem do uno
            picUno.Visible = true;
            picMonza.Visible = false;
        }

        private void btnMonza_Click(object sender, EventArgs e)
        {
            //criação do objeto carro2 que é uma instancia da classe carro preenchimento dos atributos de carro2
            Carro carro2 = new Carro();
            carro2.modelo = "monza";
            carro2.motorizacao = "2.0";
            carro2.ano_fabricacao = 1990;
            carro2.cor = "preto";
            carro2.marca = "chevrolet";
            carro2.quantidade_marchas = 5;
            carro2.velocidade_maxima = 200;

            //preenchimento da ficha do carro
            lblModelo.Text = carro2.modelo;
            lblMotorizacao.Text = carro2.motorizacao;
            lblMarca.Text = carro2.marca;
            lblQuantidadeMarchas.Text = carro2.quantidade_marchas.ToString();
            lblAnoFabricacao.Text = carro2.ano_fabricacao.ToString();
            lblCor.Text = carro2.cor;
            lblVelocidadeMaxima.Text = carro2.velocidade_maxima.ToString();

            //mostra somente a imagem do monza
            picMonza.Visible = true;
            picUno.Visible = false;
        }
    }
}
