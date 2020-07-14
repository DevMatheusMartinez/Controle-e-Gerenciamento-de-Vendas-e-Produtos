namespace CamadaApresentacao
{
    partial class formEditarProduto
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
            this.lbl_mensagem_preco = new System.Windows.Forms.Label();
            this.lbl_mensagem_nome = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.btn_marca = new System.Windows.Forms.Button();
            this.btn_categoria = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.quantidade_num = new System.Windows.Forms.NumericUpDown();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_num)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mensagem_preco
            // 
            this.lbl_mensagem_preco.AutoSize = true;
            this.lbl_mensagem_preco.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_preco.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_preco.Location = new System.Drawing.Point(29, 388);
            this.lbl_mensagem_preco.Name = "lbl_mensagem_preco";
            this.lbl_mensagem_preco.Size = new System.Drawing.Size(127, 13);
            this.lbl_mensagem_preco.TabIndex = 65;
            this.lbl_mensagem_preco.Text = "Digite o preço do produto";
            // 
            // lbl_mensagem_nome
            // 
            this.lbl_mensagem_nome.AutoSize = true;
            this.lbl_mensagem_nome.BackColor = System.Drawing.Color.Maroon;
            this.lbl_mensagem_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem_nome.Location = new System.Drawing.Point(29, 124);
            this.lbl_mensagem_nome.Name = "lbl_mensagem_nome";
            this.lbl_mensagem_nome.Size = new System.Drawing.Size(126, 13);
            this.lbl_mensagem_nome.TabIndex = 64;
            this.lbl_mensagem_nome.Text = "Digite o nome do produto";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(123, 272);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(183, 28);
            this.btn_ok.TabIndex = 63;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.Color.White;
            this.lbl_mensagem.Location = new System.Drawing.Point(75, 190);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(127, 29);
            this.lbl_mensagem.TabIndex = 62;
            this.lbl_mensagem.Text = "mensagem";
            this.lbl_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mensagem.Visible = false;
            // 
            // btn_marca
            // 
            this.btn_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marca.ForeColor = System.Drawing.Color.White;
            this.btn_marca.Location = new System.Drawing.Point(307, 236);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(94, 24);
            this.btn_marca.TabIndex = 61;
            this.btn_marca.Text = "Nova Marca";
            this.btn_marca.UseVisualStyleBackColor = false;
            this.btn_marca.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // btn_categoria
            // 
            this.btn_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_categoria.Location = new System.Drawing.Point(307, 167);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.Size = new System.Drawing.Size(94, 24);
            this.btn_categoria.TabIndex = 60;
            this.btn_categoria.Text = "Nova Categoria";
            this.btn_categoria.UseVisualStyleBackColor = false;
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(239, 427);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(162, 28);
            this.btn_limpar.TabIndex = 59;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.ForeColor = System.Drawing.Color.White;
            this.lbl_preco.Location = new System.Drawing.Point(23, 336);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(64, 23);
            this.lbl_preco.TabIndex = 58;
            this.lbl_preco.Text = "Preço:";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(28, 362);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(119, 20);
            this.txt_preco.TabIndex = 57;
            this.txt_preco.TextChanged += new System.EventHandler(this.txt_preco_TextChanged);
            this.txt_preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_preco_KeyPress);
            this.txt_preco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_preco_KeyUp);
            this.txt_preco.Leave += new System.EventHandler(this.txt_preco_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(28, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 1);
            this.panel4.TabIndex = 56;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.ForeColor = System.Drawing.Color.White;
            this.lbl_quantidade.Location = new System.Drawing.Point(24, 277);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(220, 23);
            this.lbl_quantidade.TabIndex = 55;
            this.lbl_quantidade.Text = "Quantidade em Estoque:";
            // 
            // quantidade_num
            // 
            this.quantidade_num.Location = new System.Drawing.Point(28, 303);
            this.quantidade_num.Name = "quantidade_num";
            this.quantidade_num.Size = new System.Drawing.Size(68, 20);
            this.quantidade_num.TabIndex = 54;
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(28, 236);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(262, 21);
            this.comboMarca.TabIndex = 53;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.comboMarca_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(28, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 1);
            this.panel3.TabIndex = 52;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.Color.White;
            this.lbl_marca.Location = new System.Drawing.Point(24, 203);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(71, 23);
            this.lbl_marca.TabIndex = 51;
            this.lbl_marca.Text = "Marca:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "teste",
            "nome",
            "sei la",
            "maca"});
            this.comboCategoria.Location = new System.Drawing.Point(27, 167);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(262, 21);
            this.comboCategoria.TabIndex = 50;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(27, 427);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(162, 28);
            this.btn_editar.TabIndex = 49;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 1);
            this.panel2.TabIndex = 48;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_categoria.Location = new System.Drawing.Point(23, 134);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(98, 23);
            this.lbl_categoria.TabIndex = 47;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(27, 101);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(374, 20);
            this.txt_nome.TabIndex = 46;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 1);
            this.panel1.TabIndex = 45;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(23, 67);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(167, 23);
            this.lbl_usuario.TabIndex = 44;
            this.lbl_usuario.Text = "Nome do Produto:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(23, 27);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(173, 29);
            this.lbl_titulo.TabIndex = 43;
            this.lbl_titulo.Text = "Editar Produto";
            // 
            // formEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(432, 486);
            this.Controls.Add(this.lbl_mensagem_preco);
            this.Controls.Add(this.lbl_mensagem_nome);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_mensagem);
            this.Controls.Add(this.btn_marca);
            this.Controls.Add(this.btn_categoria);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.quantidade_num);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formEditarProduto";
            this.Text = "Editar Produto";
            this.Load += new System.EventHandler(this.formEditarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mensagem_preco;
        private System.Windows.Forms.Label lbl_mensagem_nome;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Button btn_marca;
        private System.Windows.Forms.Button btn_categoria;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.NumericUpDown quantidade_num;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_titulo;
    }
}