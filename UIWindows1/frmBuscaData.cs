using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using frmRelSaoPaulo.DAL;
using frmRelSaoPaulo.Modelos;

namespace UIWindows1
{
    public partial class frmBuscaData : Form
    {
        public frmBuscaData()
        {
            InitializeComponent();
        }

        private void frmBuscaData_Load(object sender, EventArgs e)
        {

        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {     
                        
            if (mskDataInicio.Text != "" && mskDataFinal.Text != "")
            {              
                frmRelatorio frm = new frmRelatorio(this);                
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Preencha os campos corretamente!");
        }     
    }
}
