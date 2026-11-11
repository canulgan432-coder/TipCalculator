namespace CalculadoraPropinas.Maui.models
{
    public class ConsumoCompartido
    {
        public decimal ImporteDelConsumo { get; set; }  = decimal.Zero;
        public int NumeroDePersonas { get; set; } = 1;
        public decimal PorcentajedePropina { get; set; } = 10;

        public ConsumoCompartido(decimal importeDelConsumo, 
            int numeroDePersonas = 1,
            decimal porcentajeDePropina = 10.0m)

        {
            ImporteDelConsumo = importeDelConsumo;
            NumeroDePersonas = numeroDePersonas;
            PorcentajedePropina = porcentajeDePropina;
        }

        public decimal ImporteDelConsumoPorPersona
            => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDeLaPropina
            => ImporteDelConsumo * PorcentajedePropina / 100.0m;
        public decimal ImporteDeLaPropinaPorPersona
            => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDelConsumoConPropina
            => ImporteDelConsumo + ImporteDeLaPropina;
        public decimal ImporteDelConsumoConPropinaPorPersona
            => ImporteDelConsumoConPropina / NumeroDePersonas;



        
    }
}
