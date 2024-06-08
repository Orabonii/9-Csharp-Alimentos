using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite o código do produto:");
            int codigo;

            if (int.TryParse(Console.ReadLine(), out codigo))
            {
                if (codigo >= 1 && codigo <= 10)
                {
                    Console.WriteLine("Categoria: Alimento não-perecível");
                }
                else if (codigo >= 11 && codigo <= 20)
                {
                    Console.WriteLine("Categoria: Alimento perecível");
                }
                else if (codigo >= 21 && codigo <= 30)
                {
                    Console.WriteLine("Categoria: Vestuário");
                }
                else if (codigo >= 31 && codigo <= 40)
                {
                    Console.WriteLine("Categoria: Eletrônicos");
                }
                else
                {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }
}


