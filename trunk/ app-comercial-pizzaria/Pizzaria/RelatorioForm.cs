using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class RelatorioForm : Form
    {
        public RelatorioForm()
        {
            InitializeComponent();
            cbGarcConsulta.SelectedIndex = 0;
            exibirOpcão(1);
        }

      

        private void btConfirmarGarcon_Click(object sender, EventArgs e)
        {

        }
        public void limpaList()
        {
            while(lvConsInfo.Columns.Count>0)
            lvConsInfo.Columns.RemoveAt(0);
        }
        public void carregarConsultaQuadroTipo1()
        {
            try
            {
                DataTable t = new BancoRelatorio().quadroGarconTodos();
                //   DataTable t = new Banco().informacoes("Mesa 25");
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Items.Clear();
                lvConsInfo.Columns[0].Text = "Codigo";
                lvConsInfo.Columns[0].Width = 100;
                lvConsInfo.Columns[1].Text = "Garcon";
                lvConsInfo.Columns[1].Width = 150;
                lvConsInfo.Columns[2].Text = "Estado Atual";
                lvConsInfo.Columns[2].Width = 150;
                lvConsInfo.Columns[3].Text = "Dia de Entrada";
                lvConsInfo.Columns[3].Width = 150;                
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvConsInfo.Items.Add( t.Rows[i].ItemArray.GetValue(0).ToString() );
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(2).ToString());
                    lvConsInfo.Items[i].SubItems.Add(   t.Rows[i].ItemArray.GetValue(3).ToString().Substring(0,
                         t.Rows[i].ItemArray.GetValue(3).ToString().Length-9)
                        );
                }
            
            }
            catch { }
        }
        public void carregarConsultaQuadroTipo2()
        {
            try
            {
                DataTable t = new BancoRelatorio().quadroGarconAtivo(true);
                //   DataTable t = new Banco().informacoes("Mesa 25");

                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Items.Clear();
                lvConsInfo.Columns[0].Text = "Codigo";
                lvConsInfo.Columns[0].Width = 100;
                lvConsInfo.Columns[1].Text = "Garcon";
                lvConsInfo.Columns[1].Width = 150;
                lvConsInfo.Columns[2].Text = "Estado Atual";
                lvConsInfo.Columns[2].Width = 150;
                lvConsInfo.Columns[3].Text = "Dia de Entrada";
                lvConsInfo.Columns[3].Width = 150;

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvConsInfo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(2).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(3).ToString().Substring(0,
                         t.Rows[i].ItemArray.GetValue(3).ToString().Length - 9));
                }

            }
            catch { }
        }
        public void carregarConsultaQuadroTipo3()
        {
            try
            {
                DataTable t = new BancoRelatorio().quadroGarconAtivo(false);
                //   DataTable t = new Banco().informacoes("Mesa 25");
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Items.Clear();
                lvConsInfo.Columns[0].Text = "Codigo";
                lvConsInfo.Columns[0].Width = 100;
                lvConsInfo.Columns[1].Text = "Garcon";
                lvConsInfo.Columns[1].Width = 150;
                lvConsInfo.Columns[2].Text = "Estado Atual";
                lvConsInfo.Columns[2].Width = 150;
                lvConsInfo.Columns[3].Text = "Dia de Entrada";
                lvConsInfo.Columns[3].Width = 150;

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvConsInfo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(2).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(3).ToString().Substring(0,
                       t.Rows[i].ItemArray.GetValue(3).ToString().Length -9));
                }

            }
            catch { }
        }
        public void carregarConsultaTrabalhado(DataTable cpms)
        {
            try
            {
                DataTable t = cpms;
            
                lvConsInfo.Columns.Add(new ColumnHeader());lvConsInfo.Columns.Add(new ColumnHeader());
               
                lvConsInfo.Items.Clear();

                lvConsInfo.Columns[0].Text = "Garcon";
                lvConsInfo.Columns[0].Width = 150;
                lvConsInfo.Columns[1].Text = "Data";
                lvConsInfo.Columns[1].Width = 150;

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvConsInfo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString().Substring(0,
                       t.Rows[i].ItemArray.GetValue(1).ToString().Length - 9));
                }
            }
            catch { }
        }
        public void carregarConsultaTrabalhado2(DataTable cpms)
        {
            try
            {
                DataTable t = cpms;
                lvConsInfo.Columns.Add(new ColumnHeader()); lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Items.Clear();

                lvConsInfo.Columns[0].Text = "Garcon";
                lvConsInfo.Columns[0].Width = 150;
                   lvConsInfo.Columns[1].Text = "Estado Atual";
                  lvConsInfo.Columns[1].Width = 150;
                lvConsInfo.Columns[2].Text = "Data";
                lvConsInfo.Columns[2].Width = 150;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvConsInfo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(2).ToString().Substring(0,
                       t.Rows[i].ItemArray.GetValue(2).ToString().Length - 9));
                }
            }
            catch { }
        }
        public void carregarConsultaTrabalhado3(DataTable cpms)
        {
            try
            {
                DataTable t = cpms;

                lvConsInfo.Columns.Add(new ColumnHeader()); lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns.Add(new ColumnHeader()); lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Items.Clear();

                lvConsInfo.Columns[0].Text = "Garcon";
                lvConsInfo.Columns[0].Width = 150;
                lvConsInfo.Columns[1].Text = "Data";
                lvConsInfo.Columns[1].Width = 150;
                lvConsInfo.Columns[2].Text = "Mesa da Venda";
                lvConsInfo.Columns[2].Width = 150;
                lvConsInfo.Columns[3].Text = "Sub Total";
                lvConsInfo.Columns[3].Width = 150;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvConsInfo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString().Substring(0,
                       t.Rows[i].ItemArray.GetValue(1).ToString().Length - 9));
                    lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(2).ToString());
                    lvConsInfo.Items[i].SubItems.Add(  new Tratamento().retornaValorEscrito( Convert.ToDouble(  t.Rows[i].ItemArray.GetValue(3)) ) );
                }
            }
            catch { }
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGarcConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpaList();
            switch (cbGarcConsulta.SelectedIndex)
            {
                case 0:
                    {
                        carregarConsultaQuadroTipo1();
                        exibirOpcão((short)(cbGarcConsulta.SelectedIndex + 1));
                        rbGarAtivo1.Checked = true;
                        break;
                    }
                case 1:
                    {
                        exibirOpcão((short)(cbGarcConsulta.SelectedIndex + 1)); break;

                    }
                case 2:
                    {
                        exibirOpcão((short)(cbGarcConsulta.SelectedIndex + 1)); break;
                    }

            }  


        }

        private void rbGarAtivo1_CheckedChanged(object sender, EventArgs e)
        {
            limpaList();
            if(cbGarcConsulta.SelectedIndex==0)
            carregarConsultaQuadroTipo1();
            else if (cbGarcConsulta.SelectedIndex == 1)
            { 
            
            }
        }

        private void rbGarAtivo2_CheckedChanged(object sender, EventArgs e)
        {
            limpaList();
            if (cbGarcConsulta.SelectedIndex == 0)
            carregarConsultaQuadroTipo2();
            else if (cbGarcConsulta.SelectedIndex == 1)
            { }
        }

        private void rbGarAtivo3_CheckedChanged(object sender, EventArgs e)
        {
            limpaList();
            if (cbGarcConsulta.SelectedIndex == 0)
            carregarConsultaQuadroTipo3();
            else if (cbGarcConsulta.SelectedIndex == 1)
            { }

        }

        private void consultaTrabalho()
        {
            limpaList();
            if (cbGarcConsulta.SelectedIndex == 1)
            {
                //----------------------------------------consulta trabalhados - consulta numero 2--------------------------------
                if (rbGarQuadro1.Checked)//um garcon
                {
                    if (rbPeriodo2.Checked)
                    {//mes
                        string query =
                        "where v.datavenda between '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "' and ((date '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "'+interval '1 month') - interval '1 day')" +
                            "and g.cod_garcon =  " + new Banco().codGarconByNome(cbGarUm.Text) + " ";
                        carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));
                    }
                    else if (rbPeriodo1.Checked)
                    {//periodo
                        string query;// = "where v.datavenda between '01-06-2012' and  '30-06-2012'";
                        if (dtPData1.Value < dtPData2.Value)
                            query = "where v.datavenda between '" + dtPData1.Value.Date.ToShortDateString() + "' and  '" + dtPData2.Value.Date.ToShortDateString() + "'";
                        else query = "where v.datavenda between '" + dtPData2.Value.Date.ToShortDateString() + "' and  '" + dtPData1.Value.Date.ToShortDateString() + "'";
                        query = query + " and g.cod_garcon =  " + new Banco().codGarconByNome(cbGarUm.Text) + " ";
                        carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));
                    }
                }
                else
                {
                    if (rbGarAtivo1.Checked)
                    {
                        if (rbPeriodo3.Checked)
                        {
                            string query = "where v.datavenda = '" + dtPData2.Value.Date.ToShortDateString() + "' ";
                            carregarConsultaTrabalhado2(new BancoRelatorio().trabalhadoGarconPeriodo(query));

                        }
                        else if (rbPeriodo2.Checked)
                        {
                            string query =
                     "where v.datavenda between '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) +
                     "' and ((date '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "'+interval '1 month') - interval '1 day') ";
                            try
                            {
                                carregarConsultaTrabalhado2(new BancoRelatorio().trabalhadoGarconPeriodo(query));
                            }
                            catch { return; }
                        }
                        else if (rbPeriodo1.Checked)
                        {
                            string query;// = "where v.datavenda between '01-06-2012' and  '30-06-2012'";
                            if (dtPData1.Value < dtPData2.Value)
                                query = "where v.datavenda between '" + dtPData1.Value.Date.ToShortDateString() + "' and  '" + dtPData2.Value.Date.ToShortDateString() + "'";
                            else query = "where v.datavenda between '" + dtPData2.Value.Date.ToShortDateString() + "' and  '" + dtPData1.Value.Date.ToShortDateString() + "'";

                            carregarConsultaTrabalhado2(new BancoRelatorio().trabalhadoGarconPeriodo(query));
                        }
                    }
                    else if (rbGarAtivo2.Checked)
                    {
                        if (rbPeriodo3.Checked)
                        {
                            string query = "where v.datavenda = '" + dtPData2.Value.Date.ToShortDateString() + "' and" +
                            " ativo = true ";
                            carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));

                        }
                        else if (rbPeriodo2.Checked)
                        {
                            string query =
                     "where v.datavenda between '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) +
                     "' and ((date '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "'+interval '1 month') - interval '1 day')  and  ativo = true ";
                            try
                            {
                                carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));
                            }
                            catch { return; }
                        }
                        else if (rbPeriodo1.Checked)
                        {
                            string query;// = "where v.datavenda between '01-06-2012' and  '30-06-2012'";
                            if (dtPData1.Value < dtPData2.Value)
                                query = "where v.datavenda between '" + dtPData1.Value.Date.ToShortDateString() + "' and  '" + dtPData2.Value.Date.ToShortDateString() + "'";
                            else query = "where v.datavenda between '" + dtPData2.Value.Date.ToShortDateString() + "' and  '" + dtPData1.Value.Date.ToShortDateString() + "'";
                            query = query + "   and  ativo = true ";
                            carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));
                        }
                    }
                    else if (rbGarAtivo3.Checked)
                    {
                        if (rbPeriodo3.Checked)
                        {
                            string query = "where v.datavenda = '" + dtPData2.Value.Date.ToShortDateString() + "' and" +
                            " ativo = false ";
                            carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));

                        }
                        else if (rbPeriodo2.Checked)
                        {
                            string query =
                     "where v.datavenda between '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) +
                     "' and ((date '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "'+interval '1 month') - interval '1 day')  and  ativo = false ";
                            try
                            {
                                carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));
                            }
                            catch { return; }
                        }
                        else if (rbPeriodo1.Checked)
                        {
                            string query;// = "where v.datavenda between '01-06-2012' and  '30-06-2012'";
                            if (dtPData1.Value < dtPData2.Value)
                                query = "where v.datavenda between '" + dtPData1.Value.Date.ToShortDateString() + "' and  '" + dtPData2.Value.Date.ToShortDateString() + "'";
                            else query = "where v.datavenda between '" + dtPData2.Value.Date.ToShortDateString() + "' and  '" + dtPData1.Value.Date.ToShortDateString() + "'";
                            query = query + "   and  ativo = false ";
                            carregarConsultaTrabalhado(new BancoRelatorio().trabalhadoGarconPeriodoSemAtivo(query));
                        }

                    }
                }
            }//fim if consulta 2 trabalhado


                ///////////--------------------------------------


            else if (cbGarcConsulta.SelectedIndex == 2) { //vendas do garcon

                if (rbGarQuadro1.Checked)//um garcon
                {
                    if (rbPeriodo2.Checked)
                    {//mes
                        string query =
                        "where v.datavenda between '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "' and ((date '01-" + (cbMesGarcon.SelectedIndex + 1) + "-" + (cbAnoGarcon.SelectedIndex + 2012) + "'+interval '1 month') - interval '1 day')" +
                            "and g.cod_garcon =  " + new Banco().codGarconByNome(cbGarUm.Text) + " and v.aberta ="+rbVendAbert.Checked;
                        carregarConsultaTrabalhado3(new BancoRelatorio().valoresGarconNaVenda(query));
                    }
                    else if (rbPeriodo1.Checked)
                    {//periodo
                        string query;// = "where v.datavenda between '01-06-2012' and  '30-06-2012'";
                        if (dtPData1.Value < dtPData2.Value)
                            query = "where v.datavenda between '" + dtPData1.Value.Date.ToShortDateString() + "' and  '" + dtPData2.Value.Date.ToShortDateString() + "'";
                        else query = "where v.datavenda between '" + dtPData2.Value.Date.ToShortDateString() + "' and  '" + dtPData1.Value.Date.ToShortDateString() + "'";
                        query = query + " and g.cod_garcon =  " + new Banco().codGarconByNome(cbGarUm.Text)  + " and v.aberta =" + rbVendAbert.Checked;
                        carregarConsultaTrabalhado3(new BancoRelatorio().valoresGarconNaVenda(query));
                    }
                    else if (rbPeriodo3.Checked) { 
                    
                    
                    }
                }


            }
        }
        private void rbGarQuadro1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGarQuadro1.Checked)
            {
                gbGarUm.Visible = true;
                gbGarAtiv.Visible = false;
                rbPeriodo3.Visible = false;
                {
                    cbGarUm.DataSource = new BancoConsulta().descricaoGarcon();
                cbGarUm.DisplayMember = "nome";
                cbGarUm.SelectedIndex = 0;
                cbAnoGarcon.SelectedIndex = DateTime.Now.Year - 2012;
                cbMesGarcon.SelectedIndex = DateTime.Now.Month-1;
                    rbPeriodo2.Checked = true;

                }
            }
        }

        private void rbGarQuadro2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGarQuadro2.Checked)
            {
                gbGarUm.Visible = false;
                gbGarAtiv.Visible = true;
                rbPeriodo3.Visible = true;

            }
        }
        //periodo
        private void rbPeriodo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodo1.Checked)
            {
                cbAnoGarcon.Visible = false;
                cbMesGarcon.Visible = false;
                dtPData1.Visible = true;
                dtPData2.Visible = true;
                consultaTrabalho();
            }
        }
        //mes
        private void rbPeriodo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodo2.Checked)
            {
                cbAnoGarcon.Visible = true;
                cbMesGarcon.Visible = true;
                dtPData1.Visible = false;
                dtPData2.Visible = false;
                consultaTrabalho();
            }
        }
        //dia
        private void rbPeriodo3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodo3.Checked)
            {
                cbAnoGarcon.Visible = false;
                cbMesGarcon.Visible = false;
                dtPData1.Visible = false;
                dtPData2.Visible = true;
                consultaTrabalho();
            }
        }

        private void cbMesGarcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaTrabalho();
        }

        private void cbAnoGarcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaTrabalho();
        }

        private void dtPData1_ValueChanged(object sender, EventArgs e)
        {
            consultaTrabalho();
        }

        private void dtPData2_ValueChanged(object sender, EventArgs e)
        {
            consultaTrabalho();
        }

      

        private void rbVendAbert_CheckedChanged(object sender, EventArgs e)
        {
            gbGarAll.Visible = true;
            gbGarAtiv.Visible = false;
            gbGarUm.Visible = false;
            gbGarPeriodo.Visible = false;
            
            gbPicker.Visible = false;

        }

        private void rbVendEncer_CheckedChanged(object sender, EventArgs e)
        {
            exibirOpcão(3);
        }
        //----------------------------------------------
        bool vendaAberta;
        bool umGarcon;
        string garcon;//somente quando umGarcon está marcado
        bool usaAtivo;
        bool isAtivo; //somente quando usaAtivo esta marcado como True
        bool dia;
        bool mes;
        bool periodo;
        int mesNum;
        int anoNum;
        string data1;
        string data2;

        string query;



        private void btConsulta_Click(object sender, EventArgs e)
        {
            switch (cbGarcConsulta.SelectedIndex)
            {
                case 0:
                    {
                        exibirOpcão(1);
                        break;
                    }
                case 1:
                    {
                        exibirOpcão(2);
                        break;

                    }
                case 2:
                    {
                        exibirOpcão(3);
                        
                        break;
                    }
                case 3:
                    {
                        exibirOpcão(4);
                        break;
                    }

            }  
        }
        private void exibirOpcão(short valor)
        {

            switch (valor)
            {
                case 1:
                    {
                        gbGarAll.Visible = false;
                        gbGarAtiv.Visible = true;
                        gbGarUm.Visible = false;
                        gbGarPeriodo.Visible = false;
                        gbGarVenda.Visible = false;
                        gbPicker.Visible = false;

                        break;
                    }
                case 2:
                    {
                        gbGarAll.Visible = true;
                        gbGarAtiv.Visible = true;
                        gbGarUm.Visible = false;
                        gbGarPeriodo.Visible = true;
                        gbGarVenda.Visible = false;
                        gbPicker.Visible = false;
                        rbGarQuadro1.Checked = true;
                        rbGarQuadro1.Focus();
                        rbPeriodo3.Checked = true;
                        gbPicker.Visible = true;
                        break;
                    }
                case 3:
                    {
                        gbGarVenda.Visible = true;
                        gbGarAll.Visible = true;
                        gbGarAtiv.Visible = true;
                        gbGarUm.Visible = false;
                        gbGarPeriodo.Visible = true;

                        gbPicker.Visible = false;
                        rbGarQuadro1.Checked = true;
                        rbGarQuadro1.Focus();
                        rbPeriodo3.Checked = true;
                        gbPicker.Visible = true;
                        break;
                    }
                default: break;
            }
        }

        private void gbGarconConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void lvConsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbGarAll_Enter(object sender, EventArgs e)
        {

        }


    }
}
