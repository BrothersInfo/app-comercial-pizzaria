namespace Pizzaria.Tela
{
    partial class SenhaAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaAcesso));
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbNovoNomeGarcon = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Arial", 16F);
            this.tbUsuario.Location = new System.Drawing.Point(129, 68);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(162, 32);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // lbNovoNomeGarcon
            // 
            this.lbNovoNomeGarcon.AutoSize = true;
            this.lbNovoNomeGarcon.BackColor = System.Drawing.Color.Transparent;
            this.lbNovoNomeGarcon.Font = new System.Drawing.Font("Arial", 13F);
            this.lbNovoNomeGarcon.Location = new System.Drawing.Point(125, 44);
            this.lbNovoNomeGarcon.Name = "lbNovoNomeGarcon";
            this.lbNovoNomeGarcon.Size = new System.Drawing.Size(72, 21);
            this.lbNovoNomeGarcon.TabIndex = 31;
            this.lbNovoNomeGarcon.Text = "Usuário";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Arial", 16F);
            this.tbSenha.Location = new System.Drawing.Point(129, 130);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(162, 32);
            this.tbSenha.TabIndex = 1;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.Location = new System.Drawing.Point(125, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Senha";
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Arial", 13F);
            this.lTitulo.Location = new System.Drawing.Point(4, 7);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(437, 21);
            this.lTitulo.TabIndex = 36;
            this.lTitulo.Text = "ÁREA RESTRITA - DIGITE SUA SENHA DE ACESSO";
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Pizzaria.Properties.Resources.BtCancelar;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btCancelar.Location = new System.Drawing.Point(313, 106);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(124, 57);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.BtConfirmar;
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btConfirmar.Location = new System.Drawing.Point(313, 43);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(124, 57);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pizzaria.Properties.Resources.Register_128;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(16, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 100);
            this.panel1.TabIndex = 37;
            // 
            // SenhaAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 171);
            this.ControlBox = false;
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.lbNovoNomeGarcon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SenhaAcesso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbNovoNomeGarcon;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel panel1;
    }
}