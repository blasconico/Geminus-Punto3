using System.Collections.Generic;
using System.Linq;

namespace Punto3
{
    public class Ferrocarril
    {
        public Ferrocarril()
        {
            this.Vagones = new List<Vagon>();
            this.VagonesLlenos = false;
        }

        public List<Vagon> Vagones { get; set; }

        public bool VagonesLlenos { get; set; }

        public void AsignarCaja(Caja caja)
        {
            foreach (var vagon in Vagones)
            {
                if ((caja.CapacidadM3() + vagon.VolumenTotalCargado()) <= vagon.CapacidadM3)
                {
                    vagon.Cajas.Add(caja);
                    return;
                }
            }

            this.VagonesLlenos = true;

        }

        public int CantidadDeCajasPorVagon()
        {
            decimal volumenVagones = this.Vagones.Sum(v => v.CapacidadM3);
            decimal volumenCajas = this.Vagones.Sum(c => c.VolumenTotalCargado());
            return (int)(volumenVagones / volumenCajas / this.Vagones.Count());

        }

    }
}
