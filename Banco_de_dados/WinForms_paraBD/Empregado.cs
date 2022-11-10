using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_paraBD
{
    internal class Empregado
    {
        public string nome { get; set; }
        public int idGerente { get; set; }
        public string funcao { get; set; }
        public int idDepartamento { get; set; }
        public string data { get; set; }
        public float salario { get; set; }
        public float comissao { get; set; }

        public Empregado(string nome, int idGerente, string funcao, int idDepartamento, string data, float salario, float comissao)
        {
            this.nome = nome;
            this.idGerente = idGerente;
            this.funcao = funcao;
            this.idDepartamento = idDepartamento;
            this.data = data;
            this.salario = salario;
            this.comissao = comissao;
        }

        public Empregado() { }

        public bool gravarEmpregado()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into empregado values (@nome, @idGerente, @funcao, @idDepartamento, @data, @salario, @comissao);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idGerente", SqlDbType.Int);
            cmd.Parameters.Add("@funcao", SqlDbType.VarChar);
            cmd.Parameters.Add("@idDepartamento", SqlDbType.Int);
            cmd.Parameters.Add("@data", SqlDbType.Date);
            cmd.Parameters.Add("@salario", SqlDbType.Float);
            cmd.Parameters.Add("@comissao", SqlDbType.Float);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = idGerente;
            cmd.Parameters[2].Value = funcao;
            cmd.Parameters[3].Value = idDepartamento;
            cmd.Parameters[4].Value = data;
            cmd.Parameters[5].Value = salario;
            cmd.Parameters[6].Value = comissao;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;

            }
            catch (Exception e)
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
