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
            this.CBRelatorio = new System.Windows.Forms.ComboBox();
            this.RBDiaAtual = new System.Windows.Forms.RadioButton();
            this.LDiaAtual = new System.Windows.Forms.Label();
            this.CBDia = new System.Windows.Forms.ComboBox();
            this.GBDia = new System.Windows.Forms.GroupBox();
            this.GBMes = new System.Windows.Forms.GroupBox();
            this.LMesAtual = new System.Windows.Forms.Label();
            this.RBMesAtual = new System.Windows.Forms.RadioButton();
            this.CBMes = new System.Windows.Forms.ComboBox();
            this.GBAno = new System.Windows.Forms.GroupBox();
            this.LAnoAtual = new System.Windows.Forms.Label();
            this.RBAnoAtual = new System.Windows.Forms.RadioButton();
            this.CBAno = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pVenda = new System.Windows.Forms.Panel();
            this.pGarcon = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbDecrescente = new System.Windows.Forms.RadioButton();
            this.rbCrescente = new System.Windows.Forms.RadioButton();
            this.btConsultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBDia.SuspendLayout();
            this.GBMes.SuspendLayout();
            this.GBAno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flpPrincipal.SuspendLayout();
            this.pVenda.SuspendLayout();
            this.pGarcon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // CBRelatorio
            // 
            this.CBRelatorio.FormattingEnabled = true;
            this.CBRelatorio.Items.AddRange(new object[] {
            "Vendas",
            "Garçon",
            "Produto"});
            this.CBRelatorio.Location = new System.Drawing.Point(54, 60);
            this.CBRelatorio.Name = "CBRelatorio";
            this.CBRelatorio.Size = new System.Drawing.Size(121, 21);
            this.CBRelatorio.TabIndex = 2;
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
            // GBDia
            // 
            this.GBDia.Controls.Add(this.LDiaAtual);
            this.GBDia.Controls.Add(this.RBDiaAtual);
            this.GBDia.Controls.Add(this.CBDia);
            this.GBDia.Location = new System.Drawing.Point(7, 25);
            this.GBDia.Name = "GBDia";
            this.GBDia.Size = new System.Drawing.Size(72, 59);
            this.GBDia.TabIndex = 5;
            this.GBDia.TabStop = false;
            this.GBDia.Text = "Dia";
            // 
            // GBMes
            // 
            this.GBMes.Controls.Add(this.LMesAtual);
            this.GBMes.Controls.Add(this.RBMesAtual);
            this.GBMes.Controls.Add(this.CBMes);
            this.GBMes.Location = new System.Drawing.Point(85, 25);
            this.GBMes.Name = "GBMes";
            this.GBMes.Size = new System.Drawing.Size(72, 59);
            this.GBMes.TabIndex = 6;
            this.GBMes.TabStop = false;
            this.GBMes.Text = "Mês";
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
            // GBAno
            // 
            this.GBAno.Controls.Add(this.LAnoAtual);
            this.GBAno.Controls.Add(this.RBAnoAtual);
            this.GBAno.Controls.Add(this.CBAno);
            this.GBAno.Location = new System.Drawing.Point(163, 25);
            this.GBAno.Name = "GBAno";
            this.GBAno.Size = new System.Drawing.Size(72, 59);
            this.GBAno.TabIndex = 7;
            this.GBAno.TabStop = false;
            this.GBAno.Text = "Ano";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(241, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // flpPrincipal
            // 
            this.flpPrincipal.Controls.Add(this.pVenda);
            this.flpPrincipal.Controls.Add(this.pGarcon);
            this.flpPrincipal.Location = new System.Drawing.Point(242, 32);
            this.flpPrincipal.Name = "flpPrincipal";
            this.flpPrincipal.Size = new System.Drawing.Size(711, 218);
            this.flpPrincipal.TabIndex = 9;
            // 
            // pVenda
            // 
            this.pVenda.Controls.Add(this.btConsultar);
            this.pVenda.Controls.Add(this.groupBox6);
            this.pVenda.Controls.Add(this.GBDia);
            this.pVenda.Controls.Add(this.groupBox1);
            this.pVenda.Controls.Add(this.GBAno);
            this.pVenda.Controls.Add(this.GBMes);
            this.pVenda.Location = new System.Drawing.Point(3, 3);
            this.pVenda.Name = "pVenda";
            this.pVenda.Size = new System.Drawing.Size(698, 94);
            this.pVenda.TabIndex = 10;
            // 
            // pGarcon
            // 
            this.pGarcon.Controls.Add(this.groupBox2);
            this.pGarcon.Controls.Add(this.groupBox3);
            this.pGarcon.Controls.Add(this.groupBox4);
            this.pGarcon.Controls.Add(this.groupBox5);
            this.pGarcon.Location = new System.Drawing.Point(3, 103);
            this.pGarcon.Name = "pGarcon";
            this.pGarcon.Size = new System.Drawing.Size(698, 94);
            this.pGarcon.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(220, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoje";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(9, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(454, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 59);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Período";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(376, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(72, 59);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Atual";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(9, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Location = new System.Drawing.Point(298, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(72, 59);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Atual";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(42, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
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
            this.comboBox4.Location = new System.Drawing.Point(9, 32);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(47, 21);
            this.comboBox4.TabIndex = 4;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 19);
            this.dateTimePicker2.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbCrescente);
            this.groupBox6.Controls.Add(this.rbDecrescente);
            this.groupBox6.Location = new System.Drawing.Point(479, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 59);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ordenar";
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
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(599, 45);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 10;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBRelatorio);
            this.panel1.Controls.Add(this.LTipoRelatorio);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 94);
            this.panel1.TabIndex = 10;
            // 
            // TipoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpPrincipal);
            this.Controls.Add(this.LRelatorio);
            this.Name = "TipoRelatorio";
            this.Text = "Relatorios";
            this.GBDia.ResumeLayout(false);
            this.GBDia.PerformLayout();
            this.GBMes.ResumeLayout(false);
            this.GBMes.PerformLayout();
            this.GBAno.ResumeLayout(false);
            this.GBAno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flpPrincipal.ResumeLayout(false);
            this.pVenda.ResumeLayout(false);
            this.pGarcon.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTipoRelatorio;
        private System.Windows.Forms.Label LRelatorio;
        private System.Windows.Forms.ComboBox CBRelatorio;
        private System.Windows.Forms.RadioButton RBDiaAtual;
        private System.Windows.Forms.Label LDiaAtual;
        private System.Windows.Forms.ComboBox CBDia;
        private System.Windows.Forms.GroupBox GBDia;
        private System.Windows.Forms.GroupBox GBMes;
        private System.Windows.Forms.Label LMesAtual;
        private System.Windows.Forms.RadioButton RBMesAtual;
        private System.Windows.Forms.ComboBox CBMes;
        private System.Windows.Forms.GroupBox GBAno;
        private System.Windows.Forms.Label LAnoAtual;
        private System.Windows.Forms.RadioButton RBAnoAtual;
        private System.Windows.Forms.ComboBox CBAno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpPrincipal;
        private System.Windows.Forms.Panel pVenda;
        private System.Windows.Forms.Panel pGarcon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbCrescente;
        private System.Windows.Forms.RadioButton rbDecrescente;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Panel panel1;
    }
}