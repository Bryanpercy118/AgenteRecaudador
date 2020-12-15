using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class AgenteRecaudador
    {
        public string NitAgenteRecaudador { get; set; }
        public int MesReporte { get; set; }
        public int AñoReporte { get; set; }
        public string TipoEstampilla { get; set; }
        public decimal ValorImpuesto { get; set; }
        public string IdentificacionContratista { get; set; }
        public string NombreContratista { get; set; }
       
    }
}
