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
    class ManipulaJogadores
    {
        public void cadastroJogadores()
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
    }
}