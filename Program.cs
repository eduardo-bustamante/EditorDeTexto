internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer? ");
        Console.WriteLine("1 - Abrir um arquivo de texto");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "0": System.Environment.Exit(0); break;
            case "1": Abrir(); break;
            case "2": Criar(); break;

            default: Menu(); break;
        }
    }

    static void Abrir() { 
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo?");
        string caminho = Console.ReadLine();

         using (var arquivo = new StreamReader(caminho))
        {
            string text = arquivo.ReadToEnd();
            Console.WriteLine(text);

            
        }

         Console.WriteLine("");
         Console.ReadLine();
        Menu();
    }
    static void Criar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo: (esc para SAIR)");
        Console.WriteLine("------------------");
        string text = "";


        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;

        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
        Salvar(text);

    }

    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var caminho = Console.ReadLine();

        
        using (var arquivo = new StreamWriter(caminho))
        {
            arquivo.Write(text);
        }
        Console.WriteLine($"Arquivo {caminho} Salvo com Sucesso!");
        Console.ReadLine();
        Menu();

    }
}