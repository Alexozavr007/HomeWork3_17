using HomeWork3_17_3;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var dictionary = new EnUaDictionary();
dictionary.Add("milkmaid", "доярка");
dictionary.Add("udder", "вим'я");
dictionary.Add("tail", "хвіст");

var entries = dictionary.GetEntries();

foreach (var entry in entries) {
    Console.WriteLine($"{entry.EnWord} ---- {entry.UaWord}");
}

