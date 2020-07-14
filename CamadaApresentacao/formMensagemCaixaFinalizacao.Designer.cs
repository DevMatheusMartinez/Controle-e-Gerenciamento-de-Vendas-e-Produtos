namespace CamadaApresentacao
{
    partial class formMensagemCaixaFinalizacao
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
            this.btn_nao = new System.Windows.Forms.Button();
            this.btn_sim = new System.Windows.Forms.Button();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(120, 80);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(183, 28);
            this.btn_OK.TabIndex = 49;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_nao
            // 
            this.btn_nao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nao.ForeColor = System.Drawing.Color.White;
            this.btn_nao.Location = new System.Drawing.Point(239, 80);
            this.btn_nao.Name = "btn_nao";
            this.btn_nao.Size = new System.Drawing.Size(183, 28);
            this.btn_nao.TabIndex = 47;
            this.btn_nao.Text = "NÃO";
            this.btn_nao.UseVisualStyleBackColor = false;
            this.btn_nao.Click += new System.EventHandler(this.btn_nao_Click);
            // 
            // btn_sim
            // 
            this.btn_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sim.ForeColor = System.Drawing.Color.White;
            this.btn_sim.Location = new System.Drawing.Point(12, 80);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(183, 28);
            this.btn_sim.TabIndex = 46;
            this.btn_sim.Text = "SIM";
            this.btn_sim.UseVisualStyleBackColor = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem.Location = new System.Drawing.Point(65, 9);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(309, 29);
            this.lbl_mensagem.TabIndex = 45;
            this.lbl_mensagem.Text = "Deseja finalizar essa venda?";
            this.lbl_mensagem.Click += new System.EventHandler(this.lbl_mensagem_Click);
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.ForeColor = System.Drawing.Color.White;
            this.lbl_ok.Location = new System.Drawing.Point(65, 9);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(328, 29);
            this.lbl_ok.TabIndex = 50;
            this.lbl_ok.Text = "Venda finalizada com sucesso";
            this.lbl_ok.Click += new System.EventHandler(this.lbl_ok_Click);
            // 
            // formMensagemCaixaFinalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 119);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_nao);
            this.Controls.Add(this.btn_sim);
            this.Controls.Add(this.lbl_mensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMensagemCaixaFinalizacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_nao;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Label lbl_ok;
    }
}