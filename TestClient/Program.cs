using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Want more WCF tips?
 * Visit http://webservices20.blogspot.com/
 */


namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {            
            ServiceReference1.EchoServiceClient client = new TestClient.ServiceReference1.EchoServiceClient();
            client.ClientCredentials.UserName.UserName = "yaron";
            client.ClientCredentials.UserName.Password = "1234";
            Console.WriteLine(client.EchoString("hello"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("Want more WCF tips?");
            Console.WriteLine("Visit http://webservices20.blogspot.com/");
            Console.WriteLine("***********************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate program.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
