using System;
class Divisao {
    public static void Main (string[] args) {
        Console.WriteLine ("Programa de Divisão!");
        Console.WriteLine ("Digite um número:");
        int numero01 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Digite outro número: ");
        int numero02 = Convert.ToInt32(Console.ReadLine());
        int divisao = numero01 / numero02;
        Console.WriteLine("O resultado da divisão é: " + divisao);
    }
}