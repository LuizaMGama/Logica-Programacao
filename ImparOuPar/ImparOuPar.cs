//1) Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar.

using System;
class ImparOuPar {
    public static void Main (string[] args) {
        Console.WriteLine ("Ímpar ou Par");
        Console.WriteLine("Digite um número inteiro");
        int numero01 = Convert.ToInt32(Console.ReadLine());
        int resultado = numero01 % 2;

        if(resultado != 0 ){
        Console.WriteLine("O número é Ímpar!");
        }

        else{
        Console.WriteLine("O número é Par");
        }
    }
}