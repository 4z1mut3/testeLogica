using System;

namespace ImprimirNumeros
{


    //    TESTE 02
    //Escrever um programa que escreva na tela números de 1 a 100.

    //ESCREVER O TESTE EM C#
    //NÃO pode: utilizar laços de repetição, por exemplo: do-while, for, foreach, linq, lambda e etc;
    //Será avaliado: Lógica de programação;

    //Classe criada para montar o objeto do que será impresso na tela 
    class Imprime {
        
        public int valorInicial { get; set; }
        public int valorFinal { get; set; }

        public Imprime() { }
        public Imprime(int valorInicial, int valorFinal) {
            this.valorInicial = valorInicial;
            this.valorFinal = valorFinal;
        }

        //imprime na tela a sequencia de numeros desejada, incrementando de 1 em 1. Este metodo faz uso de recursividade. 
        public int imprimeNumeros(int inicial,int final)
        {
            if (inicial <= final)
            {
                inicial++;
                Console.WriteLine(inicial);
                imprimeNumeros(inicial, final);
                return inicial;
            }
            else {
                return 0;
            }
        }
    }


    class Program
    {        
        static void Main(string[] args)
        {   
            //Criando objeto e chamento método de impressão
            Imprime im = new Imprime(0,100);
            im.imprimeNumeros(im.valorInicial,im.valorFinal);
        }
    }
}
