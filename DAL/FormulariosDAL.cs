using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmRelSaoPaulo.Modelos;
using System.Data.SqlClient;
using System.Data;
using frmRelSaoPaulo.DAL;

namespace DAL
{
    public class FormulariosDAL
    {
        public void Incluir(DadosInformation dados)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                //nome da stored procedure
                cmd.CommandText = "insere_dados_sp";

                //parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pcod_empresa = new SqlParameter("@cod_empresa", System.Data.SqlDbType.Int);
                pcod_empresa.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pcod_empresa);

                SqlParameter pdata = new SqlParameter("@data", System.Data.SqlDbType.SmallDateTime);
                pdata.Value = dados.Data;
                cmd.Parameters.Add(pdata);

                SqlParameter pempresa = new SqlParameter("@empresa", System.Data.SqlDbType.NVarChar, 255);
                pempresa.Value = dados.Empresa;
                cmd.Parameters.Add(pempresa);

                SqlParameter pcnpj = new SqlParameter("@cnpj", System.Data.SqlDbType.NVarChar, 14);
                pcnpj.Value = dados.CNPJ;
                cmd.Parameters.Add(pcnpj);

                SqlParameter pnire = new SqlParameter("@nire", System.Data.SqlDbType.NVarChar, 15);
                pnire.Value = dados.Nire;
                cmd.Parameters.Add(pnire);

                SqlParameter pregistro = new SqlParameter("@registro", System.Data.SqlDbType.NVarChar, 50);
                pregistro.Value = dados.Registro;
                cmd.Parameters.Add(pregistro);

                SqlParameter pparametro = new SqlParameter("@parametro", System.Data.SqlDbType.NVarChar, 50);
                pparametro.Value = dados.Parametro;
                cmd.Parameters.Add(pparametro);

                cn.Open();
                cmd.ExecuteNonQuery();

                dados.Cod_empresa = (Int32)cmd.Parameters["@cod_empresa"].Value;

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
                cn.Close();
            }
        }

        public void Alterar(DadosInformation dados)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update FORMULARIO_SP set data = @data, empresa = @empresa, cnpj = @cnpj, nire = @nire, registro = @registro, parametro = @parametro where cod_empresa = @cod_empresa;";

                cmd.Parameters.AddWithValue("@cod_empresa", dados.Cod_empresa);
                cmd.Parameters.AddWithValue("@data", dados.Data);
                cmd.Parameters.AddWithValue("@empresa", dados.Empresa);
                cmd.Parameters.AddWithValue("@cnpj", dados.CNPJ);
                cmd.Parameters.AddWithValue("@nire", dados.Nire);
                cmd.Parameters.AddWithValue("@registro", dados.Registro);
                cmd.Parameters.AddWithValue("@parametro", dados.Parametro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int cod_empresa)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "exclui_dados_sp";
                //parametros da stored procedure
                SqlParameter pcod_empresa = new SqlParameter("@cod_empresa", System.Data.SqlDbType.Int);
                pcod_empresa.Value = cod_empresa;
                cmd.Parameters.Add(cod_empresa);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if(resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente " + cod_empresa);
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            {
                cn.Close();
            }

        }

        public DataTable AlterarEmpresa(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "SELECT_EMPRESA";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", System.Data.SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(tabela);

                return tabela;

            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AlterarDadosEmpresa(DadosInformation dados)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ALTERA_DADOS_EMPRESA";

                SqlParameter pcodigo = new SqlParameter("@cod_empresa", SqlDbType.Int);
                pcodigo.Value = dados.Cod_empresa;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pempresa = new SqlParameter("@empresa", SqlDbType.NVarChar, 255);
                pempresa.Value = dados.Empresa;
                cmd.Parameters.Add(pempresa);

                SqlParameter pregistro = new SqlParameter("@registro", SqlDbType.NVarChar, 50);
                pregistro.Value = dados.Registro;
                cmd.Parameters.Add(pregistro);

                SqlParameter pcnpj = new SqlParameter("@cnpj", SqlDbType.NVarChar, 20);
                pcnpj.Value = dados.CNPJ;
                cmd.Parameters.Add(pcnpj);

                SqlParameter pnire = new SqlParameter("@nire", SqlDbType.NVarChar, 20);
                pnire.Value = dados.Nire;
                cmd.Parameters.Add(pnire);

                SqlParameter pparametro = new SqlParameter("@parametro", SqlDbType.NVarChar, 50);
                pparametro.Value = dados.Parametro;
                cmd.Parameters.Add(pparametro);

                SqlParameter pdata = new SqlParameter("@data", SqlDbType.SmallDateTime);
                pdata.Value = dados.Data;
                cmd.Parameters.Add(pdata);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

       

    }
}
