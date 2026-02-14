namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu primeiro número > ");
            if (!float.TryParse(Console.ReadLine(), out float primeiroNumero))
                {
                Console.Write("Entrada inválida! Insira um número para prosseguir a operação!");
                return;
            }

            Console.Write("Insira seu outro número > ");
            if (!float.TryParse(Console.ReadLine(), out float segundoNumero))
            {
                Console.Write("Entrada inválida! Insira um número para prosseguir a operação!");
                return;
            }

            Console.WriteLine("0. + (Soma)\n1. - (Subtração)\n2. * (Multiplicação)\n3. / (Divisão)");
            Console.Write("Agora insira qual operação você gostaria para obter um resultado > ");
            if (!int.TryParse(Console.ReadLine(), out int operacao))
            {
                Console.Write("Entrada inválida. Insira o número correto para prosseguir!");
                return;
            }

            switch (operacao)
            {
                case 0:
                    Console.Write($"A soma dos seus dois números é: {primeiroNumero + segundoNumero}!");
                    break;
                case 1:
                    Console.Write($"A subtrção dos seus dois números é {primeiroNumero - segundoNumero}!");
                    break;
                case 2:
                    Console.Write($"A multiplicação dos seus dois números é {primeiroNumero * segundoNumero}!");
                    break;
                case 3:
                    Console.Write($"A divisão dos seus dois números é {primeiroNumero / segundoNumero}!");
                    break;
                default:
                    Console.Write($"Por favor, insira uma escolha correta!");
                    return;
            }
        }
    }
}
