/*8) Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3)*/

using System;
class Nota{
    public static void Main(string[] args){
        Console.WriteLine("Como verificar a classificação da sua nota?");
        Console.WriteLine("Informe sua nota:");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 9){
            Console.WriteLine("Sua nota é classificada como: A");
        } else if (nota >= 7 && nota < 9){
            Console.WriteLine("Sua nota é classificada como: B");
        } else if (nota >= 5 && nota < 7){
            Console.WriteLine("Sua nota é classificada como: C");
        } else if (nota >= 3 && nota < 5){
            Console.WriteLine("Sua nota é classificada como: D");
        } else {
            Console.WriteLine("Sua nota é classificada como: E");
        }
    }
}