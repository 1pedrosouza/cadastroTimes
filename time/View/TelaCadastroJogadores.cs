using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using time.Model;

namespace time.View
{
    public partial class TelaCadastroJogadores : Form
    {
        public TelaCadastroJogadores()
        {
            InitializeComponent();
        }

        private void btnCadastrarJogadores_Click(object sender, EventArgs e)
        {
            Jogadores.NomeJogadores = tbxNomeJogadores.Text;
            Jogadores.EmailJogadores = tbxEmailJogadores.Text;
            Jogadores.FoneJogadores = tbxFoneJogadores.Text;

            ManipulaJogadores manipulaJogadores = new ManipulaJogadores();
            manipulaJogadores.CadastroJogadores();

            if(Jogadores.Retorno == "Sim")
            {
                tbxNomeJogadores.Text = string.Empty;
                tbxEmailJogadores.Text = string.Empty;
                tbxFoneJogadores.Text = string.Empty;
            }
            else
            {
                fecharCadastro();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        public void fecharCadastro()
        {

        }
    }
}
