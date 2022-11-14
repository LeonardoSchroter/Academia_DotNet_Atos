using System.Data.SqlClient;
namespace windForm_Glicemia_BD;

public partial class Form1 : Form
{
    Banco b = new Banco();
    public Form1()
    {
        InitializeComponent();
    }

    private void button_conectar_Click(object sender, EventArgs e)
    {
        string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
        SqlCommand comando = new SqlCommand(sqlTexto, b.abrirConexao());

        listView_medidasGlicemicas.Items.Clear();
        SqlDataReader leitor = comando.ExecuteReader();
        int i = 0;
        while (leitor.Read())
        {
            listView_medidasGlicemicas.Items.Add(leitor["idMedidaGlicemia"].ToString());
            listView_medidasGlicemicas.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
            listView_medidasGlicemicas.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
            listView_medidasGlicemicas.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
            i++;
        }

        button_cadastrar.Enabled = true;
        
        button_deletar.Enabled = true;
        button_editar.Enabled = true;

        b.fecharConexao();

    }

    private void button_cadastrar_Click(object sender, EventArgs e)
    {
        textBox_dataMedicao.Enabled = true;
        textBox_idPaciente.Enabled = true;
        textBox_valorGlicemia.Enabled = true;
        button_salvar.Enabled = true;
    }

    private void button_salvar_Click(object sender, EventArgs e)
    {

        try
        {
            MedicaoGlicemia mg = new MedicaoGlicemia(int.Parse(textBox_valorGlicemia.Text),textBox_dataMedicao.Text, int.Parse(textBox_idPaciente.Text));
            mg.gravarMedicaoGlicemia();
        }
        catch (Exception)
        {
            Console.WriteLine("Erro nas informações");
            throw;
        }
        finally
        {
            textBox_dataMedicao.Enabled =false;
            textBox_idPaciente.Enabled = false;
            textBox_valorGlicemia.Enabled = false;
            button_salvar.Enabled = false;
        }

    }

    private void button_deletar_Click(object sender, EventArgs e)
    {
        textBox_deletar.Enabled = true;
        button_deleta.Enabled = true;
    }

    private void button_deleta_Click(object sender, EventArgs e)
    {
        int idMedidaGlicemia = int.Parse(textBox_deletar.Text);

        try
        {
            string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

            SqlCommand comando = new SqlCommand(sqlTexto, b.abrirConexao());
            comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

            //executar sentença SQL
            comando.ExecuteNonQuery();
            MessageBox.Show("Deletado com sucesso");
            textBox_deletar.Enabled = false;
            button_deleta.Enabled = false;
        }
        catch (Exception)
        {
            MessageBox.Show("Problemas para deletar");
            throw;
        }
        finally
        {
            b.fecharConexao();
        }
    }
}

