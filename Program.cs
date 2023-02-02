using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _1_PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 10;
            Console.WriteLine(idade);   

            idade= 10 + 5;
            Console.WriteLine(idade);       

            idade= (10 + 5)*2;
            Console.WriteLine(idade);
            
            Console.WriteLine("Sua Idade é: " + idade);
            


            Console.WriteLine("Execução Finalizada! Tecle enter para sair. . .");
            Console.ReadLine();
        }
        
    }
}