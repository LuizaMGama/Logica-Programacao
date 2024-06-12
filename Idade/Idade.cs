/*7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais).*/

using System;
class Idade{
    public static void Main(string[] args){
        Console.WriteLine("Me diga uma idade e eu te direi em qual fase da vida essa pessoa está: infância, adolescência, idade adulta ou idade idosa:");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 12){
            Console.WriteLine("Infância!)");
        } else if (idade >= 13 && idade <= 17){
            Console.WriteLine("Adolescência!)");
        } else if (idade >= 18 && idade <= 59){
            Console.WriteLine("Idade Adulta!)");
        } else {
            Console.WriteLine("Idade Idosa:)");
        }
    }
}