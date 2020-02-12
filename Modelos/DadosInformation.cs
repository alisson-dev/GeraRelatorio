using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmRelSaoPaulo.Modelos
{
    public class DadosInformation
    {
        private int _cod_empresa;
        public int Cod_empresa
        {
            get { return _cod_empresa; }
            set { _cod_empresa = value; }
        }

        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _empresa;
        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        private string _cnpj;
        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private string _nire;
        public string Nire
        {
            get { return _nire; }
            set { _nire = value; }
        }

        private string _registro;
        public string Registro
        {
            get { return _registro; }
            set { _registro = value; }
        }

        private string _parametro;
        public string Parametro
        {
            get { return _parametro; }
            set { _parametro = value; }
        }

     
    }
}
