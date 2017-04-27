namespace Jogo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMotorizacao = new System.Windows.Forms.Label();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.lblVelocidadeMaxima = new System.Windows.Forms.Label();
            this.lblQuantidadeMarchas = new System.Windows.Forms.Label();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnMonza = new System.Windows.Forms.Button();
            this.picMonza = new System.Windows.Forms.PictureBox();
            this.picUno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMonza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(39, 45);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(52, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "lblModelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(39, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "lblMarca";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(39, 137);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 13);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "lblCor";
            // 
            // lblMotorizacao
            // 
            this.lblMotorizacao.AutoSize = true;
            this.lblMotorizacao.Location = new System.Drawing.Point(190, 45);
            this.lblMotorizacao.Name = "lblMotorizacao";
            this.lblMotorizacao.Size = new System.Drawing.Size(75, 13);
            this.lblMotorizacao.TabIndex = 3;
            this.lblMotorizacao.Text = "lblMotorização";
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(190, 87);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(89, 13);
            this.lblAnoFabricacao.TabIndex = 4;
            this.lblAnoFabricacao.Text = "lblAnoFabricação";
            // 
            // lblVelocidadeMaxima
            // 
            this.lblVelocidadeMaxima.AutoSize = true;
            this.lblVelocidadeMaxima.Location = new System.Drawing.Point(193, 137);
            this.lblVelocidadeMaxima.Name = "lblVelocidadeMaxima";
            this.lblVelocidadeMaxima.Size = new System.Drawing.Size(106, 13);
            this.lblVelocidadeMaxima.TabIndex = 5;
            this.lblVelocidadeMaxima.Text = "lblVelocidadeMaxima";
            // 
            // lblQuantidadeMarchas
            // 
            this.lblQuantidadeMarchas.AutoSize = true;
            this.lblQuantidadeMarchas.Location = new System.Drawing.Point(390, 45);
            this.lblQuantidadeMarchas.Name = "lblQuantidadeMarchas";
            this.lblQuantidadeMarchas.Size = new System.Drawing.Size(113, 13);
            this.lblQuantidadeMarchas.TabIndex = 6;
            this.lblQuantidadeMarchas.Text = "lblQuantidadeMarchas";
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(393, 92);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(102, 58);
            this.btnUno.TabIndex = 7;
            this.btnUno.Text = "UNÃO ZICA TUNADO";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnMonza
            // 
            this.btnMonza.Location = new System.Drawing.Point(522, 92);
            this.btnMonza.Name = "btnMonza";
            this.btnMonza.Size = new System.Drawing.Size(102, 58);
            this.btnMonza.TabIndex = 8;
            this.btnMonza.Text = "MONZÃO BRUXO DO MAL";
            this.btnMonza.UseVisualStyleBackColor = true;
            this.btnMonza.Click += new System.EventHandler(this.btnMonza_Click);
            // 
            // picMonza
            // 
            this.picMonza.Image = global::Jogo.Properties.Resources.monza;
            this.picMonza.Location = new System.Drawing.Point(251, 222);
            this.picMonza.Name = "picMonza";
            this.picMonza.Size = new System.Drawing.Size(154, 90);
            this.picMonza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonza.TabIndex = 10;
            this.picMonza.TabStop = false;
            // 
            // picUno
            // 
            this.picUno.Image = global::Jogo.Properties.Resources.uno;
            this.picUno.Location = new System.Drawing.Point(42, 222);
            this.picUno.Name = "picUno";
            this.picUno.Size = new System.Drawing.Size(154, 90);
            this.picUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUno.TabIndex = 9;
            this.picUno.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 381);
            this.Controls.Add(this.picMonza);
            this.Controls.Add(this.picUno);
            this.Controls.Add(this.btnMonza);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.lblQuantidadeMarchas);
            this.Controls.Add(this.lblVelocidadeMaxima);
            this.Controls.Add(this.lblAnoFabricacao);
            this.Controls.Add(this.lblMotorizacao);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMotorizacao;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.Label lblVelocidadeMaxima;
        private System.Windows.Forms.Label lblQuantidadeMarchas;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnMonza;
        private System.Windows.Forms.PictureBox picUno;
        private System.Windows.Forms.PictureBox picMonza;
    }
}

