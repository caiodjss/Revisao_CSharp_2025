Nível 1: Entrada, Processamento e Saída 
1) Faça um programa para calcular o estoque médio de uma peça, sendo que: 
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

using System;

public class Estoque
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Informe a quantidade de maxima");
        int quantMax = int.Parse(Console.ReadLine());
        Console.WriteLine ("Informe a quantidade de minima");
        int quantMin = int.Parse(Console.ReadLine());
        double medio;
        
        medio = (quantMax + quantMin) / 2.0;
        
        Console.WriteLine ("O estoque medio eh: " + medio);
    }
}

2) Faça um programa que: 
- Leia a cotação do dólar 
- Leia um valor em dólares 
- Converta esse valor para Real 
- Mostre o resultado

using System;

public class Cambio
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual a cotacao do dolar?");
        double cotacao = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Quanto deseja converter?");
        double dolar = double.Parse(Console.ReadLine());
        
        double real;
        
        real = dolar * cotacao;
        
        Console.WriteLine("O valor em real R$ eh: " + real);
    }
}

3) Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua 
comissão será de 5% do total da venda e que você tem os seguintes dados: 
- Identificação do vendedor 
- Código da peça 
- Preço unitário da peça 
- Quantidade vendida

using System;

public class Cambio
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe a identificacao do vendedor.");
        int id = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe o codigo da peca.");
        int cod = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe o preco da peca.");
        double preco = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a quantidade vendida.");
        int qt = int.Parse(Console.ReadLine());
        
        double comissao = (preco * qt) * 0.05;
        
        Console.WriteLine("A comissao do vendedor " + id + " eh de " + comissao + ".");
        
    }
}

4) Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os 
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis 
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B 
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo, 
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as 
multiplicações. 

using System;

public class Cambio
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o primeiro numero");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o terceiro numero");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o quarto numero");
        int d = int.Parse(Console.ReadLine());
        
        Console.WriteLine(a + "+" + b + "=" + (a+b));
        Console.WriteLine(a + "+" + c + "=" + (a+c));
        Console.WriteLine(a + "+" + d + "=" + (a+d));
        Console.WriteLine(b + "+" + c + "=" + (b+c));
        Console.WriteLine(b + "+" + d + "=" + (b+d));
        Console.WriteLine(c + "+" + d + "=" + (c+d));
        
        Console.WriteLine(a + "*" + b + "=" + (a*b));
        Console.WriteLine(a + "*" + c + "=" + (a*c));
        Console.WriteLine(a + "*" + d + "=" + (a*d));
        Console.WriteLine(b + "*" + c + "=" + (b*c));
        Console.WriteLine(b + "*" + d + "=" + (b*d));
        Console.WriteLine(c + "*" + d + "=" + (c*d));
        
    }
}