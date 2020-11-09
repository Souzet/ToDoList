using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1Declaration:
            string command;
            string[] commandWord;   //3
            // 3Greetings:
            Console.WriteLine("Hello and welcome todo list");
            Console.WriteLine("To quit type 'quit', for help type 'help'!");
            // 2REPL (do-while-loop)
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                commandWord = command.Split(' ');
                //    Om commandot är load: läs filen
                if (command == "quit")
                {
                    Console.WriteLine("Bye!");
                }
                else if (commandWord[0] == "load")
                {
                    Console.WriteLine("Reading file {0}", commandWord[1]);
                    using (StreamReader sr = new StreamReader(commandWord[1]))
                    {
                        while(sr.Peek() >= 0)  // Is next char an Endoffile sign?
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine("{0}", line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("unknown command: {0}", command);
                }
            }
            while (command != "quit");
        }
    }
}
