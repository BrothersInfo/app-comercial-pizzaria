namespace Pizzaria.Tela
{
    partial class ConsultaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaForm));
            this.tcConsultar = new System.Windows.Forms.TabControl();
            this.tPCons1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpConsulta1Nivel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btConsImprimir = new System.Windows.Forms.Button();
            this.lvConsInfo = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tPCons2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.btImprimir1 = new System.Windows.Forms.Button();
            this.lvConsInfo2 = new System.Windows.Forms.ListView();
            this.codigo2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tcConsultar.SuspendLayout();
            this.tPCons1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpConsulta1Nivel2.SuspendLayout();
            this.tPCons2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcConsultar
            // 
            this.tcConsultar.Controls.Add(this.tPCons1);
            this.tcConsultar.Controls.Add(this.tPCons2);
            this.tcConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tcConsultar.Location = new System.Drawing.Point(0, 0);
            this.tcConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.tcConsultar.Name = "tcConsultar";
            this.tcConsultar.SelectedIndex = 0;
            this.tcConsultar.Size = new System.Drawing.Size(844, 511);
            this.tcConsultar.TabIndex = 5;
            // 
            // tPCons1
            // 
            this.tPCons1.Controls.Add(this.tableLayoutPanel1);
            this.tPCons1.Location = new System.Drawing.Point(4, 29);
            this.tPCons1.Margin = new System.Windows.Forms.Padding(0);
            this.tPCons1.Name = "tPCons1";
            this.tPCons1.Size = new System.Drawing.Size(836, 478);
            this.tPCons1.TabIndex = 0;
            this.tPCons1.Text = "Valor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpConsulta1Nivel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 478);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tlpConsulta1Nivel2
            // 
            this.tlpConsulta1Nivel2.ColumnCount = 1;
            this.tlpConsulta1Nivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsulta1Nivel2.Controls.Add(this.btConsImprimir, 0, 2);
            this.tlpConsulta1Nivel2.Controls.Add(this.lvConsInfo, 0, 1);
            this.tlpConsulta1Nivel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConsulta1Nivel2.Location = new System.Drawing.Point(143, 0);
            this.tlpConsulta1Nivel2.Margin = new System.Windows.Forms.Padding(0);
            this.tlpConsulta1Nivel2.Name = "tlpConsulta1Nivel2";
            this.tlpConsulta1Nivel2.RowCount = 4;
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpConsulta1Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConsulta1Nivel2.Size = new System.Drawing.Size(550, 478);
            this.tlpConsulta1Nivel2.TabIndex = 1;
            // 
            // btConsImprimir
            // 
            this.btConsImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConsImprimir.BackgroundImage = global::Pizzaria.Properties.Resources.BtImprimir;
            this.btConsImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsImprimir.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsImprimir.ForeColor = System.Drawing.Color.White;
            this.btConsImprimir.Location = new System.Drawing.Point(209, 411);
            this.btConsImprimir.Name = "btConsImprimir";
            this.btConsImprimir.Size = new System.Drawing.Size(132, 44);
            this.btConsImprimir.TabIndex = 42;
            this.btConsImprimir.UseVisualStyleBackColor = true;
            this.btConsImprimir.Click += new System.EventHandler(this.btConsImprimir_Click);
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
            this.lvConsInfo.Location = new System.Drawing.Point(0, 20);
            this.lvConsInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lvConsInfo.Name = "lvConsInfo";
            this.lvConsInfo.Size = new System.Drawing.Size(550, 388);
            this.lvConsInfo.TabIndex = 43;
            this.lvConsInfo.UseCompatibleStateImageBehavior = false;
            this.lvConsInfo.View = System.Windows.Forms.View.Details;
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
            // tPCons2
            // 
            this.tPCons2.Controls.Add(this.tableLayoutPanel2);
            this.tPCons2.Location = new System.Drawing.Point(4, 29);
            this.tPCons2.Margin = new System.Windows.Forms.Padding(0);
            this.tPCons2.Name = "tPCons2";
            this.tPCons2.Size = new System.Drawing.Size(836, 478);
            this.tPCons2.TabIndex = 1;
            this.tPCons2.Text = "Segmento";
            this.tPCons2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 478);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.btImprimir1, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.lvConsInfo2, 0, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(143, 0);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 4;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(550, 478);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // btImprimir1
            // 
            this.btImprimir1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir1.BackgroundImage = global::Pizzaria.Properties.Resources.BtImprimir;
            this.btImprimir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir1.ForeColor = System.Drawing.Color.White;
            this.btImprimir1.Location = new System.Drawing.Point(209, 411);
            this.btImprimir1.Name = "btImprimir1";
            this.btImprimir1.Size = new System.Drawing.Size(132, 44);
            this.btImprimir1.TabIndex = 42;
            this.btImprimir1.UseVisualStyleBackColor = true;
            this.btImprimir1.Click += new System.EventHandler(this.btImprimir1_Click);
            // 
            // lvConsInfo2
            // 
            this.lvConsInfo2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo2,
            this.descricao2,
            this.tipo2});
            this.lvConsInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConsInfo2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvConsInfo2.FullRowSelect = true;
            this.lvConsInfo2.GridLines = true;
            this.lvConsInfo2.HoverSelection = true;
            this.lvConsInfo2.Location = new System.Drawing.Point(0, 20);
            this.lvConsInfo2.Margin = new System.Windows.Forms.Padding(0);
            this.lvConsInfo2.Name = "lvConsInfo2";
            this.lvConsInfo2.Size = new System.Drawing.Size(550, 388);
            this.lvConsInfo2.TabIndex = 43;
            this.lvConsInfo2.UseCompatibleStateImageBehavior = false;
            this.lvConsInfo2.View = System.Windows.Forms.View.Details;
            // 
            // codigo2
            // 
            this.codigo2.Text = "Item";
            this.codigo2.Width = 55;
            // 
            // descricao2
            // 
            this.descricao2.Text = "Produto";
            this.descricao2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descricao2.Width = 170;
            // 
            // tipo2
            // 
            this.tipo2.Text = "Tamanho";
            this.tipo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipo2.Width = 75;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.ControlBox = false;
            this.Controls.Add(this.tcConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsultaForm";
            this.tcConsultar.ResumeLayout(false);
            this.tPCons1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpConsulta1Nivel2.ResumeLayout(false);
            this.tPCons2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcConsultar;
        private System.Windows.Forms.TabPage tPCons1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpConsulta1Nivel2;
        private System.Windows.Forms.Button btConsImprimir;
        private System.Windows.Forms.ListView lvConsInfo;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader ValorUni;
        private System.Windows.Forms.TabPage tPCons2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button btImprimir1;
        private System.Windows.Forms.ListView lvConsInfo2;
        private System.Windows.Forms.ColumnHeader codigo2;
        private System.Windows.Forms.ColumnHeader descricao2;
        private System.Windows.Forms.ColumnHeader tipo2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}