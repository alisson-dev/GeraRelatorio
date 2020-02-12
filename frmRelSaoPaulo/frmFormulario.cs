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


namespace UIWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtData.Text = "";
            txtCnpj.Text = "";
            txtEmpresa.Text = "";
            txtNire.Text = "";
            txtParametro.Text = "";
            txtRegistro.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelSaoPaulo.Modelos.DadosInformation dados = new frmRelSaoPaulo.Modelos.DadosInformation();
                dados.CNPJ = txtCnpj.Text;
                dados.Data = Convert.ToDateTime(txtData.Text);
                dados.Empresa = txtEmpresa.Text;
                dados.Nire = txtNire.Text;
                dados.Parametro = txtParametro.Text;
                dados.Registro = txtRegistro.Text;

                BLL.FormulariosBLL obj = new BLL.FormulariosBLL();
                obj.Incluir(dados);
                MessageBox.Show("Dados Incluidos com sucesso!");
                txtCodigo.Text = Convert.ToString(dados.Cod_empresa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Uma empresa deve ser selecionada para alteração.");
            }
            else
                try
                {
                    DadosInformation dados = new DadosInformation();
                    dados.Cod_empresa = int.Parse(txtCodigo.Text);
                    dados.CNPJ = txtCnpj.Text;
                    dados.Data = Convert.ToDateTime(txtData.Text);
                    dados.Empresa = txtEmpresa.Text;
                    dados.Nire = txtNire.Text;
                    dados.Parametro = txtParametro.Text;
                    dados.Registro = txtRegistro.Text;

                    BLL.FormulariosBLL obj = new BLL.FormulariosBLL();
                    obj.Alterar(dados);
                    MessageBox.Show("Dados alterados com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //if (txtCodigo.Text.Length == 0)
            //{
            //    MessageBox.Show("Selecionar uma empresa antes da exclusão");
            //}
            //else
            //    try
            //    {
            //        int codigo = Convert.ToInt32(txtCodigo.Text);
            //        BLL.FormulariosBLL obj = new BLL.FormulariosBLL();
            //        obj.excluir(codigo);
            //        MessageBox.Show("Empresa excluida com sucesso!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
        }
    }
}
