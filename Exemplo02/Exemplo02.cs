using System;

class Soma{
public static void Main(String[] args){
    Console.WriteLine("Programa de soma!");
    Console.WriteLine("Digite um numero:");
    int numero01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro numero:");
    int numero02 = Convert.ToInt32(Console.ReadLine());
    int soma = numero01 + numero02;
    Console.WriteLine("O resultado da soma é:" + soma);
}
}