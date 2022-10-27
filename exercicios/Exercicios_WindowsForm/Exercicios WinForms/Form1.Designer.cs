namespace Exercicios_WinForms
{
    partial class Form_principal
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
            this.Txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.Button_addLista = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo:";
            // 
            // Txt_nomeCompleto
            // 
            this.Txt_nomeCompleto.Location = new System.Drawing.Point(154, 18);
            this.Txt_nomeCompleto.Name = "Txt_nomeCompleto";
            this.Txt_nomeCompleto.Size = new System.Drawing.Size(258, 23);
            this.Txt_nomeCompleto.TabIndex = 1;
            this.Txt_nomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nomeCompleto_KeyPress);
            // 
            // Button_addLista
            // 
            this.Button_addLista.Location = new System.Drawing.Point(154, 57);
            this.Button_addLista.Name = "Button_addLista";
            this.Button_addLista.Size = new System.Drawing.Size(75, 23);
            this.Button_addLista.TabIndex = 2;
            this.Button_addLista.Text = "Inserir";
            this.Button_addLista.UseVisualStyleBackColor = true;
            this.Button_addLista.Click += new System.EventHandler(this.Button_addLista_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Enabled = false;
            this.textBox_listaNomes.Location = new System.Drawing.Point(154, 118);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.Size = new System.Drawing.Size(258, 299);
            this.textBox_listaNomes.TabIndex = 3;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.Button_addLista);
            this.Controls.Add(this.Txt_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form_principal";
            this.Text = "Titulo do formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Txt_nomeCompleto;
        private Button Button_addLista;
        private TextBox textBox_listaNomes;
    }
}