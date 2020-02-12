using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using frmRelSaoPaulo.Modelos;

namespace UIWindows1
{
    public partial class frmAlteraDadosEmpresa : Form
    {
        public frmAlteraDadosEmpresa()
        {
            InitializeComponent();
        }

        private void frmAlteraDadosEmpresa_Load(object sender, EventArgs e)
        {
            txtAltCodigo.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormulariosDAL dados = new FormulariosDAL();
            dgvAltEmpresa.DataSource = dados.AlterarEmpresa(txtBuscar.Text);
           
        }       

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAltCodigo.Text == "")
            {
                MessageBox.Show("Um escritório deve ser selecionado para alteração!");
            }
            else
                try
                {                   
                    DadosInformation dados = new DadosInformation();

                    dados.Cod_empresa = Convert.ToInt32(txtAltCodigo.Text);
                    dados.CNPJ = txtAltCnpj.Text;
                    dados.Data = Convert.ToDateTime(mskAltData.Text);
                    dados.Empresa = txtAltEmpresa.Text;
                    dados.Nire = txtAltNire.Text;
                    dados.Parametro = txtAltParametro.Text;
                    dados.Registro = txtAltRegistro.Text;

                    FormulariosDAL frmDal = new FormulariosDAL();
                    frmDal.Alterar(dados);
                    MessageBox.Show("Empresa atualizada com sucesso!");

                    mskAltData.Text = "";
                    txtAltCnpj.Text = "";
                    txtAltCodigo.Text = "";
                    txtAltEmpresa.Text = "";
                    txtAltNire.Text = "";
                    txtAltParametro.Text = "";
                    txtAltRegistro.Text = "";

                    if (this.dgvAltEmpresa.DataSource != null)
                    {
                        this.dgvAltEmpresa.DataSource = null;
                    }
                    else
                    {
                        this.dgvAltEmpresa.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }         
        }

        public void EnviaDados(DataGridViewRow row)
        {
            txtAltCodigo.Text = row.Cells["cod_empresa"].Value.ToString();
            txtAltEmpresa.Text = row.Cells["empresa"].Value.ToString();
            txtAltCnpj.Text = row.Cells["cnpj"].Value.ToString();
            txtAltNire.Text = row.Cells["nire"].Value.ToString();
            txtAltParametro.Text = row.Cells["parametro"].Value.ToString();
            txtAltRegistro.Text = row.Cells["registro"].Value.ToString();
            mskAltData.Text = row.Cells["data"].Value.ToString();
        }

        private void dgvAltEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvAltEmpresa.Rows[e.RowIndex];
            EnviaDados(row);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
