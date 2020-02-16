namespace Ilovecode.ProtegerAppConfig
{
    partial class Form1
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
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnObterConexao = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(12, 12);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(118, 67);
            this.btnCriptografar.TabIndex = 0;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.BtnCriptografar_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Location = new System.Drawing.Point(154, 10);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(145, 71);
            this.btnDescriptografar.TabIndex = 1;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.BtnDescriptografar_Click);
            // 
            // btnObterConexao
            // 
            this.btnObterConexao.Location = new System.Drawing.Point(323, 12);
            this.btnObterConexao.Name = "btnObterConexao";
            this.btnObterConexao.Size = new System.Drawing.Size(147, 69);
            this.btnObterConexao.TabIndex = 2;
            this.btnObterConexao.Text = "ObterConexao";
            this.btnObterConexao.UseVisualStyleBackColor = true;
            this.btnObterConexao.Click += new System.EventHandler(this.BtnObterConexao_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 103);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(46, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 157);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnObterConexao);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnCriptografar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnObterConexao;
        private System.Windows.Forms.Label lblResultado;
    }
}

