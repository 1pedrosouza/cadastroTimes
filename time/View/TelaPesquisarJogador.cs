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
                    Jogadores.CodJogadores = Convert.ToInt32(lblCodigoJogadoresAtual.Text);
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

 
    }
}
