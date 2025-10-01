using System;
using System.Runtime.Intrinsics.Arm;
using static System.Console; // fixa a classe console 
int opc;

BackgroundColor = ConsoleColor.DarkRed;
do
{
    Clear();
    Console.WriteLine("==================================");
    Console.WriteLine("      *** Menu Principal ***");
    Console.WriteLine("==================================");
    Console.WriteLine("[1] Calculos");
    Console.WriteLine("[2] Entrevista");
    Console.WriteLine("[3] tabuada");
    Console.WriteLine("[4] fim");

    Console.WriteLine("digite uma opção");
    opc = int.Parse(ReadLine()!);
    switch (opc)
    {
        case 1:
            Todos_Calculos();
            break;
        case 2:
            Entrevista();
            break;
    }
} while (opc != 0);


static void Todos_Calculos()
{
    //Declaração de variaveis
    double a, b, r, x, y, z; //inteiro
    string pausa;//cadeia
    double real;//real
    decimal valor;//real
    float juros;//real
    bool achou = true;//logico

    
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Clear();//limpa
    Console.WriteLine("Boa noite!!!!");//escreva com \n no final 
                                       //Entradas
    Console.SetCursorPosition(25, 5);
    Console.WriteLine("Informe o 1º numero");//escreva
    a = double.Parse(Console.ReadLine()!);
    Console.SetCursorPosition(25, 7);
    Console.WriteLine("Informe o 2º numero");//escreva
    b = double.Parse(Console.ReadLine()!);
    //processamento
    r = a + b;
    x = a - b;
    y = a * b;
    z = a / b;

    //saidas
    Console.SetCursorPosition(25, 15);
    Console.WriteLine($"{a} + {b} = {r}");
    Console.SetCursorPosition(25, 16);
    Console.WriteLine($"{a} - {b} = {x}");
    Console.SetCursorPosition(25, 17);
    Console.WriteLine($"{a} x {b} = {y}");
    Console.SetCursorPosition(25, 18);
    Console.WriteLine($"{a} / {b} = {z}");
    Console.ReadKey();
    Console.Clear();

}
static void Entrevista()
{
    //Declaração de variaveis
    string Nome, Endereco, Escola, Filhos, Resposta;
    int idade, Mes_Nascimento, Ano_Nascimento, Ano_Atual, Mes_Atual, Quantidades_filhos = 0;


    do
    {
        //Entradas
        Clear();
        Console.WriteLine("qual seu nome?");
        Nome = Console.ReadLine();
        Console.WriteLine("onde vc mora?");
        Endereco = Console.ReadLine();
        Console.WriteLine("onde vc estuda?");
        Escola = Console.ReadLine();
        Console.WriteLine("vc tem filhos?");
        Filhos = Console.ReadLine();
        if (Filhos == "sim" || Filhos == "tenho")
        {
            Console.WriteLine("quantos filhos vc tem?");
            Quantidades_filhos = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("qual o ano que vc nasceu?");
        Ano_Nascimento = int.Parse(Console.ReadLine());
        Console.WriteLine("qual mes vc nasceu?");
        Mes_Nascimento = int.Parse(Console.ReadLine());
        Console.WriteLine("qual o ano atual?");
        Ano_Atual = int.Parse(Console.ReadLine());
        Console.WriteLine("qual o mes atual?");
        Mes_Atual = int.Parse(Console.ReadLine());
        Clear();
        //Processamento
        idade = Ano_Atual - Ano_Nascimento;
        if (Mes_Nascimento > Mes_Atual)
        {
            idade = idade - 1;
        }
        Console.WriteLine(Nome + ", agora sei que vc:");
        Console.WriteLine("Mora (em/na)" + Endereco);
        Console.WriteLine("que estuda (na/no)" + Escola);
        if (Quantidades_filhos < 1)
        {
            Console.WriteLine("vc nao tem filhos");
        }
        else if (Quantidades_filhos > 1)
        {
            Console.WriteLine("que tem" + Quantidades_filhos + "filhos");
        }
        else
        {
            Console.WriteLine("que tem 1 filho");
        }
        Console.WriteLine("e que tem " + idade + "anos completos");
        Console.WriteLine("deseja continuar(s/n)");
        Resposta = Console.ReadLine();
    } while (Resposta == "Sim" && Resposta == "sim ");  
}