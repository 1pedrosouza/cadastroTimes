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

                var resposta = MessageBox.Show("Cadastro efetuado papai, deseja executar um novo cadastro?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation );

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
            SqlCommand cmd = new SqlCommand("pBuscarCodigoJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cn.Open();
                MessageBox.Show("Test");
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



    }
}