
namespace time.View
{
    partial class TelaPesquisarJogador
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(90, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnBuscarJogador);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbxBuscarCodigoJogador);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbxFone);
            this.tabPage1.Controls.Add(this.lblCodigoJogadoresAtual);
            this.tabPage1.Controls.Add(this.btnEditarJogador);
            this.tabPage1.Controls.Add(this.BtnXJogador);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbxEmailJogador);
            this.tabPage1.Controls.Add(this.tbxNomeJogador);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarJogador
            // 
            this.btnBuscarJogador.Location = new System.Drawing.Point(360, 23);
            this.btnBuscarJogador.Name = "btnBuscarJogador";
            this.btnBuscarJogador.Size = new System.Drawing.Size(67, 27);
            this.btnBuscarJogador.TabIndex = 39;
            this.btnBuscarJogador.Text = "Buscar";
            this.btnBuscarJogador.UseVisualStyleBackColor = true;
            this.btnBuscarJogador.Click += new System.EventHandler(this.btnBuscarJogador_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(34, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Digite o código do Jogador";
            // 
            // tbxBuscarCodigoJogador
            // 
            this.tbxBuscarCodigoJogador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBuscarCodigoJogador.Location = new System.Drawing.Point(249, 19);
            this.tbxBuscarCodigoJogador.Name = "tbxBuscarCodigoJogador";
            this.tbxBuscarCodigoJogador.Size = new System.Drawing.Size(96, 33);
            this.tbxBuscarCodigoJogador.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefone:";
            // 
            // tbxFone
            // 
            this.tbxFone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFone.Location = new System.Drawing.Point(114, 239);
            this.tbxFone.Name = "tbxFone";
            this.tbxFone.Size = new System.Drawing.Size(170, 29);
            this.tbxFone.TabIndex = 35;
            // 
            // lblCodigoJogadoresAtual
            // 
            this.lblCodigoJogadoresAtual.AutoSize = true;
            this.lblCodigoJogadoresAtual.BackColor = System.Drawing.Color.Gray;
            this.lblCodigoJogadoresAtual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoJogadoresAtual.Location = new System.Drawing.Point(117, 116);
            this.lblCodigoJogadoresAtual.Name = "lblCodigoJogadoresAtual";
            this.lblCodigoJogadoresAtual.Size = new System.Drawing.Size(52, 25);
            this.lblCodigoJogadoresAtual.TabIndex = 34;
            this.lblCodigoJogadoresAtual.Text = "..........";
            // 
            // btnEditarJogador
            // 
            this.btnEditarJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarJogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarJogador.Image = global::time.Properties.Resources.edit_modify_icon_149489;
            this.btnEditarJogador.Location = new System.Drawing.Point(504, 297);
            this.btnEditarJogador.Name = "btnEditarJogador";
            this.btnEditarJogador.Size = new System.Drawing.Size(75, 57);
            this.btnEditarJogador.TabIndex = 33;
            this.btnEditarJogador.UseVisualStyleBackColor = true;
            // 
            // BtnXJogador
            // 
            this.BtnXJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXJogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnXJogador.Image = global::time.Properties.Resources.icons8_circled_x_48;
            this.BtnXJogador.Location = new System.Drawing.Point(409, 297);
            this.BtnXJogador.Name = "BtnXJogador";
            this.BtnXJogador.Size = new System.Drawing.Size(75, 57);
            this.BtnXJogador.TabIndex = 32;
            this.BtnXJogador.UseVisualStyleBackColor = true;   
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Código:";
            // 
            // tbxEmailJogador
            // 
            this.tbxEmailJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxEmailJogador.Location = new System.Drawing.Point(114, 193);
            this.tbxEmailJogador.Name = "tbxEmailJogador";
            this.tbxEmailJogador.Size = new System.Drawing.Size(344, 29);
            this.tbxEmailJogador.TabIndex = 30;
            // 
            // tbxNomeJogador
            // 
            this.tbxNomeJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeJogador.Location = new System.Drawing.Point(114, 149);
            this.tbxNomeJogador.Name = "tbxNomeJogador";
            this.tbxNomeJogador.Size = new System.Drawing.Size(344, 29);
            this.tbxNomeJogador.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(34, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // TelaPesquisarJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPesquisarJogador";
            this.Text = "TelaPesquisarJogador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}