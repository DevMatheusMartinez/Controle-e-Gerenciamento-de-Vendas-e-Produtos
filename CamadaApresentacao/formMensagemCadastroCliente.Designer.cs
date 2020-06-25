namespace CamadaApresentacao
{
    partial class formMensagemCadastroCliente
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.lbl_mensagem2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(116, 70);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(183, 28);
            this.btn_OK.TabIndex = 49;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem.Location = new System.Drawing.Point(31, 9);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(347, 29);
            this.lbl_mensagem.TabIndex = 45;
            this.lbl_mensagem.Text = "Cliente cadastrado com sucesso";
            // 
            // lbl_mensagem2
            // 
            this.lbl_mensagem2.AutoSize = true;
            this.lbl_mensagem2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem2.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem2.Location = new System.Drawing.Point(52, 9);
            this.lbl_mensagem2.Name = "lbl_mensagem2";
            this.lbl_mensagem2.Size = new System.Drawing.Size(311, 29);
            this.lbl_mensagem2.TabIndex = 50;
            this.lbl_mensagem2.Text = "Cliente editado com sucesso";
            // 
            // formMensagemCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(416, 124);
            this.Controls.Add(this.lbl_mensagem2);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_mensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMensagemCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Label lbl_mensagem2;
    }
}