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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lista_produtos = new System.Windows.Forms.DataGridView();
            this.lbl_caixa = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_valor_total_da_venda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lista_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista_produtos
            // 
            this.lista_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista_produtos.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.lista_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_produtos.DefaultCellStyle = dataGridViewCellStyle38;
            this.lista_produtos.Location = new System.Drawing.Point(1, 148);
            this.lista_produtos.Name = "lista_produtos";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.lista_produtos.RowTemplate.Height = 25;
            this.lista_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_produtos.Size = new System.Drawing.Size(684, 351);
            this.lista_produtos.TabIndex = 1;
            this.lista_produtos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_produtos_CellEnter);
            // 
            // lbl_caixa
            // 
            this.lbl_caixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_caixa.AutoSize = true;
            this.lbl_caixa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caixa.Location = new System.Drawing.Point(706, 9);
            this.lbl_caixa.Name = "lbl_caixa";
            this.lbl_caixa.Size = new System.Drawing.Size(69, 22);
            this.lbl_caixa.TabIndex = 3;
            this.lbl_caixa.Text = "CAIXA";
            this.lbl_caixa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(230, 502);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(138, 23);
            this.btn_adicionar.TabIndex = 40;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lista_carrinho
            // 
            this.lista_carrinho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista_carrinho.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_carrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.lista_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_carrinho.DefaultCellStyle = dataGridViewCellStyle41;
            this.lista_carrinho.Location = new System.Drawing.Point(809, 148);
            this.lista_carrinho.Name = "lista_carrinho";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_carrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.lista_carrinho.RowTemplate.Height = 25;
            this.lista_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_carrinho.Size = new System.Drawing.Size(671, 351);
            this.lista_carrinho.TabIndex = 41;
            this.lista_carrinho.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_carrinho_CellEnter);
            this.lista_carrinho.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lista_carrinho_CellMouseClick);
            // 
            // num_quantidade
            // 
            this.num_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_quantidade.Location = new System.Drawing.Point(136, 505);
            this.num_quantidade.Name = "num_quantidade";
            this.num_quantidade.Size = new System.Drawing.Size(88, 20);
            this.num_quantidade.TabIndex = 43;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantidade.Location = new System.Drawing.Point(14, 502);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(116, 23);
            this.lbl_quantidade.TabIndex = 56;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(809, 502);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(138, 23);
            this.btn_remove.TabIndex = 58;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_buscar.Location = new System.Drawing.Point(1, 116);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(684, 26);
            this.txt_buscar.TabIndex = 59;
            this.txt_buscar.Text = "Buscar...";
            this.txt_buscar.Click += new System.EventHandler(this.txt_buscar_Click);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1312, 503);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(128, 22);
            this.lbl_total.TabIndex = 57;
            this.lbl_total.Text = "Total: R$ 0,00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_itens
            // 
            this.lbl_itens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_itens.AutoSize = true;
            this.lbl_itens.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens.Location = new System.Drawing.Point(978, 503);
            this.lbl_itens.Name = "lbl_itens";
            this.lbl_itens.Size = new System.Drawing.Size(73, 22);
            this.lbl_itens.TabIndex = 60;
            this.lbl_itens.Text = "Itens: 0";
            this.lbl_itens.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_quantidade_itens
            // 
            this.lbl_quantidade_itens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_quantidade_itens.AutoSize = true;
            this.lbl_quantidade_itens.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade_itens.Location = new System.Drawing.Point(1098, 503);
            this.lbl_quantidade_itens.Name = "lbl_quantidade_itens";
            this.lbl_quantidade_itens.Size = new System.Drawing.Size(128, 22);
            this.lbl_quantidade_itens.TabIndex = 61;
            this.lbl_quantidade_itens.Text = "Quantidade: 0";
            this.lbl_quantidade_itens.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1112, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(374, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Novo produto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_valor_total_da_venda
            // 
            this.lbl_valor_total_da_venda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valor_total_da_venda.AutoSize = true;
            this.lbl_valor_total_da_venda.BackColor = System.Drawing.Color.White;
            this.lbl_valor_total_da_venda.Font = new System.Drawing.Font("Arial", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_total_da_venda.Location = new System.Drawing.Point(23, 49);
            this.lbl_valor_total_da_venda.Name = "lbl_valor_total_da_venda";
            this.lbl_valor_total_da_venda.Size = new System.Drawing.Size(478, 134);
            this.lbl_valor_total_da_venda.TabIndex = 65;
            this.lbl_valor_total_da_venda.Text = "R$ 0,00";
            this.lbl_valor_total_da_venda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_valor_total_da_venda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 197);
            this.panel1.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "VALOR TOTAL DA VENDA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(718, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(762, 134);
            this.button2.TabIndex = 67;
            this.button2.Text = "FINALIZAR VENDA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // formCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 842);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.lbl_caixa);
            this.Controls.Add(this.lista_produtos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCaixa";
            this.Text = "formCaixa";
            this.Load += new System.EventHandler(this.formCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_produtos;
        private System.Windows.Forms.Label lbl_caixa;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_valor_total_da_venda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}