using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__7
{
    internal class dF
    {
        string nombre = "", apellido = "";
        int nCasa;
        double cuota_de_Matenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NCasa { get => nCasa; set => nCasa = value; }
        public double Cuota_de_Matenimiento { get => cuota_de_Matenimiento; set => cuota_de_Matenimiento = value; }
    }
}
