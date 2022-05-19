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
                throw;
            }
        }

        private void tbxBuscarCodigoJogador_TextChanged(object sender, EventArgs e)
        {
           //
        }

       
    }
}
