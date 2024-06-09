using System;

class Subtracao {
    public static void Main (string[] args) {
    Console.WriteLine ("Programa de Subtração");
    Console.WriteLine("Digite um número:");
    int numero01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    int numero02 = Convert.ToInt32(Console.ReadLine());
    int subtracao = numero01 - numero02;
    Console.WriteLine("O resultado da subtração é: " + subtracao);
}
}