using System.Net;
using System.Net.Sockets;

List<string> builtins = ["exit", "echo", "type"];

while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine().Trim();
    var cmdArgs = command.Split(" ");
    switch (cmdArgs[0])
    {
        case "exit":
            if (cmdArgs.Length > 1)
                return int.Parse(cmdArgs[1]);
            break;
        case "echo":
            if (command.Length > 5)
                Console.WriteLine(command.Substring(5));
            break;
        case "type":
            if (builtins.Contains(cmdArgs[1]))
                Console.WriteLine($"{cmdArgs[1]} is a shell builtin");
            else
                Console.WriteLine($"{cmdArgs[1]}: not found");
            break;
        default:
            Console.WriteLine($"{command}: command not found");
            break;
    }
}