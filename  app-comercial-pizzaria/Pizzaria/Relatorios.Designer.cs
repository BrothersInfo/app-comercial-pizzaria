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
            this.btConsultaVenda = new System.Windows.Forms.Button();
            this.gbVendaOrdenar = new System.Windows.Forms.GroupBox();
            this.rbCrescente = new System.Windows.Forms.RadioButton();
            this.rbDecrescente = new System.Windows.Forms.RadioButton();
            this.pGarcon = new System.Windows.Forms.Panel();
            this.gpGarcon = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPeriodoGarcon = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.gpOrdenarGarcon = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btConsultaGarcon = new System.Windows.Forms.Button();
            this.pProduto = new System.Windows.Forms.Panel();
            this.btProdutoConsultar = new System.Windows.Forms.Button();
            this.gbProdutoOrdenar = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbPeriodoProduto = new System.Windows.Forms.GroupBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.gbDiaVenda.SuspendLayout();
            this.gbMesVenda.SuspendLayout();
            this.gbAnoVenda.SuspendLayout();
            this.gbPeriodoVenda.SuspendLayout();
            this.flpPrincipal.SuspendLayout();
            this.pVenda.SuspendLayout();
            this.gbVendaOrdenar.SuspendLayout();
            this.pGarcon.SuspendLayout();
            this.gpGarcon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPeriodoGarcon.SuspendLayout();
            this.gpOrdenarGarcon.SuspendLayout();
            this.pProduto.SuspendLayout();
            this.gbProdutoOrdenar.SuspendLayout();
            this.gbPeriodoProduto.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTipoRelatorio
            // 
            this.LTipoRelatorio.AutoSize = true;
            this.LTipoRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoRelatorio.Location = new System.Drawing.Point(32, 25);
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
            this.cbRelatorio.Location = new System.Drawing.Point(54, 60);
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
            this.flpPrincipal.Location = new System.Drawing.Point(242, 32);
            this.flpPrincipal.Name = "flpPrincipal";
            this.flpPrincipal.Size = new System.Drawing.Size(711, 307);
            this.flpPrincipal.TabIndex = 9;
            // 
            // pVenda
            // 
            this.pVenda.Controls.Add(this.btConsultaVenda);
            this.pVenda.Controls.Add(this.gbVendaOrdenar);
            this.pVenda.Controls.Add(this.gbDiaVenda);
            this.pVenda.Controls.Add(this.gbPeriodoVenda);
            this.pVenda.Controls.Add(this.gbAnoVenda);
            this.pVenda.Controls.Add(this.gbMesVenda);
            this.pVenda.Location = new System.Drawing.Point(3, 3);
            this.pVenda.Name = "pVenda";
            this.pVenda.Size = new System.Drawing.Size(698, 94);
            this.pVenda.TabIndex = 10;
            // 
            // btConsultaVenda
            // 
            this.btConsultaVenda.Location = new System.Drawing.Point(599, 45);
            this.btConsultaVenda.Name = "btConsultaVenda";
            this.btConsultaVenda.Size = new System.Drawing.Size(75, 23);
            this.btConsultaVenda.TabIndex = 10;
            this.btConsultaVenda.Text = "Consultar";
            this.btConsultaVenda.UseVisualStyleBackColor = true;
            // 
            // gbVendaOrdenar
            // 
            this.gbVendaOrdenar.Controls.Add(this.rbCrescente);
            this.gbVendaOrdenar.Controls.Add(this.rbDecrescente);
            this.gbVendaOrdenar.Location = new System.Drawing.Point(479, 25);
            this.gbVendaOrdenar.Name = "gbVendaOrdenar";
            this.gbVendaOrdenar.Size = new System.Drawing.Size(114, 59);
            this.gbVendaOrdenar.TabIndex = 9;
            this.gbVendaOrdenar.TabStop = false;
            this.gbVendaOrdenar.Text = "Ordenar";
            // 
            // rbCrescente
            // 
            this.rbCrescente.AutoSize = true;
            this.rbCrescente.Location = new System.Drawing.Point(22, 19);
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
            this.rbDecrescente.Location = new System.Drawing.Point(22, 36);
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
            this.pGarcon.Controls.Add(this.btConsultaGarcon);
            this.pGarcon.Controls.Add(this.gpOrdenarGarcon);
            this.pGarcon.Controls.Add(this.gbPeriodoGarcon);
            this.pGarcon.Controls.Add(this.gpGarcon);
            this.pGarcon.Location = new System.Drawing.Point(3, 103);
            this.pGarcon.Name = "pGarcon";
            this.pGarcon.Size = new System.Drawing.Size(698, 94);
            this.pGarcon.TabIndex = 11;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.cbRelatorio);
            this.panel1.Controls.Add(this.LTipoRelatorio);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 94);
            this.panel1.TabIndex = 10;
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
            // gpOrdenarGarcon
            // 
            this.gpOrdenarGarcon.Controls.Add(this.radioButton1);
            this.gpOrdenarGarcon.Controls.Add(this.radioButton2);
            this.gpOrdenarGarcon.Location = new System.Drawing.Point(366, 25);
            this.gpOrdenarGarcon.Name = "gpOrdenarGarcon";
            this.gpOrdenarGarcon.Size = new System.Drawing.Size(114, 59);
            this.gpOrdenarGarcon.TabIndex = 10;
            this.gpOrdenarGarcon.TabStop = false;
            this.gpOrdenarGarcon.Text = "Ordenar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Crescente";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Decrescente";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btConsultaGarcon
            // 
            this.btConsultaGarcon.Location = new System.Drawing.Point(486, 44);
            this.btConsultaGarcon.Name = "btConsultaGarcon";
            this.btConsultaGarcon.Size = new System.Drawing.Size(75, 23);
            this.btConsultaGarcon.TabIndex = 11;
            this.btConsultaGarcon.Text = "Consultar";
            this.btConsultaGarcon.UseVisualStyleBackColor = true;
            // 
            // pProduto
            // 
            this.pProduto.Controls.Add(this.btProdutoConsultar);
            this.pProduto.Controls.Add(this.gbProdutoOrdenar);
            this.pProduto.Controls.Add(this.gbPeriodoProduto);
            this.pProduto.Controls.Add(this.gbProduto);
            this.pProduto.Location = new System.Drawing.Point(3, 203);
            this.pProduto.Name = "pProduto";
            this.pProduto.Size = new System.Drawing.Size(698, 94);
            this.pProduto.TabIndex = 12;
            // 
            // btProdutoConsultar
            // 
            this.btProdutoConsultar.Location = new System.Drawing.Point(486, 44);
            this.btProdutoConsultar.Name = "btProdutoConsultar";
            this.btProdutoConsultar.Size = new System.Drawing.Size(75, 23);
            this.btProdutoConsultar.TabIndex = 11;
            this.btProdutoConsultar.Text = "Consultar";
            this.btProdutoConsultar.UseVisualStyleBackColor = true;
            // 
            // gbProdutoOrdenar
            // 
            this.gbProdutoOrdenar.Controls.Add(this.radioButton3);
            this.gbProdutoOrdenar.Controls.Add(this.radioButton4);
            this.gbProdutoOrdenar.Location = new System.Drawing.Point(366, 25);
            this.gbProdutoOrdenar.Name = "gbProdutoOrdenar";
            this.gbProdutoOrdenar.Size = new System.Drawing.Size(114, 59);
            this.gbProdutoOrdenar.TabIndex = 10;
            this.gbProdutoOrdenar.TabStop = false;
            this.gbProdutoOrdenar.Text = "Ordenar";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Crescente";
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(22, 36);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(86, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Decrescente";
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton4.UseVisualStyleBackColor = true;
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
            this.gpGarcon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPeriodoGarcon.ResumeLayout(false);
            this.gpOrdenarGarcon.ResumeLayout(false);
            this.gpOrdenarGarcon.PerformLayout();
            this.pProduto.ResumeLayout(false);
            this.gbProdutoOrdenar.ResumeLayout(false);
            this.gbProdutoOrdenar.PerformLayout();
            this.gbPeriodoProduto.ResumeLayout(false);
            this.gbProduto.ResumeLayout(false);
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
        private System.Windows.Forms.Button btConsultaVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConsultaGarcon;
        private System.Windows.Forms.GroupBox gpOrdenarGarcon;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbPeriodoGarcon;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Panel pProduto;
        private System.Windows.Forms.Button btProdutoConsultar;
        private System.Windows.Forms.GroupBox gbProdutoOrdenar;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbPeriodoProduto;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.ComboBox cbProduto;
    }
}