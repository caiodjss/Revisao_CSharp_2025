5) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 
12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. 
Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. 
Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a 
fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, 
tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.using System;
using System.Globalization;

public class Autonomia
{
    public static void Main(string[] args)
    {
        double tempo, velocidadeMedia;

        Console.WriteLine("Informe o tempo gasto na viagem (em horas):");
        tempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Informe a velocidade media (em km/h):");
        velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double distancia = tempo * velocidadeMedia;
        double litrosUsados = distancia / 12;

        Console.WriteLine($"Velocidade media: {velocidadeMedia} km/h");
        Console.WriteLine($"Tempo gasto: {tempo} horas");
        Console.WriteLine($"Distancia percorrida: {distancia} km");
        Console.WriteLine($"Combustivel utilizado: {litrosUsados} litros");
    }
}

6) Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius.

using System;
using System.Globalization;

public class Termometro
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe a temperatura em graus Celsius:");
        double celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine($"A temperatura em Fahrenheit eh {fahrenheit:F2}F");
    }
}

7) Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de 
temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a 
variável C é a temperatura em graus Celsius. 

using System;
using System.Globalization;

public class Termometro
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe a temperatura em graus Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double celsius = (fahrenheit - 32) * 5/9;

        Console.WriteLine($"A temperatura em Celsius eh {celsius:F2}F");
    }
}


8) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: 
V = 3.14159 * R * R * A 
Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura. 

using System;
using System.Globalization;

public class Volume
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio");
        double raio = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe altura");
        double altura = double.Parse(Console.ReadLine());
        
        double volume = 3.14159 * raio * raio * altura;
        
        Console.WriteLine($"O volume da lata de oleo eh {volume:F2}");
    }
}

9) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa 
pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. 

using System;

public class Idade
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe os anos.");
        int anos = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe os meses.");
        int meses = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe os dias.");
        int dias = int.Parse(Console.ReadLine());
        
        int diasTotal = (anos*365)+(meses*30)+dias;
        
        Console.WriteLine($"Voce tem {diasTotal} dias de vida!");
        
    }
}





