using System;
using System.Collections.Generic;
using System.Text;

namespace Menutask2
{
    public class Store
    {
        Notebook[] Notebooks;
        public string Name;


        public void AddNotebook(Notebook notebook)
        {
            Array.Resize(ref Notebooks, Notebooks.Length);
            Notebooks[Notebooks.Length - 1] = notebook;
        }

        static Notebook[] SearchNotebooks(Notebook[] arr,string search)
        {
            Notebook[] newArr = new Notebook[0];
            for (int i = 0; i < newArr.Length; i++)
            {
                Array.Resize(ref newArr, newArr.Length);
                newArr[newArr.Length - 1] = arr[i];
            }
            return newArr;
        }

        public void ShowNotebooks(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetInfo());
            }
        }
    }
}
