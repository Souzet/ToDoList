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
        class Activity
        {
            public string date;
            public string status;
            public string title;
            public Activity(string D, string S, string T)
            {
                date = D; status = S; title = T;
            }
            //NYT: public void Print  skriver en rad
        }
        static void Main(string[] args)
        {            
            // 3Greetings:
            Console.WriteLine("Hello and welcome todo list");
            Console.WriteLine("To quit type 'quit', for help type 'help'!");
            // 1Declaration:
            string command;
            string[] commandWord;   //3
            List<Activity> todoList;

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
                    todoList= ReadToDoListFile(commandWord[1]);
                }
                else
                {
                    Console.WriteLine("unknown command: {0}", command);
                }
            }
            while (command != "quit");
        }

        private static List<Activity> ReadTodoListFile(string fileName)
        {
            List<Activity> todoList = new List<Activity>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (sr.Peek() >= 0)  // Is next char an Endoffile sign?
                {
                    string[] lword = sr.ReadLine().Split('#');
                    // fas 2
                    Activity A = new Activity(lword[0],lword[1], lword[2]);
                   
                   // Console.WriteLine("{0} - [1} - {2}", A.date, A.status, A.title);
                    todoList.Add(A);
                }
            }
            return todoList;
        }
    }
}
