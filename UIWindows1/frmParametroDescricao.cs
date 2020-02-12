using frmRelSaoPaulo.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows1
{
    public partial class frmParametroDescricao : Form
    {
        public frmParametroDescricao()
        {
            InitializeComponent();
        }

        private void frmParametroDescricao_Load(object sender, EventArgs e)
        {
            ObterDescricao();
            txtJc001.Enabled = false;
            txtJc002.Enabled = false;
            txtJc003.Enabled = false;
            txtJc004.Enabled = false;
            txtJc005.Enabled = false;
            txtJc006.Enabled = false;
            txtJc007.Enabled = false;
            txtJc008.Enabled = false;
            txtJc009.Enabled = false;
            txtJd001.Enabled = false;
        }
    

        public delegate void OnDataChangeHandler(Hashtable info, Hashtable info1, Hashtable info2, Hashtable info3, Hashtable info4, Hashtable info5, Hashtable info6, Hashtable info7, Hashtable info8, Hashtable info9);
        public event OnDataChangeHandler OnDataChange;

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão ok vou pegar os checkBox selecionados enviar para o txtparametro do form principal e fechar o frmParametroDescricao

            Hashtable info1 = new Hashtable();
            Hashtable info2 = new Hashtable();
            Hashtable info3 = new Hashtable();
            Hashtable info4 = new Hashtable();
            Hashtable info5 = new Hashtable();
            Hashtable info6 = new Hashtable();
            Hashtable info7 = new Hashtable();
            Hashtable info8 = new Hashtable();
            Hashtable info9 = new Hashtable();
            Hashtable info10 = new Hashtable();

            //int contador = 0;
            //while (contador <= 9)
            //{
            if (chkJc001.Checked == true)
            {
                info1.Add("JC001", chkJc001.Text);

                chkJc001.Checked = false;
            }

            if (chkJc002.Checked == true)
            {
                info2.Add("JC002", chkJc002.Text);

                chkJc002.Checked = false;
            }

            if (chkJc003.Checked == true)
            {
                info3.Add("JC003", chkJc003.Text);

                chkJc003.Checked = false;
            }

            if (chkJc004.Checked == true)
            {
                info4.Add("JC004", chkJc004.Text);

                chkJc004.Checked = false;
            }

            if (chkJc005.Checked == true)
            {
                info5.Add("JC005", chkJc005.Text);

                chkJc005.Checked = false;
            }

            if (chkJc006.Checked == true)
            {
                info6.Add("JC006", chkJc006.Text);

                chkJc006.Checked = false;
            }

            if (chkJc007.Checked == true)
            {
                info7.Add("JC007", chkJc007.Text);

                chkJc007.Checked = false;
            }

            if (chkJc008.Checked == true)
            {
                info8.Add("JC008", chkJc008.Text);

                chkJc008.Checked = false;
            }

            if (chkJc009.Checked == true)
            {
                info9.Add("JC009", chkJc009.Text);

                chkJc009.Checked = false;
            }

            if (chkjD001.Checked == true)
            {
                info10.Add("JD001", chkjD001.Text);

                chkjD001.Checked = false;
            }
            // contador++;
            // }

            OnDataChange(info1, info2, info3, info4, info5, info6, info7, info8, info9, info10);
            //OnDataChange(info);
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // ao clicar neste botão ele irá salvar al alterações feitas nos txtbox's deste form.

            
        }
     
        public string cod1 = "JC001", cod2 = "JC002", cod3 = "JC003", cod4 = "JC004", cod5 = "JC005", cod6 = "JC006", cod7 = "JC007", cod8 = "JC008", cod9 = "JC009", cod10 = "JD001";
        
        private void ObterDescricao()
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = Dados.StringDeConexao;

            SqlCommand cmd = new SqlCommand("SELECT * FROM desc_parametro", cn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            /* Aqui tem que preencher e adicionar os parametros*/
            cmd.Parameters.Add(new SqlParameter("@cod1", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod2", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod3", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod4", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod5", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod6", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod7", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod8", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod9", "cod_parametro"));
            cmd.Parameters.Add(new SqlParameter("@cod10", "cod_parametro"));

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtJc001.Text = dr["Descricao"].ToString();             
            }
            if (dr.Read())
            {
                txtJc002.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc003.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc004.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc005.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc006.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc007.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc008.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {
                txtJc009.Text = dr["Descricao"].ToString();
            }
            if (dr.Read())
            {               
                txtJd001.Text = dr["Descricao"].ToString();
            }
            cn.Close();

        }
    }
}
