
namespace time.View
{
    partial class CadastrarTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarTimes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNomeTime = new System.Windows.Forms.TextBox();
            this.tbxFraseTime = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Times";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(154, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frase";
            // 
            // tbxNomeTime
            // 
            this.tbxNomeTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTime.Location = new System.Drawing.Point(154, 230);
            this.tbxNomeTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNomeTime.Name = "tbxNomeTime";
            this.tbxNomeTime.Size = new System.Drawing.Size(278, 33);
            this.tbxNomeTime.TabIndex = 3;
            // 
            // tbxFraseTime
            // 
            this.tbxFraseTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFraseTime.Location = new System.Drawing.Point(154, 346);
            this.tbxFraseTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFraseTime.Name = "tbxFraseTime";
            this.tbxFraseTime.Size = new System.Drawing.Size(278, 33);
            this.tbxFraseTime.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(154, 441);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 116);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Logo";
            // 
            // btnCadastrarTime
            // 
            this.btnCadastrarTime.Location = new System.Drawing.Point(316, 441);
            this.btnCadastrarTime.Name = "btnCadastrarTime";
            this.btnCadastrarTime.Size = new System.Drawing.Size(116, 50);
            this.btnCadastrarTime.TabIndex = 7;
            this.btnCadastrarTime.Text = "Cadastrar";
            this.btnCadastrarTime.UseVisualStyleBackColor = true;
            this.btnCadastrarTime.Click += new System.EventHandler(this.btnCadastrarTime_Click);
            // 
            // CadastrarTimes
            // 
            this.AcceptButton = this.btnCadastrarTime;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.btnCadastrarTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxFraseTime);
            this.Controls.Add(this.tbxNomeTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CadastrarTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Jogos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastrarTimes_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNomeTime;
        private System.Windows.Forms.TextBox tbxFraseTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarTime;
    }
}