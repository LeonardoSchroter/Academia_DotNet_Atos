
using System.Data;
using System.Data.SqlClient;

namespace windForm_Glicemia_BD
{
    internal class Banco
    {
        private bool conectado = false;
        private string stringConexao = "Data Source=localhost; Initial Catalog=glicemia_db; User ID=sa; password=Leo996701392;language=Portuguese";

        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();
               
                conectado = true;
                return cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao conectar com banco");
                //faz algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
                conectado=false;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        public bool getConectado()
        {
            return conectado;
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
