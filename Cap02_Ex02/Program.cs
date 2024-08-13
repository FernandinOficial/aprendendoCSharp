using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;    //variaveis INTEIRO

            Console.Write("Entre o 1o. valor: ");   //escrever na tela
            A = int.Parse(Console.ReadLine());  //atribuir um caracter do tipo INT para uma variavel

            Console.Write("Entre o 2o. valor: ");   //escrever na tela
            B = int.Parse(Console.ReadLine());  //atribuir um caracter do tipo INT para uma variavel

            R = A + B;  //soma das variaveis A e B atribuidas na variavel R

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);  //exibir o resultado com concatenação

            Console.WriteLine();    //pular linha
            Console.Write("Tecla <Enter> para continuar...");
            Console.ReadLine(); //precionar enter para finalizar
        }
    }
}
