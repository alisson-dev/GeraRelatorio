using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmRelSaoPaulo.Modelos;
using frmRelSaoPaulo.DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class FormulariosBLL
    {
        public void Incluir(DadosInformation dados)
        {    
            if (dados.Empresa.Trim().Length == 0)
            {
                throw new Exception("O nome da Empresa é obrigatório!");
            }          
            else if (dados.Parametro.Trim().Length == 0)
            {
                throw new Exception("O parâmetro é obrigatório!");
            }

            DAL.FormulariosDAL obj = new DAL.FormulariosDAL();
            obj.Incluir(dados);
        }
           
    public void Alterar(DadosInformation dados)
        {
            if (dados.Empresa.Trim().Length == 0)
            {
                throw new Exception("O nome da Empresa é obrigatório!");
            }

            DAL.FormulariosDAL obj = new DAL.FormulariosDAL();
            obj.Alterar(dados);
        }

        public void Excluir(int cod_empresa)
        {
            if (cod_empresa < 1)
            {
                throw new Exception("Selecione uma Empresa antes de Excluí-la.");
            }
            DAL.FormulariosDAL obj = new DAL.FormulariosDAL();
            obj.Excluir(cod_empresa);
        }

    }
}
