using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergyWeb
{
    public class SistemaHidroelectric : SistemaEnergia
    {
        public double CabalAigua { get; set; }
        public override bool ValidarDades() => this.CabalAigua >= 20;
        public override double CalculEnergia() => this.CabalAigua * 9.8 * 0.8;
        public SistemaHidroelectric(double cabalAigua)
        {
            CabalAigua = cabalAigua;
            Data = DateTime.Now;
            TipusEnergia = "Hidroelectric";
        }
        public SistemaHidroelectric() 
        {
            CabalAigua = 21;
            Data = DateTime.Now;
            TipusEnergia = "Hidroelectric";
        }
    }
}