using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL;   //variaveis float
            //HT = Horas Trabalhadas
            //VH = Valor da Hora
            //PD = Percentual de Desconto
            //SB = Salário Bruto
            //TD = Total Desconto
            //SL = Salário Liquído

            Console.Write("Horas trabalhadas .................: ");
            HT = float.Parse(Console.ReadLine());   //recebe um float na variavel instanciada

            Console.Write("Valor da hora .....................: ");
            VH = float.Parse(Console.ReadLine());   //recebe um float na variavel instanciada

            Console.Write("Valor do percentual de desconto ...: ");
            PD = float.Parse(Console.ReadLine());   //recebe um float na variavel instanciada

            //seção de calculos 
            SB = HT * PD;   //horas trabalhadas VEZES percentual de desconto
            TD = (PD / 100) * SB;   //percentual de desconto DIVIDIDO por 100 VEZES SB
            SL = SB - TD;

            Console.WriteLine();    //pular linha
            Console.Write("Salário líquido ..............: ");
            Console.WriteLine(SL.ToString("##,##0.00"));    //é uma mascara para o float de Salario Liquido onde tem virgula e ponto como decimal

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
