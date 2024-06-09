//2) Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero. 

using System;
class PositivoOuNegativo {
    public static void Main (string[] args) {
    Console.WriteLine ("Número positivo ou Negativo?");
    Console.WriteLine("Digite um número inteiro");
    int numero01 = Convert.ToInt32(Console.ReadLine());
    if(numero01 >= 0){
        Console.WriteLine("O número é positivo!");
    }
    else{
        Console.WriteLine("O número é negativo");
    }
}
}