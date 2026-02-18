using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
            Console.WriteLine("8: Exercício Doador de Sangue");
            Console.WriteLine("9: Exercício Número par ou ímpar");
            Console.WriteLine("10: Exercício Peso Ideal");
            Console.WriteLine("11: Exercício Análise de Crédito");
            Console.WriteLine("12: Exercício Triângulo");
            Console.WriteLine("13: Exercício Bhaskara");
            Console.WriteLine("14: Sair");


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
                    ExercicioDoadorDeSangue();
                    break;

                case 9:
                    ExerciciosParImpar();
                    break;

                case 10:
                    ExercicioPesoIdeal();
                    break;

                case 11:
                    ExercicioAnaliseCredito();
                    break;

                case 12:
                    ExercicioHeronSeTriangulo();
                    break;

                case 13:
                    ExercicioBhaskara();
                    break;

                case 14:
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
    public static void ExercicioDoadorDeSangue()
    {
        Console.Write("Digite a sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18 && idade <= 67)
        {
            Console.WriteLine("Você pode ser doador de sangue");
        }
        else if (idade < 18 || idade > 67)
        {
            Console.WriteLine("Desculpe, você não pode ser doador de sangue");
        }
    }
    public static void ExerciciosParImpar()
    {
        Console.Write("Digite o número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Este número é par");
        }
        else
        {
            Console.WriteLine("Este número é impar");
        }
    }
    public static void ExercicioPesoIdeal()

    {
        Console.Write("Digite a sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o seu sexo: (M) para masculino (F) para feminino");
        string sexo = Console.ReadLine().ToUpper();

        double pesoIdealMasculino = altura * 72.7 - 58.0;
        double pesoIdealFeminino = altura * 62.1 - 44.7;

        if (sexo == "F")
        {
            if (Convert.ToBoolean(pesoIdealFeminino) == true)
            {
                Console.WriteLine($"Seu peso ideal é {pesoIdealFeminino.ToString("#,##")}kg");
            }
        }
        else if (sexo == "M")
        {
            Console.WriteLine($"Seu peso ideal é {pesoIdealMasculino.ToString("#,##")}kg");

        }

    }
    public static void ExercicioAnaliseCredito()
    {
        Console.Write("Por favor solicite o valor do empréstimo: ");
        decimal valorEmprestimo = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a quantidade de parcelas desejadas: ");
        int numeroDeParcelas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a sua renda mensal: ");
        decimal rendaMensal = Convert.ToDecimal(Console.ReadLine());

        double resultado = Convert.ToDouble((rendaMensal * 30) / 100);
        double parcelaEmprestimo = Convert.ToDouble(valorEmprestimo / numeroDeParcelas);

        if (resultado >= parcelaEmprestimo)
        {
            Console.WriteLine("\n>>>Empréstimo autorizado");
        }
        else
        {
            Console.WriteLine("\n>>>Emprestimo não autorizado");
        }
        Console.WriteLine($"\nValor do Emprestimo: {valorEmprestimo}");
        Console.WriteLine($"Número de Parcelas: {numeroDeParcelas}");
        Console.WriteLine($"Valor da Parcela: {parcelaEmprestimo}");
        Console.WriteLine($"Valor da Renda Mensal: {rendaMensal}");
    }
    public static void ExercicioHeronSeTriangulo()
    {
        Console.WriteLine("Informe 3 números decimais maiores que zero");
        decimal num1 = 0, num2 = 0, num3 = 0;
        bool obterNum = false;
        while (!obterNum)
        {
            Console.Write("1º número: ");
            num1 = Math.Round(Convert.ToDecimal(Console.ReadLine()) ,1);
            if (num1 < 0)
            {
                Console.WriteLine("Digite somente números maiores que 0");
                obterNum= false;
            }

            else
                obterNum = true;
        }
        obterNum = false;
        while (!obterNum) 
        {
            Console.Write("2º número: ");
            num2 = Math.Round(Convert.ToDecimal(Console.ReadLine()) ,1);
            if (num2 < 0) 
            {
                Console.WriteLine("Digite somente números maiores que 0");
                obterNum= false;
            }
            else
                obterNum = true;
        }
        obterNum = false;
        while (!obterNum)
        {
            Console.Write("3º número: ");
            num3 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);
            if (num3 < 0)
            {
                Console.WriteLine("Digite somente números maiores que 0");
                obterNum = false;
            }
            else
                obterNum = true;
        }
        if (num1 < (num2 + num3) &&
            num1 > Math.Abs(num2 - num3) &&
            num2 < (num1 + num3) &&
            num2 > Math.Abs(num1 - num3) &&
            num3 < (num1 + num2) &&
            num3 > Math.Abs(num1 - num2))
        {
            if (num1 == num2 && num2 == num3 && num3 == num1)
                Console.WriteLine("Triângulo Equilátero");
            else if (num1 != num2 && num2 != num3 && num3 != num1)
                Console.WriteLine("Triângulo Escaleno");
            else
                Console.WriteLine("Triângulo Isósceles");

            decimal semiperimetro = (num1 + num2 + num3) / 2;
            decimal conta1 = semiperimetro - num1;
            decimal conta2 = semiperimetro - num2;
            decimal conta3 = semiperimetro - num3;
            decimal resultado = semiperimetro * conta1 * conta2 * conta3;
            resultado = (decimal)Math.Sqrt(Convert.ToDouble(resultado));
            Console.WriteLine($"A área do triângulo pelo Teorema de Heron é: {resultado}");
        }
        else
            Console.WriteLine("Não é um triângulo");
    }
    public static void ExercicioBhaskara()
    {
        Console.WriteLine("Informe 3 valores:");
        double valorA = 0;
        bool valorValido = false;
        while (!valorValido)
        {
            Console.Write("1º valor: ");
            valorA = Convert.ToDouble(Console.ReadLine());
            if (valorA == 0)
            {
                Console.WriteLine("Não é uma equação de segundo grau");
                valorValido = false;
            }
            else
                valorValido = true;
        }
        Console.Write("2º valor: ");
        double valorB = Convert.ToDouble(Console.ReadLine());
        Console.Write("3º valor: ");
        double valorC = Convert.ToDouble(Console.ReadLine());
        double valorDelta1 = valorB * valorB;
        double valorDelta2 = 4 * valorA * valorC;
        double delta = 0;
        double x1 = 0;
        double x2 = 0;
        
        delta = valorDelta1 - valorDelta2;
        if (delta < 0)
        {
            Console.WriteLine($"Como delta é = {delta}, a equação não possui raízes reais");
        }
        else
        {
            x1 = ((valorB * -1) + Math.Sqrt(delta)) / (2 * valorA);
            x2 = ((valorB * -1) - Math.Sqrt(delta)) / (2 * valorA);
            Console.WriteLine($"As raízes são: x1 = {x1} e x2 = {x2}");
        }
    }
    public static void ExercicioMaiorDeTres()
    {
        //to do
    }
}


