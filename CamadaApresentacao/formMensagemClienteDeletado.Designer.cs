namespace CamadaApresentacao
{
    partial class formMensagemClienteDeletado
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
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.btn_sim = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_confirmado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.ForeColor = System.Drawing.Color.White;
            this.lbl_ok.Location = new System.Drawing.Point(38, 9);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(301, 29);
            this.lbl_ok.TabIndex = 51;
            this.lbl_ok.Text = "Deseja deletar este cliente?";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_cliente.Location = new System.Drawing.Point(121, 53);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(121, 29);
            this.lbl_cliente.TabIndex = 52;
            this.lbl_cliente.Text = "lbl Cliente";
            this.lbl_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_sim
            // 
            this.btn_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sim.ForeColor = System.Drawing.Color.White;
            this.btn_sim.Location = new System.Drawing.Point(64, 95);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(105, 28);
            this.btn_sim.TabIndex = 53;
            this.btn_sim.Text = "SIM";
            this.btn_sim.UseVisualStyleBackColor = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(134, 53);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(105, 28);
            this.btn_ok.TabIndex = 54;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(208, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 55;
            this.button2.Text = "NÃO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_confirmado
            // 
            this.lbl_confirmado.AutoSize = true;
            this.lbl_confirmado.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmado.ForeColor = System.Drawing.Color.White;
            this.lbl_confirmado.Location = new System.Drawing.Point(29, 9);
            this.lbl_confirmado.Name = "lbl_confirmado";
            this.lbl_confirmado.Size = new System.Drawing.Size(323, 29);
            this.lbl_confirmado.TabIndex = 56;
            this.lbl_confirmado.Text = "Cliente deletado com sucesso";
            // 
            // formMensagemClienteDeletado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(373, 135);
            this.Controls.Add(this.lbl_confirmado);
            this.Controls.Add(this.btn_sim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_ok);
            this.Name = "formMensagemClienteDeletado";
            this.Text = "formMensagemClienteDeletado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_confirmado;
    }
}