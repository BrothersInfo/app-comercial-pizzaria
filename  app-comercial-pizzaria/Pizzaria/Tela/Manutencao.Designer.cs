namespace Pizzaria.Tela
{
    partial class Manutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manutencao));
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btComissao = new System.Windows.Forms.Button();
            this.gbComissao = new System.Windows.Forms.GroupBox();
            this.lbPct = new System.Windows.Forms.Label();
            this.lbComissaoAviso = new System.Windows.Forms.Label();
            this.mtComissao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPct = new System.Windows.Forms.RadioButton();
            this.rbFixo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btIsPct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbComissao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Location = new System.Drawing.Point(12, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(297, 287);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btComissao
            // 
            this.btComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btComissao.BackgroundImage = global::Pizzaria.Properties.Resources.BtConfirmar;
            this.btComissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btComissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btComissao.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComissao.ForeColor = System.Drawing.Color.White;
            this.btComissao.Location = new System.Drawing.Point(297, 84);
            this.btComissao.Name = "btComissao";
            this.btComissao.Size = new System.Drawing.Size(100, 43);
            this.btComissao.TabIndex = 4;
            this.btComissao.Tag = "";
            this.btComissao.UseVisualStyleBackColor = true;
            this.btComissao.Click += new System.EventHandler(this.btComissao_Click);
            // 
            // gbComissao
            // 
            this.gbComissao.Controls.Add(this.lbPct);
            this.gbComissao.Controls.Add(this.lbComissaoAviso);
            this.gbComissao.Controls.Add(this.mtComissao);
            this.gbComissao.Controls.Add(this.btComissao);
            this.gbComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComissao.Location = new System.Drawing.Point(324, 151);
            this.gbComissao.Name = "gbComissao";
            this.gbComissao.Size = new System.Drawing.Size(426, 148);
            this.gbComissao.TabIndex = 5;
            this.gbComissao.TabStop = false;
            this.gbComissao.Text = "Valor Percentual da Comissão";
            // 
            // lbPct
            // 
            this.lbPct.AutoSize = true;
            this.lbPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbPct.Location = new System.Drawing.Point(365, 35);
            this.lbPct.Name = "lbPct";
            this.lbPct.Size = new System.Drawing.Size(32, 26);
            this.lbPct.TabIndex = 7;
            this.lbPct.Text = "%";
            // 
            // lbComissaoAviso
            // 
            this.lbComissaoAviso.AutoSize = true;
            this.lbComissaoAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbComissaoAviso.Location = new System.Drawing.Point(26, 23);
            this.lbComissaoAviso.Name = "lbComissaoAviso";
            this.lbComissaoAviso.Size = new System.Drawing.Size(246, 120);
            this.lbComissaoAviso.TabIndex = 5;
            this.lbComissaoAviso.Text = "Digite Zero para :\r\nDesativar a Comissão de Garcon;\r\nDigite um Valor* para :\r\nAtu" +
                "alizar a Comissão\r\n* Valores permitidos entre 0 e 99\r\n* Somente Números";
            // 
            // mtComissao
            // 
            this.mtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtComissao.Location = new System.Drawing.Point(297, 29);
            this.mtComissao.Mask = "00";
            this.mtComissao.Name = "mtComissao";
            this.mtComissao.Size = new System.Drawing.Size(42, 32);
            this.mtComissao.TabIndex = 6;
            this.mtComissao.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPct);
            this.groupBox1.Controls.Add(this.rbFixo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btIsPct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(324, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor Percentual da Comissão";
            // 
            // rbPct
            // 
            this.rbPct.AutoSize = true;
            this.rbPct.Location = new System.Drawing.Point(383, 44);
            this.rbPct.Name = "rbPct";
            this.rbPct.Size = new System.Drawing.Size(14, 13);
            this.rbPct.TabIndex = 10;
            this.rbPct.TabStop = true;
            this.rbPct.UseVisualStyleBackColor = true;
            this.rbPct.CheckedChanged += new System.EventHandler(this.rbPct_CheckedChanged);
            // 
            // rbFixo
            // 
            this.rbFixo.AutoSize = true;
            this.rbFixo.Location = new System.Drawing.Point(331, 44);
            this.rbFixo.Name = "rbFixo";
            this.rbFixo.Size = new System.Drawing.Size(14, 13);
            this.rbFixo.TabIndex = 9;
            this.rbFixo.TabStop = true;
            this.rbFixo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(292, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(353, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Defina a Forma de Comissão :\r\nValor Fixo ou\r\nValor Percentual Sobre a Venda ";
            // 
            // btIsPct
            // 
            this.btIsPct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btIsPct.BackgroundImage = global::Pizzaria.Properties.Resources.BtConfirmar;
            this.btIsPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIsPct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIsPct.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIsPct.ForeColor = System.Drawing.Color.White;
            this.btIsPct.Location = new System.Drawing.Point(297, 78);
            this.btIsPct.Name = "btIsPct";
            this.btIsPct.Size = new System.Drawing.Size(100, 43);
            this.btIsPct.TabIndex = 4;
            this.btIsPct.Tag = "";
            this.btIsPct.UseVisualStyleBackColor = true;
            this.btIsPct.Click += new System.EventHandler(this.btIsPct_Click);
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 314);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbComissao);
            this.Controls.Add(this.pbFoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(778, 330);
            this.MinimumSize = new System.Drawing.Size(778, 330);
            this.Name = "Manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manutencao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Manutencao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbComissao.ResumeLayout(false);
            this.gbComissao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btComissao;
        private System.Windows.Forms.GroupBox gbComissao;
        private System.Windows.Forms.Label lbComissaoAviso;
        private System.Windows.Forms.MaskedTextBox mtComissao;
        private System.Windows.Forms.Label lbPct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIsPct;
        private System.Windows.Forms.RadioButton rbPct;
        private System.Windows.Forms.RadioButton rbFixo;
        private System.Windows.Forms.Label label3;
    }
}