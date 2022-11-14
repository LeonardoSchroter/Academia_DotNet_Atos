namespace Atividadde_aula_14_novembro
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
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_consultar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.textBox_consulta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nome
            // 
            this.textBox_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nome.Location = new System.Drawing.Point(41, 40);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 23);
            this.textBox_nome.TabIndex = 0;
            // 
            // textBox_peso
            // 
            this.textBox_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_peso.Location = new System.Drawing.Point(41, 93);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(100, 23);
            this.textBox_peso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso";
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_gravar.Location = new System.Drawing.Point(41, 134);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 4;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_consultar
            // 
            this.button_consultar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_consultar.Location = new System.Drawing.Point(362, 105);
            this.button_consultar.Name = "button_consultar";
            this.button_consultar.Size = new System.Drawing.Size(75, 23);
            this.button_consultar.TabIndex = 5;
            this.button_consultar.Text = "Consultar";
            this.button_consultar.UseVisualStyleBackColor = false;
            this.button_consultar.Click += new System.EventHandler(this.button_consultar_Click);
            // 
            // button_filtrar
            // 
            this.button_filtrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_filtrar.Location = new System.Drawing.Point(458, 105);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(75, 23);
            this.button_filtrar.TabIndex = 6;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = false;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // textBox_consulta
            // 
            this.textBox_consulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_consulta.Location = new System.Drawing.Point(444, 67);
            this.textBox_consulta.Name = "textBox_consulta";
            this.textBox_consulta.Size = new System.Drawing.Size(252, 23);
            this.textBox_consulta.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(418, 214);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_consulta);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.button_consultar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.textBox_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_nome;
        private TextBox textBox_peso;
        private Label label1;
        private Label label2;
        private Button button_gravar;
        private Button button_consultar;
        private Button button_filtrar;
        private TextBox textBox_consulta;
        private DataGridView dataGridView1;
    }
}