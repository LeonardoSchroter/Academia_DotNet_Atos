namespace WinForms_paraBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Banco banco = new Banco();
        private void button_conectar_Click(object sender, EventArgs e)
        {
            if(textBox_gerenteE.Text == null)
            {
                textBox_gerenteE.Text = "";
            }
            Departamento departamento = new Departamento(txt_nome.Text,txt_localizacao.Text, txt_orcamento.Text);
            

            if (departamento.gravarDepartamento())
            {
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao salvar departamento!");
            }




        }

        private void button_adicionarE_Click(object sender, EventArgs e)
        {
            Empregado empregado = new Empregado(textBox_nomeE.Text, int.Parse(textBox_gerenteE.Text), textBox_funcaoE.Text,int.Parse(textBox_idDepartamentoE.Text),textBox_dataE.Text,float.Parse(textBox_salarioE.Text),float.Parse(textBox_comissaoE.Text));


            if (empregado.gravarEmpregado())
            {
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao salvar departamento!");
            }
        }
    }
}