using DataAccess;
using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class CilindradaDL
    {
        public IList<CilindradaDE> ObtenerCilindrada() {
            CilindradaDA dataAccess = new CilindradaDA();
            return dataAccess.ObtenerCilindradas();
        }
    }
}
