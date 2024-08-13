using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME;    //declara o tipo da STRING, neste caso é STRING
            Console.Write("Entre seu nome: ");  //vai escrever na tela a STRING dentro do "("")"
            NOME = Console.ReadLine();  //NOME recebe o valor digitado pelo método ReadLine()
            Console.WriteLine("Ola, " + NOME);  //escrita com concatenação
        
            
            Console.WriteLine();    //pular linha
            Console.WriteLine("Tecle <ENTER> para encerrar...");    //escrever na tela
            Console.ReadLine(); //espera ENTER para encerrar
            
        }
    }
}
