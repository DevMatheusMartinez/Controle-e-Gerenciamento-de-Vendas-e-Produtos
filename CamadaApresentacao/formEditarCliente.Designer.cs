namespace CamadaApresentacao
{
    partial class formEditarCliente
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
            this.lbl_mensagem_telefone = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_mensagem_email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lista_de_numeros_telefone = new System.Windows.Forms.ListBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mensagem_endereco = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mensagem_cpf = new System.Windows.Forms.Label();
            this.lbl_mensagem_nome = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mensagem_telefone
            // 
            this.lbl_mensagem_telefone.AutoSize = true;
            this.lbl_mensagem_telefone.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_telefone.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_telefone.Location = new System.Drawing.Point(169, 316);
            this.lbl_mensagem_telefone.Name = "lbl_mensagem_telefone";
            this.lbl_mensagem_telefone.Size = new System.Drawing.Size(83, 13);
            this.lbl_mensagem_telefone.TabIndex = 111;
            this.lbl_mensagem_telefone.Text = "Numero inválido";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtxt_cpf.Location = new System.Drawing.Point(27, 168);
            this.mtxt_cpf.Mask = "999,999,999-99";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(328, 20);
            this.mtxt_cpf.TabIndex = 110;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(172, 282);
            this.txt_numero.Mask = "(99) 00000-0000";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(182, 31);
            this.txt_numero.TabIndex = 109;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(411, 168);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(328, 20);
            this.txt_email.TabIndex = 108;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(411, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 1);
            this.panel4.TabIndex = 107;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(412, 138);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(66, 23);
            this.lbl_email.TabIndex = 106;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_mensagem_email
            // 
            this.lbl_mensagem_email.AutoSize = true;
            this.lbl_mensagem_email.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_email.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_email.Location = new System.Drawing.Point(413, 190);
            this.lbl_mensagem_email.Name = "lbl_mensagem_email";
            this.lbl_mensagem_email.Size = new System.Drawing.Size(71, 13);
            this.lbl_mensagem_email.TabIndex = 105;
            this.lbl_mensagem_email.Text = "Email inválido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(413, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 104;
            this.label6.Text = "Numeros do Cliente:";
            // 
            // lista_de_numeros_telefone
            // 
            this.lista_de_numeros_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_de_numeros_telefone.FormattingEnabled = true;
            this.lista_de_numeros_telefone.ItemHeight = 18;
            this.lista_de_numeros_telefone.Location = new System.Drawing.Point(416, 282);
            this.lista_de_numeros_telefone.Name = "lista_de_numeros_telefone";
            this.lista_de_numeros_telefone.Size = new System.Drawing.Size(323, 148);
            this.lista_de_numeros_telefone.TabIndex = 103;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(27, 282);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(127, 31);
            this.btn_adicionar.TabIndex = 102;
            this.btn_adicionar.Text = "Adicionar Numero";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 101;
            this.label5.Text = "Telefone:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(411, 93);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(328, 20);
            this.txt_endereco.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(411, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 1);
            this.panel3.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "Endereço:";
            // 
            // lbl_mensagem_endereco
            // 
            this.lbl_mensagem_endereco.AutoSize = true;
            this.lbl_mensagem_endereco.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_endereco.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_endereco.Location = new System.Drawing.Point(413, 116);
            this.lbl_mensagem_endereco.Name = "lbl_mensagem_endereco";
            this.lbl_mensagem_endereco.Size = new System.Drawing.Size(92, 13);
            this.lbl_mensagem_endereco.TabIndex = 97;
            this.lbl_mensagem_endereco.Text = "Endereço inválido";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 1);
            this.panel2.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 95;
            this.label2.Text = "CPF:";
            // 
            // lbl_mensagem_cpf
            // 
            this.lbl_mensagem_cpf.AutoSize = true;
            this.lbl_mensagem_cpf.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_cpf.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_cpf.Location = new System.Drawing.Point(29, 191);
            this.lbl_mensagem_cpf.Name = "lbl_mensagem_cpf";
            this.lbl_mensagem_cpf.Size = new System.Drawing.Size(66, 13);
            this.lbl_mensagem_cpf.TabIndex = 94;
            this.lbl_mensagem_cpf.Text = "CPF inválido";
            // 
            // lbl_mensagem_nome
            // 
            this.lbl_mensagem_nome.AutoSize = true;
            this.lbl_mensagem_nome.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_nome.Location = new System.Drawing.Point(29, 116);
            this.lbl_mensagem_nome.Name = "lbl_mensagem_nome";
            this.lbl_mensagem_nome.Size = new System.Drawing.Size(74, 13);
            this.lbl_mensagem_nome.TabIndex = 93;
            this.lbl_mensagem_nome.Text = "Nome inválido";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(215, 399);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(139, 28);
            this.btn_limpar.TabIndex = 92;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(27, 399);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(139, 28);
            this.btn_editar.TabIndex = 91;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(27, 93);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(327, 20);
            this.txt_nome.TabIndex = 90;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 1);
            this.panel1.TabIndex = 89;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(23, 59);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(157, 23);
            this.lbl_usuario.TabIndex = 88;
            this.lbl_usuario.Text = "Nome do Cliente:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(23, 19);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(161, 29);
            this.lbl_titulo.TabIndex = 87;
            this.lbl_titulo.Text = "Editar Cliente";
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(612, 248);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(127, 31);
            this.btn_remover.TabIndex = 112;
            this.btn_remover.Text = "Remover Numero";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // formEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(754, 455);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.lbl_mensagem_telefone);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_mensagem_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lista_de_numeros_telefone);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_mensagem_endereco);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_mensagem_cpf);
            this.Controls.Add(this.lbl_mensagem_nome);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formEditarCliente";
            this.Load += new System.EventHandler(this.formEditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mensagem_telefone;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_numero;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mensagem_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lista_de_numeros_telefone;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mensagem_endereco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mensagem_cpf;
        private System.Windows.Forms.Label lbl_mensagem_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_remover;
    }
}