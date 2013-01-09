namespace Pizzaria.Tela
{
    partial class Codes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codes));
            this.tvTipado = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvCodigo = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvTipado
            // 
            this.tvTipado.Location = new System.Drawing.Point(12, 12);
            this.tvTipado.Name = "tvTipado";
            this.tvTipado.Size = new System.Drawing.Size(248, 353);
            this.tvTipado.TabIndex = 0;
            this.tvTipado.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTipado_AfterSelect);
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
            this.imageList1.Images.SetKeyName(11, "Suco 12.jpg");
            this.imageList1.Images.SetKeyName(12, "Almoco 13.jpg");
            this.imageList1.Images.SetKeyName(13, "Petisco 14.jpg");
            this.imageList1.Images.SetKeyName(14, "Caldinho 15.jpg");
            this.imageList1.Images.SetKeyName(15, "Tira Gosto 16.jpg");
            this.imageList1.Images.SetKeyName(16, "Agua 17.jpg");
            // 
            // lvCodigo
            // 
            this.lvCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvCodigo.FullRowSelect = true;
            this.lvCodigo.GridLines = true;
            this.lvCodigo.HoverSelection = true;
            this.lvCodigo.LargeImageList = this.imageList1;
            this.lvCodigo.Location = new System.Drawing.Point(275, 12);
            this.lvCodigo.Margin = new System.Windows.Forms.Padding(1);
            this.lvCodigo.Name = "lvCodigo";
            this.lvCodigo.Size = new System.Drawing.Size(644, 353);
            this.lvCodigo.SmallImageList = this.imageList1;
            this.lvCodigo.TabIndex = 2;
            this.lvCodigo.UseCompatibleStateImageBehavior = false;
            this.lvCodigo.ItemActivate += new System.EventHandler(this.lvCodigo_ItemActivate);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Pizza 1.jpg");
            this.imageList2.Images.SetKeyName(1, "Massa 2.jpg");
            this.imageList2.Images.SetKeyName(2, "Aperitivo 3.jpg");
            this.imageList2.Images.SetKeyName(3, "Sobremesa 4.jpg");
            this.imageList2.Images.SetKeyName(4, "Sorvete 5.jpg");
            this.imageList2.Images.SetKeyName(5, "Refrigerantes 6.jpg");
            this.imageList2.Images.SetKeyName(6, "Cervejas 7.jpg");
            this.imageList2.Images.SetKeyName(7, "Outros 8.jpg");
            this.imageList2.Images.SetKeyName(8, "Bebida Quente 9.jpg");
            this.imageList2.Images.SetKeyName(9, "Wisky 10.jpg");
            this.imageList2.Images.SetKeyName(10, "Vinho 11.jpg");
            this.imageList2.Images.SetKeyName(11, "Suco 12.jpg");
            this.imageList2.Images.SetKeyName(12, "Almoco 13.jpg");
            this.imageList2.Images.SetKeyName(13, "Petisco 14.jpg");
            this.imageList2.Images.SetKeyName(14, "Caldinho 15.jpg");
            this.imageList2.Images.SetKeyName(15, "Tira Gosto 16.jpg");
            this.imageList2.Images.SetKeyName(16, "Agua 17.jpg");
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Pizzaria.Properties.Resources.BtCancelar;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(77, 371);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 52);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.BtConfirmar;
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btConfirmar.Location = new System.Drawing.Point(538, 369);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(118, 52);
            this.btConfirmar.TabIndex = 5;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // Codes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 434);
            this.ControlBox = false;
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lvCodigo);
            this.Controls.Add(this.tvTipado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Codes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codes_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvTipado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvCodigo;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirmar;
    }
}