using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using time.Model;
using System.Windows.Forms;
using time.View;


namespace time.Model
{
    class ManipulaTimes
    {
        public void cadastroTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomesTimes", Times.NomeTimee);
                cmd.Parameters.AddWithValue("@LogoTimes", Times.LogoTimes);
                cmd.Parameters.AddWithValue("@FraseTimes", Times.FraseTimes);

                SqlParameter nv = cmd.Parameters.Add("@CodTimes", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro efetuado, deseja executar um novo cadastro?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation );

                if(resposta == DialogResult.Yes)
                {
                    Times.Retorno = "Sim";
                    return;
                }
                else
                {
                    Times.Retorno = "não";
                    return;
                }
                
            }
            catch(Exception)
            {
               
                throw;
            }


        }
        public void pesquisarCodigoTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarCodigoTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", Times.CodTimes);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Times.CodTimes = Convert.ToInt32(arrayDados["CodTimes"]);
                    Times.NomeTimee = arrayDados["NomeTimes"].ToString();
                    Times.FraseTimes = arrayDados["FraseTimes"].ToString();
                    Times.LogoTimes = (System.Array)arrayDados["LogoTimes"];
                    Times.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("código não localizado", "Atenção",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Times.Retorno = "Não";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void deletarTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", Times.CodTimes);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Time excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MessageBox.Show("O time não pode se excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }

        }
        public void alterarTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", Times.CodTimes);
                cmd.Parameters.AddWithValue("@NomeTimes", Times.NomeTimee);
                cmd.Parameters.AddWithValue("@FraseTimes", Times.FraseTimes);
                cmd.Parameters.AddWithValue("@LogoTimes", Times.LogoTimes);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Time alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {

                MessageBox.Show("O time não foi alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}
