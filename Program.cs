using System;
using System.Collections.Generic;
using System.Data;
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
            // 3Greetings:
            Console.WriteLine("Hello and welcome todo list");
            Console.WriteLine("To quit type 'quit', for help type 'help'!");
            // 2REPL (do-while-loop)
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                //    Om commandot är load: läs filen
                if( command== "quit")
                {
                    Console.WriteLine("Bye!");
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
