// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using Tests;
using Tests.Servicos;

IServicoDeLog servicoDeLog = new ServicoDeLog();

var valores = PedeNumeros();

new Calculadora(servicoDeLog).Soma(valores.primeiro, valores.segundo);


(int primeiro ,int segundo) PedeNumeros()
{
    int? primeiro = null;
    int? segundo = null;
    bool sucesso = false;

    Console.WriteLine($"Calculadora");

    do
    {
        if (primeiro == null)
        {
            servicoDeLog.Log($"Qual é o primeiro valor de 0 a 9 que será somado");
            primeiro = PedeONumero();
        }
        
        if (segundo == null)
        {
            servicoDeLog.Log($"Qual é o segundo valor de 0 a 9 que será somado");
            segundo = PedeONumero();
        }

        if(primeiro != null && segundo != null)
        {
            sucesso = true;
        }
    }
    while (!sucesso);

    return ((int)primeiro, (int)segundo);
}

int PedeONumero()
{
    bool sucesso = false;
    var numero = "";
    do
    {
        numero = Console.ReadLine();
        if (Regex.Match(numero, @"^\d$").Success)
        {
            sucesso = true;
        }
        else
        {
            servicoDeLog.Log($"Precisa ser um número dentro do intervalo 0 1 2 3 4 5 6 7 8 9 /n");
        }
    } while (!sucesso);
    return int.Parse(numero);
}
