namespace Pizzaria.Tela
{
    partial class SubVenda
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
            this.tlpBotao = new System.Windows.Forms.TableLayoutPanel();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.panBut.SuspendLayout();
            this.tabLayDescricao.SuspendLayout();
            this.tlpGAmb.SuspendLayout();
            this.pValor.SuspendLayout();
            this.tabLayINFO.SuspendLayout();
            this.tlpBotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBut
            // 
            this.panBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBut.BackColor = System.Drawing.Color.Transparent;
            this.panBut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBut.Controls.Add(this.tabLayDescricao);
            this.panBut.Controls.Add(this.tabLayINFO);
            this.panBut.Location = new System.Drawing.Point(0, 0);
            this.panBut.Margin = new System.Windows.Forms.Padding(0);
            this.panBut.MaximumSize = new System.Drawing.Size(712, 240);
            this.panBut.MinimumSize = new System.Drawing.Size(712, 240);
            this.panBut.Name = "panBut";
            this.panBut.Size = new System.Drawing.Size(712, 240);
            this.panBut.TabIndex = 23;
            // 
            // tabLayDescricao
            // 
            this.tabLayDescricao.ColumnCount = 1;
            this.tabLayDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayDescricao.Controls.Add(this.lvInfo, 0, 0);
            this.tabLayDescricao.Controls.Add(this.tlpGAmb, 0, 1);
            this.tabLayDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayDescricao.Location = new System.Drawing.Point(159, 0);
            this.tabLayDescricao.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tabLayDescricao.Name = "tabLayDescricao";
            this.tabLayDescricao.RowCount = 2;
            this.tabLayDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tabLayDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tabLayDescricao.Size = new System.Drawing.Size(551, 238);
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
            this.lvInfo.Size = new System.Drawing.Size(546, 126);
            this.lvInfo.TabIndex = 32;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
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
            this.tlpGAmb.ColumnCount = 3;
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.57641F));
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.42359F));
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tlpGAmb.Controls.Add(this.lvGarcon, 1, 0);
            this.tlpGAmb.Controls.Add(this.pValor, 0, 0);
            this.tlpGAmb.Controls.Add(this.lvMesa, 2, 0);
            this.tlpGAmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGAmb.Location = new System.Drawing.Point(0, 126);
            this.tlpGAmb.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tlpGAmb.Name = "tlpGAmb";
            this.tlpGAmb.RowCount = 1;
            this.tlpGAmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGAmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tlpGAmb.Size = new System.Drawing.Size(550, 193);
            this.tlpGAmb.TabIndex = 0;
            // 
            // lvGarcon
            // 
            this.lvGarcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGarcon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codGar,
            this.nomGar});
            this.lvGarcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGarcon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGarcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvGarcon.FullRowSelect = true;
            this.lvGarcon.GridLines = true;
            this.lvGarcon.HoverSelection = true;
            this.lvGarcon.Location = new System.Drawing.Point(172, 3);
            this.lvGarcon.Margin = new System.Windows.Forms.Padding(3, 3, 1, 6);
            this.lvGarcon.Name = "lvGarcon";
            this.lvGarcon.Size = new System.Drawing.Size(197, 184);
            this.lvGarcon.TabIndex = 0;
            this.lvGarcon.UseCompatibleStateImageBehavior = false;
            this.lvGarcon.View = System.Windows.Forms.View.Details;
            // 
            // codGar
            // 
            this.codGar.Text = "Codigo";
            this.codGar.Width = 79;
            // 
            // nomGar
            // 
            this.nomGar.Text = "Garçon";
            this.nomGar.Width = 117;
            // 
            // pValor
            // 
            this.pValor.Controls.Add(this.mtValor);
            this.pValor.Controls.Add(this.label4);
            this.pValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pValor.Location = new System.Drawing.Point(0, 0);
            this.pValor.Margin = new System.Windows.Forms.Padding(0);
            this.pValor.Name = "pValor";
            this.pValor.Size = new System.Drawing.Size(169, 193);
            this.pValor.TabIndex = 34;
            // 
            // mtValor
            // 
            this.mtValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtValor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtValor.ForeColor = System.Drawing.Color.DarkRed;
            this.mtValor.Location = new System.Drawing.Point(17, 49);
            this.mtValor.Mask = "0,00";
            this.mtValor.Name = "mtValor";
            this.mtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtValor.Size = new System.Drawing.Size(132, 44);
            this.mtValor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(43, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "VALOR";
            // 
            // lvMesa
            // 
            this.lvMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMesa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomMesa,
            this.ambient});
            this.lvMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvMesa.FullRowSelect = true;
            this.lvMesa.GridLines = true;
            this.lvMesa.HoverSelection = true;
            this.lvMesa.Location = new System.Drawing.Point(373, 3);
            this.lvMesa.Margin = new System.Windows.Forms.Padding(3, 3, 1, 6);
            this.lvMesa.Name = "lvMesa";
            this.lvMesa.Size = new System.Drawing.Size(176, 184);
            this.lvMesa.TabIndex = 0;
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
            this.tabLayINFO.Controls.Add(this.tlpBotao, 0, 0);
            this.tabLayINFO.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabLayINFO.Location = new System.Drawing.Point(0, 0);
            this.tabLayINFO.Margin = new System.Windows.Forms.Padding(0);
            this.tabLayINFO.Name = "tabLayINFO";
            this.tabLayINFO.RowCount = 1;
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tabLayINFO.Size = new System.Drawing.Size(159, 238);
            this.tabLayINFO.TabIndex = 11;
            // 
            // tlpBotao
            // 
            this.tlpBotao.BackColor = System.Drawing.Color.Transparent;
            this.tlpBotao.ColumnCount = 1;
            this.tlpBotao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotao.Controls.Add(this.btEncerrar, 0, 0);
            this.tlpBotao.Controls.Add(this.btVoltar, 0, 2);
            this.tlpBotao.Controls.Add(this.btImprimir, 0, 1);
            this.tlpBotao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotao.Location = new System.Drawing.Point(0, 0);
            this.tlpBotao.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotao.Name = "tlpBotao";
            this.tlpBotao.RowCount = 3;
            this.tlpBotao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBotao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBotao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBotao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotao.Size = new System.Drawing.Size(159, 238);
            this.tlpBotao.TabIndex = 11;
            // 
            // btEncerrar
            // 
            this.btEncerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEncerrar.BackgroundImage = global::Pizzaria.Properties.Resources.setverde;
            this.btEncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEncerrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btEncerrar.Location = new System.Drawing.Point(36, 26);
            this.btEncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(87, 43);
            this.btEncerrar.TabIndex = 1;
            this.btEncerrar.Text = "ENCERRAR";
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btVoltar.BackgroundImage = global::Pizzaria.Properties.Resources.setVermelhor;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(36, 180);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(87, 43);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "VOLTAR";
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
            this.btImprimir.Location = new System.Drawing.Point(36, 109);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(87, 43);
            this.btImprimir.TabIndex = 2;
            this.btImprimir.Text = "IMPRIMIR";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // SubVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 240);
            this.ControlBox = false;
            this.Controls.Add(this.panBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(712, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(712, 240);
            this.Name = "SubVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SubVenda";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubVenda_KeyDown);
            this.panBut.ResumeLayout(false);
            this.tabLayDescricao.ResumeLayout(false);
            this.tlpGAmb.ResumeLayout(false);
            this.pValor.ResumeLayout(false);
            this.pValor.PerformLayout();
            this.tabLayINFO.ResumeLayout(false);
            this.tlpBotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBut;
        private System.Windows.Forms.TableLayoutPanel tabLayDescricao;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader ValorUni;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.TableLayoutPanel tlpGAmb;
        private System.Windows.Forms.ListView lvGarcon;
        private System.Windows.Forms.ColumnHeader codGar;
        private System.Windows.Forms.ColumnHeader nomGar;
        private System.Windows.Forms.Panel pValor;
        private System.Windows.Forms.MaskedTextBox mtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvMesa;
        private System.Windows.Forms.ColumnHeader nomMesa;
        private System.Windows.Forms.ColumnHeader ambient;
        private System.Windows.Forms.TableLayoutPanel tabLayINFO;
        private System.Windows.Forms.TableLayoutPanel tlpBotao;
        private System.Windows.Forms.Button btEncerrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btImprimir;
    }
}