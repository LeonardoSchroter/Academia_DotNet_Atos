using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_paraBD
{
    internal class Departamento
    {
        public string nome { get; set; }
        public string localizacao { get; set; }
        public string orcamento { get; set; }

        public Departamento(string nome, string localizacao, string orcamento)
        {
            this.nome = nome;
            this.localizacao = localizacao;
            this.orcamento = orcamento;
        }

        public Departamento()
        {

        }

        public bool gravarDepartamento()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into departamento values (@nome, @localizacao, @orcamento);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@localizacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@orcamento", SqlDbType.VarChar);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = localizacao;
            cmd.Parameters[2].Value = orcamento;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;

            }
            catch(Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }

           
            
        }
    }
}
