using System;
using System.Linq;

namespace problemaArray_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TESTE_01
             * Dado o a variavel arrInicial que é um array com os valores[1, 2, 3, 4, 5, 6, 7, 8, 9, 0].
             * Gravar na variavel arrFinal os mesmos valores, porem em ordem invertida.
             */
            
            int[] arrayInicial = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] arrayFinal = new int[10];
            int auxCounter = 0;
            
            //Faz a inversão dos arrays
            for (int i = arrayInicial.Length -1; i >= 0;i--) {
                arrayFinal[auxCounter] = arrayInicial[i];
                auxCounter++;
            }

            //Imprime o array invertido na tela
            for (int k = 0;k < arrayFinal.Length;k++) {
                Console.WriteLine(arrayFinal[k]);    
            }

        }
    }
}
