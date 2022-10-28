namespace exercicio_WinForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Criptomoeda> listaCriptomoedas = new List<Criptomoeda>();

        private void button_inserir_Click(object sender, EventArgs e)
        {
            if(textBox_valorCriptomoeda.Text == "" || textBox_siglaCriptomoeda.Text== "" || textBox_nomeCriptomoeda.Text == "")
            {
                MessageBox.Show("É necessário preencher todos os campos");
                limparCampos();
            }
            else
            {
                listaCriptomoedas.Add(new Criptomoeda(textBox_siglaCriptomoeda.Text, textBox_nomeCriptomoeda.Text, float.Parse(textBox_valorCriptomoeda.Text))) ;
                limparCampos();
            }
        }

        private void button_consultarCripto_Click(object sender, EventArgs e)
        {
            foreach(var cripto in listaCriptomoedas)
            {
                if(cripto.Sigla == textBox_consultarCripto.Text)
                {
                    textBox_lpesquisarCripto.Text = cripto.Sigla + Environment.NewLine + cripto.Nome + Environment.NewLine + cripto.Preco;
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Esta cripto não esta presente na lista");
                    limparCampos();
                }
            }
        }

        private void limparCampos()
        {
            textBox_consultarCripto.Clear();
            textBox_nomeCriptomoeda.Clear();
            textBox_siglaCriptomoeda.Clear();
            textBox_valorCriptomoeda.Clear();
            textBox_remover.Clear();
        }

        private void button_listarCriptomoedas_Click(object sender, EventArgs e)
        {

            if (listaCriptomoedas.Count == 0)
            {
                MessageBox.Show("Não há nenhuma cripto para listar");
            }
            else
            {
                textBox_listarCriptomoedas.Clear();
                foreach(var cripto in listaCriptomoedas)
                {
                    textBox_listarCriptomoedas.Text += cripto.Sigla + Environment.NewLine;
                }
            }
        }

        private void button_remover_Click(object sender, EventArgs e)
        {
            bool encontrei = false;
            foreach (var cripto in listaCriptomoedas)
            {
                if(cripto.Sigla == textBox_remover.Text)
                {
                    listaCriptomoedas.Remove(cripto);
                    encontrei = true;
                    limparCampos();
                    MessageBox.Show("Criptomoeda deletada");
                    break;
                   
                }
            }
            if (!encontrei)
            {
                MessageBox.Show("Cripto não encontrada");
                limparCampos();
            }
        }
    }
}