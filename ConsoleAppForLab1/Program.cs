using lab1BinaryTree;
using System;

namespace ConsoleAppForLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BinaryTree<string> languages = new BinaryTree<string>("A");
            languages.Added += (object sender, AddToBinaryTreeEventArgs<string> arg) => Console.WriteLine(arg.Message);
            languages.CheckIfContains += (object sender,CheckIfBinaryTreeContainsItemEventArgs<string> arg) => Console.WriteLine(arg.Message);
            
            languages.Add("Z", "D", "C", "B", "F", "E", "Z", "Y", "K", "L", "M", "N", "Y", "Q");
            Console.WriteLine(languages.Count);
            foreach (string language in languages.InOrder(languages.Node))
            {
                Console.WriteLine(language);
            }
            Console.WriteLine(languages.Contains("Java"));
        }
    }
}
