//qual dos produtos é o preferêncial dos clientes de um posto de abastecimento de combustível
//escrever um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte 
//forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim)
//Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado 
//um novo código (até que seja válido)
//O programa será encerrado quando o código informado for o número 4.

using System;

class URI
{

    static void Main(string[] args)
    {

        int a = 0;
        int b = 0;
        int c = 0;
        int x;

        do
        {
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1: x = 1;
                    a++;
                    continue;
                case 2: x = 2;                    
                    b++;
                    continue;
                case 3: x = 3;
                    c++;
                    continue;
                case 4: x = 4;
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine($"Alcool: {a}\nGasolina: {b}\nDiesel: {c}");
                    break;
                default:
                    continue;
            }
        }

        while (x >= 1);
    }

}