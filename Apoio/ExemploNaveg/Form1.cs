namespace ExemploNaveg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.Show();
            this.Hide();
        }
    }
}