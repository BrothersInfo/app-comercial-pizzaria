namespace Pizzaria.Tela
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pLoadForm = new System.Windows.Forms.Panel();
            this.tlpColuna = new System.Windows.Forms.TableLayoutPanel();
            this.listVenda = new System.Windows.Forms.ListView();
            this.menuDireito = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.MSEncerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.MSProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tabLayFullEsquerda = new System.Windows.Forms.TableLayoutPanel();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.aparelho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpLivreOcupado = new System.Windows.Forms.TableLayoutPanel();
            this.pBalcao = new System.Windows.Forms.Panel();
            this.lBalcao = new System.Windows.Forms.Label();
            this.tlpLO = new System.Windows.Forms.TableLayoutPanel();
            this.pLivre = new System.Windows.Forms.Panel();
            this.linutil1 = new System.Windows.Forms.Label();
            this.pOcupada = new System.Windows.Forms.Panel();
            this.lInutil2 = new System.Windows.Forms.Label();
            this.ptitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lValor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ttMsg = new System.Windows.Forms.ToolTip(this.components);
            this.pLoadForm.SuspendLayout();
            this.tlpColuna.SuspendLayout();
            this.menuDireito.SuspendLayout();
            this.tabLayFullEsquerda.SuspendLayout();
            this.tlpLivreOcupado.SuspendLayout();
            this.pBalcao.SuspendLayout();
            this.tlpLO.SuspendLayout();
            this.pLivre.SuspendLayout();
            this.pOcupada.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLoadForm
            // 
            this.pLoadForm.Controls.Add(this.tlpColuna);
            this.pLoadForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadForm.Location = new System.Drawing.Point(0, 0);
            this.pLoadForm.Margin = new System.Windows.Forms.Padding(0);
            this.pLoadForm.Name = "pLoadForm";
            this.pLoadForm.Size = new System.Drawing.Size(920, 567);
            this.pLoadForm.TabIndex = 0;
            // 
            // tlpColuna
            // 
            this.tlpColuna.ColumnCount = 2;
            this.tlpColuna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColuna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.tlpColuna.Controls.Add(this.listVenda, 0, 0);
            this.tlpColuna.Controls.Add(this.tabLayFullEsquerda, 1, 0);
            this.tlpColuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpColuna.Location = new System.Drawing.Point(0, 0);
            this.tlpColuna.Margin = new System.Windows.Forms.Padding(0);
            this.tlpColuna.Name = "tlpColuna";
            this.tlpColuna.RowCount = 1;
            this.tlpColuna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColuna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 567F));
            this.tlpColuna.Size = new System.Drawing.Size(920, 567);
            this.tlpColuna.TabIndex = 0;
            // 
            // listVenda
            // 
            this.listVenda.ContextMenuStrip = this.menuDireito;
            this.listVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVenda.Location = new System.Drawing.Point(0, 4);
            this.listVenda.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.listVenda.Name = "listVenda";
            this.listVenda.ShowItemToolTips = true;
            this.listVenda.Size = new System.Drawing.Size(468, 559);
            this.listVenda.TabIndex = 7;
            this.ttMsg.SetToolTip(this.listVenda, "Selecione uma Mesa para Realizar Operação");
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.ItemActivate += new System.EventHandler(this.listVenda_ItemActivate);
            this.listVenda.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listVenda_ItemSelectionChanged);
            this.listVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listVenda_KeyPress);
            this.listVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVenda_MouseClick);
            // 
            // menuDireito
            // 
            this.menuDireito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSImprimir,
            this.MSEncerrar,
            this.separador,
            this.MSProduto});
            this.menuDireito.Name = "menuDireito";
            this.menuDireito.Size = new System.Drawing.Size(174, 76);
            // 
            // MSImprimir
            // 
            this.MSImprimir.Name = "MSImprimir";
            this.MSImprimir.Size = new System.Drawing.Size(173, 22);
            this.MSImprimir.Text = "Imprimir ( I )";
            this.MSImprimir.Click += new System.EventHandler(this.MSImprimir_Click);
            // 
            // MSEncerrar
            // 
            this.MSEncerrar.Name = "MSEncerrar";
            this.MSEncerrar.Size = new System.Drawing.Size(173, 22);
            this.MSEncerrar.Text = "Encerrar ( V )";
            this.MSEncerrar.Click += new System.EventHandler(this.MSEncerrar_Click);
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(170, 6);
            // 
            // MSProduto
            // 
            this.MSProduto.Name = "MSProduto";
            this.MSProduto.Size = new System.Drawing.Size(173, 22);
            this.MSProduto.Text = "Novo Produto ( P )";
            this.MSProduto.Click += new System.EventHandler(this.MSProduto_Click);
            // 
            // tabLayFullEsquerda
            // 
            this.tabLayFullEsquerda.ColumnCount = 1;
            this.tabLayFullEsquerda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayFullEsquerda.Controls.Add(this.lvInfo, 0, 2);
            this.tabLayFullEsquerda.Controls.Add(this.tlpLivreOcupado, 0, 1);
            this.tabLayFullEsquerda.Controls.Add(this.ptitulo, 0, 0);
            this.tabLayFullEsquerda.Controls.Add(this.panel1, 0, 3);
            this.tabLayFullEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayFullEsquerda.Location = new System.Drawing.Point(472, 4);
            this.tabLayFullEsquerda.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tabLayFullEsquerda.Name = "tabLayFullEsquerda";
            this.tabLayFullEsquerda.RowCount = 4;
            this.tabLayFullEsquerda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tabLayFullEsquerda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tabLayFullEsquerda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayFullEsquerda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tabLayFullEsquerda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayFullEsquerda.Size = new System.Drawing.Size(448, 563);
            this.tabLayFullEsquerda.TabIndex = 6;
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aparelho,
            this.inicio,
            this.fim,
            this.qtd});
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.Enabled = false;
            this.lvInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvInfo.GridLines = true;
            this.lvInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvInfo.Location = new System.Drawing.Point(1, 357);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(446, 157);
            this.lvInfo.TabIndex = 31;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // aparelho
            // 
            this.aparelho.Text = "Produto";
            this.aparelho.Width = 160;
            // 
            // inicio
            // 
            this.inicio.Text = "Tamanho";
            this.inicio.Width = 102;
            // 
            // fim
            // 
            this.fim.Text = "Valor Uni";
            this.fim.Width = 90;
            // 
            // qtd
            // 
            this.qtd.Text = "Quant";
            this.qtd.Width = 85;
            // 
            // tlpLivreOcupado
            // 
            this.tlpLivreOcupado.ColumnCount = 1;
            this.tlpLivreOcupado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLivreOcupado.Controls.Add(this.pBalcao, 0, 1);
            this.tlpLivreOcupado.Controls.Add(this.tlpLO, 0, 0);
            this.tlpLivreOcupado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLivreOcupado.Location = new System.Drawing.Point(0, 202);
            this.tlpLivreOcupado.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLivreOcupado.Name = "tlpLivreOcupado";
            this.tlpLivreOcupado.RowCount = 2;
            this.tlpLivreOcupado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLivreOcupado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLivreOcupado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpLivreOcupado.Size = new System.Drawing.Size(448, 151);
            this.tlpLivreOcupado.TabIndex = 32;
            // 
            // pBalcao
            // 
            this.pBalcao.BackColor = System.Drawing.Color.White;
            this.pBalcao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBalcao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBalcao.Controls.Add(this.lBalcao);
            this.pBalcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBalcao.Location = new System.Drawing.Point(4, 105);
            this.pBalcao.Margin = new System.Windows.Forms.Padding(4);
            this.pBalcao.Name = "pBalcao";
            this.pBalcao.Size = new System.Drawing.Size(440, 42);
            this.pBalcao.TabIndex = 34;
            this.pBalcao.Click += new System.EventHandler(this.pBalcao_Click);
            this.pBalcao.MouseEnter += new System.EventHandler(this.pBalcao_MouseEnter);
            this.pBalcao.MouseLeave += new System.EventHandler(this.pBalcao_MouseLeave);
            // 
            // lBalcao
            // 
            this.lBalcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBalcao.AutoSize = true;
            this.lBalcao.BackColor = System.Drawing.Color.Transparent;
            this.lBalcao.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBalcao.ForeColor = System.Drawing.Color.Black;
            this.lBalcao.Location = new System.Drawing.Point(151, 7);
            this.lBalcao.Name = "lBalcao";
            this.lBalcao.Size = new System.Drawing.Size(136, 27);
            this.lBalcao.TabIndex = 2;
            this.lBalcao.Text = "BALCAO [ B ]";
            // 
            // tlpLO
            // 
            this.tlpLO.ColumnCount = 2;
            this.tlpLO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLO.Controls.Add(this.pLivre, 1, 0);
            this.tlpLO.Controls.Add(this.pOcupada, 0, 0);
            this.tlpLO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLO.Location = new System.Drawing.Point(0, 0);
            this.tlpLO.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLO.Name = "tlpLO";
            this.tlpLO.RowCount = 1;
            this.tlpLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLO.Size = new System.Drawing.Size(448, 101);
            this.tlpLO.TabIndex = 33;
            // 
            // pLivre
            // 
            this.pLivre.BackColor = System.Drawing.Color.White;
            this.pLivre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLivre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLivre.Controls.Add(this.linutil1);
            this.pLivre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLivre.Location = new System.Drawing.Point(224, 4);
            this.pLivre.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.pLivre.Name = "pLivre";
            this.pLivre.Size = new System.Drawing.Size(220, 93);
            this.pLivre.TabIndex = 3;
            this.pLivre.MouseEnter += new System.EventHandler(this.pLivre_MouseEnter);
            // 
            // linutil1
            // 
            this.linutil1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linutil1.AutoSize = true;
            this.linutil1.BackColor = System.Drawing.Color.Transparent;
            this.linutil1.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linutil1.ForeColor = System.Drawing.Color.Black;
            this.linutil1.Location = new System.Drawing.Point(54, 31);
            this.linutil1.Name = "linutil1";
            this.linutil1.Size = new System.Drawing.Size(108, 27);
            this.linutil1.TabIndex = 2;
            this.linutil1.Text = "LIVRE [ L ]";
            // 
            // pOcupada
            // 
            this.pOcupada.BackColor = System.Drawing.Color.White;
            this.pOcupada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pOcupada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pOcupada.Controls.Add(this.lInutil2);
            this.pOcupada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOcupada.Location = new System.Drawing.Point(4, 4);
            this.pOcupada.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.pOcupada.Name = "pOcupada";
            this.pOcupada.Size = new System.Drawing.Size(220, 93);
            this.pOcupada.TabIndex = 4;
            this.pOcupada.MouseEnter += new System.EventHandler(this.pOcupada_MouseEnter);
            // 
            // lInutil2
            // 
            this.lInutil2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lInutil2.AutoSize = true;
            this.lInutil2.BackColor = System.Drawing.Color.Transparent;
            this.lInutil2.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInutil2.ForeColor = System.Drawing.Color.Black;
            this.lInutil2.Location = new System.Drawing.Point(32, 31);
            this.lInutil2.Name = "lInutil2";
            this.lInutil2.Size = new System.Drawing.Size(152, 27);
            this.lInutil2.TabIndex = 2;
            this.lInutil2.Text = "OCUPADA [ O ]";
            // 
            // ptitulo
            // 
            this.ptitulo.BackColor = System.Drawing.Color.White;
            this.ptitulo.BackgroundImage = global::Pizzaria.Properties.Resources.Delirios;
            this.ptitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptitulo.Location = new System.Drawing.Point(1, 0);
            this.ptitulo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ptitulo.Name = "ptitulo";
            this.ptitulo.Size = new System.Drawing.Size(446, 201);
            this.ptitulo.TabIndex = 36;
            this.ptitulo.Click += new System.EventHandler(this.ptitulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lValor);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 520);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 39);
            this.panel1.TabIndex = 38;
            // 
            // lValor
            // 
            this.lValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lValor.AutoSize = true;
            this.lValor.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lValor.ForeColor = System.Drawing.Color.Red;
            this.lValor.Location = new System.Drawing.Point(211, 10);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(0, 18);
            this.lValor.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textBox2.Location = new System.Drawing.Point(3, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 33);
            this.textBox2.TabIndex = 24;
            this.textBox2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mesaLivre.jpg");
            this.imageList1.Images.SetKeyName(1, "mesa Impressa 3.jpg");
            this.imageList1.Images.SetKeyName(2, "mesa Ocupada 2.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "mesaLivre.jpg");
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 567);
            this.ControlBox = false;
            this.Controls.Add(this.pLoadForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Click += new System.EventHandler(this.Principal_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            this.pLoadForm.ResumeLayout(false);
            this.tlpColuna.ResumeLayout(false);
            this.menuDireito.ResumeLayout(false);
            this.tabLayFullEsquerda.ResumeLayout(false);
            this.tlpLivreOcupado.ResumeLayout(false);
            this.pBalcao.ResumeLayout(false);
            this.pBalcao.PerformLayout();
            this.tlpLO.ResumeLayout(false);
            this.pLivre.ResumeLayout(false);
            this.pLivre.PerformLayout();
            this.pOcupada.ResumeLayout(false);
            this.pOcupada.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLoadForm;
        private System.Windows.Forms.TableLayoutPanel tlpColuna;
        private System.Windows.Forms.TableLayoutPanel tabLayFullEsquerda;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pOcupada;
        private System.Windows.Forms.Label lInutil2;
        private System.Windows.Forms.Panel pLivre;
        private System.Windows.Forms.Label linutil1;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader aparelho;
        private System.Windows.Forms.ColumnHeader inicio;
        private System.Windows.Forms.ColumnHeader fim;
        private System.Windows.Forms.ColumnHeader qtd;
        private System.Windows.Forms.TableLayoutPanel tlpLivreOcupado;
        private System.Windows.Forms.Panel ptitulo;
        private System.Windows.Forms.ListView listVenda;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip menuDireito;
        private System.Windows.Forms.ToolStripMenuItem MSImprimir;
        private System.Windows.Forms.ToolStripMenuItem MSEncerrar;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.ToolStripMenuItem MSProduto;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel pBalcao;
        private System.Windows.Forms.Label lBalcao;
        private System.Windows.Forms.TableLayoutPanel tlpLO;
        private System.Windows.Forms.ToolTip ttMsg;
    }
}