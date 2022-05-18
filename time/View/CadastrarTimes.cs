using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        MemoryStream memoryLogo = new MemoryStream();
        pictureBoxLogo.Image.Save(memoryLogo, pictureBoxLogo.Image.RawFormat);
            Times.LogoTimes = memoryLogo.ToArray();

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

        private void btnImagem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Escolha seu logo (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
