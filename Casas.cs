using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__7
{
    internal class Casas
    {
        int nCasa;
        string dpi = "";
        double cuota_de_Matenimiento;

        public int NCasa { get => nCasa; set => nCasa = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public double Cuota_de_Matenimiento { get => cuota_de_Matenimiento; set => cuota_de_Matenimiento = value; }
    }
}
