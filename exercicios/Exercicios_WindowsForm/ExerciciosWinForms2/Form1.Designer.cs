namespace ExerciciosWinForms2
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
            this.button_listarEmails = new System.Windows.Forms.Button();
            this.button_inserir = new System.Windows.Forms.Button();
            this.button_listarDominios = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.textBox_listarEmail = new System.Windows.Forms.TextBox();
            this.textBox_listarDominio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_limparEmails = new System.Windows.Forms.Button();
            this.button_limparDominios = new System.Windows.Forms.Button();
            this.button_limparNomes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_listarEmails
            // 
            this.button_listarEmails.Location = new System.Drawing.Point(374, 241);
            this.button_listarEmails.Name = "button_listarEmails";
            this.button_listarEmails.Size = new System.Drawing.Size(75, 23);
            this.button_listarEmails.TabIndex = 0;
            this.button_listarEmails.Text = "Listar email";
            this.button_listarEmails.UseVisualStyleBackColor = true;
            this.button_listarEmails.Click += new System.EventHandler(this.button_listarEmails_Click);
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(61, 241);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(75, 23);
            this.button_inserir.TabIndex = 1;
            this.button_inserir.Text = "Inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // button_listarDominios
            // 
            this.button_listarDominios.Location = new System.Drawing.Point(674, 241);
            this.button_listarDominios.Name = "button_listarDominios";
            this.button_listarDominios.Size = new System.Drawing.Size(103, 23);
            this.button_listarDominios.TabIndex = 2;
            this.button_listarDominios.Text = "Listar dominios";
            this.button_listarDominios.UseVisualStyleBackColor = true;
            this.button_listarDominios.Click += new System.EventHandler(this.button_listarDominios_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_listaNomes.Location = new System.Drawing.Point(22, 293);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.Size = new System.Drawing.Size(166, 287);
            this.textBox_listaNomes.TabIndex = 3;
            // 
            // textBox_listarEmail
            // 
            this.textBox_listarEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_listarEmail.Location = new System.Drawing.Point(322, 293);
            this.textBox_listarEmail.Multiline = true;
            this.textBox_listarEmail.Name = "textBox_listarEmail";
            this.textBox_listarEmail.Size = new System.Drawing.Size(176, 287);
            this.textBox_listarEmail.TabIndex = 4;
            // 
            // textBox_listarDominio
            // 
            this.textBox_listarDominio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_listarDominio.Location = new System.Drawing.Point(629, 293);
            this.textBox_listarDominio.Multiline = true;
            this.textBox_listarDominio.Name = "textBox_listarDominio";
            this.textBox_listarDominio.Size = new System.Drawing.Size(182, 287);
            this.textBox_listarDominio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Location = new System.Drawing.Point(91, 84);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(268, 23);
            this.textBox_email.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(91, 17);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(268, 23);
            this.textBox_nome.TabIndex = 9;
            // 
            // button_limparEmails
            // 
            this.button_limparEmails.Location = new System.Drawing.Point(362, 202);
            this.button_limparEmails.Name = "button_limparEmails";
            this.button_limparEmails.Size = new System.Drawing.Size(104, 23);
            this.button_limparEmails.TabIndex = 10;
            this.button_limparEmails.Text = "Limpar emails";
            this.button_limparEmails.UseVisualStyleBackColor = true;
            this.button_limparEmails.Click += new System.EventHandler(this.button_limparEmails_Click);
            // 
            // button_limparDominios
            // 
            this.button_limparDominios.Location = new System.Drawing.Point(674, 202);
            this.button_limparDominios.Name = "button_limparDominios";
            this.button_limparDominios.Size = new System.Drawing.Size(119, 23);
            this.button_limparDominios.TabIndex = 11;
            this.button_limparDominios.Text = "Limpar dominios";
            this.button_limparDominios.UseVisualStyleBackColor = true;
            this.button_limparDominios.Click += new System.EventHandler(this.button_limparDominios_Click);
            // 
            // button_limparNomes
            // 
            this.button_limparNomes.Location = new System.Drawing.Point(61, 194);
            this.button_limparNomes.Name = "button_limparNomes";
            this.button_limparNomes.Size = new System.Drawing.Size(75, 23);
            this.button_limparNomes.TabIndex = 12;
            this.button_limparNomes.Text = "Limpar nomes";
            this.button_limparNomes.UseVisualStyleBackColor = true;
            this.button_limparNomes.Click += new System.EventHandler(this.button_limparNomes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 592);
            this.Controls.Add(this.button_limparNomes);
            this.Controls.Add(this.button_limparDominios);
            this.Controls.Add(this.button_limparEmails);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_listarDominio);
            this.Controls.Add(this.textBox_listarEmail);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.button_listarDominios);
            this.Controls.Add(this.button_inserir);
            this.Controls.Add(this.button_listarEmails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_listarEmails;
        private Button button_inserir;
        private Button button_listarDominios;
       
        private Button button_listarEmail;
        
        private TextBox TextBox_nomeCompleto;
        
        private Label label1;
        private Label label2;
        private TextBox textBox_listarDominios;
        private TextBox textBox_listarEmails;
        private TextBox textBox_Inserir;
        private TextBox textBox_listaNomes;
        private TextBox textBox_listarEmail;
        private TextBox textBox_listarDominio;
        private Label label3;
        private TextBox textBox_email;
        private Label label4;
        private TextBox textBox_nome;
        private Button button_limparEmails;
        private Button button_limparDominios;
        private Button button_limparNomes;
    }
}