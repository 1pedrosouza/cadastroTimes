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
    public partial class CadastrarTimes : Form
    {
        public CadastrarTimes()
        {
            InitializeComponent();
        }

        private void btnCadastrarTime_Click(object sender, EventArgs e)
        {
            if(tbxNomeTime.Text == "" || tbxFraseTime.Text == "")
            {
                MessageBox.Show("escreva uma parada ai irmão", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

        Times.NomeTimee = tbxNomeTime.Text;
        Times.FraseTimes = tbxFraseTime.Text;
        Times.LogoTimes = "c:/";  //bagui das logo tem que fazer

            ManipulaTimes manipulaTimes = new ManipulaTimes();
            manipulaTimes.cadastroTimes();
            if (Times.Retorno == "Sim" )

            {
                tbxNomeTime.Text = string.Empty;
                tbxFraseTime.Text = string.Empty;
            }
            else
            {
                fecharCadastro();
            }







        }
     
        public void fecharCadastro()
        {
            this.Close();
        }

        public void limparTela()
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void CadastrarTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                fecharCadastro();
            }
        }
    }
}
