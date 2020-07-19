namespace CamadaApresentacao
{
    partial class formConfiguracao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.btn_pasta = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_horario = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.checkAnual = new System.Windows.Forms.CheckBox();
            this.checkMensal = new System.Windows.Forms.CheckBox();
            this.checkDiario = new System.Windows.Forms.CheckBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_backup_agora = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_novasenha = new System.Windows.Forms.TextBox();
            this.btn_mudarsenha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_senhaatual = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "CONFIGURAÇÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboMes);
            this.groupBox1.Controls.Add(this.btn_pasta);
            this.groupBox1.Controls.Add(this.btn_confirmar);
            this.groupBox1.Controls.Add(this.txt_horario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_dia);
            this.groupBox1.Controls.Add(this.checkAnual);
            this.groupBox1.Controls.Add(this.checkMensal);
            this.groupBox1.Controls.Add(this.checkDiario);
            this.groupBox1.Controls.Add(this.lbl_usuario);
            this.groupBox1.Controls.Add(this.btn_backup_agora);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 244);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // comboMes
            // 
            this.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Items.AddRange(new object[] {
            "",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto ",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboMes.Location = new System.Drawing.Point(159, 133);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(121, 28);
            this.comboMes.TabIndex = 119;
            this.comboMes.Leave += new System.EventHandler(this.comboMes_Leave);
            // 
            // btn_pasta
            // 
            this.btn_pasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_pasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pasta.ForeColor = System.Drawing.Color.White;
            this.btn_pasta.Location = new System.Drawing.Point(33, 201);
            this.btn_pasta.Name = "btn_pasta";
            this.btn_pasta.Size = new System.Drawing.Size(497, 28);
            this.btn_pasta.TabIndex = 118;
            this.btn_pasta.Text = "Abrir pasta backup";
            this.btn_pasta.UseVisualStyleBackColor = false;
            this.btn_pasta.Click += new System.EventHandler(this.btn_pasta_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(33, 167);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(497, 28);
            this.btn_confirmar.TabIndex = 117;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_horario
            // 
            this.txt_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horario.Location = new System.Drawing.Point(381, 135);
            this.txt_horario.Mask = "90:00";
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.Size = new System.Drawing.Size(50, 26);
            this.txt_horario.TabIndex = 116;
            this.txt_horario.ValidatingType = typeof(System.DateTime);
            this.txt_horario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horario_KeyPress);
            this.txt_horario.Leave += new System.EventHandler(this.txt_horario_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(292, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 115;
            this.label4.Text = "Horario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 113;
            this.label3.Text = "Mês";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 112;
            this.label2.Text = "Dia";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(75, 135);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(27, 26);
            this.txt_dia.TabIndex = 111;
            this.txt_dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dia_KeyPress);
            this.txt_dia.Leave += new System.EventHandler(this.txt_dia_Leave);
            // 
            // checkAnual
            // 
            this.checkAnual.AutoSize = true;
            this.checkAnual.Location = new System.Drawing.Point(193, 94);
            this.checkAnual.Name = "checkAnual";
            this.checkAnual.Size = new System.Drawing.Size(69, 24);
            this.checkAnual.TabIndex = 91;
            this.checkAnual.Text = "Anual";
            this.checkAnual.UseVisualStyleBackColor = true;
            this.checkAnual.CheckedChanged += new System.EventHandler(this.checkAnual_CheckedChanged);
            // 
            // checkMensal
            // 
            this.checkMensal.AutoSize = true;
            this.checkMensal.Location = new System.Drawing.Point(108, 94);
            this.checkMensal.Name = "checkMensal";
            this.checkMensal.Size = new System.Drawing.Size(79, 24);
            this.checkMensal.TabIndex = 90;
            this.checkMensal.Text = "Mensal";
            this.checkMensal.UseVisualStyleBackColor = true;
            this.checkMensal.CheckedChanged += new System.EventHandler(this.checkMensal_CheckedChanged);
            // 
            // checkDiario
            // 
            this.checkDiario.AutoSize = true;
            this.checkDiario.Location = new System.Drawing.Point(33, 94);
            this.checkDiario.Name = "checkDiario";
            this.checkDiario.Size = new System.Drawing.Size(69, 24);
            this.checkDiario.TabIndex = 89;
            this.checkDiario.Text = "Diário";
            this.checkDiario.UseVisualStyleBackColor = true;
            this.checkDiario.CheckedChanged += new System.EventHandler(this.checkDiario_CheckedChanged);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_usuario.Location = new System.Drawing.Point(29, 68);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(245, 23);
            this.lbl_usuario.TabIndex = 88;
            this.lbl_usuario.Text = "Definir backup automatico:";
            // 
            // btn_backup_agora
            // 
            this.btn_backup_agora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backup_agora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_backup_agora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup_agora.ForeColor = System.Drawing.Color.White;
            this.btn_backup_agora.Location = new System.Drawing.Point(33, 25);
            this.btn_backup_agora.Name = "btn_backup_agora";
            this.btn_backup_agora.Size = new System.Drawing.Size(497, 28);
            this.btn_backup_agora.TabIndex = 45;
            this.btn_backup_agora.Text = "Criar backup do sistema agora";
            this.btn_backup_agora.UseVisualStyleBackColor = false;
            this.btn_backup_agora.Click += new System.EventHandler(this.btn_backup_agora_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_novasenha);
            this.groupBox2.Controls.Add(this.btn_mudarsenha);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_senhaatual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(604, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 244);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trocar senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 120;
            this.label5.Text = "Senha nova:";
            // 
            // txt_novasenha
            // 
            this.txt_novasenha.Location = new System.Drawing.Point(24, 118);
            this.txt_novasenha.Name = "txt_novasenha";
            this.txt_novasenha.Size = new System.Drawing.Size(291, 26);
            this.txt_novasenha.TabIndex = 119;
            // 
            // btn_mudarsenha
            // 
            this.btn_mudarsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mudarsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_mudarsenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mudarsenha.ForeColor = System.Drawing.Color.White;
            this.btn_mudarsenha.Location = new System.Drawing.Point(34, 181);
            this.btn_mudarsenha.Name = "btn_mudarsenha";
            this.btn_mudarsenha.Size = new System.Drawing.Size(497, 28);
            this.btn_mudarsenha.TabIndex = 118;
            this.btn_mudarsenha.Text = "Trocar senha";
            this.btn_mudarsenha.UseVisualStyleBackColor = false;
            this.btn_mudarsenha.Click += new System.EventHandler(this.btn_mudarsenha_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 112;
            this.label7.Text = "Senha atual:";
            // 
            // txt_senhaatual
            // 
            this.txt_senhaatual.Location = new System.Drawing.Point(24, 52);
            this.txt_senhaatual.Name = "txt_senhaatual";
            this.txt_senhaatual.Size = new System.Drawing.Size(291, 26);
            this.txt_senhaatual.TabIndex = 111;
            // 
            // formConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConfiguracao";
            this.Text = "formConfiguracao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_backup_agora;
        private System.Windows.Forms.CheckBox checkAnual;
        private System.Windows.Forms.CheckBox checkMensal;
        private System.Windows.Forms.CheckBox checkDiario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Button btn_pasta;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.MaskedTextBox txt_horario;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_novasenha;
        private System.Windows.Forms.Button btn_mudarsenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_senhaatual;
    }
}