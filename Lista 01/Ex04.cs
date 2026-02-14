namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número de 1 a 7 para a exibição do dia da semana > ");
            if (!int.TryParse(Console.ReadLine(), out int diaSemana))
            {
                Console.Write("Entrada inválida. Insira um número para prosseguir a operação!");
                return;
            }

            switch (diaSemana)
            {
                case 1:
                    Console.Write("O dia da semana é: Domingo!");
                    break;
                case 2:
                    Console.Write("O dia da semana é: Segunda-feira!");
                    break;
                case 3:
                    Console.Write("O dia da semana é: Terça-feira!");
                    break;
                case 4:
                    Console.Write("O dia da semana é: Quarta-feira!");
                    break;
                case 5:
                    Console.Write("O dia da semana é: Quinta-feira!");
                    break;
                case 6:
                    Console.Write("O dia da semana é: Sexta-feira!");
                    break;
                case 7:
                    Console.Write("O dia da semana é: Sábado!");
                    break;
                default:
                    Console.Write("Por favor, insira um número de 1 a 7 para prosseguir a exibição!");
                    return;
            }
        }
    }
}
