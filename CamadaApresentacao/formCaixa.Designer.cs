namespace CamadaApresentacao
{
    partial class formCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lista_produtos = new System.Windows.Forms.DataGridView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lista_carrinho = new System.Windows.Forms.DataGridView();
            this.num_quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_itens = new System.Windows.Forms.Label();
            this.lbl_quantidade_itens = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lbl_caixa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_vencimento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_valor_total_da_venda = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_itens = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hora_pedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_data_pedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numerovenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timerdatahora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lista_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista_produtos
            // 
            this.lista_produtos.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lista_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.lista_produtos.Location = new System.Drawing.Point(12, 127);
            this.lista_produtos.Name = "lista_produtos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lista_produtos.RowTemplate.Height = 25;
            this.lista_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_produtos.Size = new System.Drawing.Size(1061, 351);
            this.lista_produtos.TabIndex = 1;
            this.lista_produtos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_produtos_CellEnter);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(241, 481);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(138, 23);
            this.btn_adicionar.TabIndex = 40;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lista_carrinho
            // 
            this.lista_carrinho.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_carrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lista_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_carrinho.DefaultCellStyle = dataGridViewCellStyle5;
            this.lista_carrinho.Location = new System.Drawing.Point(12, 574);
            this.lista_carrinho.Name = "lista_carrinho";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_carrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.lista_carrinho.RowTemplate.Height = 25;
            this.lista_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_carrinho.Size = new System.Drawing.Size(1061, 351);
            this.lista_carrinho.TabIndex = 41;
            this.lista_carrinho.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_carrinho_CellEnter);
            this.lista_carrinho.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lista_carrinho_CellMouseClick);
            // 
            // num_quantidade
            // 
            this.num_quantidade.Location = new System.Drawing.Point(147, 484);
            this.num_quantidade.Name = "num_quantidade";
            this.num_quantidade.Size = new System.Drawing.Size(88, 20);
            this.num_quantidade.TabIndex = 43;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantidade.Location = new System.Drawing.Point(25, 481);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(116, 23);
            this.lbl_quantidade.TabIndex = 56;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(12, 928);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(151, 23);
            this.btn_remove.TabIndex = 58;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_buscar.Location = new System.Drawing.Point(12, 95);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(1061, 26);
            this.txt_buscar.TabIndex = 59;
            this.txt_buscar.Text = "Buscar...";
            this.txt_buscar.Click += new System.EventHandler(this.txt_buscar_Click);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(515, 929);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(128, 22);
            this.lbl_total.TabIndex = 57;
            this.lbl_total.Text = "Total: R$ 0,00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_itens
            // 
            this.lbl_itens.AutoSize = true;
            this.lbl_itens.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens.Location = new System.Drawing.Point(181, 929);
            this.lbl_itens.Name = "lbl_itens";
            this.lbl_itens.Size = new System.Drawing.Size(73, 22);
            this.lbl_itens.TabIndex = 60;
            this.lbl_itens.Text = "Itens: 0";
            this.lbl_itens.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_quantidade_itens
            // 
            this.lbl_quantidade_itens.AutoSize = true;
            this.lbl_quantidade_itens.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade_itens.Location = new System.Drawing.Point(301, 929);
            this.lbl_quantidade_itens.Name = "lbl_quantidade_itens";
            this.lbl_quantidade_itens.Size = new System.Drawing.Size(128, 22);
            this.lbl_quantidade_itens.TabIndex = 61;
            this.lbl_quantidade_itens.Text = "Quantidade: 0";
            this.lbl_quantidade_itens.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Location = new System.Drawing.Point(385, 481);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(138, 23);
            this.btn_novo.TabIndex = 64;
            this.btn_novo.Text = "Novo produto";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // lbl_caixa
            // 
            this.lbl_caixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_caixa.AutoSize = true;
            this.lbl_caixa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caixa.Location = new System.Drawing.Point(692, -36);
            this.lbl_caixa.Name = "lbl_caixa";
            this.lbl_caixa.Size = new System.Drawing.Size(69, 22);
            this.lbl_caixa.TabIndex = 3;
            this.lbl_caixa.Text = "CAIXA";
            this.lbl_caixa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_vencimento);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_valor_total_da_venda);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(this.txt_itens);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_hora_pedido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_data_pedido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_numerovenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboCliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1103, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 360);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficha";
            // 
            // txt_vencimento
            // 
            this.txt_vencimento.Location = new System.Drawing.Point(224, 211);
            this.txt_vencimento.Name = "txt_vencimento";
            this.txt_vencimento.Size = new System.Drawing.Size(85, 26);
            this.txt_vencimento.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "Vencimento da Ficha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Valor Total:";
            // 
            // lbl_valor_total_da_venda
            // 
            this.lbl_valor_total_da_venda.AutoSize = true;
            this.lbl_valor_total_da_venda.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_total_da_venda.Location = new System.Drawing.Point(19, 274);
            this.lbl_valor_total_da_venda.Name = "lbl_valor_total_da_venda";
            this.lbl_valor_total_da_venda.Size = new System.Drawing.Size(256, 72);
            this.lbl_valor_total_da_venda.TabIndex = 66;
            this.lbl_valor_total_da_venda.Text = "R$ 0,00";
            this.lbl_valor_total_da_venda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(267, 180);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(54, 26);
            this.txt_quantidade.TabIndex = 12;
            this.txt_quantidade.Text = "0";
            // 
            // txt_itens
            // 
            this.txt_itens.Location = new System.Drawing.Point(207, 180);
            this.txt_itens.Name = "txt_itens";
            this.txt_itens.Size = new System.Drawing.Size(54, 26);
            this.txt_itens.TabIndex = 11;
            this.txt_itens.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nº Itens/Quantidade:";
            // 
            // txt_hora_pedido
            // 
            this.txt_hora_pedido.Location = new System.Drawing.Point(299, 149);
            this.txt_hora_pedido.Name = "txt_hora_pedido";
            this.txt_hora_pedido.Size = new System.Drawing.Size(71, 26);
            this.txt_hora_pedido.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hora:";
            // 
            // txt_data_pedido
            // 
            this.txt_data_pedido.Location = new System.Drawing.Point(144, 148);
            this.txt_data_pedido.Name = "txt_data_pedido";
            this.txt_data_pedido.Size = new System.Drawing.Size(85, 26);
            this.txt_data_pedido.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data Pedido:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(94, 115);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(276, 26);
            this.txt_cpf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // txt_numerovenda
            // 
            this.txt_numerovenda.Location = new System.Drawing.Point(144, 39);
            this.txt_numerovenda.Name = "txt_numerovenda";
            this.txt_numerovenda.Size = new System.Drawing.Size(40, 26);
            this.txt_numerovenda.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nº da Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            // 
            // comboCliente
            // 
            this.comboCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(94, 78);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(276, 26);
            this.comboCliente.TabIndex = 0;
            this.comboCliente.SelectedValueChanged += new System.EventHandler(this.comboCliente_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1103, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 42);
            this.button1.TabIndex = 67;
            this.button1.Text = "Finalizar Pedido";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(1103, 622);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(376, 42);
            this.btn_salvar.TabIndex = 68;
            this.btn_salvar.Text = "Salvar Pedido";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1103, 670);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(376, 42);
            this.button3.TabIndex = 69;
            this.button3.Text = "Cancelar Pedido";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // timerdatahora
            // 
            this.timerdatahora.Tick += new System.EventHandler(this.timerdatahora_Tick);
            // 
            // formCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1508, 974);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_caixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_quantidade_itens);
            this.Controls.Add(this.lbl_itens);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.num_quantidade);
            this.Controls.Add(this.lista_carrinho);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lista_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCaixa";
            this.Text = "formCaixa";
            this.Load += new System.EventHandler(this.formCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_produtos;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.DataGridView lista_carrinho;
        private System.Windows.Forms.NumericUpDown num_quantidade;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_itens;
        private System.Windows.Forms.Label lbl_quantidade_itens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_caixa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_valor_total_da_venda;
        private System.Windows.Forms.TextBox txt_numerovenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_itens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_hora_pedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_data_pedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_vencimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timerdatahora;
    }
}