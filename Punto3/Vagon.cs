using System.Collections.Generic;
using System.Linq;

namespace Punto3
{
    public class Vagon
    {
        public Vagon()
        {
            this.Cajas = new List<Caja>();
        }

        public decimal LongitudMts { get; set; }
        public decimal LongitudConAcoplesMts { get; set; }
        public decimal AlturaMts { get; set; }
        public decimal CapacidadM3 { get; set; }
        public decimal PesoNetoTon { get; set; }
        public List<Caja> Cajas { get; set; }

        public decimal VolumenTotalCargado()
        {
            return Cajas.Sum(x => x.CapacidadM3());
        }


    }
}
