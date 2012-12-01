﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Pizzaria.Tela
{
    using Pizzaria.Banco;
    using Pizzaria.Properties;
    using Pizzaria.Classes;
    public partial class Fundo : Form
    {
        Principal obj;
        public Fundo()
        {
          
            InitializeComponent();
            {
                obj = new Principal(1, tlpBotoes);
                carregarFormPrincipal(obj);
            }
            ordenarTamanhoBotoesCima();
            tlpBotoes.Visible = true;

        }
        private void ordenarTamanhoBotoesCima()
        {
            this.tlpBotoes.Size = new System.Drawing.Size(this.tlpBotoes.Size.Height, 80);
        }
        //---------------Forms responsaveis por carregar formularios no painel = pLoadForm
        private void carregarFormPrincipal(Principal obj) {
         
            //obj = new Principal(1);
            tlpBotoes.Visible = true;
            pLoadForm.Visible = true;
            
            this.IsMdiContainer = true;
            obj.MdiParent = this;
            obj.Visible = true;
            obj.WindowState = FormWindowState.Maximized;
            obj.StartPosition = FormStartPosition.CenterScreen;

            obj.Size = new System.Drawing.Size(pLoadForm.Size.Width, pLoadForm.Size.Height);
            pLoadForm.Controls.Add(obj);
            obj.Location = new Point(0, 0);
            this.IsMdiContainer = false;
            tlpBotoes.Visible = true;
         /*/  obj // ;= new Principal(1);
                 this.IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Visible = true;
                obj.WindowState = FormWindowState.Maximized;
                obj.StartPosition = FormStartPosition.CenterScreen;
              
                pFormLoadUp.Visible = false;
          
            obj.Size = new System.Drawing.Size(pLoadForm.Size.Width, pLoadForm.Size.Height);
            pLoadForm.Controls.Add(obj);
            obj.Location = new Point(0, 0);
            this.IsMdiContainer = false;
            tlpBotoes.Visible = true;
         /*/
        }
        CadastroForm cf;        AlterarForm af;
        ConsultaForm cof;       TipoRelatorio rf;
        private void expandirConsulta()
        {
            cof = new ConsultaForm();
            cof.Visible = true;
            cof.WindowState = FormWindowState.Maximized;
            cof.StartPosition = FormStartPosition.CenterScreen;
            cof.TopLevel = false;
            cof.Size = new System.Drawing.Size(pLoadForm.Size.Width, pLoadForm.Size.Height);
            pLoadForm.Controls.Add(cof);
            cof.Location = new Point(0, 0);
            obj.Visible = false;
        }
        private void expandirCadastro()
        {
            cf = new CadastroForm();
            cf.Visible = true;
            cf.WindowState = FormWindowState.Maximized;
            cf.StartPosition = FormStartPosition.CenterScreen;
            cf.TopLevel = false;
            cf.Size = new System.Drawing.Size(pLoadForm.Size.Width, pLoadForm.Size.Height);
            pLoadForm.Controls.Add(cf);
            cf.Location = new Point(0, 0);
            obj.Visible = false;
        }
        private void expandirAlterar()
        {
            af = new AlterarForm();
            af.Visible = true;
            af.WindowState = FormWindowState.Maximized;
            af.StartPosition = FormStartPosition.CenterScreen;
            af.TopLevel = false;
            af.Size = new System.Drawing.Size(pLoadForm.Size.Width, pLoadForm.Size.Height);
            pLoadForm.Controls.Add(af);
            af.Location = new Point(0, 0);
            obj.Visible = false;
        }
        private void expandirRelatorios()
        {
            SenhaAcesso sa = new SenhaAcesso();
            sa.ShowDialog();
            if (sa.acesso)
            {

                rf = new TipoRelatorio();
                rf.Visible = true;
                rf.WindowState = FormWindowState.Maximized;
                rf.StartPosition = FormStartPosition.CenterScreen;
                rf.TopLevel = false;
                rf.Size = new System.Drawing.Size(pLoadForm.Size.Width, pLoadForm.Size.Height);
                pLoadForm.Controls.Add(rf);
                rf.Location = new Point(0, 0);
                obj.Visible = false;
            }
            else
            {
                allFixedSingle();
               // rf.Visible = false;
                obj.Visible = true;
                removeAllForm();
            }
        }
        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbCadastro_Click(object sender, EventArgs e)
        {
          
            if (pbCadastro.BorderStyle == BorderStyle.FixedSingle)
            {
             

                allFixedSingle();
                pbCadastro.BorderStyle = BorderStyle.Fixed3D;
                expandirCadastro();
                pLoadForm.Controls.Remove(af);
                pLoadForm.Controls.Remove(cof);

            }
            else {
                allFixedSingle();
                cf.Visible = false;
                obj.Visible = true;
                removeAllForm();
            }
        }
        private void pbAlterar_Click(object sender, EventArgs e)
        {
            if (pbAlterar.BorderStyle == BorderStyle.FixedSingle)
            {
                allFixedSingle();
                
                pbAlterar.BorderStyle = BorderStyle.Fixed3D;
                expandirAlterar();
                pLoadForm.Controls.Remove(cf);
                pLoadForm.Controls.Remove(cof);
                
            }
            else
            {
                allFixedSingle();
                af.Visible = false;
                obj.Visible = true;
                removeAllForm();
                
            }
        }
        private void pbConsulta_Click(object sender, EventArgs e)
        {
            if (pbConsulta.BorderStyle == BorderStyle.FixedSingle)
            {
                allFixedSingle();
                pbConsulta.BorderStyle = BorderStyle.Fixed3D;
                expandirConsulta();
                pLoadForm.Controls.Remove(cf);
                pLoadForm.Controls.Remove(af);
            }
            else
            {
                allFixedSingle();
                cof.Visible = false;
                obj.Visible = true;
                removeAllForm();
            }
        }
        private void pbRelatorio_Click(object sender, EventArgs e)
        {
            if (pbRelatorio.BorderStyle == BorderStyle.FixedSingle)
            {
                allFixedSingle();
                pbRelatorio.BorderStyle = BorderStyle.Fixed3D;
                expandirRelatorios();
                pLoadForm.Controls.Remove(cf);
                pLoadForm.Controls.Remove(cof);
                pLoadForm.Controls.Remove(af);
            }
            else
            {
                allFixedSingle();
                rf.Visible = false;
                obj.Visible = true;
                removeAllForm();
            }

        }     
        private void removeAllForm()
        {
            pLoadForm.Controls.Remove(cf);
            pLoadForm.Controls.Remove(af);
            pLoadForm.Controls.Remove(cof);
            pLoadForm.Controls.Remove(rf);
        }
        private void allFixedSingle()
        {
            pbRelatorio.BorderStyle = BorderStyle.FixedSingle;
            pbCadastro.BorderStyle = BorderStyle.FixedSingle;
            pbAlterar.BorderStyle = BorderStyle.FixedSingle;
            pbConsulta.BorderStyle = BorderStyle.FixedSingle;
        }
  
    }
}
