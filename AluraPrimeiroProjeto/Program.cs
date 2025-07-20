
// screen-sound

using Microsoft.Win32;
using System.ComponentModel.Design;

string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 9, 8,});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirOLogo()
{
    Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░███████║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██╔══██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝██║░░██║╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░╚══╝╚═════╝░");


    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu()
{
    ExibirOLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para ver todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
   string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        {
        switch (opcaoEscolhidaNumerica) 
        {
                case 1: RegistrarBanda();
                break;
                case 2: MostrarBandasRegistradas();
                break;
                case 3: AvaliarUmaBanda();
                break;
                case 4: Exibirmedia();
                break;
                case -1: Console.WriteLine("Você escolheu a opção" + opcaoEscolhidaNumerica);
                break;
                default : Console.WriteLine("Tchau Tchau :)");
                break;
                }     
    }
}
void RegistrarBanda()
{ 
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomedabanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomedabanda, new List<int>());
    Console.WriteLine($"A banda {nomedabanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();


}

void MostrarBandasRegistradas() 

{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    //for (int i = 0; i < listaDasBandas.Count; i++)    
    //{
    // Console.WriteLine($"banda: {listaDasBandas[i]}");   
    //}
    foreach (string banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda: {banda}");
    
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}
void AvaliarUmaBanda() 
{
// Digite qual banda deseja avaliar
// se a banda existir no dicionario >> atribuir uma noata
// se não volta ao menu principal.
Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomedabanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomedabanda)) 
    {

        Console.WriteLine($"Qual a nota que a banda {nomedabanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomedabanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomedabanda}  ");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else 
    {
        Console.WriteLine($"\nA banda {nomedabanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();


    }



}
void Exibirmedia() {
    Console.Clear();
    ExibirTituloDaOpcao("Exibir a média de uma banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomedabanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomedabanda))
    {
        List<int> notasdabanda = bandasRegistradas[nomedabanda];
        Console.WriteLine($"A medida da banda {nomedabanda} é {notasdabanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else 
    {
        Console.WriteLine($"\nBanda {nomedabanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();

    }


}



ExibirOpcoesDoMenu();
