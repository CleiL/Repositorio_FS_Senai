using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlgoII
{
    internal class Exercicio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com Vetores");
            bool verificar = int.TryParse(Console.ReadLine(), out int tamanhoVetor);

            int[] array = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($" Digite o {i + 1}º número ");
                verificar = int.TryParse(Console.ReadLine(), out int x);
                array.SetValue(x, i);
            }
            int diferenca = FuncaoDiferenca(array);
            Console.WriteLine("Calcule e retorna o valor da maior diferença entre dois elementos distintos no vetor: ");
            Console.WriteLine("Respostas: A maior diferença é " + diferenca);

            bool comparar = CompararArrayCrescente(array);
            Console.WriteLine("Verifique se o vetor está em ordem crescente, e retorne true caso esteja e false caso contrario:");
            Console.WriteLine("Resposta: " + comparar);
        }
        public static int FuncaoDiferenca(int[] numeros)
        {
            //essa função pega o maior numero do vetor e o menor e faz uma subtração
            int maiorValor = numeros.Max();
            int menorValor = numeros.Min();
            int diferenca = maiorValor - menorValor;

            return diferenca;
        }
        public static bool CompararArrayCrescente(int[] listNumeros)

        {
            for (int i = 0; i < listNumeros.Length; i++)
            {

                if ((i + 1) < listNumeros.Length)
                {
                    var num1 = listNumeros[i];
                    var num2 = listNumeros[i + 1];
                    if (num1 > num2)
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}