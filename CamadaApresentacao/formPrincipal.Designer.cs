namespace CamadaApresentacao
{
    partial class formPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.menu_vertical = new System.Windows.Forms.Panel();
            this.btn_ferramentas = new System.Windows.Forms.Button();
            this.btn_ficha = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_produto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_caixa = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.button_menu = new System.Windows.Forms.PictureBox();
            this.pn_conteudo = new System.Windows.Forms.Panel();
            this.verificadorBackup = new System.Windows.Forms.Timer(this.components);
            this.menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(316, 91);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 13);
            this.lbl_nome.TabIndex = 0;
            // 
            // menu_vertical
            // 
            this.menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.menu_vertical.Controls.Add(this.btn_ferramentas);
            this.menu_vertical.Controls.Add(this.btn_ficha);
            this.menu_vertical.Controls.Add(this.btn_cliente);
            this.menu_vertical.Controls.Add(this.btn_produto);
            this.menu_vertical.Controls.Add(this.pictureBox2);
            this.menu_vertical.Controls.Add(this.pictureBox1);
            this.menu_vertical.Controls.Add(this.btn_caixa);
            this.menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.menu_vertical.Name = "menu_vertical";
            this.menu_vertical.Size = new System.Drawing.Size(61, 1100);
            this.menu_vertical.TabIndex = 1;
            // 
            // btn_ferramentas
            // 
            this.btn_ferramentas.FlatAppearance.BorderSize = 0;
            this.btn_ferramentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_ferramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ferramentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ferramentas.ForeColor = System.Drawing.Color.White;
            this.btn_ferramentas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ferramentas.Image")));
            this.btn_ferramentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ferramentas.Location = new System.Drawing.Point(0, 495);
            this.btn_ferramentas.Name = "btn_ferramentas";
            this.btn_ferramentas.Size = new System.Drawing.Size(228, 95);
            this.btn_ferramentas.TabIndex = 10;
            this.btn_ferramentas.Text = "      Ferramentas";
            this.btn_ferramentas.UseVisualStyleBackColor = true;
            this.btn_ferramentas.Click += new System.EventHandler(this.btn_ferramentas_Click);
            // 
            // btn_ficha
            // 
            this.btn_ficha.FlatAppearance.BorderSize = 0;
            this.btn_ficha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_ficha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ficha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ficha.ForeColor = System.Drawing.Color.White;
            this.btn_ficha.Image = ((System.Drawing.Image)(resources.GetObject("btn_ficha.Image")));
            this.btn_ficha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ficha.Location = new System.Drawing.Point(0, 394);
            this.btn_ficha.Name = "btn_ficha";
            this.btn_ficha.Size = new System.Drawing.Size(228, 95);
            this.btn_ficha.TabIndex = 9;
            this.btn_ficha.Text = "      Ficha";
            this.btn_ficha.UseVisualStyleBackColor = true;
            this.btn_ficha.Click += new System.EventHandler(this.btn_ficha_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(0, 293);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(228, 95);
            this.btn_cliente.TabIndex = 8;
            this.btn_cliente.Text = "      Clientes";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.FlatAppearance.BorderSize = 0;
            this.btn_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.ForeColor = System.Drawing.Color.White;
            this.btn_produto.Image = ((System.Drawing.Image)(resources.GetObject("btn_produto.Image")));
            this.btn_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produto.Location = new System.Drawing.Point(0, 192);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(228, 95);
            this.btn_produto.TabIndex = 7;
            this.btn_produto.Text = "      Produtos";
            this.btn_produto.UseVisualStyleBackColor = true;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 42);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_caixa
            // 
            this.btn_caixa.FlatAppearance.BorderSize = 0;
            this.btn_caixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caixa.ForeColor = System.Drawing.Color.White;
            this.btn_caixa.Image = ((System.Drawing.Image)(resources.GetObject("btn_caixa.Image")));
            this.btn_caixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caixa.Location = new System.Drawing.Point(0, 91);
            this.btn_caixa.Name = "btn_caixa";
            this.btn_caixa.Size = new System.Drawing.Size(228, 95);
            this.btn_caixa.TabIndex = 1;
            this.btn_caixa.Text = "      Compra";
            this.btn_caixa.UseVisualStyleBackColor = true;
            this.btn_caixa.Click += new System.EventHandler(this.btn_caixa_Click);
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.White;
            this.titulo.Controls.Add(this.btn_restaurar);
            this.titulo.Controls.Add(this.btn_minimizar);
            this.titulo.Controls.Add(this.btn_maximizar);
            this.titulo.Controls.Add(this.btn_fechar);
            this.titulo.Controls.Add(this.button_menu);
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Location = new System.Drawing.Point(61, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1523, 50);
            this.titulo.TabIndex = 2;
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(1468, 5);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(20, 20);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 4;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1442, 5);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(20, 20);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 3;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(1468, 5);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(20, 20);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 2;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(1494, 5);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(20, 20);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // button_menu
            // 
            this.button_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu.Image = ((System.Drawing.Image)(resources.GetObject("button_menu.Image")));
            this.button_menu.Location = new System.Drawing.Point(9, 12);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(35, 35);
            this.button_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_menu.TabIndex = 0;
            this.button_menu.TabStop = false;
            this.button_menu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pn_conteudo
            // 
            this.pn_conteudo.BackColor = System.Drawing.Color.White;
            this.pn_conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_conteudo.Location = new System.Drawing.Point(61, 50);
            this.pn_conteudo.Name = "pn_conteudo";
            this.pn_conteudo.Size = new System.Drawing.Size(1523, 1050);
            this.pn_conteudo.TabIndex = 3;
            // 
            // verificadorBackup
            // 
            this.verificadorBackup.Tick += new System.EventHandler(this.verificadorBackup_Tick);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1100);
            this.Controls.Add(this.pn_conteudo);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menu_vertical);
            this.Controls.Add(this.lbl_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPrincipal";
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel menu_vertical;
        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.PictureBox button_menu;
        private System.Windows.Forms.Panel pn_conteudo;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.Button btn_caixa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_ferramentas;
        private System.Windows.Forms.Button btn_ficha;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Timer verificadorBackup;
    }
}