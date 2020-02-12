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
using DAL;

namespace UIWindows1
{
    public partial class frmExcluiDados : Form
    {
        public frmExcluiDados()
        {
            InitializeComponent();
        }

        private void frmExcluiDados_Load(object sender, EventArgs e)
        {
            gpbDados.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtExCodigo.Text.Length == 0)
            {
                MessageBox.Show("Uma empresa deve ser selecionada para Exclusão.");
            }
            else
                try
                {
                    // conexao
                    SqlConnection cn = new SqlConnection();

                    cn.ConnectionString = Dados.StringDeConexao;
                    //command
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM formulario_sp where cod_empresa = '" + this.txtExCodigo.Text + "';";
                  
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    cn.Close();

                    MessageBox.Show("Empresa excluida com sucesso!");
                }
                catch (SqlException ex)
                {
                    throw new Exception("Servidor SQL Erro: " + ex.Number);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    txtBuscaCnpj.Text = "";
                    txtExCodigo.Text = "";
                    mskDataEx.Text = "";
                    txtExCnpj.Text = "";
                    txtExEmpresa.Text = "";
                    txtExNire.Text = "";
                    txtExParametro.Text = "";
                    txtExRegistro.Text = "";
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscaCnpj.Text != "")
            {
                ObterClientePorCnpj(txtBuscaCnpj.Text, txtBuscaCnpj.Text);            
            }
            else
                MessageBox.Show("O campo de Busca não pode ser vazio!");
        }

        public DadosInformation ObterClientePorCnpj(string empresa, string cnpj)
        {
            //objeto cliente que será retornado pelo método 
            DadosInformation dados = new DadosInformation();

            //conexao
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.StringDeConexao;

            string sql = "SELECT * from formulario_sp WHERE empresa=@empresa or cnpj=@cnpj";
            if (sql == "")
            {
                MessageBox.Show("CNPJ OU EMPRESA não encontrado!");
            }
            else
            {
                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCommand cmd = new SqlCommand(sql, cn);

                //informo o parâmetro do comando 
                cmd.Parameters.AddWithValue("@empresa", empresa);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);

                cn.Open();
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    //Recupero o nome encontrado
                    leitor.Read();

                    dados.Cod_empresa = Convert.ToInt32(leitor["cod_empresa"].ToString());
                    dados.CNPJ = leitor["cnpj"].ToString();
                    dados.Data = Convert.ToDateTime(leitor["data"]);
                    dados.Empresa = leitor["empresa"].ToString();
                    dados.Nire = leitor["nire"].ToString();
                    dados.Parametro = leitor["parametro"].ToString();
                    dados.Registro = leitor["registro"].ToString();
                }             
               
                cn.Close();

                if (dados.Cod_empresa == 0 || dados.CNPJ == "" || dados.CNPJ == null)
                {
                    MessageBox.Show("Dados não encontrados");
                }
                else
                {
                    txtExCodigo.Text = dados.Cod_empresa.ToString();
                    txtExCnpj.Text = dados.CNPJ.ToString();
                    mskDataEx.Text = dados.Data.ToShortDateString();
                    txtExEmpresa.Text = dados.Empresa.ToString();
                    txtExNire.Text = dados.Nire.ToString();
                    txtExParametro.Text = dados.Parametro.ToString();
                    txtExRegistro.Text = dados.Registro.ToString();
                }

            }
            return dados;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtExCodigo.Text = "";
            txtExCnpj.Text = "";
            txtBuscaCnpj.Text = "";
            mskDataEx.Text = "";
            txtExEmpresa.Text = "";
            txtExNire.Text = "";
            txtExParametro.Text = "";
            txtExRegistro.Text = "";
        }
    }
}
