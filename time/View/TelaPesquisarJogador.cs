using System;

using System.Windows.Forms;
using time.Model;

namespace time.View
{
    public partial class TelaPesquisarJogador : Form
    {
        public TelaPesquisarJogador()
        {
            InitializeComponent();
        }

       

        private void btnBuscarJogador_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbxBuscarCodigoJogador.Text == "")
                {
                    MessageBox.Show("Digite um código válido.");
                    return;
                }
                else
                {
                    Jogadores.CodJogadores = Convert.ToInt32(tbxBuscarCodigoJogador.Text);
                }

                ManipulaJogadores manipul = new ManipulaJogadores();
                manipul.PesquisarCodigoJogadores();



                lblCodigoJogadoresAtual.Text = Jogadores.CodJogadores.ToString();
                tbxEmailJogador.Text = Jogadores.EmailJogadores;
                tbxNomeJogador.Text = Jogadores.NomeJogadores;
                tbxFone.Text = Jogadores.FoneJogadores;

            }
            catch (Exception)
            {
             
            }
        }

        private void BtnXJogador_Click(object sender, EventArgs e)
        {
            Jogadores.CodJogadores = Convert.ToInt32(tbxBuscarCodigoJogador.Text);
            if (tbxBuscarCodigoJogador.Text == "")
            {
                MessageBox.Show("Digite um numero");

            };



            var resposta = MessageBox.Show("Deseja exluir o Time" + tbxBuscarCodigoJogador.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resposta == DialogResult.Yes)
            {

                ManipulaJogadores manipulaTimes = new ManipulaJogadores();
                manipulaTimes.deletarJogadores();
            
                lblCodigoJogadoresAtual.Text = string.Empty;
                tbxNomeJogador.Text = string.Empty;
                tbxEmailJogador.Text = string.Empty;
                tbxFone.Text = string.Empty;


            }
        }

        private void btnEditarJogador_Click(object sender, EventArgs e)
        {
            if (lblCodigoJogadoresAtual.Text == "")
            {

                MessageBox.Show("Digite um código válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




            var reposta = MessageBox.Show("Deseja fazer alterações no time" + tbxNomeJogador.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reposta == DialogResult.Yes)
            {
                Jogadores.CodJogadores = Convert.ToInt32(lblCodigoJogadoresAtual.Text);
                Jogadores.NomeJogadores = tbxNomeJogador.Text;
                Jogadores.EmailJogadores = tbxEmailJogador.Text;
                Jogadores.FoneJogadores = tbxFone.Text;

                ManipulaJogadores  manipulaTimes = new ManipulaJogadores();
                manipulaTimes.alterarJogadores();


                lblCodigoJogadoresAtual.Text = string.Empty;
                tbxNomeJogador.Text = string.Empty;
                tbxEmailJogador.Text = string.Empty;
                tbxFone.Text = string.Empty;
                return;
            }
        }
    }
}
