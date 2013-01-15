namespace Pizzaria.Tela
{
    partial class QuantidadeItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantidadeItem));
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.LQuantidade = new System.Windows.Forms.Label();
            this.btParcial = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.Location = new System.Drawing.Point(124, 29);
            this.numQuantidade.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(93, 32);
            this.numQuantidade.TabIndex = 14;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LQuantidade
            // 
            this.LQuantidade.AutoSize = true;
            this.LQuantidade.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.LQuantidade.Location = new System.Drawing.Point(11, 40);
            this.LQuantidade.Name = "LQuantidade";
            this.LQuantidade.Size = new System.Drawing.Size(97, 21);
            this.LQuantidade.TabIndex = 13;
            this.LQuantidade.Text = "QUANTID.";
            // 
            // btParcial
            // 
            this.btParcial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btParcial.BackgroundImage = global::Pizzaria.Properties.Resources.BtImprimir;
            this.btParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btParcial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParcial.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParcial.ForeColor = System.Drawing.Color.Black;
            this.btParcial.Location = new System.Drawing.Point(248, 21);
            this.btParcial.Margin = new System.Windows.Forms.Padding(0);
            this.btParcial.Name = "btParcial";
            this.btParcial.Size = new System.Drawing.Size(102, 43);
            this.btParcial.TabIndex = 15;
            this.btParcial.UseVisualStyleBackColor = true;
            this.btParcial.Click += new System.EventHandler(this.btParcial_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 234;
            this.lineShape1.X2 = 235;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 85;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(364, 84);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "DEFINA QUANTIDADE DO ITEM NO CUPOM";
            // 
            // QuantidadeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 84);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btParcial);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.LQuantidade);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(380, 100);
            this.MinimumSize = new System.Drawing.Size(380, 100);
            this.Name = "QuantidadeItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantidadeItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label LQuantidade;
        private System.Windows.Forms.Button btParcial;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
    }
}