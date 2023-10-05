using System.Collections.Generic;

Dictionary<int, string> myDictionary = new Dictionary<int, string>();
myDictionary.Add(1, "Micheal");
myDictionary.Add(2, "Lagos");
myDictionary.Add(3, "Expert");
myDictionary.Add(4, "Alert");

foreach(KeyValuepair<int, string> item in myDictionary)
{
    Console.WriteLine($"key {item.Key} and value {item.Value}");
}