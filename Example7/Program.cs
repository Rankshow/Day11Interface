using System.Collections.Generic;

Queue<string> queues = new Queue<string>(); 
queues.Enqueue("Africa");
queues.Enqueue("Asia");
queues.Enqueue("America");
queues.Enqueue("Europe");
queues.Enqueue("North-America");

queues.Dequeue();

foreach(string queue in queues)
{
    Console.WriteLine(queue);
}