namespace Pizzaria.Tela
{
    partial class Garcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garcon));
            this.listVenda = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pUnico = new System.Windows.Forms.Panel();
            this.bUnico = new System.Windows.Forms.Button();
            this.lUnico = new System.Windows.Forms.Label();
            this.pUnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVenda
            // 
            this.listVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVenda.Location = new System.Drawing.Point(0, 52);
            this.listVenda.Margin = new System.Windows.Forms.Padding(0);
            this.listVenda.MultiSelect = false;
            this.listVenda.Name = "listVenda";
            this.listVenda.ShowItemToolTips = true;
            this.listVenda.Size = new System.Drawing.Size(324, 194);
            this.listVenda.TabIndex = 8;
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.ItemActivate += new System.EventHandler(this.listVenda_ItemActivate);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "7831_64x64.png");
            // 
            // pUnico
            // 
            this.pUnico.Controls.Add(this.bUnico);
            this.pUnico.Controls.Add(this.lUnico);
            this.pUnico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUnico.Location = new System.Drawing.Point(0, 0);
            this.pUnico.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pUnico.Name = "pUnico";
            this.pUnico.Size = new System.Drawing.Size(324, 52);
            this.pUnico.TabIndex = 9;
            // 
            // bUnico
            // 
            this.bUnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bUnico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnico.ForeColor = System.Drawing.Color.Red;
            this.bUnico.Location = new System.Drawing.Point(301, 0);
            this.bUnico.Margin = new System.Windows.Forms.Padding(0);
            this.bUnico.Name = "bUnico";
            this.bUnico.Size = new System.Drawing.Size(23, 23);
            this.bUnico.TabIndex = 1;
            this.bUnico.Text = "X";
            this.bUnico.UseVisualStyleBackColor = true;
            this.bUnico.Click += new System.EventHandler(this.bUnico_Click);
            // 
            // lUnico
            // 
            this.lUnico.AutoSize = true;
            this.lUnico.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lUnico.Location = new System.Drawing.Point(36, 18);
            this.lUnico.Name = "lUnico";
            this.lUnico.Size = new System.Drawing.Size(268, 17);
            this.lUnico.TabIndex = 0;
            this.lUnico.Text = "DEFINA O GARÇON - APERTE ENTER";
            // 
            // Garcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 246);
            this.ControlBox = false;
            this.Controls.Add(this.listVenda);
            this.Controls.Add(this.pUnico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Garcon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Garcon_KeyDown);
            this.pUnico.ResumeLayout(false);
            this.pUnico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listVenda;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pUnico;
        private System.Windows.Forms.Label lUnico;
        private System.Windows.Forms.Button bUnico;
    }
}