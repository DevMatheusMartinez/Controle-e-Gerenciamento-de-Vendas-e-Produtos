namespace CamadaApresentacao
{
    partial class formCadastroAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroAdministrador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.lbl_mensagem_login = new System.Windows.Forms.Label();
            this.lbl_mensagem_senha = new System.Windows.Forms.Label();
            this.lbl_mensagem_incorreta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(518, 61);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(73, 29);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(518, 101);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(164, 23);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Nome de Usuario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(522, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 1);
            this.panel1.TabIndex = 4;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(522, 135);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(387, 20);
            this.txt_login.TabIndex = 5;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(522, 202);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(387, 20);
            this.txt_senha.TabIndex = 8;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(522, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 1);
            this.panel2.TabIndex = 7;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_senha.Location = new System.Drawing.Point(518, 168);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(68, 23);
            this.lbl_senha.TabIndex = 6;
            this.lbl_senha.Text = "Senha:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(522, 249);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(183, 28);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Logar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(523, 444);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(386, 28);
            this.btn_cadastrar.TabIndex = 10;
            this.btn_cadastrar.Text = "Ir para tela de Cadastro";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(726, 249);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(183, 28);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.AutoSize = true;
            this.lbl_pergunta.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergunta.ForeColor = System.Drawing.Color.White;
            this.lbl_pergunta.Location = new System.Drawing.Point(520, 425);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(154, 16);
            this.lbl_pergunta.TabIndex = 12;
            this.lbl_pergunta.Text = "Não possui uma conta?:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(900, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(28, 22);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 31;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(866, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(28, 22);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 32;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // lbl_mensagem_login
            // 
            this.lbl_mensagem_login.AutoSize = true;
            this.lbl_mensagem_login.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_login.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_login.Location = new System.Drawing.Point(522, 159);
            this.lbl_mensagem_login.Name = "lbl_mensagem_login";
            this.lbl_mensagem_login.Size = new System.Drawing.Size(79, 13);
            this.lbl_mensagem_login.TabIndex = 43;
            this.lbl_mensagem_login.Text = "Digite seu login";
            // 
            // lbl_mensagem_senha
            // 
            this.lbl_mensagem_senha.AutoSize = true;
            this.lbl_mensagem_senha.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_senha.Location = new System.Drawing.Point(522, 225);
            this.lbl_mensagem_senha.Name = "lbl_mensagem_senha";
            this.lbl_mensagem_senha.Size = new System.Drawing.Size(86, 13);
            this.lbl_mensagem_senha.TabIndex = 44;
            this.lbl_mensagem_senha.Text = "Digite sua senha";
            // 
            // lbl_mensagem_incorreta
            // 
            this.lbl_mensagem_incorreta.AutoSize = true;
            this.lbl_mensagem_incorreta.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_incorreta.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_incorreta.Location = new System.Drawing.Point(520, 280);
            this.lbl_mensagem_incorreta.Name = "lbl_mensagem_incorreta";
            this.lbl_mensagem_incorreta.Size = new System.Drawing.Size(124, 13);
            this.lbl_mensagem_incorreta.TabIndex = 45;
            this.lbl_mensagem_incorreta.Text = "Login ou senha incorreta";
            // 
            // formCadastroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(933, 501);
            this.Controls.Add(this.lbl_mensagem_incorreta);
            this.Controls.Add(this.lbl_mensagem_senha);
            this.Controls.Add(this.lbl_mensagem_login);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lbl_pergunta);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCadastroAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.formCadastroAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label lbl_mensagem_login;
        private System.Windows.Forms.Label lbl_mensagem_senha;
        private System.Windows.Forms.Label lbl_mensagem_incorreta;
    }
}