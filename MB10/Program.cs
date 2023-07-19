using MB10.CrossreferenztabelleAufgabe;

class Program
{
    static void Main(string[] args)
    {

        //Crossreferenztabelle Beispiel:
        Console.Write("Geben Sie den Pfad zur C#-Datei ein: ");
        string filePath = Console.ReadLine();

        KeywordAnalyzer analyzer = new KeywordAnalyzer();
        analyzer.AnalyzeFile(filePath);

        analyzer.PrintKeywordTable();

        Console.Write("Geben Sie ein Schlüsselwort ein, um die Zeilennummern anzuzeigen: ");
        string searchKeyword = Console.ReadLine();

        analyzer.SearchKeyword(searchKeyword);

        Console.ReadLine();
    }
}