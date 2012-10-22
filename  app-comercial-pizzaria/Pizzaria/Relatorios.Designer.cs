namespace Pizzaria
{
    partial class TipoRelatorio
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
            this.LTipoRelatorio = new System.Windows.Forms.Label();
            this.LRelatorio = new System.Windows.Forms.Label();
            this.cbRelatorio = new System.Windows.Forms.ComboBox();
            this.RBDiaAtual = new System.Windows.Forms.RadioButton();
            this.LDiaAtual = new System.Windows.Forms.Label();
            this.CBDia = new System.Windows.Forms.ComboBox();
            this.gbDiaVenda = new System.Windows.Forms.GroupBox();
            this.gbMesVenda = new System.Windows.Forms.GroupBox();
            this.LMesAtual = new System.Windows.Forms.Label();
            this.RBMesAtual = new System.Windows.Forms.RadioButton();
            this.CBMes = new System.Windows.Forms.ComboBox();
            this.gbAnoVenda = new System.Windows.Forms.GroupBox();
            this.LAnoAtual = new System.Windows.Forms.Label();
            this.RBAnoAtual = new System.Windows.Forms.RadioButton();
            this.CBAno = new System.Windows.Forms.ComboBox();
            this.gbPeriodoVenda = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flpPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pVenda = new System.Windows.Forms.Panel();
            this.btConsultarVenda = new System.Windows.Forms.Button();
            this.gbVendaOrdenar = new System.Windows.Forms.GroupBox();
            this.rbCrescente = new System.Windows.Forms.RadioButton();
            this.rbDecrescente = new System.Windows.Forms.RadioButton();
            this.pGarcon = new System.Windows.Forms.Panel();
            this.btConsultarGarcon = new System.Windows.Forms.Button();
            this.gbPeriodoGarcon = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.gpGarcon = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pProduto = new System.Windows.Forms.Panel();
            this.btConsultarProduto = new System.Windows.Forms.Button();
            this.gbPeriodoProduto = new System.Windows.Forms.GroupBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOrdenarVenda = new System.Windows.Forms.ComboBox();
            this.gbFiltroVenda = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbFiltroGarcon = new System.Windows.Forms.GroupBox();
            this.cbFiltroGarcon = new System.Windows.Forms.ComboBox();
            this.gbFiltrarProduto = new System.Windows.Forms.GroupBox();
            this.cbFiltrarProduto = new System.Windows.Forms.ComboBox();
            this.gbOrdenarGarcon = new System.Windows.Forms.GroupBox();
            this.cbOrdenarGarcon = new System.Windows.Forms.ComboBox();
            this.rbOrdenarGarcon = new System.Windows.Forms.RadioButton();
            this.rbOrdenarGarconD = new System.Windows.Forms.RadioButton();
            this.gbOrdenarProduto = new System.Windows.Forms.GroupBox();
            this.cbOrdenarProduto = new System.Windows.Forms.ComboBox();
            this.rbOrdenarProdutoC = new System.Windows.Forms.RadioButton();
            this.rbOrdenarProdutoD = new System.Windows.Forms.RadioButton();
            this.gbDiaVenda.SuspendLayout();
            this.gbMesVenda.SuspendLayout();
            this.gbAnoVenda.SuspendLayout();
            this.gbPeriodoVenda.SuspendLayout();
            this.flpPrincipal.SuspendLayout();
            this.pVenda.SuspendLayout();
            this.gbVendaOrdenar.SuspendLayout();
            this.pGarcon.SuspendLayout();
            this.gbPeriodoGarcon.SuspendLayout();
            this.gpGarcon.SuspendLayout();
            this.pProduto.SuspendLayout();
            this.gbPeriodoProduto.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbFiltroVenda.SuspendLayout();
            this.gbFiltroGarcon.SuspendLayout();
            this.gbFiltrarProduto.SuspendLayout();
            this.gbOrdenarGarcon.SuspendLayout();
            this.gbOrdenarProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTipoRelatorio
            // 
            this.LTipoRelatorio.AutoSize = true;
            this.LTipoRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoRelatorio.Location = new System.Drawing.Point(3, 25);
            this.LTipoRelatorio.Name = "LTipoRelatorio";
            this.LTipoRelatorio.Size = new System.Drawing.Size(164, 16);
            this.LTipoRelatorio.TabIndex = 0;
            this.LTipoRelatorio.Text = "Escolha o tipo de relatório";
            this.LTipoRelatorio.Click += new System.EventHandler(this.TipoRel_Click);
            // 
            // LRelatorio
            // 
            this.LRelatorio.AutoSize = true;
            this.LRelatorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRelatorio.Location = new System.Drawing.Point(455, 9);
            this.LRelatorio.Name = "LRelatorio";
            this.LRelatorio.Size = new System.Drawing.Size(121, 18);
            this.LRelatorio.TabIndex = 1;
            this.LRelatorio.Text = "RELATÓRIOS ";
            // 
            // cbRelatorio
            // 
            this.cbRelatorio.FormattingEnabled = true;
            this.cbRelatorio.Items.AddRange(new object[] {
            "Vendas",
            "Garçon",
            "Produto"});
            this.cbRelatorio.Location = new System.Drawing.Point(22, 57);
            this.cbRelatorio.Name = "cbRelatorio";
            this.cbRelatorio.Size = new System.Drawing.Size(121, 21);
            this.cbRelatorio.TabIndex = 2;
            // 
            // RBDiaAtual
            // 
            this.RBDiaAtual.AutoSize = true;
            this.RBDiaAtual.Location = new System.Drawing.Point(42, 16);
            this.RBDiaAtual.Name = "RBDiaAtual";
            this.RBDiaAtual.Size = new System.Drawing.Size(14, 13);
            this.RBDiaAtual.TabIndex = 0;
            this.RBDiaAtual.TabStop = true;
            this.RBDiaAtual.UseVisualStyleBackColor = true;
            this.RBDiaAtual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LDiaAtual
            // 
            this.LDiaAtual.AutoSize = true;
            this.LDiaAtual.Location = new System.Drawing.Point(6, 16);
            this.LDiaAtual.Name = "LDiaAtual";
            this.LDiaAtual.Size = new System.Drawing.Size(29, 13);
            this.LDiaAtual.TabIndex = 1;
            this.LDiaAtual.Text = "Hoje";
            // 
            // CBDia
            // 
            this.CBDia.FormattingEnabled = true;
            this.CBDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.CBDia.Location = new System.Drawing.Point(9, 32);
            this.CBDia.Name = "CBDia";
            this.CBDia.Size = new System.Drawing.Size(47, 21);
            this.CBDia.TabIndex = 4;
            // 
            // gbDiaVenda
            // 
            this.gbDiaVenda.Controls.Add(this.LDiaAtual);
            this.gbDiaVenda.Controls.Add(this.RBDiaAtual);
            this.gbDiaVenda.Controls.Add(this.CBDia);
            this.gbDiaVenda.Location = new System.Drawing.Point(7, 25);
            this.gbDiaVenda.Name = "gbDiaVenda";
            this.gbDiaVenda.Size = new System.Drawing.Size(72, 59);
            this.gbDiaVenda.TabIndex = 5;
            this.gbDiaVenda.TabStop = false;
            this.gbDiaVenda.Text = "Dia";
            // 
            // gbMesVenda
            // 
            this.gbMesVenda.Controls.Add(this.LMesAtual);
            this.gbMesVenda.Controls.Add(this.RBMesAtual);
            this.gbMesVenda.Controls.Add(this.CBMes);
            this.gbMesVenda.Location = new System.Drawing.Point(85, 25);
            this.gbMesVenda.Name = "gbMesVenda";
            this.gbMesVenda.Size = new System.Drawing.Size(72, 59);
            this.gbMesVenda.TabIndex = 6;
            this.gbMesVenda.TabStop = false;
            this.gbMesVenda.Text = "Mês";
            // 
            // LMesAtual
            // 
            this.LMesAtual.AutoSize = true;
            this.LMesAtual.Location = new System.Drawing.Point(6, 16);
            this.LMesAtual.Name = "LMesAtual";
            this.LMesAtual.Size = new System.Drawing.Size(31, 13);
            this.LMesAtual.TabIndex = 1;
            this.LMesAtual.Text = "Atual";
            // 
            // RBMesAtual
            // 
            this.RBMesAtual.AutoSize = true;
            this.RBMesAtual.Location = new System.Drawing.Point(42, 16);
            this.RBMesAtual.Name = "RBMesAtual";
            this.RBMesAtual.Size = new System.Drawing.Size(14, 13);
            this.RBMesAtual.TabIndex = 0;
            this.RBMesAtual.TabStop = true;
            this.RBMesAtual.UseVisualStyleBackColor = true;
            // 
            // CBMes
            // 
            this.CBMes.FormattingEnabled = true;
            this.CBMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CBMes.Location = new System.Drawing.Point(9, 32);
            this.CBMes.Name = "CBMes";
            this.CBMes.Size = new System.Drawing.Size(47, 21);
            this.CBMes.TabIndex = 4;
            // 
            // gbAnoVenda
            // 
            this.gbAnoVenda.Controls.Add(this.LAnoAtual);
            this.gbAnoVenda.Controls.Add(this.RBAnoAtual);
            this.gbAnoVenda.Controls.Add(this.CBAno);
            this.gbAnoVenda.Location = new System.Drawing.Point(163, 25);
            this.gbAnoVenda.Name = "gbAnoVenda";
            this.gbAnoVenda.Size = new System.Drawing.Size(72, 59);
            this.gbAnoVenda.TabIndex = 7;
            this.gbAnoVenda.TabStop = false;
            this.gbAnoVenda.Text = "Ano";
            // 
            // LAnoAtual
            // 
            this.LAnoAtual.AutoSize = true;
            this.LAnoAtual.Location = new System.Drawing.Point(6, 16);
            this.LAnoAtual.Name = "LAnoAtual";
            this.LAnoAtual.Size = new System.Drawing.Size(31, 13);
            this.LAnoAtual.TabIndex = 1;
            this.LAnoAtual.Text = "Atual";
            // 
            // RBAnoAtual
            // 
            this.RBAnoAtual.AutoSize = true;
            this.RBAnoAtual.Location = new System.Drawing.Point(42, 16);
            this.RBAnoAtual.Name = "RBAnoAtual";
            this.RBAnoAtual.Size = new System.Drawing.Size(14, 13);
            this.RBAnoAtual.TabIndex = 0;
            this.RBAnoAtual.TabStop = true;
            this.RBAnoAtual.UseVisualStyleBackColor = true;
            // 
            // CBAno
            // 
            this.CBAno.FormattingEnabled = true;
            this.CBAno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CBAno.Location = new System.Drawing.Point(9, 32);
            this.CBAno.Name = "CBAno";
            this.CBAno.Size = new System.Drawing.Size(57, 21);
            this.CBAno.TabIndex = 4;
            // 
            // gbPeriodoVenda
            // 
            this.gbPeriodoVenda.Controls.Add(this.dateTimePicker2);
            this.gbPeriodoVenda.Controls.Add(this.dateTimePicker1);
            this.gbPeriodoVenda.Location = new System.Drawing.Point(241, 25);
            this.gbPeriodoVenda.Name = "gbPeriodoVenda";
            this.gbPeriodoVenda.Size = new System.Drawing.Size(232, 59);
            this.gbPeriodoVenda.TabIndex = 8;
            this.gbPeriodoVenda.TabStop = false;
            this.gbPeriodoVenda.Text = "Período";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 19);
            this.dateTimePicker2.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // flpPrincipal
            // 
            this.flpPrincipal.Controls.Add(this.pVenda);
            this.flpPrincipal.Controls.Add(this.pGarcon);
            this.flpPrincipal.Controls.Add(this.pProduto);
            this.flpPrincipal.Location = new System.Drawing.Point(185, 32);
            this.flpPrincipal.Name = "flpPrincipal";
            this.flpPrincipal.Size = new System.Drawing.Size(768, 307);
            this.flpPrincipal.TabIndex = 9;
            // 
            // pVenda
            // 
            this.pVenda.Controls.Add(this.gbFiltroVenda);
            this.pVenda.Controls.Add(this.btConsultarVenda);
            this.pVenda.Controls.Add(this.gbVendaOrdenar);
            this.pVenda.Controls.Add(this.gbDiaVenda);
            this.pVenda.Controls.Add(this.gbPeriodoVenda);
            this.pVenda.Controls.Add(this.gbAnoVenda);
            this.pVenda.Controls.Add(this.gbMesVenda);
            this.pVenda.Location = new System.Drawing.Point(3, 3);
            this.pVenda.Name = "pVenda";
            this.pVenda.Size = new System.Drawing.Size(765, 94);
            this.pVenda.TabIndex = 10;
            // 
            // btConsultarVenda
            // 
            this.btConsultarVenda.Location = new System.Drawing.Point(687, 41);
            this.btConsultarVenda.Name = "btConsultarVenda";
            this.btConsultarVenda.Size = new System.Drawing.Size(75, 23);
            this.btConsultarVenda.TabIndex = 10;
            this.btConsultarVenda.Text = "Consultar";
            this.btConsultarVenda.UseVisualStyleBackColor = true;
            // 
            // gbVendaOrdenar
            // 
            this.gbVendaOrdenar.Controls.Add(this.cbOrdenarVenda);
            this.gbVendaOrdenar.Controls.Add(this.rbCrescente);
            this.gbVendaOrdenar.Controls.Add(this.rbDecrescente);
            this.gbVendaOrdenar.Location = new System.Drawing.Point(567, 10);
            this.gbVendaOrdenar.Name = "gbVendaOrdenar";
            this.gbVendaOrdenar.Size = new System.Drawing.Size(114, 81);
            this.gbVendaOrdenar.TabIndex = 9;
            this.gbVendaOrdenar.TabStop = false;
            this.gbVendaOrdenar.Text = "Ordenar";
            // 
            // rbCrescente
            // 
            this.rbCrescente.AutoSize = true;
            this.rbCrescente.Location = new System.Drawing.Point(20, 45);
            this.rbCrescente.Name = "rbCrescente";
            this.rbCrescente.Size = new System.Drawing.Size(73, 17);
            this.rbCrescente.TabIndex = 3;
            this.rbCrescente.TabStop = true;
            this.rbCrescente.Text = "Crescente";
            this.rbCrescente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbCrescente.UseVisualStyleBackColor = true;
            this.rbCrescente.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbDecrescente
            // 
            this.rbDecrescente.AutoSize = true;
            this.rbDecrescente.Location = new System.Drawing.Point(20, 62);
            this.rbDecrescente.Name = "rbDecrescente";
            this.rbDecrescente.Size = new System.Drawing.Size(86, 17);
            this.rbDecrescente.TabIndex = 2;
            this.rbDecrescente.TabStop = true;
            this.rbDecrescente.Text = "Decrescente";
            this.rbDecrescente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbDecrescente.UseVisualStyleBackColor = true;
            // 
            // pGarcon
            // 
            this.pGarcon.Controls.Add(this.gbOrdenarGarcon);
            this.pGarcon.Controls.Add(this.gbFiltroGarcon);
            this.pGarcon.Controls.Add(this.btConsultarGarcon);
            this.pGarcon.Controls.Add(this.gbPeriodoGarcon);
            this.pGarcon.Controls.Add(this.gpGarcon);
            this.pGarcon.Location = new System.Drawing.Point(3, 103);
            this.pGarcon.Name = "pGarcon";
            this.pGarcon.Size = new System.Drawing.Size(762, 94);
            this.pGarcon.TabIndex = 11;
            // 
            // btConsultarGarcon
            // 
            this.btConsultarGarcon.Location = new System.Drawing.Point(587, 44);
            this.btConsultarGarcon.Name = "btConsultarGarcon";
            this.btConsultarGarcon.Size = new System.Drawing.Size(75, 23);
            this.btConsultarGarcon.TabIndex = 11;
            this.btConsultarGarcon.Text = "Consultar";
            this.btConsultarGarcon.UseVisualStyleBackColor = true;
            // 
            // gbPeriodoGarcon
            // 
            this.gbPeriodoGarcon.Controls.Add(this.dateTimePicker3);
            this.gbPeriodoGarcon.Controls.Add(this.dateTimePicker4);
            this.gbPeriodoGarcon.Location = new System.Drawing.Point(128, 25);
            this.gbPeriodoGarcon.Name = "gbPeriodoGarcon";
            this.gbPeriodoGarcon.Size = new System.Drawing.Size(232, 59);
            this.gbPeriodoGarcon.TabIndex = 9;
            this.gbPeriodoGarcon.TabStop = false;
            this.gbPeriodoGarcon.Text = "Período";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(113, 19);
            this.dateTimePicker3.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker3.TabIndex = 11;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker4.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker4.TabIndex = 10;
            // 
            // gpGarcon
            // 
            this.gpGarcon.Controls.Add(this.comboBox1);
            this.gpGarcon.Location = new System.Drawing.Point(7, 25);
            this.gpGarcon.Name = "gpGarcon";
            this.gpGarcon.Size = new System.Drawing.Size(115, 59);
            this.gpGarcon.TabIndex = 5;
            this.gpGarcon.TabStop = false;
            this.gpGarcon.Text = "Garçon";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // pProduto
            // 
            this.pProduto.Controls.Add(this.gbOrdenarProduto);
            this.pProduto.Controls.Add(this.gbFiltrarProduto);
            this.pProduto.Controls.Add(this.btConsultarProduto);
            this.pProduto.Controls.Add(this.gbPeriodoProduto);
            this.pProduto.Controls.Add(this.gbProduto);
            this.pProduto.Location = new System.Drawing.Point(3, 203);
            this.pProduto.Name = "pProduto";
            this.pProduto.Size = new System.Drawing.Size(698, 94);
            this.pProduto.TabIndex = 12;
            // 
            // btConsultarProduto
            // 
            this.btConsultarProduto.Location = new System.Drawing.Point(587, 38);
            this.btConsultarProduto.Name = "btConsultarProduto";
            this.btConsultarProduto.Size = new System.Drawing.Size(75, 23);
            this.btConsultarProduto.TabIndex = 11;
            this.btConsultarProduto.Text = "Consultar";
            this.btConsultarProduto.UseVisualStyleBackColor = true;
            this.btConsultarProduto.Click += new System.EventHandler(this.bt_Click);
            // 
            // gbPeriodoProduto
            // 
            this.gbPeriodoProduto.Controls.Add(this.dateTimePicker5);
            this.gbPeriodoProduto.Controls.Add(this.dateTimePicker6);
            this.gbPeriodoProduto.Location = new System.Drawing.Point(128, 25);
            this.gbPeriodoProduto.Name = "gbPeriodoProduto";
            this.gbPeriodoProduto.Size = new System.Drawing.Size(232, 59);
            this.gbPeriodoProduto.TabIndex = 9;
            this.gbPeriodoProduto.TabStop = false;
            this.gbPeriodoProduto.Text = "Período";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(113, 19);
            this.dateTimePicker5.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker6.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker6.TabIndex = 10;
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.cbProduto);
            this.gbProduto.Location = new System.Drawing.Point(7, 25);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(115, 59);
            this.gbProduto.TabIndex = 5;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(9, 32);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(100, 21);
            this.cbProduto.TabIndex = 4;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbRelatorio);
            this.panel1.Controls.Add(this.LTipoRelatorio);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 94);
            this.panel1.TabIndex = 10;
            // 
            // cbOrdenarVenda
            // 
            this.cbOrdenarVenda.FormattingEnabled = true;
            this.cbOrdenarVenda.Location = new System.Drawing.Point(6, 23);
            this.cbOrdenarVenda.Name = "cbOrdenarVenda";
            this.cbOrdenarVenda.Size = new System.Drawing.Size(102, 21);
            this.cbOrdenarVenda.TabIndex = 4;
            // 
            // gbFiltroVenda
            // 
            this.gbFiltroVenda.Controls.Add(this.comboBox2);
            this.gbFiltroVenda.Location = new System.Drawing.Point(479, 10);
            this.gbFiltroVenda.Name = "gbFiltroVenda";
            this.gbFiltroVenda.Size = new System.Drawing.Size(88, 81);
            this.gbFiltroVenda.TabIndex = 11;
            this.gbFiltroVenda.TabStop = false;
            this.gbFiltroVenda.Text = "Filtrar";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // gbFiltroGarcon
            // 
            this.gbFiltroGarcon.Controls.Add(this.cbFiltroGarcon);
            this.gbFiltroGarcon.Location = new System.Drawing.Point(366, 10);
            this.gbFiltroGarcon.Name = "gbFiltroGarcon";
            this.gbFiltroGarcon.Size = new System.Drawing.Size(88, 81);
            this.gbFiltroGarcon.TabIndex = 12;
            this.gbFiltroGarcon.TabStop = false;
            this.gbFiltroGarcon.Text = "Filtrar";
            // 
            // cbFiltroGarcon
            // 
            this.cbFiltroGarcon.FormattingEnabled = true;
            this.cbFiltroGarcon.Location = new System.Drawing.Point(6, 34);
            this.cbFiltroGarcon.Name = "cbFiltroGarcon";
            this.cbFiltroGarcon.Size = new System.Drawing.Size(76, 21);
            this.cbFiltroGarcon.TabIndex = 5;
            // 
            // gbFiltrarProduto
            // 
            this.gbFiltrarProduto.Controls.Add(this.cbFiltrarProduto);
            this.gbFiltrarProduto.Location = new System.Drawing.Point(366, 10);
            this.gbFiltrarProduto.Name = "gbFiltrarProduto";
            this.gbFiltrarProduto.Size = new System.Drawing.Size(88, 81);
            this.gbFiltrarProduto.TabIndex = 12;
            this.gbFiltrarProduto.TabStop = false;
            this.gbFiltrarProduto.Text = "Filtrar";
            // 
            // cbFiltrarProduto
            // 
            this.cbFiltrarProduto.FormattingEnabled = true;
            this.cbFiltrarProduto.Location = new System.Drawing.Point(6, 34);
            this.cbFiltrarProduto.Name = "cbFiltrarProduto";
            this.cbFiltrarProduto.Size = new System.Drawing.Size(76, 21);
            this.cbFiltrarProduto.TabIndex = 5;
            // 
            // gbOrdenarGarcon
            // 
            this.gbOrdenarGarcon.Controls.Add(this.cbOrdenarGarcon);
            this.gbOrdenarGarcon.Controls.Add(this.rbOrdenarGarcon);
            this.gbOrdenarGarcon.Controls.Add(this.rbOrdenarGarconD);
            this.gbOrdenarGarcon.Location = new System.Drawing.Point(460, 10);
            this.gbOrdenarGarcon.Name = "gbOrdenarGarcon";
            this.gbOrdenarGarcon.Size = new System.Drawing.Size(114, 81);
            this.gbOrdenarGarcon.TabIndex = 13;
            this.gbOrdenarGarcon.TabStop = false;
            this.gbOrdenarGarcon.Text = "Ordenar";
            // 
            // cbOrdenarGarcon
            // 
            this.cbOrdenarGarcon.FormattingEnabled = true;
            this.cbOrdenarGarcon.Location = new System.Drawing.Point(6, 23);
            this.cbOrdenarGarcon.Name = "cbOrdenarGarcon";
            this.cbOrdenarGarcon.Size = new System.Drawing.Size(102, 21);
            this.cbOrdenarGarcon.TabIndex = 4;
            // 
            // rbOrdenarGarcon
            // 
            this.rbOrdenarGarcon.AutoSize = true;
            this.rbOrdenarGarcon.Location = new System.Drawing.Point(20, 45);
            this.rbOrdenarGarcon.Name = "rbOrdenarGarcon";
            this.rbOrdenarGarcon.Size = new System.Drawing.Size(73, 17);
            this.rbOrdenarGarcon.TabIndex = 3;
            this.rbOrdenarGarcon.TabStop = true;
            this.rbOrdenarGarcon.Text = "Crescente";
            this.rbOrdenarGarcon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbOrdenarGarcon.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarGarconD
            // 
            this.rbOrdenarGarconD.AutoSize = true;
            this.rbOrdenarGarconD.Location = new System.Drawing.Point(20, 62);
            this.rbOrdenarGarconD.Name = "rbOrdenarGarconD";
            this.rbOrdenarGarconD.Size = new System.Drawing.Size(86, 17);
            this.rbOrdenarGarconD.TabIndex = 2;
            this.rbOrdenarGarconD.TabStop = true;
            this.rbOrdenarGarconD.Text = "Decrescente";
            this.rbOrdenarGarconD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbOrdenarGarconD.UseVisualStyleBackColor = true;
            // 
            // gbOrdenarProduto
            // 
            this.gbOrdenarProduto.Controls.Add(this.cbOrdenarProduto);
            this.gbOrdenarProduto.Controls.Add(this.rbOrdenarProdutoC);
            this.gbOrdenarProduto.Controls.Add(this.rbOrdenarProdutoD);
            this.gbOrdenarProduto.Location = new System.Drawing.Point(460, 10);
            this.gbOrdenarProduto.Name = "gbOrdenarProduto";
            this.gbOrdenarProduto.Size = new System.Drawing.Size(114, 81);
            this.gbOrdenarProduto.TabIndex = 13;
            this.gbOrdenarProduto.TabStop = false;
            this.gbOrdenarProduto.Text = "Ordenar";
            // 
            // cbOrdenarProduto
            // 
            this.cbOrdenarProduto.FormattingEnabled = true;
            this.cbOrdenarProduto.Location = new System.Drawing.Point(6, 23);
            this.cbOrdenarProduto.Name = "cbOrdenarProduto";
            this.cbOrdenarProduto.Size = new System.Drawing.Size(102, 21);
            this.cbOrdenarProduto.TabIndex = 4;
            // 
            // rbOrdenarProdutoC
            // 
            this.rbOrdenarProdutoC.AutoSize = true;
            this.rbOrdenarProdutoC.Location = new System.Drawing.Point(20, 45);
            this.rbOrdenarProdutoC.Name = "rbOrdenarProdutoC";
            this.rbOrdenarProdutoC.Size = new System.Drawing.Size(73, 17);
            this.rbOrdenarProdutoC.TabIndex = 3;
            this.rbOrdenarProdutoC.TabStop = true;
            this.rbOrdenarProdutoC.Text = "Crescente";
            this.rbOrdenarProdutoC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbOrdenarProdutoC.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarProdutoD
            // 
            this.rbOrdenarProdutoD.AutoSize = true;
            this.rbOrdenarProdutoD.Location = new System.Drawing.Point(20, 62);
            this.rbOrdenarProdutoD.Name = "rbOrdenarProdutoD";
            this.rbOrdenarProdutoD.Size = new System.Drawing.Size(86, 17);
            this.rbOrdenarProdutoD.TabIndex = 2;
            this.rbOrdenarProdutoD.TabStop = true;
            this.rbOrdenarProdutoD.Text = "Decrescente";
            this.rbOrdenarProdutoD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbOrdenarProdutoD.UseVisualStyleBackColor = true;
            // 
            // TipoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpPrincipal);
            this.Controls.Add(this.LRelatorio);
            this.Name = "TipoRelatorio";
            this.Text = "Relatorios";
            this.gbDiaVenda.ResumeLayout(false);
            this.gbDiaVenda.PerformLayout();
            this.gbMesVenda.ResumeLayout(false);
            this.gbMesVenda.PerformLayout();
            this.gbAnoVenda.ResumeLayout(false);
            this.gbAnoVenda.PerformLayout();
            this.gbPeriodoVenda.ResumeLayout(false);
            this.flpPrincipal.ResumeLayout(false);
            this.pVenda.ResumeLayout(false);
            this.gbVendaOrdenar.ResumeLayout(false);
            this.gbVendaOrdenar.PerformLayout();
            this.pGarcon.ResumeLayout(false);
            this.gbPeriodoGarcon.ResumeLayout(false);
            this.gpGarcon.ResumeLayout(false);
            this.pProduto.ResumeLayout(false);
            this.gbPeriodoProduto.ResumeLayout(false);
            this.gbProduto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFiltroVenda.ResumeLayout(false);
            this.gbFiltroGarcon.ResumeLayout(false);
            this.gbFiltrarProduto.ResumeLayout(false);
            this.gbOrdenarGarcon.ResumeLayout(false);
            this.gbOrdenarGarcon.PerformLayout();
            this.gbOrdenarProduto.ResumeLayout(false);
            this.gbOrdenarProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTipoRelatorio;
        private System.Windows.Forms.Label LRelatorio;
        private System.Windows.Forms.ComboBox cbRelatorio;
        private System.Windows.Forms.RadioButton RBDiaAtual;
        private System.Windows.Forms.Label LDiaAtual;
        private System.Windows.Forms.ComboBox CBDia;
        private System.Windows.Forms.GroupBox gbDiaVenda;
        private System.Windows.Forms.GroupBox gbMesVenda;
        private System.Windows.Forms.Label LMesAtual;
        private System.Windows.Forms.RadioButton RBMesAtual;
        private System.Windows.Forms.ComboBox CBMes;
        private System.Windows.Forms.GroupBox gbAnoVenda;
        private System.Windows.Forms.Label LAnoAtual;
        private System.Windows.Forms.RadioButton RBAnoAtual;
        private System.Windows.Forms.ComboBox CBAno;
        private System.Windows.Forms.GroupBox gbPeriodoVenda;
        private System.Windows.Forms.FlowLayoutPanel flpPrincipal;
        private System.Windows.Forms.Panel pVenda;
        private System.Windows.Forms.Panel pGarcon;
        private System.Windows.Forms.GroupBox gpGarcon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbVendaOrdenar;
        private System.Windows.Forms.RadioButton rbCrescente;
        private System.Windows.Forms.RadioButton rbDecrescente;
        private System.Windows.Forms.Button btConsultarVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConsultarGarcon;
        private System.Windows.Forms.GroupBox gbPeriodoGarcon;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Panel pProduto;
        private System.Windows.Forms.Button btConsultarProduto;
        private System.Windows.Forms.GroupBox gbPeriodoProduto;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.ComboBox cbOrdenarVenda;
        private System.Windows.Forms.GroupBox gbFiltroVenda;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gbOrdenarGarcon;
        private System.Windows.Forms.ComboBox cbOrdenarGarcon;
        private System.Windows.Forms.RadioButton rbOrdenarGarcon;
        private System.Windows.Forms.RadioButton rbOrdenarGarconD;
        private System.Windows.Forms.GroupBox gbFiltroGarcon;
        private System.Windows.Forms.ComboBox cbFiltroGarcon;
        private System.Windows.Forms.GroupBox gbOrdenarProduto;
        private System.Windows.Forms.ComboBox cbOrdenarProduto;
        private System.Windows.Forms.RadioButton rbOrdenarProdutoC;
        private System.Windows.Forms.RadioButton rbOrdenarProdutoD;
        private System.Windows.Forms.GroupBox gbFiltrarProduto;
        private System.Windows.Forms.ComboBox cbFiltrarProduto;
    }
}