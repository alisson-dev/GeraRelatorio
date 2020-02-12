using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmRelSaoPaulo.DAL
{
    public class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                //return @"Data Source = servidor; Initial Catalog = bd; User ID = sa; Password = sasa; Pooling = False";

                return @"Data Source=servidor;Initial Catalog=bd;User ID=sa;Password=sasa;Pooling=False";
            }
        }
    }
}



  
        
    

