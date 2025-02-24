using System;


namespace EcoEnergyWeb
{
    public abstract class SistemaEnergia : ICalculEnergia
    {
        public System.DateTime Data { get; set; }
        public string? TipusEnergia { get; set; }
        public virtual bool ValidarDades() => true;
        public virtual double CalculEnergia() => 0;
    }
}