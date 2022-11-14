using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windForm_Glicemia_BD
{
    internal class MedicaoGlicemia
    {
        public int valorGlicemia { get; set; }
        public string data { get; set; }
        public int idPaciente { get; set; }

        public MedicaoGlicemia(int valorGlicemia, string data, int idPaciente)
        {
            this.valorGlicemia = valorGlicemia;
            this.data = data;
            this.idPaciente = idPaciente;
        }

        public bool gravarMedicaoGlicemia()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into MedidaGlicemia values (@valorGlicemia, @data, @idPaciente);";
            cmd.Parameters.Add("@valorGlicemia", SqlDbType.Int);
            cmd.Parameters.Add("@data", SqlDbType.Date);
            cmd.Parameters.Add("@idPaciente", SqlDbType.Int);
            cmd.Parameters[0].Value = valorGlicemia;
            cmd.Parameters[1].Value = data;
            cmd.Parameters[2].Value = idPaciente;
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
