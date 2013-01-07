namespace Pizzaria.Tela
{
    partial class AlterarMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarMesa));
            this.btCancelar = new System.Windows.Forms.Button();
            this.listVenda = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pFundo = new System.Windows.Forms.Panel();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.cbMista = new System.Windows.Forms.ComboBox();
            this.lbMista = new System.Windows.Forms.Label();
            this.pFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Pizzaria.Properties.Resources.BtCancelar;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(446, 171);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 40);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // listVenda
            // 
            this.listVenda.Dock = System.Windows.Forms.DockStyle.Left;
            this.listVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVenda.Location = new System.Drawing.Point(0, 0);
            this.listVenda.Name = "listVenda";
            this.listVenda.ShowItemToolTips = true;
            this.listVenda.Size = new System.Drawing.Size(410, 232);
            this.listVenda.TabIndex = 4;
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listVenda_ItemChecked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mesa-jantar-demolicao-g.jpg");
            this.imageList1.Images.SetKeyName(1, "Sem título.png");
            this.imageList1.Images.SetKeyName(2, "favicon.ico");
            this.imageList1.Images.SetKeyName(3, "teste.jpg");
            this.imageList1.Images.SetKeyName(4, "images.jpg");
            // 
            // pFundo
            // 
            this.pFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFundo.Controls.Add(this.lbMista);
            this.pFundo.Controls.Add(this.cbMista);
            this.pFundo.Controls.Add(this.listVenda);
            this.pFundo.Controls.Add(this.btCancelar);
            this.pFundo.Controls.Add(this.btConfirmar);
            this.pFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFundo.Location = new System.Drawing.Point(0, 0);
            this.pFundo.Margin = new System.Windows.Forms.Padding(0);
            this.pFundo.Name = "pFundo";
            this.pFundo.Size = new System.Drawing.Size(570, 234);
            this.pFundo.TabIndex = 7;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.BtConfirmar;
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btConfirmar.Location = new System.Drawing.Point(427, 106);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(130, 49);
            this.btConfirmar.TabIndex = 5;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // cbMista
            // 
            this.cbMista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMista.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cbMista.FormattingEnabled = true;
            this.cbMista.Items.AddRange(new object[] {
            "INTEIRA",
            "50% - 50%",
            "50% - 2 x 25%",
            "4 x  - 25%"});
            this.cbMista.Location = new System.Drawing.Point(427, 38);
            this.cbMista.Name = "cbMista";
            this.cbMista.Size = new System.Drawing.Size(134, 31);
            this.cbMista.TabIndex = 8;
            this.cbMista.Visible = false;
            // 
            // lbMista
            // 
            this.lbMista.AutoSize = true;
            this.lbMista.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lbMista.Location = new System.Drawing.Point(423, 14);
            this.lbMista.Name = "lbMista";
            this.lbMista.Size = new System.Drawing.Size(146, 21);
            this.lbMista.TabIndex = 11;
            this.lbMista.Text = "MESA DESTINO";
            this.lbMista.Visible = false;
            // 
            // AlterarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 234);
            this.ControlBox = false;
            this.Controls.Add(this.pFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 250);
            this.Name = "AlterarMesa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlterarMesa_KeyDown);
            this.pFundo.ResumeLayout(false);
            this.pFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.ListView listVenda;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pFundo;
        private System.Windows.Forms.ComboBox cbMista;
        private System.Windows.Forms.Label lbMista;
    }
}