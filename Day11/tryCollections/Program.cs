using System.Collections;
class Program
{
    public static void Main()
    {
        //TRY HASHTABLE
        Hashtable tryHashtable = new();
        tryHashtable.Add(1, "eko");
        tryHashtable.Add(2, "dino");
        tryHashtable.Add("orange", "doni");
        tryHashtable.Add("apple", "tono");
        foreach (DictionaryEntry item in tryHashtable)
        {
            Console.WriteLine($"pair : {item.Key}, {item.Value}");
        }
        //different way to input the data
        Hashtable tryHashtable2 = new Hashtable(){
            {1, "eko"},
            {2, "dino"},
            { "orange", "doni"},
            { "apple", "tono"}
        };
        foreach (var item in tryHashtable)
        {
            Console.WriteLine($"pair : {item}");
        }

        //TRY DICTIONARY
        Console.WriteLine();
        Dictionary<string, string> dictionary = new();
        dictionary.Add("grape", "eko");
        dictionary.Add("mango", "dino");
        dictionary.Add("orange", "doni");
        dictionary.Add("apple", "tono");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"pair : {item.Key}, {item.Value}");
        }

        //TRY Sorteddictionary
        Console.WriteLine();
        SortedDictionary<string, string> sortedDictionary = new();
        sortedDictionary.Add("grape", "eko");
        sortedDictionary.Add("mango", "dino");
        sortedDictionary.Add("orange", "doni");
        sortedDictionary.Add("apple", "tono");
        foreach (var item in sortedDictionary)
        {
            Console.WriteLine($"pair : {item.Key}, {item.Value}");
        }
    }
}
