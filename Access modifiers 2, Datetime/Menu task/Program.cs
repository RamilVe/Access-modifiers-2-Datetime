﻿using System;

namespace Menu_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[1];

            string option;
            do
            {
                Console.WriteLine("1. Notebooklar uzerinde axtaris et");
                Console.WriteLine("2. Yeni notebook yarat");
                Console.WriteLine("0. Menudan cix");

                option = Console.ReadLine();

                if(option == "1")
                {
                    try
                    {
                        Console.WriteLine("Axtaris edin: ");
                        string search = Console.ReadLine();

                        var arr = SearchNotebook(notebooks, search);

                        ShowInfo(arr);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Deyeri daxil edin");
                    }
                    
                }

                else if (option == "2")
                {
                    try
                    {
                        var notebook = CreateNotebook();
                        Array.Resize(ref notebooks, notebooks.Length);
                        notebooks[notebooks.Length - 1] = notebook;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            } while (option !="0");
        }

        static Notebook[] SearchNotebook(Notebook[] arr, string search)
        {
            Notebook[] newArr = new Notebook[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Array.Resize(ref newArr, newArr.Length + 1);
                newArr[newArr.Length- 1] = arr[i];
            }

            return newArr;
        }

        static void ShowInfo(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetInfo());
            }
        }

        static Notebook CreateNotebook()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NameFormatException("Name deyeri bosdu");
            }

            double price;
            bool check = true;
            do
            {
                Console.WriteLine("Price: ");
                string priceStr = Console.ReadLine();
                check = double.TryParse(priceStr, out price);

                if (check == false)
                    Console.WriteLine("Price deyeri eded olmalidir");

            } while (!check);


            byte ram;

            do
            {
                Console.WriteLine("Ram: ");
                string ramStr = Console.ReadLine();
                check = byte.TryParse(ramStr, out ram);

                if (check == false)
                    Console.WriteLine("Ram deyeri eded olmalidir");

            } while (!check);

            return new Notebook(name, price, ram);
        }
    }
}
