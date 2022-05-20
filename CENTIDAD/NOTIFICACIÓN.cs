using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENTIDAD
{
    public class NOTIFICACIÓN
    {
        int sNoInsumos;
        int sNoInsumosCambiados;
        public int NoInsumos
        {
            get
            {
                return sNoInsumos;
            }
            set
            {
                sNoInsumos = value;
            }
        }
        public int NoInsumosCambiados
        {
            get
            {
                return sNoInsumosCambiados;
            }
            set
            {
                sNoInsumosCambiados = value;
            }
        }
    }
}
