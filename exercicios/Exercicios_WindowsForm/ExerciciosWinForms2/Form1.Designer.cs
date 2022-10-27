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
            this.textBox_inserir = new System.Windows.Forms.TextBox();
            this.textBox_listarEmail = new System.Windows.Forms.TextBox();
            this.textBox_listarDominio = new System.Windows.Forms.TextBox();
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
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(61, 241);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(75, 23);
            this.button_inserir.TabIndex = 1;
            this.button_inserir.Text = "Inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            // 
            // button_listarDominios
            // 
            this.button_listarDominios.Location = new System.Drawing.Point(674, 241);
            this.button_listarDominios.Name = "button_listarDominios";
            this.button_listarDominios.Size = new System.Drawing.Size(103, 23);
            this.button_listarDominios.TabIndex = 2;
            this.button_listarDominios.Text = "Listar dominios";
            this.button_listarDominios.UseVisualStyleBackColor = true;
            // 
            // textBox_inserir
            // 
            this.textBox_inserir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_inserir.Location = new System.Drawing.Point(22, 293);
            this.textBox_inserir.Multiline = true;
            this.textBox_inserir.Name = "textBox_inserir";
            this.textBox_inserir.Size = new System.Drawing.Size(166, 287);
            this.textBox_inserir.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 592);
            this.Controls.Add(this.textBox_listarDominio);
            this.Controls.Add(this.textBox_listarEmail);
            this.Controls.Add(this.textBox_inserir);
            this.Controls.Add(this.button_listarDominios);
            this.Controls.Add(this.button_inserir);
            this.Controls.Add(this.button_listarEmails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_listarEmails;
        private Button button_inserir;
        private Button button_listarDominios;
        private Button button_listarDominios;
        private Button button_listarEmail;
        private Button button_inserir;
        private TextBox TextBox_nomeCompleto;
        private TextBox textBox_email;
        private Label label1;
        private Label label2;
        private TextBox textBox_listarDominios;
        private TextBox textBox_listarEmails;
        private TextBox textBox_Inserir;
        private TextBox textBox_inserir;
        private TextBox textBox_listarEmail;
        private TextBox textBox_listarDominio;
    }
}