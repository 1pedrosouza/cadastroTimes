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
    public partial class TelaPesquisarTimes : Form
    {
        public TelaPesquisarTimes()
        {
            InitializeComponent();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxCodigoTime.Text == "")
                {
                    MessageBox.Show("Digite um código válido.");
                    return;
                }
                else
                {
                    Times.CodTimes = Convert.ToInt32(tbxCodigoTime.Text);
                }

                ManipulaTimes manipula = new ManipulaTimes();
                manipula.pesquisarCodigoTimes();

               
                
                    lblCodigoTimeAtual.Text = Times.CodTimes.ToString();
                    tbxFraseTime.Text = Times.FraseTimes;
                    tbxNomeTime.Text = Times.NomeTimee;
                    MemoryStream ms = new MemoryStream((byte[])Times.LogoTimes);

                pictureBoxLogo.Image = Image.FromStream(ms);

               


            }
            catch(Exception)
            {
                
            }
        }

        private void tbxBuscarCodigoJogador_TextChanged(object sender, EventArgs e)
        {
           //
        }

        private void btnBuscarCodigoJogadores_Click(object sender, EventArgs e)
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

        private void btnDeletarTime_Click(object sender, EventArgs e)
        {
            Times.CodTimes = Convert.ToInt32(tbxCodigoTime.Text);
            if (tbxCodigoTime.Text == "") {
                MessageBox.Show("Digite um numero");
            
            };



            var resposta =  MessageBox.Show("Deseja exluir o Time" + tbxNomeTime + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(resposta == DialogResult.Yes)
            {

                ManipulaTimes manipulaTimes = new ManipulaTimes();
                manipulaTimes.deletarTimes();
            }
            else
            {
                lblCodigoTimeAtual.Text = string.Empty;
                tbxNomeTime.Text = string.Empty;
                tbxFraseTime.Text = string.Empty;
                pictureBoxLogo.Image = null;
              
                
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblCodigoTimeAtual.Text == "")
            {

                MessageBox.Show("Digite um código válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


         
          
            var reposta = MessageBox.Show("Deseja fazer alterações no time" + tbxNomeTime + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reposta == DialogResult.Yes)
            {
                Times.CodTimes = Convert.ToInt32(lblCodigoTimeAtual.Text);
                Times.NomeTimee = tbxNomeTime.Text;
                Times.FraseTimes = tbxFraseTime.Text;
                MemoryStream memoriaLogo = new MemoryStream();
                pictureBoxLogo.Image.Save(memoriaLogo, pictureBoxLogo.Image.RawFormat);
                Times.LogoTimes = memoriaLogo.ToArray();

                ManipulaTimes manipulaTimes = new ManipulaTimes();
                manipulaTimes.alterarTimes();


                lblCodigoTimeAtual.Text = string.Empty;
                tbxNomeTime.Text = string.Empty;
                tbxFraseTime.Text = string.Empty;
                pictureBoxLogo.Image = null;
                return;
            }
        }

        private void btnAlterarLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha seu logo (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
