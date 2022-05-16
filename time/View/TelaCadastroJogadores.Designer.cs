
namespace time.View
{
    partial class TelaCadastroJogadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNomeJogadores = new System.Windows.Forms.TextBox();
            this.tbxEmailJogadores = new System.Windows.Forms.TextBox();
            this.tbxFoneJogadores = new System.Windows.Forms.TextBox();
            this.btnCadastrarJogadores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cadastro de Jogadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fone:";
            // 
            // tbxNomeJogadores
            // 
            this.tbxNomeJogadores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeJogadores.Location = new System.Drawing.Point(54, 111);
            this.tbxNomeJogadores.Name = "tbxNomeJogadores";
            this.tbxNomeJogadores.Size = new System.Drawing.Size(454, 33);
            this.tbxNomeJogadores.TabIndex = 4;
            // 
            // tbxEmailJogadores
            // 
            this.tbxEmailJogadores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxEmailJogadores.Location = new System.Drawing.Point(53, 179);
            this.tbxEmailJogadores.Name = "tbxEmailJogadores";
            this.tbxEmailJogadores.Size = new System.Drawing.Size(455, 33);
            this.tbxEmailJogadores.TabIndex = 5;
            // 
            // tbxFoneJogadores
            // 
            this.tbxFoneJogadores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFoneJogadores.Location = new System.Drawing.Point(54, 255);
            this.tbxFoneJogadores.Name = "tbxFoneJogadores";
            this.tbxFoneJogadores.Size = new System.Drawing.Size(178, 33);
            this.tbxFoneJogadores.TabIndex = 6;
            // 
            // btnCadastrarJogadores
            // 
            this.btnCadastrarJogadores.Location = new System.Drawing.Point(334, 237);
            this.btnCadastrarJogadores.Name = "btnCadastrarJogadores";
            this.btnCadastrarJogadores.Size = new System.Drawing.Size(136, 51);
            this.btnCadastrarJogadores.TabIndex = 7;
            this.btnCadastrarJogadores.Text = "Cadastrar";
            this.btnCadastrarJogadores.UseVisualStyleBackColor = true;
            this.btnCadastrarJogadores.Click += new System.EventHandler(this.btnCadastrarJogadores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrarJogadores);
            this.Controls.Add(this.tbxFoneJogadores);
            this.Controls.Add(this.tbxEmailJogadores);
            this.Controls.Add(this.tbxNomeJogadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroJogadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroJogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNomeJogadores;
        private System.Windows.Forms.TextBox tbxEmailJogadores;
        private System.Windows.Forms.TextBox tbxFoneJogadores;
        private System.Windows.Forms.Button btnCadastrarJogadores;
        private System.Windows.Forms.Button button1;
    }
}