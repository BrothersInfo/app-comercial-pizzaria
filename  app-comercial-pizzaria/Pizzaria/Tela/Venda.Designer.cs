namespace Pizzaria.Tela
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            this.panBut = new System.Windows.Forms.Panel();
            this.tabLayDescricao = new System.Windows.Forms.TableLayoutPanel();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpGAmb = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lvGarcon = new System.Windows.Forms.ListView();
            this.codGar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomGar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pValor = new System.Windows.Forms.Panel();
            this.mtValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvMesa = new System.Windows.Forms.ListView();
            this.nomMesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ambient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLayINFO = new System.Windows.Forms.TableLayoutPanel();
            this.tabLayCima = new System.Windows.Forms.TableLayoutPanel();
            this.tabLayPROD = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProduto = new System.Windows.Forms.TableLayoutPanel();
            this.pProduto = new System.Windows.Forms.Panel();
            this.tabLayCimaMESA = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVenda = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlbBotaoVendas = new System.Windows.Forms.TableLayoutPanel();
            this.tlpComanda = new System.Windows.Forms.TableLayoutPanel();
            this.ttEncerrar = new System.Windows.Forms.ToolTip(this.components);
            this.btProduto = new System.Windows.Forms.Button();
            this.btRemoveProd = new System.Windows.Forms.Button();
            this.btInseMesa = new System.Windows.Forms.Button();
            this.btRemoMesa = new System.Windows.Forms.Button();
            this.pMesa = new System.Windows.Forms.Panel();
            this.btAnular = new System.Windows.Forms.Button();
            this.btParcial = new System.Windows.Forms.Button();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panBut.SuspendLayout();
            this.tabLayDescricao.SuspendLayout();
            this.tlpGAmb.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.pValor.SuspendLayout();
            this.tabLayINFO.SuspendLayout();
            this.tabLayCima.SuspendLayout();
            this.tabLayPROD.SuspendLayout();
            this.tlpProduto.SuspendLayout();
            this.pProduto.SuspendLayout();
            this.tabLayCimaMESA.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpVenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlbBotaoVendas.SuspendLayout();
            this.tlpComanda.SuspendLayout();
            this.pMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBut
            // 
            this.panBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBut.BackColor = System.Drawing.Color.Transparent;
            this.panBut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panBut.Controls.Add(this.tabLayDescricao);
            this.panBut.Controls.Add(this.tabLayINFO);
            this.panBut.Location = new System.Drawing.Point(0, 0);
            this.panBut.Margin = new System.Windows.Forms.Padding(0);
            this.panBut.MaximumSize = new System.Drawing.Size(1019, 318);
            this.panBut.MinimumSize = new System.Drawing.Size(1019, 318);
            this.panBut.Name = "panBut";
            this.panBut.Size = new System.Drawing.Size(1019, 318);
            this.panBut.TabIndex = 22;
            // 
            // tabLayDescricao
            // 
            this.tabLayDescricao.ColumnCount = 1;
            this.tabLayDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayDescricao.Controls.Add(this.lvInfo, 0, 0);
            this.tabLayDescricao.Controls.Add(this.tlpGAmb, 0, 1);
            this.tabLayDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabLayDescricao.Location = new System.Drawing.Point(447, 0);
            this.tabLayDescricao.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tabLayDescricao.Name = "tabLayDescricao";
            this.tabLayDescricao.RowCount = 2;
            this.tabLayDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tabLayDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tabLayDescricao.Size = new System.Drawing.Size(570, 314);
            this.tabLayDescricao.TabIndex = 20;
            // 
            // lvInfo
            // 
            this.lvInfo.CheckBoxes = true;
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Produto,
            this.Tamanho,
            this.Quantidade,
            this.ValorUni,
            this.SubTotal});
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HoverSelection = true;
            this.lvInfo.Location = new System.Drawing.Point(3, 0);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(565, 211);
            this.lvInfo.TabIndex = 32;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.ItemActivate += new System.EventHandler(this.lvInfo_ItemActivate);
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
            // tlpGAmb
            // 
            this.tlpGAmb.ColumnCount = 2;
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.53927F));
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46073F));
            this.tlpGAmb.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tlpGAmb.Controls.Add(this.lvMesa, 1, 0);
            this.tlpGAmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGAmb.Location = new System.Drawing.Point(0, 211);
            this.tlpGAmb.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tlpGAmb.Name = "tlpGAmb";
            this.tlpGAmb.RowCount = 1;
            this.tlpGAmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGAmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpGAmb.Size = new System.Drawing.Size(569, 108);
            this.tlpGAmb.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34375F));
            this.tableLayoutPanel5.Controls.Add(this.lvGarcon, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.pValor, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(384, 108);
            this.tableLayoutPanel5.TabIndex = 39;
            // 
            // lvGarcon
            // 
            this.lvGarcon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codGar,
            this.nomGar});
            this.lvGarcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGarcon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGarcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvGarcon.FullRowSelect = true;
            this.lvGarcon.GridLines = true;
            this.lvGarcon.HoverSelection = true;
            this.lvGarcon.Location = new System.Drawing.Point(186, 3);
            this.lvGarcon.Margin = new System.Windows.Forms.Padding(3, 3, 1, 6);
            this.lvGarcon.Name = "lvGarcon";
            this.lvGarcon.Size = new System.Drawing.Size(197, 99);
            this.lvGarcon.TabIndex = 33;
            this.lvGarcon.UseCompatibleStateImageBehavior = false;
            this.lvGarcon.View = System.Windows.Forms.View.Details;
            // 
            // codGar
            // 
            this.codGar.Text = "Codigo";
            // 
            // nomGar
            // 
            this.nomGar.Text = "Garçon";
            this.nomGar.Width = 117;
            // 
            // pValor
            // 
            this.pValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pValor.Controls.Add(this.mtValor);
            this.pValor.Controls.Add(this.label4);
            this.pValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pValor.Location = new System.Drawing.Point(3, 3);
            this.pValor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pValor.Name = "pValor";
            this.pValor.Size = new System.Drawing.Size(177, 99);
            this.pValor.TabIndex = 34;
            // 
            // mtValor
            // 
            this.mtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtValor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtValor.ForeColor = System.Drawing.Color.DarkRed;
            this.mtValor.Location = new System.Drawing.Point(21, 50);
            this.mtValor.Mask = "0,00";
            this.mtValor.Name = "mtValor";
            this.mtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtValor.Size = new System.Drawing.Size(132, 44);
            this.mtValor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(47, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "VALOR";
            // 
            // lvMesa
            // 
            this.lvMesa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomMesa,
            this.ambient});
            this.lvMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvMesa.FullRowSelect = true;
            this.lvMesa.GridLines = true;
            this.lvMesa.HoverSelection = true;
            this.lvMesa.Location = new System.Drawing.Point(387, 3);
            this.lvMesa.Margin = new System.Windows.Forms.Padding(3, 3, 1, 6);
            this.lvMesa.Name = "lvMesa";
            this.lvMesa.Size = new System.Drawing.Size(181, 99);
            this.lvMesa.TabIndex = 38;
            this.lvMesa.UseCompatibleStateImageBehavior = false;
            this.lvMesa.View = System.Windows.Forms.View.Details;
            // 
            // nomMesa
            // 
            this.nomMesa.Text = "Mesa";
            this.nomMesa.Width = 90;
            // 
            // ambient
            // 
            this.ambient.Text = "Ambiente";
            this.ambient.Width = 80;
            // 
            // tabLayINFO
            // 
            this.tabLayINFO.BackColor = System.Drawing.Color.Transparent;
            this.tabLayINFO.ColumnCount = 1;
            this.tabLayINFO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayINFO.Controls.Add(this.tabLayCima, 0, 0);
            this.tabLayINFO.Controls.Add(this.tlpVenda, 0, 1);
            this.tabLayINFO.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabLayINFO.Location = new System.Drawing.Point(0, 0);
            this.tabLayINFO.Margin = new System.Windows.Forms.Padding(0);
            this.tabLayINFO.Name = "tabLayINFO";
            this.tabLayINFO.RowCount = 2;
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.49045F));
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.50955F));
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayINFO.Size = new System.Drawing.Size(447, 314);
            this.tabLayINFO.TabIndex = 11;
            // 
            // tabLayCima
            // 
            this.tabLayCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLayCima.ColumnCount = 2;
            this.tabLayCima.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayCima.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayCima.Controls.Add(this.tabLayPROD, 0, 0);
            this.tabLayCima.Controls.Add(this.tabLayCimaMESA, 0, 0);
            this.tabLayCima.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabLayCima.Location = new System.Drawing.Point(3, 3);
            this.tabLayCima.Name = "tabLayCima";
            this.tabLayCima.RowCount = 1;
            this.tabLayCima.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayCima.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tabLayCima.Size = new System.Drawing.Size(441, 118);
            this.tabLayCima.TabIndex = 11;
            // 
            // tabLayPROD
            // 
            this.tabLayPROD.BackColor = System.Drawing.Color.Transparent;
            this.tabLayPROD.ColumnCount = 1;
            this.tabLayPROD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPROD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPROD.Controls.Add(this.tlpProduto, 0, 1);
            this.tabLayPROD.Controls.Add(this.pProduto, 0, 0);
            this.tabLayPROD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPROD.Location = new System.Drawing.Point(221, 3);
            this.tabLayPROD.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.tabLayPROD.Name = "tabLayPROD";
            this.tabLayPROD.RowCount = 2;
            this.tabLayPROD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPROD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPROD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPROD.Size = new System.Drawing.Size(217, 112);
            this.tabLayPROD.TabIndex = 9;
            // 
            // tlpProduto
            // 
            this.tlpProduto.BackColor = System.Drawing.Color.Transparent;
            this.tlpProduto.ColumnCount = 2;
            this.tlpProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProduto.Controls.Add(this.btProduto, 0, 0);
            this.tlpProduto.Controls.Add(this.btRemoveProd, 1, 0);
            this.tlpProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProduto.Location = new System.Drawing.Point(1, 57);
            this.tlpProduto.Margin = new System.Windows.Forms.Padding(1);
            this.tlpProduto.Name = "tlpProduto";
            this.tlpProduto.RowCount = 1;
            this.tlpProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpProduto.Size = new System.Drawing.Size(215, 54);
            this.tlpProduto.TabIndex = 7;
            // 
            // pProduto
            // 
            this.pProduto.BackColor = System.Drawing.Color.Transparent;
            this.pProduto.BackgroundImage = global::Pizzaria.Properties.Resources.FUNDO_PAINEL;
            this.pProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pProduto.Controls.Add(this.label1);
            this.pProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProduto.Location = new System.Drawing.Point(2, 2);
            this.pProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pProduto.Name = "pProduto";
            this.pProduto.Size = new System.Drawing.Size(213, 54);
            this.pProduto.TabIndex = 8;
            // 
            // tabLayCimaMESA
            // 
            this.tabLayCimaMESA.BackColor = System.Drawing.Color.Transparent;
            this.tabLayCimaMESA.ColumnCount = 1;
            this.tabLayCimaMESA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayCimaMESA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayCimaMESA.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tabLayCimaMESA.Controls.Add(this.pMesa, 0, 0);
            this.tabLayCimaMESA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayCimaMESA.Location = new System.Drawing.Point(3, 3);
            this.tabLayCimaMESA.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.tabLayCimaMESA.Name = "tabLayCimaMESA";
            this.tabLayCimaMESA.RowCount = 2;
            this.tabLayCimaMESA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayCimaMESA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayCimaMESA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayCimaMESA.Size = new System.Drawing.Size(216, 112);
            this.tabLayCimaMESA.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btInseMesa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRemoMesa, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 54);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tlpVenda
            // 
            this.tlpVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tlpVenda.ColumnCount = 1;
            this.tlpVenda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVenda.Controls.Add(this.panel1, 0, 0);
            this.tlpVenda.Controls.Add(this.tlbBotaoVendas, 0, 1);
            this.tlpVenda.Controls.Add(this.tlpComanda, 0, 2);
            this.tlpVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVenda.Location = new System.Drawing.Point(4, 126);
            this.tlpVenda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 0);
            this.tlpVenda.Name = "tlpVenda";
            this.tlpVenda.RowCount = 3;
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.56322F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.08046F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.35632F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVenda.Size = new System.Drawing.Size(439, 188);
            this.tlpVenda.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Pizzaria.Properties.Resources.FUNDO_PAINEL;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 42);
            this.panel1.TabIndex = 9;
            // 
            // tlbBotaoVendas
            // 
            this.tlbBotaoVendas.BackColor = System.Drawing.Color.Transparent;
            this.tlbBotaoVendas.ColumnCount = 3;
            this.tlbBotaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbBotaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbBotaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbBotaoVendas.Controls.Add(this.btAnular, 0, 0);
            this.tlbBotaoVendas.Controls.Add(this.btParcial, 2, 0);
            this.tlbBotaoVendas.Controls.Add(this.btEncerrar, 1, 0);
            this.tlbBotaoVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbBotaoVendas.Location = new System.Drawing.Point(6, 44);
            this.tlbBotaoVendas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tlbBotaoVendas.Name = "tlbBotaoVendas";
            this.tlbBotaoVendas.RowCount = 1;
            this.tlbBotaoVendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbBotaoVendas.Size = new System.Drawing.Size(427, 73);
            this.tlbBotaoVendas.TabIndex = 3;
            // 
            // tlpComanda
            // 
            this.tlpComanda.BackColor = System.Drawing.Color.Transparent;
            this.tlpComanda.ColumnCount = 3;
            this.tlpComanda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpComanda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComanda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpComanda.Controls.Add(this.btVoltar, 0, 0);
            this.tlpComanda.Controls.Add(this.btImprimir, 1, 0);
            this.tlpComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComanda.Location = new System.Drawing.Point(6, 117);
            this.tlpComanda.Margin = new System.Windows.Forms.Padding(6, 0, 6, 4);
            this.tlpComanda.Name = "tlpComanda";
            this.tlpComanda.RowCount = 1;
            this.tlpComanda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComanda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpComanda.Size = new System.Drawing.Size(427, 67);
            this.tlpComanda.TabIndex = 4;
            // 
            // btProduto
            // 
            this.btProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btProduto.BackgroundImage")));
            this.btProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduto.ForeColor = System.Drawing.Color.Maroon;
            this.btProduto.Location = new System.Drawing.Point(10, 5);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(87, 43);
            this.btProduto.TabIndex = 5;
            this.btProduto.Text = "INSERIR";
            this.ttEncerrar.SetToolTip(this.btProduto, "Inserir Produto - (P)");
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btRemoveProd
            // 
            this.btRemoveProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRemoveProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRemoveProd.BackgroundImage")));
            this.btRemoveProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemoveProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemoveProd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveProd.ForeColor = System.Drawing.Color.White;
            this.btRemoveProd.Location = new System.Drawing.Point(117, 5);
            this.btRemoveProd.Name = "btRemoveProd";
            this.btRemoveProd.Size = new System.Drawing.Size(87, 43);
            this.btRemoveProd.TabIndex = 6;
            this.btRemoveProd.Text = "REMOVER";
            this.ttEncerrar.SetToolTip(this.btRemoveProd, "Remover Produto - (R)");
            this.btRemoveProd.UseVisualStyleBackColor = true;
            this.btRemoveProd.Click += new System.EventHandler(this.btRemoveProd_Click);
            // 
            // btInseMesa
            // 
            this.btInseMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInseMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInseMesa.BackgroundImage")));
            this.btInseMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInseMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInseMesa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInseMesa.ForeColor = System.Drawing.Color.Maroon;
            this.btInseMesa.Location = new System.Drawing.Point(10, 5);
            this.btInseMesa.Margin = new System.Windows.Forms.Padding(0);
            this.btInseMesa.Name = "btInseMesa";
            this.btInseMesa.Size = new System.Drawing.Size(87, 43);
            this.btInseMesa.TabIndex = 1;
            this.btInseMesa.Text = "INSERIR";
            this.ttEncerrar.SetToolTip(this.btInseMesa, "Inserir Mesa - (M)");
            this.btInseMesa.UseVisualStyleBackColor = true;
            this.btInseMesa.Click += new System.EventHandler(this.btInseMesa_Click);
            // 
            // btRemoMesa
            // 
            this.btRemoMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRemoMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRemoMesa.BackgroundImage")));
            this.btRemoMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemoMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemoMesa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoMesa.ForeColor = System.Drawing.Color.White;
            this.btRemoMesa.Location = new System.Drawing.Point(117, 5);
            this.btRemoMesa.Name = "btRemoMesa";
            this.btRemoMesa.Size = new System.Drawing.Size(87, 43);
            this.btRemoMesa.TabIndex = 2;
            this.btRemoMesa.Text = "REMOVER";
            this.ttEncerrar.SetToolTip(this.btRemoMesa, "Remover Mesa - (N)");
            this.btRemoMesa.UseVisualStyleBackColor = true;
            this.btRemoMesa.Click += new System.EventHandler(this.btRemoMesa_Click);
            // 
            // pMesa
            // 
            this.pMesa.BackColor = System.Drawing.Color.Transparent;
            this.pMesa.BackgroundImage = global::Pizzaria.Properties.Resources.FUNDO_PAINEL;
            this.pMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMesa.Controls.Add(this.label3);
            this.pMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMesa.Location = new System.Drawing.Point(2, 2);
            this.pMesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pMesa.Name = "pMesa";
            this.pMesa.Size = new System.Drawing.Size(212, 54);
            this.pMesa.TabIndex = 9;
            // 
            // btAnular
            // 
            this.btAnular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnular.BackgroundImage = global::Pizzaria.Properties.Resources.setVermelhor;
            this.btAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnular.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnular.ForeColor = System.Drawing.Color.White;
            this.btAnular.Location = new System.Drawing.Point(3, 15);
            this.btAnular.Name = "btAnular";
            this.btAnular.Size = new System.Drawing.Size(100, 43);
            this.btAnular.TabIndex = 3;
            this.btAnular.Tag = "";
            this.btAnular.Text = "ANULAR";
            this.btAnular.UseVisualStyleBackColor = true;
            this.btAnular.Click += new System.EventHandler(this.btAnular_Click);
            // 
            // btParcial
            // 
            this.btParcial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btParcial.BackgroundImage = global::Pizzaria.Properties.Resources.setAzul;
            this.btParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btParcial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParcial.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParcial.ForeColor = System.Drawing.Color.Maroon;
            this.btParcial.Location = new System.Drawing.Point(322, 15);
            this.btParcial.Margin = new System.Windows.Forms.Padding(0);
            this.btParcial.Name = "btParcial";
            this.btParcial.Size = new System.Drawing.Size(102, 43);
            this.btParcial.TabIndex = 2;
            this.btParcial.Text = "PARCIAL";
            this.ttEncerrar.SetToolTip(this.btParcial, "Venda Parcial - Atalho (S)");
            this.btParcial.UseVisualStyleBackColor = true;
            this.btParcial.Click += new System.EventHandler(this.btParcial_Click);
            // 
            // btEncerrar
            // 
            this.btEncerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEncerrar.BackgroundImage = global::Pizzaria.Properties.Resources.setverde;
            this.btEncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEncerrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btEncerrar.Location = new System.Drawing.Point(146, 11);
            this.btEncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(132, 51);
            this.btEncerrar.TabIndex = 1;
            this.btEncerrar.Text = "ENCERRAR";
            this.ttEncerrar.SetToolTip(this.btEncerrar, "Encerrar Venda  - (V)");
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btVoltar.BackgroundImage = global::Pizzaria.Properties.Resources.setVermelhor;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(11, 14);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(84, 38);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "VOLTAR";
            this.ttEncerrar.SetToolTip(this.btVoltar, "Retornar - (ESC)");
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir.BackgroundImage = global::Pizzaria.Properties.Resources.setPreto;
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.ForeColor = System.Drawing.Color.White;
            this.btImprimir.Location = new System.Drawing.Point(146, 8);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(132, 51);
            this.btImprimir.TabIndex = 0;
            this.btImprimir.Text = "IMPRIMIR";
            this.ttEncerrar.SetToolTip(this.btImprimir, "Imprimir - (I)");
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "MESA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "OPÇÕES DE VENDA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Venda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1019, 318);
            this.ControlBox = false;
            this.Controls.Add(this.panBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Venda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venda_KeyDown);
            this.panBut.ResumeLayout(false);
            this.tabLayDescricao.ResumeLayout(false);
            this.tlpGAmb.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.pValor.ResumeLayout(false);
            this.pValor.PerformLayout();
            this.tabLayINFO.ResumeLayout(false);
            this.tabLayCima.ResumeLayout(false);
            this.tabLayPROD.ResumeLayout(false);
            this.tlpProduto.ResumeLayout(false);
            this.pProduto.ResumeLayout(false);
            this.pProduto.PerformLayout();
            this.tabLayCimaMESA.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpVenda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlbBotaoVendas.ResumeLayout(false);
            this.tlpComanda.ResumeLayout(false);
            this.pMesa.ResumeLayout(false);
            this.pMesa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panBut;
        private System.Windows.Forms.TableLayoutPanel tabLayDescricao;
        private System.Windows.Forms.TableLayoutPanel tlpGAmb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListView lvGarcon;
        private System.Windows.Forms.ColumnHeader codGar;
        private System.Windows.Forms.ColumnHeader nomGar;
        private System.Windows.Forms.Panel pValor;
        private System.Windows.Forms.MaskedTextBox mtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvMesa;
        private System.Windows.Forms.ColumnHeader nomMesa;
        private System.Windows.Forms.ColumnHeader ambient;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader ValorUni;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.TableLayoutPanel tabLayINFO;
        private System.Windows.Forms.TableLayoutPanel tabLayCima;
        private System.Windows.Forms.TableLayoutPanel tabLayPROD;
        private System.Windows.Forms.TableLayoutPanel tlpProduto;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btRemoveProd;
        private System.Windows.Forms.Panel pProduto;
        private System.Windows.Forms.TableLayoutPanel tabLayCimaMESA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btInseMesa;
        private System.Windows.Forms.Button btRemoMesa;
        private System.Windows.Forms.Panel pMesa;
        private System.Windows.Forms.TableLayoutPanel tlpVenda;
        private System.Windows.Forms.TableLayoutPanel tlbBotaoVendas;
        private System.Windows.Forms.Button btAnular;
        private System.Windows.Forms.Button btParcial;
        private System.Windows.Forms.Button btEncerrar;
        private System.Windows.Forms.TableLayoutPanel tlpComanda;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.ToolTip ttEncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}