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

        }
    }
}
