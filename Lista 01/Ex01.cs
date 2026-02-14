namespace Lista01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número para a verificação > ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                //string status = numero > 0 ? "positivo" : numero < 0 ? "negativo" : "zero";

                //Console.Write($"O número é {status}."); 

                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }
            }

            
        }
    }
}
