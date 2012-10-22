namespace Pizzaria
{
    partial class RelatorioForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvConsInfo = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpConsulta1Nivel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbGarconConsulta = new System.Windows.Forms.GroupBox();
            this.cbGarcConsulta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flpBaixoGarcon = new System.Windows.Forms.FlowLayoutPanel();
            this.gbGarVenda = new System.Windows.Forms.GroupBox();
            this.rbVendAbert = new System.Windows.Forms.RadioButton();
            this.rbVendEncer = new System.Windows.Forms.RadioButton();
            this.gbGarAll = new System.Windows.Forms.GroupBox();
            this.rbGarQuadro2 = new System.Windows.Forms.RadioButton();
            this.rbGarQuadro1 = new System.Windows.Forms.RadioButton();
            this.gbGarUm = new System.Windows.Forms.GroupBox();
            this.cbGarUm = new System.Windows.Forms.ComboBox();
            this.gbGarAtiv = new System.Windows.Forms.GroupBox();
            this.rbGarAtivo2 = new System.Windows.Forms.RadioButton();
            this.rbGarAtivo3 = new System.Windows.Forms.RadioButton();
            this.rbGarAtivo1 = new System.Windows.Forms.RadioButton();
            this.gbGarPeriodo = new System.Windows.Forms.GroupBox();
            this.rbPeriodo2 = new System.Windows.Forms.RadioButton();
            this.rbPeriodo3 = new System.Windows.Forms.RadioButton();
            this.rbPeriodo1 = new System.Windows.Forms.RadioButton();
            this.gbPicker = new System.Windows.Forms.GroupBox();
            this.cbAnoGarcon = new System.Windows.Forms.ComboBox();
            this.btConfirmarGarcon = new System.Windows.Forms.Button();
            this.cbMesGarcon = new System.Windows.Forms.ComboBox();
            this.dtPData2 = new System.Windows.Forms.DateTimePicker();
            this.dtPData1 = new System.Windows.Forms.DateTimePicker();
            this.btConsulta = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpConsulta1Nivel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbGarconConsulta.SuspendLayout();
            this.flpBaixoGarcon.SuspendLayout();
            this.gbGarVenda.SuspendLayout();
            this.gbGarAll.SuspendLayout();
            this.gbGarUm.SuspendLayout();
            this.gbGarAtiv.SuspendLayout();
            this.gbGarPeriodo.SuspendLayout();
            this.gbPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 830F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvConsInfo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 267);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lvConsInfo
            // 
            this.lvConsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Produto,
            this.Tamanho,
            this.ValorUni});
            this.lvConsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConsInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvConsInfo.FullRowSelect = true;
            this.lvConsInfo.GridLines = true;
            this.lvConsInfo.HoverSelection = true;
            this.lvConsInfo.Location = new System.Drawing.Point(30, 0);
            this.lvConsInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lvConsInfo.Name = "lvConsInfo";
            this.lvConsInfo.Size = new System.Drawing.Size(830, 267);
            this.lvConsInfo.TabIndex = 44;
            this.lvConsInfo.UseCompatibleStateImageBehavior = false;
            this.lvConsInfo.View = System.Windows.Forms.View.Details;
            this.lvConsInfo.SelectedIndexChanged += new System.EventHandler(this.lvConsInfo_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Item";
            this.codigo.Width = 55;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Produto.Width = 170;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tamanho.Width = 75;
            // 
            // ValorUni
            // 
            this.ValorUni.Text = "Valor";
            this.ValorUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValorUni.Width = 90;
            // 
            // tlpConsulta1Nivel2
            // 
            this.tlpConsulta1Nivel2.ColumnCount = 1;
            this.tlpConsulta1Nivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsulta1Nivel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpConsulta1Nivel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tlpConsulta1Nivel2.Controls.Add(this.flpBaixoGarcon, 0, 2);
            this.tlpConsulta1Nivel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConsulta1Nivel2.Location = new System.Drawing.Point(0, 0);
            this.tlpConsulta1Nivel2.Margin = new System.Windows.Forms.Padding(0);
            this.tlpConsulta1Nivel2.Name = "tlpConsulta1Nivel2";
            this.tlpConsulta1Nivel2.RowCount = 4;
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConsulta1Nivel2.Size = new System.Drawing.Size(891, 601);
            this.tlpConsulta1Nivel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbGarconConsulta);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 106);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // gbGarconConsulta
            // 
            this.gbGarconConsulta.Controls.Add(this.cbGarcConsulta);
            this.gbGarconConsulta.Location = new System.Drawing.Point(3, 3);
            this.gbGarconConsulta.Name = "gbGarconConsulta";
            this.gbGarconConsulta.Size = new System.Drawing.Size(165, 100);
            this.gbGarconConsulta.TabIndex = 2;
            this.gbGarconConsulta.TabStop = false;
            this.gbGarconConsulta.Text = "groupBox3";
            this.gbGarconConsulta.Enter += new System.EventHandler(this.gbGarconConsulta_Enter);
            // 
            // cbGarcConsulta
            // 
            this.cbGarcConsulta.FormattingEnabled = true;
            this.cbGarcConsulta.Items.AddRange(new object[] {
            "QUADRO DE GARCON",
            "DIAS DE TRABALHO",
            "VENDA ATENDIDA"});
            this.cbGarcConsulta.Location = new System.Drawing.Point(19, 42);
            this.cbGarcConsulta.Name = "cbGarcConsulta";
            this.cbGarcConsulta.Size = new System.Drawing.Size(121, 21);
            this.cbGarcConsulta.TabIndex = 0;
            this.cbGarcConsulta.SelectedIndexChanged += new System.EventHandler(this.cbGarcConsulta_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flpBaixoGarcon
            // 
            this.flpBaixoGarcon.Controls.Add(this.gbGarVenda);
            this.flpBaixoGarcon.Controls.Add(this.gbGarAll);
            this.flpBaixoGarcon.Controls.Add(this.gbGarUm);
            this.flpBaixoGarcon.Controls.Add(this.gbGarAtiv);
            this.flpBaixoGarcon.Controls.Add(this.gbGarPeriodo);
            this.flpBaixoGarcon.Controls.Add(this.gbPicker);
            this.flpBaixoGarcon.Controls.Add(this.btConsulta);
            this.flpBaixoGarcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBaixoGarcon.Location = new System.Drawing.Point(0, 373);
            this.flpBaixoGarcon.Margin = new System.Windows.Forms.Padding(0);
            this.flpBaixoGarcon.Name = "flpBaixoGarcon";
            this.flpBaixoGarcon.Size = new System.Drawing.Size(891, 208);
            this.flpBaixoGarcon.TabIndex = 5;
            // 
            // gbGarVenda
            // 
            this.gbGarVenda.Controls.Add(this.rbVendAbert);
            this.gbGarVenda.Controls.Add(this.rbVendEncer);
            this.gbGarVenda.Location = new System.Drawing.Point(1, 1);
            this.gbGarVenda.Margin = new System.Windows.Forms.Padding(1);
            this.gbGarVenda.Name = "gbGarVenda";
            this.gbGarVenda.Size = new System.Drawing.Size(152, 100);
            this.gbGarVenda.TabIndex = 0;
            this.gbGarVenda.TabStop = false;
            this.gbGarVenda.Text = "Vendas";
            // 
            // rbVendAbert
            // 
            this.rbVendAbert.AutoSize = true;
            this.rbVendAbert.Location = new System.Drawing.Point(21, 56);
            this.rbVendAbert.Name = "rbVendAbert";
            this.rbVendAbert.Size = new System.Drawing.Size(100, 17);
            this.rbVendAbert.TabIndex = 4;
            this.rbVendAbert.Text = "Vendas Abertas";
            this.rbVendAbert.UseVisualStyleBackColor = true;
            this.rbVendAbert.CheckedChanged += new System.EventHandler(this.rbVendAbert_CheckedChanged);
            // 
            // rbVendEncer
            // 
            this.rbVendEncer.AutoSize = true;
            this.rbVendEncer.Location = new System.Drawing.Point(21, 33);
            this.rbVendEncer.Name = "rbVendEncer";
            this.rbVendEncer.Size = new System.Drawing.Size(118, 17);
            this.rbVendEncer.TabIndex = 6;
            this.rbVendEncer.Text = "Vendas Encerradas";
            this.rbVendEncer.UseVisualStyleBackColor = true;
            this.rbVendEncer.CheckedChanged += new System.EventHandler(this.rbVendEncer_CheckedChanged);
            // 
            // gbGarAll
            // 
            this.gbGarAll.Controls.Add(this.rbGarQuadro2);
            this.gbGarAll.Controls.Add(this.rbGarQuadro1);
            this.gbGarAll.Location = new System.Drawing.Point(155, 1);
            this.gbGarAll.Margin = new System.Windows.Forms.Padding(1);
            this.gbGarAll.Name = "gbGarAll";
            this.gbGarAll.Size = new System.Drawing.Size(113, 100);
            this.gbGarAll.TabIndex = 8;
            this.gbGarAll.TabStop = false;
            this.gbGarAll.Text = "Quadro";
            this.gbGarAll.Enter += new System.EventHandler(this.gbGarAll_Enter);
            // 
            // rbGarQuadro2
            // 
            this.rbGarQuadro2.AutoSize = true;
            this.rbGarQuadro2.Location = new System.Drawing.Point(23, 65);
            this.rbGarQuadro2.Name = "rbGarQuadro2";
            this.rbGarQuadro2.Size = new System.Drawing.Size(55, 17);
            this.rbGarQuadro2.TabIndex = 4;
            this.rbGarQuadro2.Text = "Todos";
            this.rbGarQuadro2.UseVisualStyleBackColor = true;
            this.rbGarQuadro2.CheckedChanged += new System.EventHandler(this.rbGarQuadro2_CheckedChanged);
            // 
            // rbGarQuadro1
            // 
            this.rbGarQuadro1.AutoSize = true;
            this.rbGarQuadro1.Checked = true;
            this.rbGarQuadro1.Location = new System.Drawing.Point(23, 31);
            this.rbGarQuadro1.Name = "rbGarQuadro1";
            this.rbGarQuadro1.Size = new System.Drawing.Size(41, 17);
            this.rbGarQuadro1.TabIndex = 6;
            this.rbGarQuadro1.TabStop = true;
            this.rbGarQuadro1.Text = "Um";
            this.rbGarQuadro1.UseVisualStyleBackColor = true;
            this.rbGarQuadro1.CheckedChanged += new System.EventHandler(this.rbGarQuadro1_CheckedChanged);
            // 
            // gbGarUm
            // 
            this.gbGarUm.Controls.Add(this.cbGarUm);
            this.gbGarUm.Location = new System.Drawing.Point(270, 1);
            this.gbGarUm.Margin = new System.Windows.Forms.Padding(1);
            this.gbGarUm.Name = "gbGarUm";
            this.gbGarUm.Size = new System.Drawing.Size(104, 100);
            this.gbGarUm.TabIndex = 8;
            this.gbGarUm.TabStop = false;
            this.gbGarUm.Text = "Garcon";
            // 
            // cbGarUm
            // 
            this.cbGarUm.FormattingEnabled = true;
            this.cbGarUm.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril ",
            "Maio",
            "Junho ",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbGarUm.Location = new System.Drawing.Point(6, 44);
            this.cbGarUm.Name = "cbGarUm";
            this.cbGarUm.Size = new System.Drawing.Size(88, 21);
            this.cbGarUm.TabIndex = 2;
            // 
            // gbGarAtiv
            // 
            this.gbGarAtiv.Controls.Add(this.rbGarAtivo2);
            this.gbGarAtiv.Controls.Add(this.rbGarAtivo3);
            this.gbGarAtiv.Controls.Add(this.rbGarAtivo1);
            this.gbGarAtiv.Location = new System.Drawing.Point(376, 1);
            this.gbGarAtiv.Margin = new System.Windows.Forms.Padding(1);
            this.gbGarAtiv.Name = "gbGarAtiv";
            this.gbGarAtiv.Size = new System.Drawing.Size(113, 100);
            this.gbGarAtiv.TabIndex = 0;
            this.gbGarAtiv.TabStop = false;
            this.gbGarAtiv.Text = "Ativo";
            // 
            // rbGarAtivo2
            // 
            this.rbGarAtivo2.AutoSize = true;
            this.rbGarAtivo2.Location = new System.Drawing.Point(27, 42);
            this.rbGarAtivo2.Name = "rbGarAtivo2";
            this.rbGarAtivo2.Size = new System.Drawing.Size(49, 17);
            this.rbGarAtivo2.TabIndex = 0;
            this.rbGarAtivo2.Text = "Ativo";
            this.rbGarAtivo2.UseVisualStyleBackColor = true;
            this.rbGarAtivo2.CheckedChanged += new System.EventHandler(this.rbGarAtivo2_CheckedChanged);
            // 
            // rbGarAtivo3
            // 
            this.rbGarAtivo3.AutoSize = true;
            this.rbGarAtivo3.Location = new System.Drawing.Point(27, 65);
            this.rbGarAtivo3.Name = "rbGarAtivo3";
            this.rbGarAtivo3.Size = new System.Drawing.Size(57, 17);
            this.rbGarAtivo3.TabIndex = 2;
            this.rbGarAtivo3.Text = "Inativo";
            this.rbGarAtivo3.UseVisualStyleBackColor = true;
            this.rbGarAtivo3.CheckedChanged += new System.EventHandler(this.rbGarAtivo3_CheckedChanged);
            // 
            // rbGarAtivo1
            // 
            this.rbGarAtivo1.AutoSize = true;
            this.rbGarAtivo1.Checked = true;
            this.rbGarAtivo1.Location = new System.Drawing.Point(27, 19);
            this.rbGarAtivo1.Name = "rbGarAtivo1";
            this.rbGarAtivo1.Size = new System.Drawing.Size(55, 17);
            this.rbGarAtivo1.TabIndex = 3;
            this.rbGarAtivo1.TabStop = true;
            this.rbGarAtivo1.Text = "Todos";
            this.rbGarAtivo1.UseVisualStyleBackColor = true;
            this.rbGarAtivo1.CheckedChanged += new System.EventHandler(this.rbGarAtivo1_CheckedChanged);
            // 
            // gbGarPeriodo
            // 
            this.gbGarPeriodo.Controls.Add(this.rbPeriodo2);
            this.gbGarPeriodo.Controls.Add(this.rbPeriodo3);
            this.gbGarPeriodo.Controls.Add(this.rbPeriodo1);
            this.gbGarPeriodo.Location = new System.Drawing.Point(491, 1);
            this.gbGarPeriodo.Margin = new System.Windows.Forms.Padding(1);
            this.gbGarPeriodo.Name = "gbGarPeriodo";
            this.gbGarPeriodo.Size = new System.Drawing.Size(113, 100);
            this.gbGarPeriodo.TabIndex = 1;
            this.gbGarPeriodo.TabStop = false;
            this.gbGarPeriodo.Text = "Período";
            // 
            // rbPeriodo2
            // 
            this.rbPeriodo2.AutoSize = true;
            this.rbPeriodo2.Location = new System.Drawing.Point(23, 42);
            this.rbPeriodo2.Name = "rbPeriodo2";
            this.rbPeriodo2.Size = new System.Drawing.Size(45, 17);
            this.rbPeriodo2.TabIndex = 4;
            this.rbPeriodo2.Text = "Mes";
            this.rbPeriodo2.UseVisualStyleBackColor = true;
            this.rbPeriodo2.CheckedChanged += new System.EventHandler(this.rbPeriodo2_CheckedChanged);
            // 
            // rbPeriodo3
            // 
            this.rbPeriodo3.AutoSize = true;
            this.rbPeriodo3.Location = new System.Drawing.Point(23, 19);
            this.rbPeriodo3.Name = "rbPeriodo3";
            this.rbPeriodo3.Size = new System.Drawing.Size(41, 17);
            this.rbPeriodo3.TabIndex = 5;
            this.rbPeriodo3.Text = "Dia";
            this.rbPeriodo3.UseVisualStyleBackColor = true;
            this.rbPeriodo3.CheckedChanged += new System.EventHandler(this.rbPeriodo3_CheckedChanged);
            // 
            // rbPeriodo1
            // 
            this.rbPeriodo1.AutoSize = true;
            this.rbPeriodo1.Checked = true;
            this.rbPeriodo1.Location = new System.Drawing.Point(23, 65);
            this.rbPeriodo1.Name = "rbPeriodo1";
            this.rbPeriodo1.Size = new System.Drawing.Size(61, 17);
            this.rbPeriodo1.TabIndex = 6;
            this.rbPeriodo1.TabStop = true;
            this.rbPeriodo1.Text = "Periodo";
            this.rbPeriodo1.UseVisualStyleBackColor = true;
            this.rbPeriodo1.CheckedChanged += new System.EventHandler(this.rbPeriodo1_CheckedChanged);
            // 
            // gbPicker
            // 
            this.gbPicker.Controls.Add(this.cbAnoGarcon);
            this.gbPicker.Controls.Add(this.btConfirmarGarcon);
            this.gbPicker.Controls.Add(this.cbMesGarcon);
            this.gbPicker.Controls.Add(this.dtPData2);
            this.gbPicker.Controls.Add(this.dtPData1);
            this.gbPicker.Location = new System.Drawing.Point(606, 1);
            this.gbPicker.Margin = new System.Windows.Forms.Padding(1);
            this.gbPicker.Name = "gbPicker";
            this.gbPicker.Size = new System.Drawing.Size(247, 100);
            this.gbPicker.TabIndex = 1;
            this.gbPicker.TabStop = false;
            // 
            // cbAnoGarcon
            // 
            this.cbAnoGarcon.FormattingEnabled = true;
            this.cbAnoGarcon.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014"});
            this.cbAnoGarcon.Location = new System.Drawing.Point(6, 15);
            this.cbAnoGarcon.Name = "cbAnoGarcon";
            this.cbAnoGarcon.Size = new System.Drawing.Size(121, 21);
            this.cbAnoGarcon.TabIndex = 44;
            this.cbAnoGarcon.SelectedIndexChanged += new System.EventHandler(this.cbAnoGarcon_SelectedIndexChanged);
            // 
            // btConfirmarGarcon
            // 
            this.btConfirmarGarcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConfirmarGarcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmarGarcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirmarGarcon.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarGarcon.Location = new System.Drawing.Point(93, 67);
            this.btConfirmarGarcon.Name = "btConfirmarGarcon";
            this.btConfirmarGarcon.Size = new System.Drawing.Size(77, 28);
            this.btConfirmarGarcon.TabIndex = 43;
            this.btConfirmarGarcon.UseVisualStyleBackColor = true;
            this.btConfirmarGarcon.Click += new System.EventHandler(this.btConfirmarGarcon_Click);
            // 
            // cbMesGarcon
            // 
            this.cbMesGarcon.FormattingEnabled = true;
            this.cbMesGarcon.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril ",
            "Maio",
            "Junho ",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMesGarcon.Location = new System.Drawing.Point(6, 40);
            this.cbMesGarcon.Name = "cbMesGarcon";
            this.cbMesGarcon.Size = new System.Drawing.Size(121, 21);
            this.cbMesGarcon.TabIndex = 1;
            this.cbMesGarcon.SelectedIndexChanged += new System.EventHandler(this.cbMesGarcon_SelectedIndexChanged);
            // 
            // dtPData2
            // 
            this.dtPData2.Location = new System.Drawing.Point(6, 41);
            this.dtPData2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPData2.Name = "dtPData2";
            this.dtPData2.Size = new System.Drawing.Size(223, 20);
            this.dtPData2.TabIndex = 9;
            this.dtPData2.ValueChanged += new System.EventHandler(this.dtPData2_ValueChanged);
            // 
            // dtPData1
            // 
            this.dtPData1.Location = new System.Drawing.Point(6, 16);
            this.dtPData1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPData1.Name = "dtPData1";
            this.dtPData1.Size = new System.Drawing.Size(223, 20);
            this.dtPData1.TabIndex = 8;
            this.dtPData1.ValueChanged += new System.EventHandler(this.dtPData1_ValueChanged);
            // 
            // btConsulta
            // 
            this.btConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsulta.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(3, 105);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(77, 28);
            this.btConsulta.TabIndex = 44;
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // RelatorioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 601);
            this.ControlBox = false;
            this.Controls.Add(this.tlpConsulta1Nivel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Garcon";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpConsulta1Nivel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbGarconConsulta.ResumeLayout(false);
            this.flpBaixoGarcon.ResumeLayout(false);
            this.gbGarVenda.ResumeLayout(false);
            this.gbGarVenda.PerformLayout();
            this.gbGarAll.ResumeLayout(false);
            this.gbGarAll.PerformLayout();
            this.gbGarUm.ResumeLayout(false);
            this.gbGarAtiv.ResumeLayout(false);
            this.gbGarAtiv.PerformLayout();
            this.gbGarPeriodo.ResumeLayout(false);
            this.gbGarPeriodo.PerformLayout();
            this.gbPicker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpConsulta1Nivel2;
        private System.Windows.Forms.ListView lvConsInfo;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader ValorUni;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbGarAtiv;
        private System.Windows.Forms.GroupBox gbPicker;
        private System.Windows.Forms.RadioButton rbGarAtivo2;
        private System.Windows.Forms.GroupBox gbGarconConsulta;
        private System.Windows.Forms.GroupBox gbGarPeriodo;
        private System.Windows.Forms.RadioButton rbGarAtivo1;
        private System.Windows.Forms.RadioButton rbGarAtivo3;
        private System.Windows.Forms.ComboBox cbGarcConsulta;
        private System.Windows.Forms.ComboBox cbMesGarcon;
        private System.Windows.Forms.DateTimePicker dtPData1;
        private System.Windows.Forms.RadioButton rbPeriodo1;
        private System.Windows.Forms.RadioButton rbPeriodo3;
        private System.Windows.Forms.RadioButton rbPeriodo2;
        private System.Windows.Forms.FlowLayoutPanel flpBaixoGarcon;
        private System.Windows.Forms.GroupBox gbGarAll;
        private System.Windows.Forms.DateTimePicker dtPData2;
        private System.Windows.Forms.RadioButton rbGarQuadro2;
        private System.Windows.Forms.RadioButton rbGarQuadro1;
        private System.Windows.Forms.Button btConfirmarGarcon;
        private System.Windows.Forms.ComboBox cbAnoGarcon;
        private System.Windows.Forms.GroupBox gbGarUm;
        private System.Windows.Forms.ComboBox cbGarUm;
        private System.Windows.Forms.GroupBox gbGarVenda;
        private System.Windows.Forms.RadioButton rbVendAbert;
        private System.Windows.Forms.RadioButton rbVendEncer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btConsulta;
    }
}