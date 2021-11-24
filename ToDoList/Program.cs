using System;

namespace ToDoList
{
    class Program
    {
        public struct Date
        {
            int day;
            int month;
            int year;
        };
        public struct ToDo
        {
            char[] title;
            char[] desc;
            int imp;
            Date deadline;
        };
        public void welcome()
        {
            int choice;
            char[] s = new char[100];
            Console.WriteLine("Please Enter Your Name");
            Console.WriteLine("Hello Dear " + s + " !");
            Console.WriteLine("Welcome To Your Own To Do List !");
        }
        public void menu()
        {
            Console.WriteLine("Enter your choice...");
            Console.WriteLine("1.See Your ToDo List");
            Console.WriteLine("2.Create Your ToDos");
            Console.WriteLine("3.Show A Certain Task");
            Console.WriteLine("4.Exit");
        }
        public void Sort_ahamiat(ToDo[] a, int n)
        {
            for (int i = 1; i < n; i++)
            {
                ToDo x = a[i];
                int j = i;
                while (j > 0)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = x;
            }
        }
        public void ShowList(ToDo[] t, int NumberOfTasks)
        {
            if (NumberOfTasks == 0)
            {
                Console.WriteLine("******************");
                Console.WriteLine("\t\t\t\t\t\t Empty !");
                Console.WriteLine("******************");
                menu();
            }
            else
            {
                Sort_ahamiat(t, NumberOfTasks);
                for (int i = 0; i < NumberOfTasks; i++)
                {
                    Console.WriteLine("   Title " + i + 1 + " :" );
                    Console.WriteLine("   Priority :" );
                    Console.WriteLine("   Deadline " + i + 1 + " :");
                }
                Console.WriteLine("*******************************");
                Console.WriteLine("\n\n check out the task ? +/- ");
                char k;
                int j;
                k = Console.ReadKey().KeyChar;
                if (k == '-')
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("Enter Number Of Task ");
                    j = Console.Read();
                    Console.WriteLine("Title " + j + " :");
                    Console.WriteLine("Describtion " + j + " :" );
                    Console.WriteLine("Priority " + " :" );
                    Console.WriteLine("Deadline :" );
                    Console.WriteLine("*******************************");
                }
                menu();
            }
        }
        public void createToDo(ToDo[] t, int NumberOfTasks)
        {
            Console.WriteLine("Add Title...");
            Console.WriteLine("Add Describtion...");
            Console.WriteLine("Add Priority...");
            Console.WriteLine("Add Deadline's Day..." );
            Console.WriteLine("Add Deadline's Month...");
            Console.WriteLine("Add Deadline's Year..." );
            Console.WriteLine("Your Task(s) Added Successfully =) ");
            NumberOfTasks++;
            menu();
        }
        public void delToDo(ToDo[] t, int NumberOfTasks, int task_number)
        {
            /*ToDo a = new ToDo[NumberOfTasks - 1];
            for (int i = 0; i < task_number; i++)
            {
                a[i] = t[i];
            }
            for (int i = task_number; i < NumberOfTasks - 1; i++)
            {
                a[i] = t[i + 1];
            }
            NumberOfTasks--;
            for (int i = 0; i < NumberOfTasks; i++)
            {
                t[i] = a[i];
            }*/
            Console.WriteLine("Task Deleted !");
            ShowList(t, NumberOfTasks);
        }
        static void Main()
        {
            int choice, task_number, NumberOfTasks = 0;
            ToDo[] Tasks = new ToDo[1000];
            while (true)
            {
                choice = Console.Read();
                switch (choice)
                {
                    case 1: 
                        //ShowList(Tasks, NumberOfTasks);
                        break;
                    case 2:
                      //  createToDo(Tasks, NumberOfTasks);
                        break;
                    case 3:
                        {
                            if (NumberOfTasks == 0)
                            {
                                Console.WriteLine("******************");
                                Console.WriteLine("\t\t\t\t\t\t Empty !");
                                Console.WriteLine("******************");
                                //menu();
                            }
                            else
                            {
                                Console.WriteLine("which one?");
                                task_number = Console.Read();
                             //   ShowOneTask(Tasks, NumberOfTasks, task_number);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Have A Nice Day :) ");
                        break;
                }
            }
        }
    }
}
