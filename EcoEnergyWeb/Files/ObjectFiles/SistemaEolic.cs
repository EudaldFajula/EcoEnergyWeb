using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergyWeb
{
    public class SistemaEolic : SistemaEnergia
    {
        public double VelocitatVent { get; set; }
        public override bool ValidarDades() => this.VelocitatVent >= 5;
        public override double CalculEnergia() => Math.Pow(this.VelocitatVent, 3) * 0.2;
        public SistemaEolic(double velocitatVent)
        {
            VelocitatVent = velocitatVent;
            Data = DateTime.Now;
            TipusEnergia = "Eolic";
        }
        public SistemaEolic() 
        {
            VelocitatVent = 6;
            Data = DateTime.Now;
            TipusEnergia = "Eolic";

        }
    }
}