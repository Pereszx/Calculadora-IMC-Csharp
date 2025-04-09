using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA IMC\n");

            Console.Write("Digite o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em cm: ");
            double alturaCm = double.Parse(Console.ReadLine());

            double alturaM = alturaCm / 100;
            double imc = peso / (alturaM * alturaM);

            Console.WriteLine($"\nIMC: {imc:F1}");

            if (imc < 18.5)
                Console.WriteLine("Classificação: Abaixo do peso");
            else if (imc < 25)
                Console.WriteLine("Classificação: Peso normal");
            else if (imc < 30)
                Console.WriteLine("Classificação: Sobrepeso");
            else if (imc < 35)
                Console.WriteLine("Classificação: Obesidade Grau I");
            else if (imc < 40)
                Console.WriteLine("Classificação: Obesidade Grau II");
            else
                Console.WriteLine("Classificação: Obesidade Grau III");

            Console.Write("\nCalcular novamente? (s/n): ");
            if (Console.ReadLine().ToLower() != "s")
                break;
        }
    }
}