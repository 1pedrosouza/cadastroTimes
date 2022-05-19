
using System;

namespace time.View
{
    partial class TelaPesquisarTimes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarTimes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoTimeAtual = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tbxFraseTime = new System.Windows.Forms.TextBox();
            this.tbxNomeTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCodigoTime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarJogador = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxBuscarCodigoJogador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFone = new System.Windows.Forms.TextBox();
            this.lblCodigoJogadoresAtual = new System.Windows.Forms.Label();
            this.btnEditarJogador = new System.Windows.Forms.Button();
            this.BtnXJogador = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxEmailJogador = new System.Windows.Forms.TextBox();
            this.tbxNomeJogador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(72, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBuscarCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxCodigoTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoTimeAtual);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.BtnX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxLogo);
            this.groupBox1.Controls.Add(this.tbxFraseTime);
            this.groupBox1.Controls.Add(this.tbxNomeTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(28, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // lblCodigoTimeAtual
            // 
            this.lblCodigoTimeAtual.AutoSize = true;
            this.lblCodigoTimeAtual.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoTimeAtual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoTimeAtual.Location = new System.Drawing.Point(24, 61);
            this.lblCodigoTimeAtual.Name = "lblCodigoTimeAtual";
            this.lblCodigoTimeAtual.Size = new System.Drawing.Size(52, 25);
            this.lblCodigoTimeAtual.TabIndex = 11;
            this.lblCodigoTimeAtual.Text = "..........";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Image = global::time.Properties.Resources.edit_modify_icon_149489;
            this.btnEditar.Location = new System.Drawing.Point(497, 199);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 57);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnX
            // 
            this.BtnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnX.Image = global::time.Properties.Resources.icons8_circled_x_48;
            this.BtnX.Location = new System.Drawing.Point(402, 199);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(75, 57);
            this.BtnX.TabIndex = 9;
            this.BtnX.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(402, 35);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(170, 158);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tbxFraseTime
            // 
            this.tbxFraseTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFraseTime.Location = new System.Drawing.Point(24, 206);
            this.tbxFraseTime.Name = "tbxFraseTime";
            this.tbxFraseTime.Size = new System.Drawing.Size(344, 29);
            this.tbxFraseTime.TabIndex = 5;
            // 
            // tbxNomeTime
            // 
            this.tbxNomeTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTime.Location = new System.Drawing.Point(24, 128);
            this.tbxNomeTime.Name = "tbxNomeTime";
            this.tbxNomeTime.Size = new System.Drawing.Size(267, 29);
            this.tbxNomeTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Frase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time:";
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(329, 56);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(67, 27);
            this.btnBuscarCodigo.TabIndex = 2;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código do Time";
            // 
            // tbxCodigoTime
            // 
            this.tbxCodigoTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCodigoTime.Location = new System.Drawing.Point(200, 50);
            this.tbxCodigoTime.Name = "tbxCodigoTime";
            this.tbxCodigoTime.Size = new System.Drawing.Size(96, 33);
            this.tbxCodigoTime.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarJogador);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbxBuscarCodigoJogador);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbxFone);
            this.tabPage2.Controls.Add(this.lblCodigoJogadoresAtual);
            this.tabPage2.Controls.Add(this.btnEditarJogador);
            this.tabPage2.Controls.Add(this.BtnXJogador);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbxEmailJogador);
            this.tabPage2.Controls.Add(this.tbxNomeJogador);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarJogador
            // 
            this.btnBuscarJogador.Location = new System.Drawing.Point(379, 26);
            this.btnBuscarJogador.Name = "btnBuscarJogador";
            this.btnBuscarJogador.Size = new System.Drawing.Size(67, 27);
            this.btnBuscarJogador.TabIndex = 26;
            this.btnBuscarJogador.Text = "Buscar";
            this.btnBuscarJogador.UseVisualStyleBackColor = true;
            this.btnBuscarJogador.Click += new System.EventHandler(this.btnBuscarJogador_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(50, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Digite o código do Jogador";
            // 
            // tbxBuscarCodigoJogador
            // 
            this.tbxBuscarCodigoJogador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBuscarCodigoJogador.Location = new System.Drawing.Point(268, 22);
            this.tbxBuscarCodigoJogador.Name = "tbxBuscarCodigoJogador";
            this.tbxBuscarCodigoJogador.Size = new System.Drawing.Size(96, 33);
            this.tbxBuscarCodigoJogador.TabIndex = 25;
            this.tbxBuscarCodigoJogador.TextChanged += new System.EventHandler(this.tbxBuscarCodigoJogador_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefone:";
            // 
            // tbxFone
            // 
            this.tbxFone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFone.Location = new System.Drawing.Point(133, 242);
            this.tbxFone.Name = "tbxFone";
            this.tbxFone.Size = new System.Drawing.Size(170, 29);
            this.tbxFone.TabIndex = 22;
            // 
            // lblCodigoJogadoresAtual
            // 
            this.lblCodigoJogadoresAtual.AutoSize = true;
            this.lblCodigoJogadoresAtual.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoJogadoresAtual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoJogadoresAtual.Location = new System.Drawing.Point(133, 116);
            this.lblCodigoJogadoresAtual.Name = "lblCodigoJogadoresAtual";
            this.lblCodigoJogadoresAtual.Size = new System.Drawing.Size(52, 25);
            this.lblCodigoJogadoresAtual.TabIndex = 21;
            this.lblCodigoJogadoresAtual.Text = "..........";
            // 
            // btnEditarJogador
            // 
            this.btnEditarJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarJogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarJogador.Image = global::time.Properties.Resources.edit_modify_icon_149489;
            this.btnEditarJogador.Location = new System.Drawing.Point(523, 300);
            this.btnEditarJogador.Name = "btnEditarJogador";
            this.btnEditarJogador.Size = new System.Drawing.Size(75, 57);
            this.btnEditarJogador.TabIndex = 20;
            this.btnEditarJogador.UseVisualStyleBackColor = true;
            // 
            // BtnXJogador
            // 
            this.BtnXJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXJogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnXJogador.Image = global::time.Properties.Resources.icons8_circled_x_48;
            this.BtnXJogador.Location = new System.Drawing.Point(428, 300);
            this.BtnXJogador.Name = "BtnXJogador";
            this.BtnXJogador.Size = new System.Drawing.Size(75, 57);
            this.BtnXJogador.TabIndex = 19;
            this.BtnXJogador.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(50, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Código:";
            // 
            // tbxEmailJogador
            // 
            this.tbxEmailJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxEmailJogador.Location = new System.Drawing.Point(133, 196);
            this.tbxEmailJogador.Name = "tbxEmailJogador";
            this.tbxEmailJogador.Size = new System.Drawing.Size(344, 29);
            this.tbxEmailJogador.TabIndex = 17;
            // 
            // tbxNomeJogador
            // 
            this.tbxNomeJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeJogador.Location = new System.Drawing.Point(133, 152);
            this.tbxNomeJogador.Name = "tbxNomeJogador";
            this.tbxNomeJogador.Size = new System.Drawing.Size(344, 29);
            this.tbxNomeJogador.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(50, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(50, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nome:";
            // 
            // TelaPesquisarTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPesquisarTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Jogos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnBuscarJogador_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNomeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCodigoTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox tbxFraseTime;
        private System.Windows.Forms.Label lblCodigoTimeAtual;
        private System.Windows.Forms.Button btnBuscarJogador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxBuscarCodigoJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFone;
        private System.Windows.Forms.Label lblCodigoJogadoresAtual;
        private System.Windows.Forms.Button btnEditarJogador;
        private System.Windows.Forms.Button BtnXJogador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxEmailJogador;
        private System.Windows.Forms.TextBox tbxNomeJogador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}