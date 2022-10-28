namespace exercicio_WinForm3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_nomeCriptomoeda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_siglaCriptomoeda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_valorCriptomoeda = new System.Windows.Forms.TextBox();
            this.button_consultarCripto = new System.Windows.Forms.Button();
            this.button_inserir = new System.Windows.Forms.Button();
            this.textBox_consultarCripto = new System.Windows.Forms.TextBox();
            this.textBox_lpesquisarCripto = new System.Windows.Forms.TextBox();
            this.textBox_listarCriptomoedas = new System.Windows.Forms.TextBox();
            this.button_listarCriptomoedas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_remover = new System.Windows.Forms.TextBox();
            this.button_remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nomeCriptomoeda
            // 
            this.textBox_nomeCriptomoeda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeCriptomoeda.Location = new System.Drawing.Point(167, 58);
            this.textBox_nomeCriptomoeda.Name = "textBox_nomeCriptomoeda";
            this.textBox_nomeCriptomoeda.Size = new System.Drawing.Size(171, 23);
            this.textBox_nomeCriptomoeda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da criptomoeda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sigla da criptomoeda";
            // 
            // textBox_siglaCriptomoeda
            // 
            this.textBox_siglaCriptomoeda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_siglaCriptomoeda.Location = new System.Drawing.Point(167, 17);
            this.textBox_siglaCriptomoeda.Name = "textBox_siglaCriptomoeda";
            this.textBox_siglaCriptomoeda.Size = new System.Drawing.Size(100, 23);
            this.textBox_siglaCriptomoeda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor da criptomoeda";
            // 
            // textBox_valorCriptomoeda
            // 
            this.textBox_valorCriptomoeda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_valorCriptomoeda.Location = new System.Drawing.Point(167, 105);
            this.textBox_valorCriptomoeda.Name = "textBox_valorCriptomoeda";
            this.textBox_valorCriptomoeda.Size = new System.Drawing.Size(132, 23);
            this.textBox_valorCriptomoeda.TabIndex = 5;
            // 
            // button_consultarCripto
            // 
            this.button_consultarCripto.Location = new System.Drawing.Point(260, 244);
            this.button_consultarCripto.Name = "button_consultarCripto";
            this.button_consultarCripto.Size = new System.Drawing.Size(105, 23);
            this.button_consultarCripto.TabIndex = 6;
            this.button_consultarCripto.Text = "Consultar cripto";
            this.button_consultarCripto.UseVisualStyleBackColor = true;
            this.button_consultarCripto.Click += new System.EventHandler(this.button_consultarCripto_Click);
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(97, 151);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(75, 23);
            this.button_inserir.TabIndex = 7;
            this.button_inserir.Text = "Inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // textBox_consultarCripto
            // 
            this.textBox_consultarCripto.Location = new System.Drawing.Point(265, 215);
            this.textBox_consultarCripto.Name = "textBox_consultarCripto";
            this.textBox_consultarCripto.Size = new System.Drawing.Size(100, 23);
            this.textBox_consultarCripto.TabIndex = 8;
            // 
            // textBox_lpesquisarCripto
            // 
            this.textBox_lpesquisarCripto.Location = new System.Drawing.Point(239, 273);
            this.textBox_lpesquisarCripto.Multiline = true;
            this.textBox_lpesquisarCripto.Name = "textBox_lpesquisarCripto";
            this.textBox_lpesquisarCripto.Size = new System.Drawing.Size(140, 165);
            this.textBox_lpesquisarCripto.TabIndex = 9;
            // 
            // textBox_listarCriptomoedas
            // 
            this.textBox_listarCriptomoedas.Location = new System.Drawing.Point(514, 196);
            this.textBox_listarCriptomoedas.Multiline = true;
            this.textBox_listarCriptomoedas.Name = "textBox_listarCriptomoedas";
            this.textBox_listarCriptomoedas.Size = new System.Drawing.Size(163, 242);
            this.textBox_listarCriptomoedas.TabIndex = 10;
            // 
            // button_listarCriptomoedas
            // 
            this.button_listarCriptomoedas.Location = new System.Drawing.Point(536, 151);
            this.button_listarCriptomoedas.Name = "button_listarCriptomoedas";
            this.button_listarCriptomoedas.Size = new System.Drawing.Size(119, 23);
            this.button_listarCriptomoedas.TabIndex = 11;
            this.button_listarCriptomoedas.Text = "Listar criptomoedas";
            this.button_listarCriptomoedas.UseVisualStyleBackColor = true;
            this.button_listarCriptomoedas.Click += new System.EventHandler(this.button_listarCriptomoedas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite uma sigla de cripto para procurar na lista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Digite a sigla de uma cripto para remover";
            // 
            // textBox_remover
            // 
            this.textBox_remover.Location = new System.Drawing.Point(636, 17);
            this.textBox_remover.Name = "textBox_remover";
            this.textBox_remover.Size = new System.Drawing.Size(100, 23);
            this.textBox_remover.TabIndex = 14;
            // 
            // button_remover
            // 
            this.button_remover.Location = new System.Drawing.Point(602, 58);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(75, 23);
            this.button_remover.TabIndex = 15;
            this.button_remover.Text = "Remover";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button_remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_remover);
            this.Controls.Add(this.textBox_remover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_listarCriptomoedas);
            this.Controls.Add(this.textBox_listarCriptomoedas);
            this.Controls.Add(this.textBox_lpesquisarCripto);
            this.Controls.Add(this.textBox_consultarCripto);
            this.Controls.Add(this.button_inserir);
            this.Controls.Add(this.button_consultarCripto);
            this.Controls.Add(this.textBox_valorCriptomoeda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_siglaCriptomoeda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nomeCriptomoeda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_nomeCriptomoeda;
        private Label label1;
        private Label label2;
        private TextBox textBox_siglaCriptomoeda;
        private Label label3;
        private TextBox textBox_valorCriptomoeda;
        private Button button_consultarCripto;
        private Button button_inserir;
        private TextBox textBox_consultarCripto;
        private TextBox textBox_lpesquisarCripto;
        private TextBox textBox_listarCriptomoedas;
        private Button button_listarCriptomoedas;
        private Label label4;
        private Label label5;
        private TextBox textBox_remover;
        private Button button_remover;
    }
}