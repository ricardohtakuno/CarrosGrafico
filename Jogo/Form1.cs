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

            MessageBox.Show(monza.modelo + " " + monza.marca);
            MessageBox.Show(uno.modelo + " " + uno.marca);
        }
    }
}
