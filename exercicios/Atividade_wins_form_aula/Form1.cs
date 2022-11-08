using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Atividade_wins_form_aula
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Jogador> Lista = new List<Jogador>();

        private void button_inserir_Click(object sender, EventArgs e)
        {
            if (textBox_nomeCompleto.Text == "")
            {
                MessageBox.Show("O campo nome deve estar preenchido");
                limparCampos();
            }
            else if (encontrarIgual())
            {
                MessageBox.Show("Este nome ja está cadastrado");
                limparCampos();
            }
            else if (!validaNomeCompleto())
            {
                MessageBox.Show("O nome deve ser completo");
                limparCampos();
            }
            else
            {
                string[] nomeCompleto = textBox_nomeCompleto.Text.Split(" ");


                string email = nomeCompleto[1] + "." + nomeCompleto[0] + "@ufn.edu.br";
                Lista.Add(new Jogador(textBox_nomeCompleto.Text.ToUpper(), email.ToUpper()));

               

                StreamWriter writer = new StreamWriter(@"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\NomesJogadores.txt", append:true);
                writer.WriteLine(textBox_nomeCompleto.Text.ToUpper() + ";" + email.ToUpper());
                writer.Close();

                limparCampos();
                Listar();

            }



        }

        private bool encontrarIgual()
        {
            foreach (Jogador jogador in Lista)
            {
                if (jogador.nome.Contains(textBox_nomeCompleto.Text.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        bool validaNomeCompleto()
        {
            for (int i = 0; i < textBox_nomeCompleto.Text.Length; i++)
            {
                if (textBox_nomeCompleto.Text[i] == ' ' && (textBox_nomeCompleto.Text[i + 1] != ' ' || textBox_nomeCompleto.Text[i + 1] != '\n'))
                {
                    return true;
                }
            }
            return false;
        }

        private void limparCampos()
        {
            textBox_nomeCompleto.Clear();
        }

        private void button_limparLista_Click(object sender, EventArgs e)
        {
            if (textBox_listagem.Text == "")
            {
                MessageBox.Show("Não ha oque limpar");
            }
            else
            {


                textBox_listagem.Clear();
            }
        }
        private void popularLista()
        {
            StreamReader leitor = new StreamReader(@"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\NomesJogadores.txt");
            string linha;
            while (!leitor.EndOfStream)
            {
                linha = leitor.ReadLine();
                string[] separa = linha.Split(";");
                if(linha != "")
                {
                    Lista.Add(new Jogador(separa[0], separa[1]));
                }

            }
            leitor.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popularLista();
            Listar();
        }
        private void Listar()
        {
            foreach(var jogador in Lista)
            {
                textBox_listagem.Text += jogador.nome + "-" +jogador.email + Environment.NewLine;
            }
        }
    }
}