// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http.Headers;

class program
{
    static void Main()
    {
        string username;
        string pass;

        Console.WriteLine("Create a new account:");
        Console.Write("Username: ");
        username = Console.ReadLine();
        while (username == "")
        {
            Console.Write("Username: ");
            Console.ReadLine();
        }

        Console.Write("Password: ");
        pass = Console.ReadLine();
        while (pass == "")
        {
            Console.Write("Password: ");
            Console.ReadLine();
        }

        Console.WriteLine("=============================================================");

        Console.WriteLine("Log-in");
        Console.Write("Username: ");
        username = Console.ReadLine();

        Console.Write("Password: ");

        if (pass == Console.ReadLine())
        {
            Console.WriteLine("Access Granted");
        }
        //yes
        else
        {
            Console.WriteLine("Access Denied");
        }
        //no

        Console.ReadKey();


    }
}