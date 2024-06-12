/*15) Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: Abaixo do peso: IMC < 18.5/ Peso normal: 18.5 <= IMC < 24.9/ Sobrepeso: 25 <= IMC < 29.9/ Obesidade grau I: 30 <= IMC < 34.9/ Obesidade grau II: 35 <= IMC < 39.9/ Obesidade grau III: IMC >= 40*/


using System;
class IMC{
    public static void Main(string[] args) {
        Console.WriteLine("Caluco de IMC!");
        Console.WriteLine("Informe o seu peso (em kg):");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe sua altura (em metros):");
        double altura = Convert.ToDouble(Console.ReadLine());
        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Você está com peso normal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Você está com sobrepeso");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("Você está com obesidade grau I");
        }
        else if (imc >= 35 && imc < 40)
        {
            Console.WriteLine("Você está com obesidade grau II");
        }
        else
        {
            Console.WriteLine("Você está com obesidade grau III");
        }
    }
}