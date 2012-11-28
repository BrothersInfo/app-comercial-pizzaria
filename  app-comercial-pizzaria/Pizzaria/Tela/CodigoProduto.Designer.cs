namespace Pizzaria.Tela
{
    partial class CodigoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoProduto));
            this.tLPGeral = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVenda = new System.Windows.Forms.TableLayoutPanel();
            this.lvCodigo = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvTipo = new System.Windows.Forms.ListView();
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pEsquerda = new System.Windows.Forms.Panel();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.ttMsg = new System.Windows.Forms.ToolTip(this.components);
            this.tLPGeral.SuspendLayout();
            this.tlpVenda.SuspendLayout();
            this.pEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPGeral
            // 
            this.tLPGeral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tLPGeral.ColumnCount = 2;
            this.tLPGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 878F));
            this.tLPGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPGeral.Controls.Add(this.tlpVenda, 0, 0);
            this.tLPGeral.Controls.Add(this.pEsquerda, 0, 0);
            this.tLPGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPGeral.Location = new System.Drawing.Point(0, 0);
            this.tLPGeral.Name = "tLPGeral";
            this.tLPGeral.RowCount = 1;
            this.tLPGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPGeral.Size = new System.Drawing.Size(1066, 526);
            this.tLPGeral.TabIndex = 1;
            // 
            // tlpVenda
            // 
            this.tlpVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tlpVenda.ColumnCount = 1;
            this.tlpVenda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVenda.Controls.Add(this.lvCodigo, 0, 1);
            this.tlpVenda.Controls.Add(this.lvTipo, 0, 0);
            this.tlpVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVenda.Location = new System.Drawing.Point(186, 2);
            this.tlpVenda.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVenda.Name = "tlpVenda";
            this.tlpVenda.RowCount = 2;
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.95519F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.04481F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVenda.Size = new System.Drawing.Size(878, 522);
            this.tlpVenda.TabIndex = 11;
            // 
            // lvCodigo
            // 
            this.lvCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvCodigo.FullRowSelect = true;
            this.lvCodigo.GridLines = true;
            this.lvCodigo.HoverSelection = true;
            this.lvCodigo.LargeImageList = this.imageList1;
            this.lvCodigo.Location = new System.Drawing.Point(1, 220);
            this.lvCodigo.Margin = new System.Windows.Forms.Padding(1);
            this.lvCodigo.Name = "lvCodigo";
            this.lvCodigo.Size = new System.Drawing.Size(876, 301);
            this.lvCodigo.SmallImageList = this.imageList1;
            this.lvCodigo.TabIndex = 1;
            this.lvCodigo.UseCompatibleStateImageBehavior = false;
            this.lvCodigo.ItemActivate += new System.EventHandler(this.lvCodigo_ItemActivate);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pizza 1.jpg");
            this.imageList1.Images.SetKeyName(1, "Massa 2.jpg");
            this.imageList1.Images.SetKeyName(2, "Aperitivo 3.jpg");
            this.imageList1.Images.SetKeyName(3, "Sobremesa 4.jpg");
            this.imageList1.Images.SetKeyName(4, "Sorvete 5.jpg");
            this.imageList1.Images.SetKeyName(5, "Refrigerantes 6.jpg");
            this.imageList1.Images.SetKeyName(6, "Cervejas 7.jpg");
            this.imageList1.Images.SetKeyName(7, "Outros 8.jpg");
            this.imageList1.Images.SetKeyName(8, "Bebida Quente 9.jpg");
            this.imageList1.Images.SetKeyName(9, "Wisky 10.jpg");
            this.imageList1.Images.SetKeyName(10, "Vinho 11.jpg");
            // 
            // lvTipo
            // 
            this.lvTipo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoria});
            this.lvTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvTipo.FullRowSelect = true;
            this.lvTipo.GridLines = true;
            this.lvTipo.HoverSelection = true;
            this.lvTipo.Location = new System.Drawing.Point(1, 1);
            this.lvTipo.Margin = new System.Windows.Forms.Padding(1);
            this.lvTipo.Name = "lvTipo";
            this.lvTipo.Size = new System.Drawing.Size(876, 217);
            this.lvTipo.TabIndex = 0;
            this.lvTipo.UseCompatibleStateImageBehavior = false;
            this.lvTipo.ItemActivate += new System.EventHandler(this.lvTipo_ItemActivate);
            this.lvTipo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvTipo_ItemSelectionChanged);
            this.lvTipo.Click += new System.EventHandler(this.lvTipo_Click);
            // 
            // categoria
            // 
            this.categoria.Text = "CATEGORIA";
            this.categoria.Width = 100;
            // 
            // pEsquerda
            // 
            this.pEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.pEsquerda.Controls.Add(this.btConfirmar);
            this.pEsquerda.Controls.Add(this.btCancelar);
            this.pEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEsquerda.Location = new System.Drawing.Point(3, 3);
            this.pEsquerda.Margin = new System.Windows.Forms.Padding(1);
            this.pEsquerda.Name = "pEsquerda";
            this.pEsquerda.Size = new System.Drawing.Size(180, 520);
            this.pEsquerda.TabIndex = 1;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.setverde;
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btConfirmar.Location = new System.Drawing.Point(28, 61);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(136, 66);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Pizzaria.Properties.Resources.setVermelhor;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(53, 331);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 52);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "SAIR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // CodigoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 526);
            this.ControlBox = false;
            this.Controls.Add(this.tLPGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(683, 250);
            this.Name = "CodigoProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CodigoProduto";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodigoProduto_KeyDown);
            this.tLPGeral.ResumeLayout(false);
            this.tlpVenda.ResumeLayout(false);
            this.pEsquerda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPGeral;
        private System.Windows.Forms.ListView lvTipo;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.Panel pEsquerda;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ListView lvCodigo;
        private System.Windows.Forms.ToolTip ttMsg;
        private System.Windows.Forms.TableLayoutPanel tlpVenda;
        private System.Windows.Forms.ImageList imageList1;
    }
}