using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmRelSaoPaulo.DAL;
using frmRelSaoPaulo.Modelos;
using System.Data.SqlClient;
using System.Collections;

namespace UIWindows1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public bool validaData(string data)
        {
            try
            {
                DateTime.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskDataCad.Text == "" || mskDataCad.Text == null)
                {
                    validaData(mskDataCad.Text);
                    MessageBox.Show("A data é obrigatória!");
                }
                else
                {
                    frmRelSaoPaulo.Modelos.DadosInformation dados = new frmRelSaoPaulo.Modelos.DadosInformation();
                    dados.CNPJ = txtCnpj.Text;
                    dados.Data = Convert.ToDateTime(mskDataCad.Text);
                    dados.Empresa = txtEmpresa.Text;
                    dados.Nire = txtNire.Text;
                    dados.Parametro = txtParametro.Text;
                    dados.Registro = txtRegistro.Text;

                    BLL.FormulariosBLL obj = new BLL.FormulariosBLL();
                    obj.Incluir(dados);
                    MessageBox.Show("Dados Incluidos com sucesso!");
                    txtCodigo.Text = Convert.ToString(dados.Cod_empresa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                txtCodigo.Text = "";
                mskDataCad.Text = "";
                txtCnpj.Text = "";
                txtEmpresa.Text = "";
                txtNire.Text = "";
                txtParametro.Text = "";
                txtRegistro.Text = "";
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            frmAlteraDadosEmpresa frm = new frmAlteraDadosEmpresa();
            frm.ShowDialog();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            mskDataCad.Text = "";
            txtCnpj.Text = "";
            txtEmpresa.Text = "";
            txtNire.Text = "";
            txtParametro.Text = "";
            txtRegistro.Text = "";
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            frmExcluiDados frm = new frmExcluiDados();
            frm.ShowDialog();
        }

        private void btnGeraRel_Click(object sender, EventArgs e)
        {
            frmBuscaData frm = new frmBuscaData();
            frm.ShowDialog();
        }

        private void btnListaParametro_Click(object sender, EventArgs e)
        {
            frmParametroDescricao frmp = new frmParametroDescricao();
            frmp.OnDataChange += new frmParametroDescricao.OnDataChangeHandler(frmParametroDescricao_OnDataChange);
            frmp.ShowDialog();          
        }

        private void frmParametroDescricao_OnDataChange(Hashtable info1, Hashtable info2, Hashtable info3, Hashtable info4, Hashtable info5, Hashtable info6, Hashtable info7, Hashtable info8, Hashtable info9, Hashtable info10)
        {

            if (info1.Count > 0)
            {
                txtParametro.Text += info1["JC001"].ToString();              
            }
           
            if(info2.Count > 0)
            {
                txtParametro.Text += info2["JC002"].ToString();
            }
          
            if (info3.Count > 0)
            {
                txtParametro.Text += info3["JC003"].ToString();
            }

            if (info4.Count > 0)
            {
                txtParametro.Text += info4["JC004"].ToString();
            }

            if (info5.Count > 0)
            {
                txtParametro.Text += info5["JC005"].ToString();
            }

            if (info6.Count > 0)
            {
                txtParametro.Text += info6["JC006"].ToString();
            }

            if (info7.Count > 0)
            {
                txtParametro.Text += info7["JC007"].ToString();
            }

            if (info8.Count > 0)
            {
                txtParametro.Text += info8["JC008"].ToString();
            }

            if (info9.Count > 0)
            {
                txtParametro.Text += info9["JC009"].ToString();
            }

            if (info10.Count > 0)
            {
                txtParametro.Text += info10["JD001"].ToString();
            }

        }
    }
}
