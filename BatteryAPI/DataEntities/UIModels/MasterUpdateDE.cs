using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.UIModels
{
    public class MasterUpdateDE
    {
        public int Master_IDMarca { get; set; }
        public int Master_IDModelo { get; set; }
        public int Master_IDAnno { get; set; }
        public int Master_IDCilindrada { get; set; }
        public int Master_IDInyeccion { get; set; }
        public int Master_IDBateria { get; set; }
        public string  Master_OldIDs { get; set; }
    }
}
