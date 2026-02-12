using System;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("5: Exercício Calculadora IMC");
            Console.WriteLine("6: Exercício Maior de 2 Números");
            Console.WriteLine("7: Exercício Senha");
            Console.WriteLine("8: Sair");

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
                    ExercicioCalculadoraIMC();
                    break;

                case 6:
                    ExercicioMaior2Numeros();
                    break;

                case 7:
                    ExercicioSenha();
                    break;

                case 8:
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

        if (resultado < 5)
        {
            Console.WriteLine("Reprovado");
        }
        if (resultado == 5 || resultado == 6)
        {
            Console.WriteLine("Em recuperação");
        }
        if (resultado > 6)
        {
            Console.WriteLine("Aprovado");
        }
    }
    public static void ExercicioCalculadoraIMC()
    {
        Console.Write(" Digite seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());


        double imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é : {Math.Round(imc),2}");
        if (imc < 17)
        {
            Console.WriteLine("Diagnostico: Muito abaixo do peso");
        }
        else if (imc >= 17 && imc <= 18.49)
        {
            Console.WriteLine("Diagnostico: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc <= 24.99)
        {
            Console.WriteLine("Diagnostico: Peso normal");
        }
        else if (imc >= 25 && imc <= 29.99)
        {
            Console.WriteLine("Diagnostico: Acima do peso");
        }
        else if (imc >= 30 && imc <= 34.99)
        {
            Console.WriteLine("Diagnostico: Obesidade I");
        }
        else if (imc >= 35 && imc <= 39.99)
        {
            Console.WriteLine("Diagnostico: Obesidade II (Severa");
        }
        else if (imc > 40)
        {
            Console.WriteLine("Diagnostico: Obesidade III (Mórbida)");
        }
    }
    public static void ExercicioMaior2Numeros()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) 
        {
            Console.WriteLine($"O maior número é o: {num1}");
        }
        else if (num2 > num1) 
        {
            Console.WriteLine($"O maior número é o {num2}");
        }
    }

    public static void ExercicioSenha()
    {
        Console.WriteLine("Olá, por favor digite a sua senha");
        string senha = Console.ReadLine();

        if (senha == "1234abcd")
        {
            Console.WriteLine("Acesso permitido");
        }
        else if (senha != "123abcd")
        {
            Console.WriteLine("Acesso negado");
        }
    }
}


