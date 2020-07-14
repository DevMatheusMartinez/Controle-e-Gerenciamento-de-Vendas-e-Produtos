namespace CamadaApresentacao
{
    partial class formMensagemDeletado
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
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.btn_sim = new System.Windows.Forms.Button();
            this.btn_não = new System.Windows.Forms.Button();
            this.lbl_nome_produto = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_sucesso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem.Location = new System.Drawing.Point(63, 9);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(318, 29);
            this.lbl_mensagem.TabIndex = 32;
            this.lbl_mensagem.Text = "Deseja deletar esse produto?";
            // 
            // btn_sim
            // 
            this.btn_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sim.ForeColor = System.Drawing.Color.White;
            this.btn_sim.Location = new System.Drawing.Point(12, 130);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(183, 28);
            this.btn_sim.TabIndex = 39;
            this.btn_sim.Text = "SIM";
            this.btn_sim.UseVisualStyleBackColor = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // btn_não
            // 
            this.btn_não.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_não.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_não.ForeColor = System.Drawing.Color.White;
            this.btn_não.Location = new System.Drawing.Point(239, 130);
            this.btn_não.Name = "btn_não";
            this.btn_não.Size = new System.Drawing.Size(183, 28);
            this.btn_não.TabIndex = 40;
            this.btn_não.Text = "NÃO";
            this.btn_não.UseVisualStyleBackColor = false;
            this.btn_não.Click += new System.EventHandler(this.btn_não_Click);
            // 
            // lbl_nome_produto
            // 
            this.lbl_nome_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_nome_produto.AutoSize = true;
            this.lbl_nome_produto.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_produto.ForeColor = System.Drawing.Color.White;
            this.lbl_nome_produto.Location = new System.Drawing.Point(175, 55);
            this.lbl_nome_produto.Name = "lbl_nome_produto";
            this.lbl_nome_produto.Size = new System.Drawing.Size(78, 23);
            this.lbl_nome_produto.TabIndex = 41;
            this.lbl_nome_produto.Text = "produto";
            this.lbl_nome_produto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(120, 106);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(183, 28);
            this.btn_ok.TabIndex = 42;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_sucesso
            // 
            this.lbl_sucesso.AutoSize = true;
            this.lbl_sucesso.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucesso.ForeColor = System.Drawing.Color.White;
            this.lbl_sucesso.Location = new System.Drawing.Point(48, 49);
            this.lbl_sucesso.Name = "lbl_sucesso";
            this.lbl_sucesso.Size = new System.Drawing.Size(335, 29);
            this.lbl_sucesso.TabIndex = 43;
            this.lbl_sucesso.Text = "Produto deletado com sucesso";
            // 
            // formMensagemDeletado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 170);
            this.Controls.Add(this.lbl_sucesso);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_não);
            this.Controls.Add(this.btn_sim);
            this.Controls.Add(this.lbl_mensagem);
            this.Controls.Add(this.lbl_nome_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMensagemDeletado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Button btn_não;
        private System.Windows.Forms.Label lbl_nome_produto;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_sucesso;
    }
}