using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria
{
   public class PersonaMSJ
    {
        public PersonaMSJ(int sECUENCIAL, string codigotIPOIDENTIFICACION, string iDENTIFICACION, string pRIMERNOMBRE, string sEGUNDONOMBRE, string pRIMERAPELLIDO, string sEGUNDOAPELLIDO, bool eSTAACTIVO)
        {
            SECUENCIAL = sECUENCIAL;
            CODIGOTIPOIDENTIFICACION = codigotIPOIDENTIFICACION;
            IDENTIFICACION = iDENTIFICACION;
            PRIMERNOMBRE = pRIMERNOMBRE;
            SEGUNDONOMBRE = sEGUNDONOMBRE;
            PRIMERAPELLIDO = pRIMERAPELLIDO;
            SEGUNDOAPELLIDO = sEGUNDOAPELLIDO;
            ESTAACTIVO = eSTAACTIVO;
        }
        public PersonaMSJ()
        {

        }

        public int SECUENCIAL { get; set; }
        public string CODIGOTIPOIDENTIFICACION { get; set; }
        public string IDENTIFICACION { get; set; }
        public string PRIMERNOMBRE { get; set; }
        public string SEGUNDONOMBRE { get; set; }
        public string PRIMERAPELLIDO { get; set; }
        public string SEGUNDOAPELLIDO { get; set; }
        public bool ESTAACTIVO { get; set; }
    }
}
