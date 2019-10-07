using System;

namespace calculadora_de__quadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de circulos!");

            Console.WriteLine("Insira o raio do circulo:");
            string raio = Console.ReadLine();
            decimal raiod = Convert.ToDecimal(raio); 

            decimal area = 0;

            area = 
                3.141592m * (raiod * raiod); 

            Console.WriteLine("A area do circulo é de "+area);
           

        }
        
    }
}
