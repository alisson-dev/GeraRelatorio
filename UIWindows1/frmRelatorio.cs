using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmRelSaoPaulo.Modelos;

namespace UIWindows1
{
    public partial class frmRelatorio : Form
    {
        frmBuscaData busca = new frmBuscaData();
        public DateTime dataI;
        public DateTime dataF;

        public frmRelatorio(frmBuscaData Frm1busca)
        {
            InitializeComponent();

            busca = Frm1busca;

            dataI = Convert.ToDateTime(Frm1busca.mskDataInicio.Text);
            dataF = Convert.ToDateTime(Frm1busca.mskDataFinal.Text);

        }

        public void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'JUCESPONLINEDataSet.FORMULARIO_SP' table. You can move, or remove it, as needed.
            this.FORMULARIO_SPTableAdapter.Fill(this.JUCESPONLINEDataSet.FORMULARIO_SP,dataI ,dataF);

            this.reportViewer1.RefreshReport();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

        }
    }
}
