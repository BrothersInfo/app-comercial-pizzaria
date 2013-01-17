namespace Pizzaria.Tela
{
    partial class Fundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fundo));
            this.tlpFundo = new System.Windows.Forms.TableLayoutPanel();
            this.pCentroFundo = new System.Windows.Forms.Panel();
            this.pLoadForm = new System.Windows.Forms.Panel();
            this.gbAtalho = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBalcao = new System.Windows.Forms.Label();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.pbFechar = new System.Windows.Forms.Panel();
            this.pbAjuda = new System.Windows.Forms.Panel();
            this.pbRelatorio = new System.Windows.Forms.Panel();
            this.pbAlterar = new System.Windows.Forms.Panel();
            this.pbConsulta = new System.Windows.Forms.Panel();
            this.pbCadastro = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ttBotao = new System.Windows.Forms.ToolTip(this.components);
            this.tlpFundo.SuspendLayout();
            this.pCentroFundo.SuspendLayout();
            this.pLoadForm.SuspendLayout();
            this.gbAtalho.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFundo
            // 
            this.tlpFundo.ColumnCount = 3;
            this.tlpFundo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFundo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFundo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFundo.Controls.Add(this.pCentroFundo, 1, 0);
            this.tlpFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFundo.Location = new System.Drawing.Point(0, 0);
            this.tlpFundo.Name = "tlpFundo";
            this.tlpFundo.RowCount = 2;
            this.tlpFundo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFundo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFundo.Size = new System.Drawing.Size(633, 436);
            this.tlpFundo.TabIndex = 0;
            // 
            // pCentroFundo
            // 
            this.pCentroFundo.Controls.Add(this.pLoadForm);
            this.pCentroFundo.Controls.Add(this.tlpBotoes);
            this.pCentroFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCentroFundo.Location = new System.Drawing.Point(20, 0);
            this.pCentroFundo.Margin = new System.Windows.Forms.Padding(0);
            this.pCentroFundo.Name = "pCentroFundo";
            this.pCentroFundo.Size = new System.Drawing.Size(593, 416);
            this.pCentroFundo.TabIndex = 4;
            // 
            // pLoadForm
            // 
            this.pLoadForm.BackColor = System.Drawing.Color.White;
            this.pLoadForm.Controls.Add(this.gbAtalho);
            this.pLoadForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadForm.Location = new System.Drawing.Point(0, 54);
            this.pLoadForm.Margin = new System.Windows.Forms.Padding(0);
            this.pLoadForm.Name = "pLoadForm";
            this.pLoadForm.Size = new System.Drawing.Size(593, 362);
            this.pLoadForm.TabIndex = 4;
            // 
            // gbAtalho
            // 
            this.gbAtalho.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbAtalho.Controls.Add(this.label4);
            this.gbAtalho.Controls.Add(this.label3);
            this.gbAtalho.Controls.Add(this.label2);
            this.gbAtalho.Controls.Add(this.label1);
            this.gbAtalho.Controls.Add(this.lBalcao);
            this.gbAtalho.Location = new System.Drawing.Point(0, 121);
            this.gbAtalho.Name = "gbAtalho";
            this.gbAtalho.Size = new System.Drawing.Size(593, 182);
            this.gbAtalho.TabIndex = 0;
            this.gbAtalho.TabStop = false;
            this.gbAtalho.Text = "Help";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "VOLTAR : [ ESC ]";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "VENDA : Imprimir Comanda : [ I ] ;      Encerrar  :  [ V ] \r\nAgrupar Vendas [ A ]" +
                " ;     Separar Venda [ S ] ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRODUTO : Inserir: [ P ] ;     Remover : [ R ]";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "MESA : Inserir [ M ] ;      Remover [ N ] ;     Trocar [ T ]";
            // 
            // lBalcao
            // 
            this.lBalcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBalcao.AutoSize = true;
            this.lBalcao.BackColor = System.Drawing.Color.Transparent;
            this.lBalcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBalcao.ForeColor = System.Drawing.Color.Black;
            this.lBalcao.Location = new System.Drawing.Point(53, 16);
            this.lBalcao.Name = "lBalcao";
            this.lBalcao.Size = new System.Drawing.Size(145, 29);
            this.lBalcao.TabIndex = 3;
            this.lBalcao.Text = "ATALHOS :";
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBotoes.ColumnCount = 6;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotoes.Controls.Add(this.pbFechar, 5, 0);
            this.tlpBotoes.Controls.Add(this.pbConsulta, 3, 0);
            this.tlpBotoes.Controls.Add(this.pbAjuda, 4, 0);
            this.tlpBotoes.Controls.Add(this.pbCadastro, 0, 0);
            this.tlpBotoes.Controls.Add(this.pbAlterar, 1, 0);
            this.tlpBotoes.Controls.Add(this.pbRelatorio, 2, 0);
            this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotoes.Location = new System.Drawing.Point(0, 0);
            this.tlpBotoes.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Size = new System.Drawing.Size(593, 54);
            this.tlpBotoes.TabIndex = 3;
            // 
            // pbFechar
            // 
            this.pbFechar.BackgroundImage = global::Pizzaria.Properties.Resources.BtSair1;
            this.pbFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFechar.Location = new System.Drawing.Point(494, 4);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(95, 46);
            this.pbFechar.TabIndex = 4;
            this.ttBotao.SetToolTip(this.pbFechar, "ENCERRAR SISTEMA");
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // pbAjuda
            // 
            this.pbAjuda.BackgroundImage = global::Pizzaria.Properties.Resources.BtManutencao1;
            this.pbAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAjuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAjuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAjuda.Location = new System.Drawing.Point(396, 4);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(91, 46);
            this.pbAjuda.TabIndex = 3;
            this.ttBotao.SetToolTip(this.pbAjuda, "Serviços de Manutenção");
            this.pbAjuda.Click += new System.EventHandler(this.pbAjuda_Click);
            // 
            // pbRelatorio
            // 
            this.pbRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.pbRelatorio.BackgroundImage = global::Pizzaria.Properties.Resources.BtRelatorio1;
            this.pbRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRelatorio.Location = new System.Drawing.Point(200, 4);
            this.pbRelatorio.Name = "pbRelatorio";
            this.pbRelatorio.Size = new System.Drawing.Size(91, 46);
            this.pbRelatorio.TabIndex = 2;
            this.ttBotao.SetToolTip(this.pbRelatorio, "Relatórios do Sistema");
            this.pbRelatorio.Click += new System.EventHandler(this.pbRelatorio_Click);
            // 
            // pbAlterar
            // 
            this.pbAlterar.BackgroundImage = global::Pizzaria.Properties.Resources.BtAlterar1;
            this.pbAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAlterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAlterar.Location = new System.Drawing.Point(102, 4);
            this.pbAlterar.Name = "pbAlterar";
            this.pbAlterar.Size = new System.Drawing.Size(91, 46);
            this.pbAlterar.TabIndex = 1;
            this.ttBotao.SetToolTip(this.pbAlterar, "Alterar Cadastros, Itens, Preços e etc");
            this.pbAlterar.Click += new System.EventHandler(this.pbAlterar_Click);
            // 
            // pbConsulta
            // 
            this.pbConsulta.BackgroundImage = global::Pizzaria.Properties.Resources.BtConsulta1;
            this.pbConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbConsulta.Location = new System.Drawing.Point(298, 4);
            this.pbConsulta.Name = "pbConsulta";
            this.pbConsulta.Size = new System.Drawing.Size(91, 46);
            this.pbConsulta.TabIndex = 1;
            this.ttBotao.SetToolTip(this.pbConsulta, "Consultar Cadastros, Itens, Produtos e etc");
            this.pbConsulta.Click += new System.EventHandler(this.pbConsulta_Click);
            // 
            // pbCadastro
            // 
            this.pbCadastro.BackgroundImage = global::Pizzaria.Properties.Resources.BtCadastro1;
            this.pbCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCadastro.Location = new System.Drawing.Point(4, 4);
            this.pbCadastro.Name = "pbCadastro";
            this.pbCadastro.Size = new System.Drawing.Size(91, 46);
            this.pbCadastro.TabIndex = 0;
            this.ttBotao.SetToolTip(this.pbCadastro, "Cadastrar Usuarios, Produtos , Mesas e etc");
            this.pbCadastro.Click += new System.EventHandler(this.pbCadastro_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BRtent1.png");
            this.imageList1.Images.SetKeyName(1, "BRtent2.png");
            this.imageList1.Images.SetKeyName(2, "mesawhite.jpg");
            // 
            // ttBotao
            // 
            this.ttBotao.IsBalloon = true;
            this.ttBotao.ShowAlways = true;
            this.ttBotao.ToolTipTitle = "INFORMAÇÃO";
            // 
            // Fundo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 436);
            this.ControlBox = false;
            this.Controls.Add(this.tlpFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Fundo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fundo_KeyDown);
            this.tlpFundo.ResumeLayout(false);
            this.pCentroFundo.ResumeLayout(false);
            this.pLoadForm.ResumeLayout(false);
            this.gbAtalho.ResumeLayout(false);
            this.gbAtalho.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TableLayoutPanel tlpFundo;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Panel pbFechar;
        private System.Windows.Forms.Panel pbAjuda;
        private System.Windows.Forms.Panel pbRelatorio;
        private System.Windows.Forms.Panel pbAlterar;
        private System.Windows.Forms.Panel pbConsulta;
        private System.Windows.Forms.Panel pbCadastro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pCentroFundo;
        private System.Windows.Forms.Panel pLoadForm;
        private System.Windows.Forms.ToolTip ttBotao;
        private System.Windows.Forms.GroupBox gbAtalho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBalcao;
    }
}