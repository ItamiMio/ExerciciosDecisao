internal class Program
{
    private static void Main(string[] args)
    {
        bool exercicio = true;
        while (exercicio)
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1: Exercício Negativo");
            Console.WriteLine("2: Exercício Sinal");
            Console.WriteLine("3: Exercício Divisão");
            Console.WriteLine("4: Exercício Médias");
            Console.WriteLine("5: Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExercicioNegativo();
                    break;

                case 2:
                    ExercicioSinal();
                    break;

                case 3:
                    ExercicioDivisao();
                    break;

                case 4:
                    ExercicioMedia4Notas();
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    exercicio = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
        }

    }

    public static void ExercicioNegativo()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("Esse número é negativo D:");
        }
        else
            Console.WriteLine("É um número positivo :D");
    }

    public static void ExercicioSinal()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("Número negativo");
        }
        if (numero == 0)
        {
            Console.WriteLine("Zero");
        }
        if (numero > 0)
        {
            Console.WriteLine("Número positivo");
        }

    }

    public static void ExercicioDivisao()
    {
        Console.Write("Digite o primeiro valor: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;
        if (valor2 == 0)
        {
            Console.WriteLine("Não é possivel dividir nenhum número por 0");
        }
        else
        {
            resultado = valor1 / valor2;
            Console.WriteLine(resultado);
        }
    }

    public static void ExercicioMedia4Notas()
    {
        bool obterNotas = false;
        decimal nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
        while (!obterNotas)
        {
            Console.Write("Digite a primeira nota: ");
            nota1 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);
            if (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                obterNotas = false;
            }
            else
                obterNotas = true;
        }
        obterNotas = false;
        while (!obterNotas) 
        { 
            Console.Write("Digite a segunda nota: ");
            nota2 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);
            if (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                obterNotas = false;
            }
            else
                obterNotas = true;
        }
        obterNotas = false;
        while (!obterNotas)
        {
            Console.Write("Digite a terceira nota: ");
            nota3 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);
            if (nota3 < 0 || nota3 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                obterNotas = false;
            }
            else
                obterNotas = true;
        }
        obterNotas = false;
        while (!obterNotas)
        {
            Console.Write("Digite a quarta nota: ");
            nota4 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);
            if (nota4 < 0 || nota4 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                obterNotas = false;
            }
            else
                obterNotas = true;
        }

        decimal resultado = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine($"Você ficou com média: {resultado}");

        if (resultado <5)
        {
            Console.WriteLine("Reprovado");
        }
        if (resultado ==5 || resultado == 6)
        {
            Console.WriteLine("Em recuperação");
        }
        if (resultado > 6)
        {
            Console.WriteLine("Aprovado");
        }

    }
}

