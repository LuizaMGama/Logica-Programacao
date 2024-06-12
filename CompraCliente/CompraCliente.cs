/*13) Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). Aplique os seguintes descontos: Comum: Sem desconto, Associado: 10% de desconto, VIP: 20% de desconto, Informe o valor final da compra.*/

using System;

class Compra {
    public static void Main(string[] args) {
        Console.WriteLine("Informe o valor da compra: ");
        double compra = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Agora insira a categoria do cliente, de 1 a 3:");
        int categoria = Convert.ToInt32(Console.ReadLine());
        double valorFinal = compra;
        
        if (categoria == 1) {
            Console.WriteLine("Categoria comum, sem desconto. Valor da compra: " + valorFinal);
        } 
        else if (categoria == 2) {
            valorFinal -= compra * 0.10; 
            Console.WriteLine("Categoria associado. O valor final da compra é: " + valorFinal);
        } 
        else if (categoria == 3) {
            valorFinal -= compra * 0.20; 
            Console.WriteLine("Categoria VIP. O valor final da compra é: " + valorFinal);
        } 
        else {
            Console.WriteLine("Categoria inválida");
        }
    }
}