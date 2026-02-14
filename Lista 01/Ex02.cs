namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a sua idade para a classificação > ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                if (idade > 0)
                {
                    if (idade > 12)
                    {
                        Console.Write("Classificação - Criança (0-12 anos)");
                    }
                    else if (idade > 13)
                    {
                        Console.Write("Classificação - Adolescente (13-17 anos)");
                    }
                    else if (idade > 18)
                    {
                        Console.Write("Classificação - Adulto (18-59 anos)");
                    }
                    else
                    {
                        Console.Write("Classificação - Idoso (60+)");
                    }
                }
             else
                {
                    Console.Write("Esse número é negativo. Fornceça uma idade real!");
                }   
            }
        }
    }
}
