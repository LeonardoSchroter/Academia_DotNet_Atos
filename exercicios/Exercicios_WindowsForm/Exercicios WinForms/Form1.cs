namespace Exercicios_WinForms
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        List<String> listaNomes = new List<String>();

        private void inserirTextBox_lista()
        {
            if (Txt_nomeCompleto.Text.Length == 0)
            {
                MessageBox.Show("Para adicionar nome, é preciso digitar algo", "ATENÇÃO");
            }
            else
            {
                listaNomes.Add(Txt_nomeCompleto.Text.ToUpper());

                listaNomes.Sort();

                //inserir o conteúdo da lista ordenado
                atualizarTextBox_lista();

                Txt_nomeCompleto.Text = String.Empty;
            }
            Txt_nomeCompleto.Focus();
        }

        private void Button_addLista_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }




        private void Txt_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)
            {
                inserirTextBox_lista();
            }

        }

        private void atualizarTextBox_lista()
        {
            textBox_listaNomes.Text = String.Empty;

            foreach (var i in listaNomes)
            {
                textBox_listaNomes.Text += i + Environment.NewLine;
            }
        }


    }
}