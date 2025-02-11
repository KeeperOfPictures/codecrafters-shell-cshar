using System.Net;
using System.Net.Sockets;

while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine().Trim();
    if (command.StartsWith("exit"))
    {
        var cmdArgs = command.Split();
        return int.Parse(cmdArgs[1]);
    }
    else if (command.StartsWith("echo"))
    {
        if(command.Length > 5)
            Console.WriteLine(command.Substring(5));
    }
    else
    {
        Console.WriteLine($"{command}: command not found");
    }
}