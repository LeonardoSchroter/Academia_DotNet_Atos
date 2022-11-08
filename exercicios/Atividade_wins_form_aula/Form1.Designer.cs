namespace Atividade_wins_form_aula
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.textBox_listagem = new System.Windows.Forms.TextBox();
            this.button_inserir = new System.Windows.Forms.Button();
            this.button_limparLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo do jogador";
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(195, 23);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(273, 23);
            this.textBox_nomeCompleto.TabIndex = 1;
            // 
            // textBox_listagem
            // 
            this.textBox_listagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_listagem.Enabled = false;
            this.textBox_listagem.Location = new System.Drawing.Point(133, 124);
            this.textBox_listagem.Multiline = true;
            this.textBox_listagem.Name = "textBox_listagem";
            this.textBox_listagem.Size = new System.Drawing.Size(461, 327);
            this.textBox_listagem.TabIndex = 4;
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(133, 77);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(75, 23);
            this.button_inserir.TabIndex = 5;
            this.button_inserir.Text = "Inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // button_limparLista
            // 
            this.button_limparLista.Location = new System.Drawing.Point(239, 77);
            this.button_limparLista.Name = "button_limparLista";
            this.button_limparLista.Size = new System.Drawing.Size(75, 23);
            this.button_limparLista.TabIndex = 6;
            this.button_limparLista.Text = "Limpar";
            this.button_limparLista.UseVisualStyleBackColor = true;
            this.button_limparLista.Click += new System.EventHandler(this.button_limparLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_limparLista);
            this.Controls.Add(this.button_inserir);
            this.Controls.Add(this.textBox_listagem);
            this.Controls.Add(this.textBox_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeCompleto;
        private TextBox textBox_listagem;
        private Button button_inserir;
        private Button button_limparLista;
    }
}