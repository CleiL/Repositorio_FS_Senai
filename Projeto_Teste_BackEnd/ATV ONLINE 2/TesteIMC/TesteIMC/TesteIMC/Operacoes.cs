using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    public class Operacoes
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return Math.Round((peso / (altura* altura)), 2);
        }
        public static String ClassificarIMC(double IMC)
        {
            if (IMC < 18.5)
                return "Abaixo do peso";
            else if (IMC < 25)
                return "Peso normal";
            else if (IMC < 30)
                return "Sobrepeso";
            else if (IMC < 35)
                return "Obesidade Grau I";
            else if (IMC < 40)
                return "Obesidade Grau II";
            else
                return "Obesidade Grau III";
        }
    }
}
