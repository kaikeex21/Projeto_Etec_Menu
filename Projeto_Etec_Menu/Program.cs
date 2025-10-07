using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using static System.Console; // fixa a classe console 
int opc;

BackgroundColor = ConsoleColor.Black;
do
{
    Clear();
    janela(0, 0, 79, 2, ConsoleColor.DarkGreen);
    janela(24, 5, 63, 18, ConsoleColor.DarkGreen);
    SetCursorPosition(25, 5);WriteLine("══════════════════════════════════");
    SetCursorPosition(25, 6);WriteLine("      *** Menu Principal ***");
    SetCursorPosition(25, 7);WriteLine("══════════════════════════════════");
    SetCursorPosition(25, 8);WriteLine("[1] Calculos");
    SetCursorPosition(25, 9);WriteLine("[2] Entrevista");
    SetCursorPosition(25, 10);WriteLine("[3] Par ou Impar");
    SetCursorPosition(25, 11);WriteLine("[4] Qual numero maior?");
    SetCursorPosition(25, 12);WriteLine("[5] Qual numero sucessor e antecessor?");
    SetCursorPosition(25, 13);WriteLine("[6] Qual Periodo do dia");
    SetCursorPosition(25, 14);WriteLine("[7] Tabuada");
    SetCursorPosition(25, 15);WriteLine("[8] Contador");

    SetCursorPosition(25, 16);WriteLine("digite uma opção");
    SetCursorPosition(25, 17); opc = int.Parse(ReadLine()!);
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
} while (opc != 8);


static void Todos_Calculos()
{
    //Declaração de variaveis
    double a, b, r, x, y, z; //inteiro
    string pausa;//cadeia
    double real;//real
    decimal valor;//real
    float juros;//real
    bool achou = true;//logico
    do
    {
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
    } while (continuar());
}
static void Entrevista()
{
    //Declaração de variaveis
    string Nome, Endereco, Escola, Filhos;
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
    } while (continuar());  
}
static void Par_Impar()
{  
    // Variaveis 
    int R = 0, Numero;
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

    } while (continuar());
}
static void Comparar_Numeros()
{
    int Numero1, Numero2;
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

    } while (continuar());
}
static void Numero_Sucessor_Antecessor()
{
    int Numero, Sucessor, Antecessor;
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

    } while (continuar());
}
static void horas()
{
    int Hora;
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

    } while (continuar());

}
static void Mult_auto()
{
    int n;
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

    } while (continuar());
}
static void Contador()
{
    int inicio, limite, fator;
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

    } while (continuar());
}
static void janela(int C1, int L1, int C2, int L2, ConsoleColor corFundo)
{
    BackgroundColor = corFundo;
    for (int i = L1; i <= L2; i++)
    {
        SetCursorPosition(C1, i); Write(new string(' ', C2 - C1));

    }
    // horizontais
    for (int i = C1; i <= C2; i++)
    {
        SetCursorPosition(i, L1); Write("═");//ALT 205
        SetCursorPosition(i, L2); Write("═");
    }
    // laterais
    for (int i = L1; i <= L2; i++)
    {
        SetCursorPosition(C1, i); Write("║");//ALT 186
        SetCursorPosition(C2, i); Write("║");
    }
    // canto
    SetCursorPosition(C1, L1); Write("╔");//ALT 201
    SetCursorPosition(C2, L1); Write("╗");//ALT 187
    SetCursorPosition(C1, L2); Write("╚");//ALT 200
    SetCursorPosition(C2, L2); Write("╝");//ALT 188
}
static bool continuar()
{
    string Resposta;
    bool resultado;

    janela(25, 20, 40, 29, ConsoleColor.Red);
    SetCursorPosition(26, 21);
    Write("Deseja continuar? S/N ");
    Resposta = ReadLine()!.ToUpper();
    resultado = (Resposta == "S" || Resposta == "sim");
    return resultado;
}