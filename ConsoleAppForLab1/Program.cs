using lab1BinaryTree;
using System;

namespace ConsoleAppForLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BinaryTree<string> languages = new BinaryTree<string>("P");
            languages.Added += (object sender, AddToBinaryTreeEventArgs<string> arg) => Console.WriteLine(arg.Message);
            languages.CheckIfContains += (object sender,CheckIfBinaryTreeContainsItemEventArgs<string> arg) => Console.WriteLine(arg.Message);

            languages.Add("A", "D", "C", "B", "F", "E", "Z", "Y", "K", "L", "M", "N", "Y", "Q");
           
            foreach (string language in languages.InOrder(languages.Node))
            {
                Console.WriteLine(language);
            }
            Console.WriteLine(languages.Count);
            Console.WriteLine(languages.Contains("Java"));
            Console.ReadKey();
        }
    }
}
