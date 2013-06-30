namespace Pizzaria.Tela
{
    partial class DividirVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DividirVenda));
            this.lbMesaDestino = new System.Windows.Forms.Label();
            this.cbMesas = new System.Windows.Forms.ComboBox();
            this.lvItensOld = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.btProduto = new System.Windows.Forms.Button();
            this.btInserirMesa = new System.Windows.Forms.Button();
            this.gbMesaDaVenda = new System.Windows.Forms.GroupBox();
            this.rbAberta = new System.Windows.Forms.RadioButton();
            this.rbLivre = new System.Windows.Forms.RadioButton();
            this.gbAddProduto = new System.Windows.Forms.GroupBox();
            this.gbQtd = new System.Windows.Forms.GroupBox();
            this.btMais = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lvItensNew = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTituloDes = new System.Windows.Forms.Label();
            this.lbTItulo = new System.Windows.Forms.Label();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMesaDaVenda.SuspendLayout();
            this.gbAddProduto.SuspendLayout();
            this.gbQtd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMesaDestino
            // 
            this.lbMesaDestino.AutoSize = true;
            this.lbMesaDestino.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lbMesaDestino.Location = new System.Drawing.Point(44, 23);
            this.lbMesaDestino.Name = "lbMesaDestino";
            this.lbMesaDestino.Size = new System.Drawing.Size(146, 21);
            this.lbMesaDestino.TabIndex = 13;
            this.lbMesaDestino.Text = "MESA DESTINO";
            // 
            // cbMesas
            // 
            this.cbMesas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesas.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cbMesas.FormattingEnabled = true;
            this.cbMesas.ItemHeight = 23;
            this.cbMesas.Items.AddRange(new object[] {
            "INTEIRA",
            "50% - 50%",
            "50% - 2 x 25%",
            "4 x  - 25%"});
            this.cbMesas.Location = new System.Drawing.Point(18, 78);
            this.cbMesas.Name = "cbMesas";
            this.cbMesas.Size = new System.Drawing.Size(134, 31);
            this.cbMesas.TabIndex = 12;
            // 
            // lvItensOld
            // 
            this.lvItensOld.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Produto,
            this.Tamanho,
            this.Quantidade,
            this.ValorUni,
            this.SubTotal});
            this.lvItensOld.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItensOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvItensOld.FullRowSelect = true;
            this.lvItensOld.GridLines = true;
            this.lvItensOld.HoverSelection = true;
            this.lvItensOld.Location = new System.Drawing.Point(303, 32);
            this.lvItensOld.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.lvItensOld.Name = "lvItensOld";
            this.lvItensOld.Size = new System.Drawing.Size(570, 140);
            this.lvItensOld.TabIndex = 33;
            this.lvItensOld.UseCompatibleStateImageBehavior = false;
            this.lvItensOld.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Item";
            this.codigo.Width = 55;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 170;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 75;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // ValorUni
            // 
            this.ValorUni.Text = "Valor Unitario";
            this.ValorUni.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "Sub Valor";
            this.SubTotal.Width = 85;
            // 
            // mtCodigo
            // 
            this.mtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCodigo.Location = new System.Drawing.Point(6, 55);
            this.mtCodigo.Mask = "00000";
            this.mtCodigo.Name = "mtCodigo";
            this.mtCodigo.Size = new System.Drawing.Size(75, 32);
            this.mtCodigo.TabIndex = 35;
            this.mtCodigo.ValidatingType = typeof(int);
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.LCodigo.Location = new System.Drawing.Point(6, 34);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(70, 18);
            this.LCodigo.TabIndex = 36;
            this.LCodigo.Text = "CODIGO";
            // 
            // btProduto
            // 
            this.btProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btProduto.BackgroundImage = global::Pizzaria.Properties.Resources.BtInserir;
            this.btProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduto.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btProduto.ForeColor = System.Drawing.Color.Maroon;
            this.btProduto.Location = new System.Drawing.Point(76, 107);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(120, 45);
            this.btProduto.TabIndex = 38;
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btInserirMesa
            // 
            this.btInserirMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInserirMesa.BackgroundImage = global::Pizzaria.Properties.Resources.BtInserir;
            this.btInserirMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInserirMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInserirMesa.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btInserirMesa.ForeColor = System.Drawing.Color.Maroon;
            this.btInserirMesa.Location = new System.Drawing.Point(158, 82);
            this.btInserirMesa.Name = "btInserirMesa";
            this.btInserirMesa.Size = new System.Drawing.Size(106, 31);
            this.btInserirMesa.TabIndex = 39;
            this.btInserirMesa.UseVisualStyleBackColor = true;
            this.btInserirMesa.Click += new System.EventHandler(this.btInserirMesa_Click);
            // 
            // gbMesaDaVenda
            // 
            this.gbMesaDaVenda.Controls.Add(this.rbAberta);
            this.gbMesaDaVenda.Controls.Add(this.rbLivre);
            this.gbMesaDaVenda.Controls.Add(this.btInserirMesa);
            this.gbMesaDaVenda.Controls.Add(this.cbMesas);
            this.gbMesaDaVenda.Controls.Add(this.lbMesaDestino);
            this.gbMesaDaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbMesaDaVenda.Location = new System.Drawing.Point(12, 23);
            this.gbMesaDaVenda.Name = "gbMesaDaVenda";
            this.gbMesaDaVenda.Size = new System.Drawing.Size(273, 149);
            this.gbMesaDaVenda.TabIndex = 40;
            this.gbMesaDaVenda.TabStop = false;
            this.gbMesaDaVenda.Text = "SELECIONE UMA MESA";
            // 
            // rbAberta
            // 
            this.rbAberta.AutoSize = true;
            this.rbAberta.Location = new System.Drawing.Point(118, 47);
            this.rbAberta.Name = "rbAberta";
            this.rbAberta.Size = new System.Drawing.Size(110, 19);
            this.rbAberta.TabIndex = 41;
            this.rbAberta.Text = "Vendas Abertas";
            this.rbAberta.UseVisualStyleBackColor = true;
            // 
            // rbLivre
            // 
            this.rbLivre.AutoSize = true;
            this.rbLivre.Checked = true;
            this.rbLivre.Location = new System.Drawing.Point(18, 47);
            this.rbLivre.Name = "rbLivre";
            this.rbLivre.Size = new System.Drawing.Size(97, 19);
            this.rbLivre.TabIndex = 40;
            this.rbLivre.TabStop = true;
            this.rbLivre.Text = "Mesas Livres";
            this.rbLivre.UseVisualStyleBackColor = true;
            this.rbLivre.CheckedChanged += new System.EventHandler(this.rbLivre_CheckedChanged);
            // 
            // gbAddProduto
            // 
            this.gbAddProduto.Controls.Add(this.gbQtd);
            this.gbAddProduto.Controls.Add(this.mtCodigo);
            this.gbAddProduto.Controls.Add(this.btProduto);
            this.gbAddProduto.Controls.Add(this.LCodigo);
            this.gbAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbAddProduto.Location = new System.Drawing.Point(12, 193);
            this.gbAddProduto.Name = "gbAddProduto";
            this.gbAddProduto.Size = new System.Drawing.Size(273, 172);
            this.gbAddProduto.TabIndex = 41;
            this.gbAddProduto.TabStop = false;
            this.gbAddProduto.Text = "ADICIONAR PRODUTO";
            this.gbAddProduto.Visible = false;
            // 
            // gbQtd
            // 
            this.gbQtd.Controls.Add(this.btMais);
            this.gbQtd.Controls.Add(this.btMenos);
            this.gbQtd.Controls.Add(this.tbQuantidade);
            this.gbQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbQtd.Location = new System.Drawing.Point(87, 22);
            this.gbQtd.Name = "gbQtd";
            this.gbQtd.Size = new System.Drawing.Size(177, 65);
            this.gbQtd.TabIndex = 46;
            this.gbQtd.TabStop = false;
            this.gbQtd.Text = "QUANTIDADE";
            // 
            // btMais
            // 
            this.btMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btMais.Location = new System.Drawing.Point(131, 20);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(40, 36);
            this.btMais.TabIndex = 20;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btMenos
            // 
            this.btMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btMenos.Location = new System.Drawing.Point(6, 20);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(40, 36);
            this.btMenos.TabIndex = 19;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbQuantidade.Location = new System.Drawing.Point(52, 22);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(73, 32);
            this.tbQuantidade.TabIndex = 1;
            // 
            // lvItensNew
            // 
            this.lvItensNew.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvItensNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItensNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvItensNew.FullRowSelect = true;
            this.lvItensNew.GridLines = true;
            this.lvItensNew.HoverSelection = true;
            this.lvItensNew.Location = new System.Drawing.Point(303, 201);
            this.lvItensNew.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.lvItensNew.Name = "lvItensNew";
            this.lvItensNew.Size = new System.Drawing.Size(570, 164);
            this.lvItensNew.TabIndex = 42;
            this.lvItensNew.UseCompatibleStateImageBehavior = false;
            this.lvItensNew.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tamanho";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantidade";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor Unitario";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sub Valor";
            this.columnHeader6.Width = 85;
            // 
            // lbTituloDes
            // 
            this.lbTituloDes.AutoSize = true;
            this.lbTituloDes.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lbTituloDes.Location = new System.Drawing.Point(467, 175);
            this.lbTituloDes.Name = "lbTituloDes";
            this.lbTituloDes.Size = new System.Drawing.Size(146, 21);
            this.lbTituloDes.TabIndex = 43;
            this.lbTituloDes.Text = "MESA DESTINO";
            // 
            // lbTItulo
            // 
            this.lbTItulo.AutoSize = true;
            this.lbTItulo.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lbTItulo.Location = new System.Drawing.Point(471, 9);
            this.lbTItulo.Name = "lbTItulo";
            this.lbTItulo.Size = new System.Drawing.Size(139, 21);
            this.lbTItulo.TabIndex = 44;
            this.lbTItulo.Text = "MESA ORIGEM";
            // 
            // btEncerrar
            // 
            this.btEncerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEncerrar.BackgroundImage = global::Pizzaria.Properties.Resources.BtSair1;
            this.btEncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEncerrar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btEncerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btEncerrar.Location = new System.Drawing.Point(357, 370);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(171, 50);
            this.btEncerrar.TabIndex = 45;
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 84);
            this.label1.TabIndex = 42;
            this.label1.Text = "Digite o codigo do produto \r\nexistente na MESA ORIGEM\r\nDefina quantidade retirada" +
                "\r\ndo Item da Mesa Origem";
            this.label1.Visible = false;
            // 
            // DividirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 423);
            this.ControlBox = false;
            this.Controls.Add(this.gbMesaDaVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEncerrar);
            this.Controls.Add(this.lbTItulo);
            this.Controls.Add(this.lbTituloDes);
            this.Controls.Add(this.lvItensNew);
            this.Controls.Add(this.gbAddProduto);
            this.Controls.Add(this.lvItensOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(900, 439);
            this.MinimumSize = new System.Drawing.Size(900, 439);
            this.Name = "DividirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DividirVenda_KeyDown);
            this.gbMesaDaVenda.ResumeLayout(false);
            this.gbMesaDaVenda.PerformLayout();
            this.gbAddProduto.ResumeLayout(false);
            this.gbAddProduto.PerformLayout();
            this.gbQtd.ResumeLayout(false);
            this.gbQtd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMesaDestino;
        private System.Windows.Forms.ComboBox cbMesas;
        private System.Windows.Forms.ListView lvItensOld;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader ValorUni;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.MaskedTextBox mtCodigo;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btInserirMesa;
        private System.Windows.Forms.GroupBox gbMesaDaVenda;
        private System.Windows.Forms.GroupBox gbAddProduto;
        private System.Windows.Forms.ListView lvItensNew;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbTituloDes;
        private System.Windows.Forms.Label lbTItulo;
        private System.Windows.Forms.Button btEncerrar;
        private System.Windows.Forms.RadioButton rbAberta;
        private System.Windows.Forms.RadioButton rbLivre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbQtd;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.TextBox tbQuantidade;
    }
}