//3) Escreva um programa que leia dois números inteiros e informe qual deles é o maior. 

using System;
class MaiorNumero {
    public static void Main (string[] args) {
    Console.WriteLine ("Qual é o maior número?");
    Console.WriteLine("Digite um número: ");
    int numero01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro número: ");
    int numero02 = Convert.ToInt32(Console.ReadLine());
    if (numero01 > numero02){
    Console.WriteLine("O maior número é: " + numero01);
    }
    else {
    Console.WriteLine("O maior número é: " + numero02);
    }
}
}