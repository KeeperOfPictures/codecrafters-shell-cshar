using System.Net;
using System.Net.Sockets;

while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine().Trim();
    if (command == "exit 0")
        return 0;
    Console.WriteLine($"{command}: command not found");
}