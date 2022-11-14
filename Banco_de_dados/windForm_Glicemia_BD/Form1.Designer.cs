namespace windForm_Glicemia_BD
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
            this.listView_medidasGlicemicas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_valorGlicemia = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_dataMedida = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.button_conectar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dataMedicao = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.textBox_valorGlicemia = new System.Windows.Forms.TextBox();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_deletar = new System.Windows.Forms.TextBox();
            this.button_deleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemicas
            // 
            this.listView_medidasGlicemicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader_valorGlicemia,
            this.columnHeader_dataMedida,
            this.columnHeader2});
            this.listView_medidasGlicemicas.Location = new System.Drawing.Point(78, 12);
            this.listView_medidasGlicemicas.Name = "listView_medidasGlicemicas";
            this.listView_medidasGlicemicas.Size = new System.Drawing.Size(442, 214);
            this.listView_medidasGlicemicas.TabIndex = 0;
            this.listView_medidasGlicemicas.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemicas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Glicemia";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader_valorGlicemia
            // 
            this.columnHeader_valorGlicemia.Text = "valor Glicemia";
            this.columnHeader_valorGlicemia.Width = 100;
            // 
            // columnHeader_dataMedida
            // 
            this.columnHeader_dataMedida.Text = "Data Medida";
            this.columnHeader_dataMedida.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Paciente";
            this.columnHeader2.Width = 100;
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(78, 228);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(75, 27);
            this.button_conectar.TabIndex = 1;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Enabled = false;
            this.button_cadastrar.Location = new System.Drawing.Point(193, 228);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 27);
            this.button_cadastrar.TabIndex = 2;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Enabled = false;
            this.button_deletar.Location = new System.Drawing.Point(310, 228);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 27);
            this.button_deletar.TabIndex = 3;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Enabled = false;
            this.button_editar.Location = new System.Drawing.Point(445, 228);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 27);
            this.button_editar.TabIndex = 4;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor da glicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de medição";
            // 
            // textBox_dataMedicao
            // 
            this.textBox_dataMedicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dataMedicao.Enabled = false;
            this.textBox_dataMedicao.Location = new System.Drawing.Point(157, 371);
            this.textBox_dataMedicao.Name = "textBox_dataMedicao";
            this.textBox_dataMedicao.Size = new System.Drawing.Size(100, 23);
            this.textBox_dataMedicao.TabIndex = 8;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_idPaciente.Enabled = false;
            this.textBox_idPaciente.Location = new System.Drawing.Point(157, 419);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBox_idPaciente.TabIndex = 9;
            // 
            // textBox_valorGlicemia
            // 
            this.textBox_valorGlicemia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_valorGlicemia.Enabled = false;
            this.textBox_valorGlicemia.Location = new System.Drawing.Point(157, 328);
            this.textBox_valorGlicemia.Name = "textBox_valorGlicemia";
            this.textBox_valorGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBox_valorGlicemia.TabIndex = 10;
            // 
            // button_salvar
            // 
            this.button_salvar.Enabled = false;
            this.button_salvar.Location = new System.Drawing.Point(87, 464);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 11;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID medida glicêmica";
            // 
            // textBox_deletar
            // 
            this.textBox_deletar.Enabled = false;
            this.textBox_deletar.Location = new System.Drawing.Point(495, 325);
            this.textBox_deletar.Name = "textBox_deletar";
            this.textBox_deletar.Size = new System.Drawing.Size(62, 23);
            this.textBox_deletar.TabIndex = 13;
            // 
            // button_deleta
            // 
            this.button_deleta.Enabled = false;
            this.button_deleta.Location = new System.Drawing.Point(445, 369);
            this.button_deleta.Name = "button_deleta";
            this.button_deleta.Size = new System.Drawing.Size(75, 23);
            this.button_deleta.TabIndex = 14;
            this.button_deleta.Text = "deletar";
            this.button_deleta.UseVisualStyleBackColor = true;
            this.button_deleta.Click += new System.EventHandler(this.button_deleta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 540);
            this.Controls.Add(this.button_deleta);
            this.Controls.Add(this.textBox_deletar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.textBox_valorGlicemia);
            this.Controls.Add(this.textBox_idPaciente);
            this.Controls.Add(this.textBox_dataMedicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.listView_medidasGlicemicas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_medidasGlicemicas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader_valorGlicemia;
        private ColumnHeader columnHeader_dataMedida;
        private ColumnHeader columnHeader2;
        private Button button_conectar;
        private Button button_cadastrar;
        private Button button_deletar;
        private Button button_editar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_dataMedicao;
        private TextBox textBox_idPaciente;
        private TextBox textBox_valorGlicemia;
        private Button button_salvar;
        private Label label4;
        private TextBox textBox_deletar;
        private Button button_deleta;
    }
}