using System;
using System.Data;
using System.Data.SqlClient;
using time.Model;
using System.Windows.Forms;
using time.View;


namespace time.Model
{
    class ManipulaJogadores
    {
        public void CadastroJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeJogador", Jogadores.NomeJogadores);
                cmd.Parameters.AddWithValue("@EmailJogador", Jogadores.EmailJogadores);
                cmd.Parameters.AddWithValue("@FoneJogador", Jogadores.FoneJogadores);

                SqlParameter nv = cmd.Parameters.Add("@CodJogador", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro efetuado, deseja executar um novo cadastro?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation );

                if(resposta == DialogResult.Yes)
                {
                    Jogadores.Retorno = "Sim";
                    return;
                }
                else
                {
                    Jogadores.Retorno = "não";
                    return;
                }

            }
            catch(Exception)
            {

                throw;
            }


        }
        public void PesquisarCodigoJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarCodigoJogadore", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cn.Open();
                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Jogadores.CodJogadores = Convert.ToInt32(arrayDados["CodJogadores"]);
                    Jogadores.NomeJogadores = arrayDados["NomeJogadores"].ToString();
                    Jogadores.EmailJogadores = arrayDados["EmailJogadores"].ToString();
                    Jogadores.FoneJogadores = arrayDados["FoneJogadores"].ToString();
                    Jogadores.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Jogadores.Retorno = "Não";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void deletarJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Jogador excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MessageBox.Show("O Jogador não pode se excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }

        }
        public void alterarJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cmd.Parameters.AddWithValue("@EmailJogadores", Jogadores.EmailJogadores);
                cmd.Parameters.AddWithValue("@FoneJogadores", Jogadores.FoneJogadores);
                cmd.Parameters.AddWithValue("@NomeJogadores", Jogadores.NomeJogadores);
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