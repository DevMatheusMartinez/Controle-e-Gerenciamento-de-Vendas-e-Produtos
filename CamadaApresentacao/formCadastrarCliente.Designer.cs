namespace CamadaApresentacao
{
    partial class formCadastrarCliente
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
            this.lbl_mensagem_nome = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_mensagem_cpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mensagem_endereco = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lista_de_numeros_telefone = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_mensagem_email = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_mensagem_nome
            // 
            this.lbl_mensagem_nome.AutoSize = true;
            this.lbl_mensagem_nome.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_nome.Location = new System.Drawing.Point(29, 120);
            this.lbl_mensagem_nome.Name = "lbl_mensagem_nome";
            this.lbl_mensagem_nome.Size = new System.Drawing.Size(74, 13);
            this.lbl_mensagem_nome.TabIndex = 64;
            this.lbl_mensagem_nome.Text = "Nome inválido";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(215, 403);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(139, 28);
            this.btn_limpar.TabIndex = 59;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(27, 403);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(139, 28);
            this.btn_cadastrar.TabIndex = 49;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(27, 97);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(327, 20);
            this.txt_nome.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 1);
            this.panel1.TabIndex = 45;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(23, 63);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(157, 23);
            this.lbl_usuario.TabIndex = 44;
            this.lbl_usuario.Text = "Nome do Cliente:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(23, 23);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(197, 29);
            this.lbl_titulo.TabIndex = 43;
            this.lbl_titulo.Text = "Cadastrar Cliente";
            // 
            // lbl_mensagem_cpf
            // 
            this.lbl_mensagem_cpf.AutoSize = true;
            this.lbl_mensagem_cpf.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_cpf.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_cpf.Location = new System.Drawing.Point(29, 195);
            this.lbl_mensagem_cpf.Name = "lbl_mensagem_cpf";
            this.lbl_mensagem_cpf.Size = new System.Drawing.Size(66, 13);
            this.lbl_mensagem_cpf.TabIndex = 67;
            this.lbl_mensagem_cpf.Text = "CPF inválido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "CPF:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 1);
            this.panel2.TabIndex = 69;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(411, 97);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(328, 20);
            this.txt_endereco.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(411, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 1);
            this.panel3.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Endereço:";
            // 
            // lbl_mensagem_endereco
            // 
            this.lbl_mensagem_endereco.AutoSize = true;
            this.lbl_mensagem_endereco.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_endereco.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_endereco.Location = new System.Drawing.Point(413, 120);
            this.lbl_mensagem_endereco.Name = "lbl_mensagem_endereco";
            this.lbl_mensagem_endereco.Size = new System.Drawing.Size(92, 13);
            this.lbl_mensagem_endereco.TabIndex = 71;
            this.lbl_mensagem_endereco.Text = "Endereço inválido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 76;
            this.label5.Text = "Telefone:";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(27, 286);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(127, 31);
            this.btn_adicionar.TabIndex = 77;
            this.btn_adicionar.Text = "Adicionar Numero";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lista_de_numeros_telefone
            // 
            this.lista_de_numeros_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_de_numeros_telefone.FormattingEnabled = true;
            this.lista_de_numeros_telefone.ItemHeight = 18;
            this.lista_de_numeros_telefone.Location = new System.Drawing.Point(416, 286);
            this.lista_de_numeros_telefone.Name = "lista_de_numeros_telefone";
            this.lista_de_numeros_telefone.Size = new System.Drawing.Size(323, 148);
            this.lista_de_numeros_telefone.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(413, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Numeros do Cliente:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(411, 172);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(328, 20);
            this.txt_email.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(411, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 1);
            this.panel4.TabIndex = 82;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(412, 142);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(66, 23);
            this.lbl_email.TabIndex = 81;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_mensagem_email
            // 
            this.lbl_mensagem_email.AutoSize = true;
            this.lbl_mensagem_email.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_email.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_email.Location = new System.Drawing.Point(413, 194);
            this.lbl_mensagem_email.Name = "lbl_mensagem_email";
            this.lbl_mensagem_email.Size = new System.Drawing.Size(71, 13);
            this.lbl_mensagem_email.TabIndex = 80;
            this.lbl_mensagem_email.Text = "Email inválido";
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(172, 286);
            this.txt_numero.Mask = "(99) 00000-0000";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(182, 31);
            this.txt_numero.TabIndex = 84;
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtxt_cpf.Location = new System.Drawing.Point(27, 172);
            this.mtxt_cpf.Mask = "999,999,999-99";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(328, 20);
            this.mtxt_cpf.TabIndex = 85;
            // 
            // formCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(754, 459);
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
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "formCadastrarCliente";
            this.Text = "formCadastrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_mensagem_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_mensagem_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mensagem_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ListBox lista_de_numeros_telefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mensagem_email;
        private System.Windows.Forms.MaskedTextBox txt_numero;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
    }
}