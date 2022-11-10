namespace WinForms_paraBD
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
            this.button_conectar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_localizacao = new System.Windows.Forms.TextBox();
            this.txt_orcamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_nomeE = new System.Windows.Forms.TextBox();
            this.textBox_gerenteE = new System.Windows.Forms.TextBox();
            this.textBox_funcaoE = new System.Windows.Forms.TextBox();
            this.textBox_idDepartamentoE = new System.Windows.Forms.TextBox();
            this.textBox_dataE = new System.Windows.Forms.TextBox();
            this.textBox_salarioE = new System.Windows.Forms.TextBox();
            this.textBox_comissaoE = new System.Windows.Forms.TextBox();
            this.button_adicionarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(66, 202);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(95, 37);
            this.button_conectar.TabIndex = 0;
            this.button_conectar.Text = "Adicionar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Location = new System.Drawing.Point(114, 67);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localização";
            // 
            // txt_localizacao
            // 
            this.txt_localizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_localizacao.Location = new System.Drawing.Point(114, 108);
            this.txt_localizacao.Name = "txt_localizacao";
            this.txt_localizacao.Size = new System.Drawing.Size(100, 23);
            this.txt_localizacao.TabIndex = 4;
            // 
            // txt_orcamento
            // 
            this.txt_orcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_orcamento.Location = new System.Drawing.Point(114, 145);
            this.txt_orcamento.Name = "txt_orcamento";
            this.txt_orcamento.Size = new System.Drawing.Size(100, 23);
            this.txt_orcamento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Orçamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(66, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastro de departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID do gerente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Função";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID do departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data[aaaa/mm/dd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(520, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cadastro de empregado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Salário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Comissão";
            // 
            // textBox_nomeE
            // 
            this.textBox_nomeE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeE.Location = new System.Drawing.Point(556, 67);
            this.textBox_nomeE.Name = "textBox_nomeE";
            this.textBox_nomeE.Size = new System.Drawing.Size(176, 23);
            this.textBox_nomeE.TabIndex = 16;
            // 
            // textBox_gerenteE
            // 
            this.textBox_gerenteE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_gerenteE.Location = new System.Drawing.Point(571, 108);
            this.textBox_gerenteE.Name = "textBox_gerenteE";
            this.textBox_gerenteE.Size = new System.Drawing.Size(100, 23);
            this.textBox_gerenteE.TabIndex = 17;
            // 
            // textBox_funcaoE
            // 
            this.textBox_funcaoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_funcaoE.Location = new System.Drawing.Point(571, 145);
            this.textBox_funcaoE.Name = "textBox_funcaoE";
            this.textBox_funcaoE.Size = new System.Drawing.Size(147, 23);
            this.textBox_funcaoE.TabIndex = 18;
            // 
            // textBox_idDepartamentoE
            // 
            this.textBox_idDepartamentoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_idDepartamentoE.Location = new System.Drawing.Point(571, 190);
            this.textBox_idDepartamentoE.Name = "textBox_idDepartamentoE";
            this.textBox_idDepartamentoE.Size = new System.Drawing.Size(100, 23);
            this.textBox_idDepartamentoE.TabIndex = 19;
            // 
            // textBox_dataE
            // 
            this.textBox_dataE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dataE.Location = new System.Drawing.Point(556, 246);
            this.textBox_dataE.Name = "textBox_dataE";
            this.textBox_dataE.Size = new System.Drawing.Size(100, 23);
            this.textBox_dataE.TabIndex = 20;
            // 
            // textBox_salarioE
            // 
            this.textBox_salarioE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_salarioE.Location = new System.Drawing.Point(556, 308);
            this.textBox_salarioE.Name = "textBox_salarioE";
            this.textBox_salarioE.Size = new System.Drawing.Size(100, 23);
            this.textBox_salarioE.TabIndex = 21;
            // 
            // textBox_comissaoE
            // 
            this.textBox_comissaoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_comissaoE.Location = new System.Drawing.Point(556, 360);
            this.textBox_comissaoE.Name = "textBox_comissaoE";
            this.textBox_comissaoE.Size = new System.Drawing.Size(100, 23);
            this.textBox_comissaoE.TabIndex = 22;
            // 
            // button_adicionarE
            // 
            this.button_adicionarE.Location = new System.Drawing.Point(466, 416);
            this.button_adicionarE.Name = "button_adicionarE";
            this.button_adicionarE.Size = new System.Drawing.Size(103, 37);
            this.button_adicionarE.TabIndex = 23;
            this.button_adicionarE.Text = "Adicionar";
            this.button_adicionarE.UseVisualStyleBackColor = true;
            this.button_adicionarE.Click += new System.EventHandler(this.button_adicionarE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 607);
            this.Controls.Add(this.button_adicionarE);
            this.Controls.Add(this.textBox_comissaoE);
            this.Controls.Add(this.textBox_salarioE);
            this.Controls.Add(this.textBox_dataE);
            this.Controls.Add(this.textBox_idDepartamentoE);
            this.Controls.Add(this.textBox_funcaoE);
            this.Controls.Add(this.textBox_gerenteE);
            this.Controls.Add(this.textBox_nomeE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_orcamento);
            this.Controls.Add(this.txt_localizacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.button_conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_conectar;
        private TextBox txt_nome;
        private Label label1;
        private Label label2;
        private TextBox txt_localizacao;
        private TextBox txt_orcamento;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox_nomeE;
        private TextBox textBox_gerenteE;
        private TextBox textBox_funcaoE;
        private TextBox textBox_idDepartamentoE;
        private TextBox textBox_dataE;
        private TextBox textBox_salarioE;
        private TextBox textBox_comissaoE;
        private Button button_adicionarE;
    }
}