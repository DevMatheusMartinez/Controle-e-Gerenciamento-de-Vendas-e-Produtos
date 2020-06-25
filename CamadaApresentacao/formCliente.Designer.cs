namespace CamadaApresentacao
{
    partial class formCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_top = new System.Windows.Forms.Panel();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lista_clientes = new System.Windows.Forms.DataGridView();
            this.pn_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.White;
            this.pn_top.Controls.Add(this.btn_deletar);
            this.pn_top.Controls.Add(this.label1);
            this.pn_top.Controls.Add(this.btn_editar);
            this.pn_top.Controls.Add(this.btn_novo);
            this.pn_top.Controls.Add(this.txt_buscar);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1239, 90);
            this.pn_top.TabIndex = 0;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(1120, 49);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(113, 28);
            this.btn_deletar.TabIndex = 46;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(1001, 49);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(113, 28);
            this.btn_editar.TabIndex = 45;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Location = new System.Drawing.Point(882, 49);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(113, 28);
            this.btn_novo.TabIndex = 44;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_buscar.Location = new System.Drawing.Point(3, 50);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(873, 26);
            this.txt_buscar.TabIndex = 43;
            this.txt_buscar.Click += new System.EventHandler(this.txt_buscar_Click);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 74);
            this.panel1.TabIndex = 1;
            // 
            // lista_clientes
            // 
            this.lista_clientes.AllowUserToAddRows = false;
            this.lista_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_clientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.lista_clientes.Location = new System.Drawing.Point(0, 91);
            this.lista_clientes.Name = "lista_clientes";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.lista_clientes.RowTemplate.Height = 25;
            this.lista_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_clientes.Size = new System.Drawing.Size(1239, 429);
            this.lista_clientes.TabIndex = 1;
            this.lista_clientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_clientes_CellEnter);
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 600);
            this.Controls.Add(this.lista_clientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCliente";
            this.Text = "formCliente";
            this.Load += new System.EventHandler(this.formCliente_Load);
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView lista_clientes;
    }
}