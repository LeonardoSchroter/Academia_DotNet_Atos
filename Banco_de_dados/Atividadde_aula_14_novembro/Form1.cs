using System.Data;

namespace Atividadde_aula_14_novembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBox_nome.Text;
            p.peso = float.Parse(textBox_peso.Text);

            if (p.gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesse");
                textBox_nome.Clear();
                textBox_peso.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao inserir a pessoa");
            }
        }

        private void button_consultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from pessoas " +
                "where nome = '"+ textBox_consulta.Text + "'");
            dataGridView1.DataSource = dt;
        }
    }
}