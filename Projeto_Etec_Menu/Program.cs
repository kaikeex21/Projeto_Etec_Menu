using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using static System.Console; // fixa a classe console 
int opc;

BackgroundColor = ConsoleColor.Black;
do
{
    Clear();
    Console.WriteLine("==================================");
    Console.WriteLine("      *** Menu Principal ***");
    Console.WriteLine("==================================");
    Console.WriteLine("[1] Calculos");
    Console.WriteLine("[2] Entrevista");
    Console.WriteLine("[3] Par ou Impar");
    Console.WriteLine("[4] Qual numero maior?");
    Console.WriteLine("[5] Qual numero sucessor e antecessor?");
    Console.WriteLine("[6] Qual Periodo do dia");
    Console.WriteLine("[7] Tabuada");
    Console.WriteLine("[8] Contador");

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
        case 3:
            Par_Impar();
            break;
        case 4:
            Comparar_Numeros();
            break;
        case 5:
            Numero_Sucessor_Antecessor();
            break;
        case 6:
            horas();
            break;
        case 7:
            Mult_auto();
            break;
        case 8:
            Contador();
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
static void Par_Impar()
{  
    // Variaveis 
    int R = 0, Numero;
    string Resposta;
    do
    {
        Clear();
        Console.WriteLine("Digite um numero para saber se é impar ou par? ");
        Numero = int.Parse(Console.ReadLine());
        //Processamento
        R = Numero % 2;

        if (R == 0)
        {
           Console.WriteLine("o numero" + Numero + " é par ");
        }
        else
        {
           Console.WriteLine("o numero" + Numero + "é impar");
        }
        Console.WriteLine("Deseja continuar?");
        Resposta = Console.ReadLine();
    } while (Resposta == "s" && Resposta == "sim");
}
static void Comparar_Numeros()
{
    int Numero1, Numero2;
    string Resposta;
    do
    {

        Clear();
        Console.WriteLine("digite um numero para saber o maior");
        Numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("digite outro numero");
        Numero2 = int.Parse(Console.ReadLine());

        if (Numero1 > Numero2)
        {
            Console.WriteLine("o numero" + Numero1 + "é maior");
        }
        else
        {
            Console.WriteLine("o numero " + Numero1 + "é menor ");
        }
        Console.WriteLine("deseja continuar?");
        Resposta = Console.ReadLine();
    } while (Resposta == "s" && Resposta == "sim");

}
static void Numero_Sucessor_Antecessor()
{
    int Numero, Sucessor, Antecessor;
    string Resposta;
    do
    {
        Clear();
        Console.WriteLine("digite um numero para saber qual o sucessor e o antecessor dele");
        Numero = int.Parse(Console.ReadLine());

        Sucessor = Numero + 1;
        Antecessor = Numero - 1;

        Console.WriteLine("o sucessor é " + Sucessor);
        Console.WriteLine("o antecessor é " + Antecessor);
        Console.WriteLine("o numero é " + Numero);

        Console.WriteLine("Deseja continuar?");
        Resposta = Console.ReadLine();
    } while (Resposta == "s" && Resposta == "sim");
}
static void horas()
{
    int Hora;
    string Resposta;
    do
    {
        Clear();
        Console.WriteLine("digite a hora (0-24):");
        Hora = int.Parse(Console.ReadLine());
        if (Hora >= 6 && Hora <= 12)
        {
            Console.WriteLine("é dia");
        }
        else if (Hora > 12 && Hora < 18)
        {
            Console.WriteLine("é tarde");
        }
        else if (Hora >= 18 && Hora <= 24)
        {
            Console.WriteLine("é noite");
        }
        else if (Hora > 0 && Hora < 6)
        {
            Console.WriteLine("é madrugada");
        }
        else
        {
            Console.WriteLine("coloque um horario existente");
        }
        Console.WriteLine("deseja continuar?");
        Resposta = (Console.ReadLine());
    } while (Resposta == "s" && Resposta == "sim");

}
static void Mult_auto()
{
    int n;
    string resposta;

    do
    {
        Console.Clear(); // limpa a tela
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
            System.Threading.Thread.Sleep(10); // pausa de 10ms
        }

        Console.Write("\n\nDeseja continuar (s/n)? ");
        resposta = Console.ReadLine().ToLower();

    } while (resposta == "s" || resposta == "sim");
}
static void Contador()
{
    int inicio, limite, fator;
    string resposta;

    do
    {
        Console.Clear();
        Console.Write("Informe o valor inicial: ");
        inicio = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor final: ");
        limite = int.Parse(Console.ReadLine());
        Console.Write("Informe o fator de incremento: ");
        fator = int.Parse(Console.ReadLine());
        for (int i = inicio; i <= limite; i += fator)
        {
            Console.Write(i);
            Thread.Sleep(1000); // pausa de 1 segundo (1000 ms)

            if (i < limite)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(".\n\nDeseja continuar (s/n)? ");
        resposta = Console.ReadLine().ToLower();

    } while (resposta == "s" && resposta == "sim");
}