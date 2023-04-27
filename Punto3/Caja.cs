namespace Punto3
{
    public class Caja
    {
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Profundidad { get; set; }

        public bool EstaVacia()
        {
            return this.Profundidad == 0 && this.Ancho == 0 && this.Largo == 0;
        }

        public decimal CapacidadM3()
        {
            return this.Largo * Ancho * Profundidad;
        }
    }
}
