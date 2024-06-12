//12) Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número.

using System;
class MaiorOuDobro {
    public static void Main(string[] args){
        Console.WriteLine("Digite um número");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 100){
            Console.WriteLine("O número é maior ou igual a 100!");
        } 
        else if (num < 100){
            int resultado = num * 2;
            Console.WriteLine("Já que este número é menor que 100, seu dobro é: " + resultado);
        }
    }
}