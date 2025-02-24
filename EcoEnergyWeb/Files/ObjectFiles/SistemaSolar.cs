using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergyWeb
{
    public class SistemaSolar : SistemaEnergia
    {
        public double HoresDeSol { get; set; }
        public override bool ValidarDades() => this.HoresDeSol > 1;
        public override double CalculEnergia() => this.HoresDeSol * 1.5;
        public SistemaSolar(double horesDeSol)
        {
            HoresDeSol = horesDeSol;
            Data = DateTime.Now;
            TipusEnergia = "Solar";
        }
        public SistemaSolar() 
        {
            HoresDeSol = 2;
            Data = DateTime.Now;
            TipusEnergia = "Solar";
        }
    }
}