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
            // Declaration:
            string command;
            // REPl (do-while-loop)
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                //    Om commandot är load: läs filen
            }
            while (command != "quit");
        }
    }
}
