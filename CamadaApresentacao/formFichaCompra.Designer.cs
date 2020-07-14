namespace CamadaApresentacao
{
    partial class formFichaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_lista_telefone = new System.Windows.Forms.Button();
            this.lista_produtos_comprados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_situacao2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_data_compra = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_vencimento = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.psituacao = new System.Windows.Forms.Panel();
            this.lbl_situacao = new System.Windows.Forms.Label();
            this.lbl_forma = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_pagamento = new System.Windows.Forms.ComboBox();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_valortotal = new System.Windows.Forms.Label();
            this.verificador = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lista_produtos_comprados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.psituacao.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Enabled = false;
            this.mtxt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtxt_cpf.Location = new System.Drawing.Point(583, 64);
            this.mtxt_cpf.Mask = "999,999,999-99";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(94, 20);
            this.mtxt_cpf.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(526, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 94;
            this.label2.Text = "CPF:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(19, 59);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(157, 23);
            this.lbl_usuario.TabIndex = 87;
            this.lbl_usuario.Text = "Nome do Cliente:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(391, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(107, 36);
            this.lbl_titulo.TabIndex = 86;
            this.lbl_titulo.Text = "FICHA 1";
            // 
            // btn_lista_telefone
            // 
            this.btn_lista_telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_lista_telefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lista_telefone.ForeColor = System.Drawing.Color.White;
            this.btn_lista_telefone.Location = new System.Drawing.Point(704, 62);
            this.btn_lista_telefone.Name = "btn_lista_telefone";
            this.btn_lista_telefone.Size = new System.Drawing.Size(132, 23);
            this.btn_lista_telefone.TabIndex = 110;
            this.btn_lista_telefone.Text = "Lista de telefones:";
            this.btn_lista_telefone.UseVisualStyleBackColor = false;
            this.btn_lista_telefone.Click += new System.EventHandler(this.btn_lista_telefone_Click);
            // 
            // lista_produtos_comprados
            // 
            this.lista_produtos_comprados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_produtos_comprados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lista_produtos_comprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_produtos_comprados.DefaultCellStyle = dataGridViewCellStyle2;
            this.lista_produtos_comprados.Location = new System.Drawing.Point(17, 193);
            this.lista_produtos_comprados.Name = "lista_produtos_comprados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_produtos_comprados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lista_produtos_comprados.RowTemplate.Height = 25;
            this.lista_produtos_comprados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_produtos_comprados.Size = new System.Drawing.Size(835, 361);
            this.lista_produtos_comprados.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 112;
            this.label1.Text = "Data da Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(275, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 114;
            this.label3.Text = "Data do Vencimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(563, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 116;
            this.label4.Text = "Data do pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 23);
            this.label5.TabIndex = 118;
            this.label5.Text = "Lista de produtos comprados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(696, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 120;
            this.label6.Text = "Troco:";
            // 
            // lbl_situacao2
            // 
            this.lbl_situacao2.AutoSize = true;
            this.lbl_situacao2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao2.ForeColor = System.Drawing.Color.White;
            this.lbl_situacao2.Location = new System.Drawing.Point(19, 561);
            this.lbl_situacao2.Name = "lbl_situacao2";
            this.lbl_situacao2.Size = new System.Drawing.Size(186, 23);
            this.lbl_situacao2.TabIndex = 121;
            this.lbl_situacao2.Text = "Situação da compra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 123;
            this.label8.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(520, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 125;
            this.label9.Text = "Email:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(3, 3);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 13);
            this.lbl_nome.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Location = new System.Drawing.Point(182, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 20);
            this.panel1.TabIndex = 128;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_data_compra);
            this.panel2.Location = new System.Drawing.Point(182, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 25);
            this.panel2.TabIndex = 129;
            // 
            // lbl_data_compra
            // 
            this.lbl_data_compra.AutoSize = true;
            this.lbl_data_compra.BackColor = System.Drawing.Color.White;
            this.lbl_data_compra.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_compra.Location = new System.Drawing.Point(3, 3);
            this.lbl_data_compra.Name = "lbl_data_compra";
            this.lbl_data_compra.Size = new System.Drawing.Size(71, 20);
            this.lbl_data_compra.TabIndex = 127;
            this.lbl_data_compra.Text = "12/03/1999";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbl_vencimento);
            this.panel3.Location = new System.Drawing.Point(470, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(87, 25);
            this.panel3.TabIndex = 130;
            // 
            // lbl_vencimento
            // 
            this.lbl_vencimento.AutoSize = true;
            this.lbl_vencimento.BackColor = System.Drawing.Color.White;
            this.lbl_vencimento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vencimento.Location = new System.Drawing.Point(3, 3);
            this.lbl_vencimento.Name = "lbl_vencimento";
            this.lbl_vencimento.Size = new System.Drawing.Size(71, 20);
            this.lbl_vencimento.TabIndex = 127;
            this.lbl_vencimento.Text = "12/03/1999";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbl_pagamento);
            this.panel4.Location = new System.Drawing.Point(749, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 25);
            this.panel4.TabIndex = 131;
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.BackColor = System.Drawing.Color.White;
            this.lbl_pagamento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagamento.Location = new System.Drawing.Point(3, 3);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(71, 20);
            this.lbl_pagamento.TabIndex = 127;
            this.lbl_pagamento.Text = "12/03/1999";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbl_endereco);
            this.panel5.Location = new System.Drawing.Point(182, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 20);
            this.panel5.TabIndex = 129;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.BackColor = System.Drawing.Color.White;
            this.lbl_endereco.Location = new System.Drawing.Point(3, 3);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(0, 13);
            this.lbl_endereco.TabIndex = 127;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lbl_email);
            this.panel6.Location = new System.Drawing.Point(592, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 20);
            this.panel6.TabIndex = 130;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(3, 3);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 13);
            this.lbl_email.TabIndex = 127;
            // 
            // psituacao
            // 
            this.psituacao.BackColor = System.Drawing.Color.White;
            this.psituacao.Controls.Add(this.lbl_situacao);
            this.psituacao.Location = new System.Drawing.Point(211, 560);
            this.psituacao.Name = "psituacao";
            this.psituacao.Size = new System.Drawing.Size(82, 29);
            this.psituacao.TabIndex = 130;
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.AutoSize = true;
            this.lbl_situacao.BackColor = System.Drawing.Color.White;
            this.lbl_situacao.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao.Location = new System.Drawing.Point(-3, 4);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(88, 25);
            this.lbl_situacao.TabIndex = 127;
            this.lbl_situacao.Text = "Pendente";
            // 
            // lbl_forma
            // 
            this.lbl_forma.AutoSize = true;
            this.lbl_forma.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forma.ForeColor = System.Drawing.Color.White;
            this.lbl_forma.Location = new System.Drawing.Point(311, 561);
            this.lbl_forma.Name = "lbl_forma";
            this.lbl_forma.Size = new System.Drawing.Size(197, 23);
            this.lbl_forma.TabIndex = 132;
            this.lbl_forma.Text = "Forma de pagamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(670, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 133;
            this.label7.Text = "Dinheiro:";
            // 
            // txt_dinheiro
            // 
            this.txt_dinheiro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinheiro.Location = new System.Drawing.Point(783, 560);
            this.txt_dinheiro.Name = "txt_dinheiro";
            this.txt_dinheiro.Size = new System.Drawing.Size(69, 26);
            this.txt_dinheiro.TabIndex = 134;
            this.txt_dinheiro.Text = "0,00";
            this.txt_dinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dinheiro_KeyPress);
            this.txt_dinheiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dinheiro_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(655, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 135;
            this.label11.Text = "Valor total:";
            // 
            // combo_pagamento
            // 
            this.combo_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pagamento.FormattingEnabled = true;
            this.combo_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Crédito",
            "Débito"});
            this.combo_pagamento.Location = new System.Drawing.Point(514, 566);
            this.combo_pagamento.Name = "combo_pagamento";
            this.combo_pagamento.Size = new System.Drawing.Size(121, 21);
            this.combo_pagamento.TabIndex = 138;
            this.combo_pagamento.SelectedIndexChanged += new System.EventHandler(this.combo_pagamento_SelectedIndexChanged);
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.ForeColor = System.Drawing.Color.White;
            this.btn_pagar.Location = new System.Drawing.Point(18, 606);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(302, 28);
            this.btn_pagar.TabIndex = 139;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(333, 606);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(302, 28);
            this.btn_sair.TabIndex = 140;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lbl_troco);
            this.panel7.Location = new System.Drawing.Point(783, 589);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(69, 26);
            this.panel7.TabIndex = 130;
            // 
            // lbl_troco
            // 
            this.lbl_troco.AutoSize = true;
            this.lbl_troco.BackColor = System.Drawing.Color.White;
            this.lbl_troco.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbl_troco.Location = new System.Drawing.Point(-1, 4);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Size = new System.Drawing.Size(38, 20);
            this.lbl_troco.TabIndex = 127;
            this.lbl_troco.Text = " 0,00";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lbl_valortotal);
            this.panel8.Location = new System.Drawing.Point(782, 617);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(70, 26);
            this.panel8.TabIndex = 137;
            // 
            // lbl_valortotal
            // 
            this.lbl_valortotal.AutoSize = true;
            this.lbl_valortotal.BackColor = System.Drawing.Color.White;
            this.lbl_valortotal.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbl_valortotal.Location = new System.Drawing.Point(-1, 4);
            this.lbl_valortotal.Name = "lbl_valortotal";
            this.lbl_valortotal.Size = new System.Drawing.Size(34, 20);
            this.lbl_valortotal.TabIndex = 127;
            this.lbl_valortotal.Text = "0,00";
            // 
            // verificador
            // 
            this.verificador.Tick += new System.EventHandler(this.verificador_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(759, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 14);
            this.label10.TabIndex = 141;
            this.label10.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(759, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 14);
            this.label12.TabIndex = 142;
            this.label12.Text = "R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(759, 623);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 14);
            this.label13.TabIndex = 143;
            this.label13.Text = "R$";
            // 
            // formFichaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(862, 651);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.combo_pagamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_dinheiro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_forma);
            this.Controls.Add(this.psituacao);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_situacao2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_produtos_comprados);
            this.Controls.Add(this.btn_lista_telefone);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formFichaCompra";
            this.Load += new System.EventHandler(this.formFichaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_produtos_comprados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.psituacao.ResumeLayout(false);
            this.psituacao.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_lista_telefone;
        private System.Windows.Forms.DataGridView lista_produtos_comprados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_situacao2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_data_compra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_vencimento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_pagamento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel psituacao;
        private System.Windows.Forms.Label lbl_situacao;
        private System.Windows.Forms.Label lbl_forma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_pagamento;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_valortotal;
        private System.Windows.Forms.Timer verificador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}