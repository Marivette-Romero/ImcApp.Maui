using System;
using System.Collections.Generic;
using System.Text;

namespace ImcApp.Maui.Models
{
    public static class CaluladoraDeIndiceDeMasaCorporal
    {
        //metodo 1:
        public static decimal IndiceDeMasaCorporal( Decimal peso, Decimal estatura)
        { 
            return peso/(estatura*estatura);
        }

        //metodo 2:
        public static string SituacionNutricional (decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso Bajo.";
            }
            if (imc < 25.0m)
            {
                return "Peso Normal.";
            }
            if (imc < 30.0m)
            {
                return "Sobrepeso.";
            }
            if(imc < 40.0m)
            {
                return "Obesidad.";
            }

            return "Obesidad Extrema.";

        }
    }
}
