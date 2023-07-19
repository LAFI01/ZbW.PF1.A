using System.Collections;

namespace MB10.CrossreferenztabelleAufgabe
{


    public class KeywordAnalyzer
    {
        private Hashtable keywordTable;

        public KeywordAnalyzer()
        {
            keywordTable = new Hashtable(StringComparer.InvariantCultureIgnoreCase);
        }

        public void AnalyzeFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
                {
                    string[] words = lines[lineNumber].Split(' ', '\t', '(', ')', '{', '}', ',', ';');

                    foreach (string word in words)
                    {
                        if (IsKeyword(word))
                        {
                            if (!keywordTable.ContainsKey(word))
                            {
                                keywordTable[word] = new LinkedList<int>();
                            }

                            LinkedList<int> lineNumbers = (LinkedList<int>)keywordTable[word];
                            lineNumbers.AddLast(lineNumber + 1);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Die angegebene Datei existiert nicht.");
            }
        }

        public void PrintKeywordTable()
        {
            Console.WriteLine("Gesamte Hashtabelle (alphabetisch sortiert):");
            foreach (string keyword in new SortedSet<string>((IComparer<string>?)keywordTable.Keys))
            {
                Console.WriteLine($"{keyword}: {string.Join(", ", ((LinkedList<int>)keywordTable[keyword]))}");
            }
        }

        public void SearchKeyword(string searchKeyword)
        {
            if (keywordTable.ContainsKey(searchKeyword))
            {
                LinkedList<int> lineNumbers = (LinkedList<int>)keywordTable[searchKeyword];
                Console.WriteLine($"Zeilennummern, in denen '{searchKeyword}' vorkommt: {string.Join(", ", lineNumbers)}");
            }
            else
            {
                Console.WriteLine($"Das Schlüsselwort '{searchKeyword}' wurde nicht gefunden.");
            }
        }

        private bool IsKeyword(string word)
        {
            string[] keywords = new string[]
            {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
            "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
            "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is",
            "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override",
            "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte",
            "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
            "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe",
            "ushort", "using", "virtual", "void", "volatile", "while"
            };

            return Array.Exists(keywords, k => k.Equals(word));
        }
    }
}
