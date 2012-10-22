namespace Pizzaria
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
            this.tLPGeral = new System.Windows.Forms.TableLayoutPanel();
            this.lvTipo = new System.Windows.Forms.ListView();
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pEsquerda = new System.Windows.Forms.Panel();
            this.query2 = new System.Windows.Forms.Label();
            this.lmsg = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lvCodigo = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttMsg = new System.Windows.Forms.ToolTip(this.components);
            this.tLPGeral.SuspendLayout();
            this.pEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPGeral
            // 
            this.tLPGeral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tLPGeral.ColumnCount = 3;
            this.tLPGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tLPGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tLPGeral.Controls.Add(this.lvTipo, 0, 0);
            this.tLPGeral.Controls.Add(this.pEsquerda, 0, 0);
            this.tLPGeral.Controls.Add(this.lvCodigo, 2, 0);
            this.tLPGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPGeral.Location = new System.Drawing.Point(0, 0);
            this.tLPGeral.Name = "tLPGeral";
            this.tLPGeral.RowCount = 1;
            this.tLPGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPGeral.Size = new System.Drawing.Size(677, 222);
            this.tLPGeral.TabIndex = 1;
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
            this.lvTipo.Location = new System.Drawing.Point(251, 3);
            this.lvTipo.Margin = new System.Windows.Forms.Padding(1);
            this.lvTipo.Name = "lvTipo";
            this.lvTipo.Size = new System.Drawing.Size(121, 216);
            this.lvTipo.TabIndex = 0;
            this.lvTipo.UseCompatibleStateImageBehavior = false;
            this.lvTipo.View = System.Windows.Forms.View.Details;
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
            this.pEsquerda.Controls.Add(this.query2);
            this.pEsquerda.Controls.Add(this.lmsg);
            this.pEsquerda.Controls.Add(this.btConfirmar);
            this.pEsquerda.Controls.Add(this.btCancelar);
            this.pEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEsquerda.Location = new System.Drawing.Point(3, 3);
            this.pEsquerda.Margin = new System.Windows.Forms.Padding(1);
            this.pEsquerda.Name = "pEsquerda";
            this.pEsquerda.Size = new System.Drawing.Size(244, 216);
            this.pEsquerda.TabIndex = 1;
            // 
            // query2
            // 
            this.query2.AutoSize = true;
            this.query2.Font = new System.Drawing.Font("Arial", 10.5F);
            this.query2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.query2.Location = new System.Drawing.Point(80, 153);
            this.query2.Name = "query2";
            this.query2.Size = new System.Drawing.Size(93, 16);
            this.query2.TabIndex = 36;
            this.query2.Text = "Duplo Clique ";
            // 
            // lmsg
            // 
            this.lmsg.AutoSize = true;
            this.lmsg.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lmsg.Location = new System.Drawing.Point(54, 172);
            this.lmsg.Name = "lmsg";
            this.lmsg.Size = new System.Drawing.Size(145, 16);
            this.lmsg.TabIndex = 35;
            this.lmsg.Text = "Descrição do Produto";
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.setverde;
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btConfirmar.Location = new System.Drawing.Point(76, 21);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(101, 36);
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
            this.btCancelar.Location = new System.Drawing.Point(95, 83);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(63, 36);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "SAIR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lvCodigo
            // 
            this.lvCodigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Produto});
            this.lvCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvCodigo.FullRowSelect = true;
            this.lvCodigo.GridLines = true;
            this.lvCodigo.HoverSelection = true;
            this.lvCodigo.Location = new System.Drawing.Point(376, 3);
            this.lvCodigo.Margin = new System.Windows.Forms.Padding(1);
            this.lvCodigo.Name = "lvCodigo";
            this.lvCodigo.Size = new System.Drawing.Size(298, 216);
            this.lvCodigo.TabIndex = 1;
            this.lvCodigo.UseCompatibleStateImageBehavior = false;
            this.lvCodigo.View = System.Windows.Forms.View.Details;
            this.lvCodigo.ItemActivate += new System.EventHandler(this.lvCodigo_ItemActivate);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 82;
            // 
            // Produto
            // 
            this.Produto.Text = "Descrição do Produto";
            this.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Produto.Width = 210;
            // 
            // CodigoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 222);
            this.ControlBox = false;
            this.Controls.Add(this.tLPGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(683, 250);
            this.MinimumSize = new System.Drawing.Size(683, 250);
            this.Name = "CodigoProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CodigoProduto";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodigoProduto_KeyDown);
            this.tLPGeral.ResumeLayout(false);
            this.pEsquerda.ResumeLayout(false);
            this.pEsquerda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPGeral;
        private System.Windows.Forms.ListView lvTipo;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.Panel pEsquerda;
        private System.Windows.Forms.Label query2;
        private System.Windows.Forms.Label lmsg;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ListView lvCodigo;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ToolTip ttMsg;
    }
}