using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace time.View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void jogadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //aqui é a aba de perquisar Jogadores
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarTimes telaCadastrar = new CadastrarTimes();
            telaCadastrar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroJogadores telaCadastrar = new TelaCadastroJogadores();
            telaCadastrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesquisarTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarTimes telaPesquisarTime = new TelaPesquisarTimes();
            telaPesquisarTime.ShowDialog();
        }
    }
}
