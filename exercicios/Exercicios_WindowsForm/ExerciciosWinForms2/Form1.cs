using System.Reflection.Metadata.Ecma335;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExerciciosWinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Pessoa> listaPessoas = new List<Pessoa>();
       

        private void button_inserir_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text.Length == 0 || textBox_email.Text.Length == 0)
            {
                MessageBox.Show("É necessário informar os dois campos", "ATENÇÃO");
            }
            else if (!CompararEmails(textBox_email.Text))
            {
                MessageBox.Show("Este email ja existe");
            }
            else
            {
                
                listaPessoas.Add(new Pessoa(textBox_nome.Text, textBox_email.Text));
                atualizarTextBox_listaNomes();
                limparCampos();
            }

        }

        private void limparCampos()
        {
            textBox_nome.Clear();
            textBox_email.Clear();
        }

        private void atualizarTextBox_listaNomes()
        {
            
            textBox_listaNomes.Text = String.Empty;

            foreach (var i in listaPessoas)
            {
                textBox_listaNomes.Text += i.Nome + Environment.NewLine;
            }
        }

        private bool CompararEmails(string email)
        {
            foreach(var pessoa in listaPessoas)
            {
                if(pessoa.Email == email)
                {
                    return false;
                }
            }
            return true;
        }

        private void button_listarEmails_Click(object sender, EventArgs e)
        {
            textBox_listarEmail.Clear();
            foreach (var pessoa in listaPessoas)
            {
                textBox_listarEmail.Text += pessoa.Email + Environment.NewLine;
            }
        }

        private void button_listarDominios_Click(object sender, EventArgs e)
        {
            textBox_listarDominio.Clear();

            foreach(var pessoa in listaPessoas)
            {
                string[] dominio = pessoa.Email.Split("@");
                textBox_listarDominio.Text += dominio[1] + Environment.NewLine;
            }
        }

        private void button_limparNomes_Click(object sender, EventArgs e)
        {
            textBox_listaNomes.Text = String.Empty;
        }

        private void button_limparEmails_Click(object sender, EventArgs e)
        {
            textBox_listarEmail.Text = String.Empty;
        }

        private void button_limparDominios_Click(object sender, EventArgs e)
        {
            textBox_listarDominio.Text = String.Empty;
        }
    }
}