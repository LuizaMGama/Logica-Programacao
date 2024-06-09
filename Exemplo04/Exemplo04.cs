using System;

class Multiplicacao {
    public static void Main (string[] args) {
    Console.WriteLine ("Programa de Multiplicação");
    Console.WriteLine("Digite um numero:");
    int numero01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro numero:");
    int numero02 = Convert.ToInt32(Console.ReadLine());
    int multiplicacao = numero01 * numero02;
    Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
}
}