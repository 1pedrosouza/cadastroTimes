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

                var resposta = MessageBox.Show("Cadastro efetuado papai, deseja executar um novo cadastro?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation );

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
    }
}
