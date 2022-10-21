using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNelio
{
    internal class Calculadora
    {
        public static int Sum(params int[] numbers)//colocar o params avisa que é uma função que vai recebr quantia variavelde valores
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;

        }

        //modelo de método com ref
        /*public static void Triple( ref int x) // usar ref aqui para referenciar o valor do main dentro da função
        {
            x = x * 3;
        }*/

        public static void Triple(int origin, out int result) //o out referencia como o ref, mas não exige inicialização
        {
            result = origin * 3;
        }
    }
}
