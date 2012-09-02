using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;


/*
 * Want more WCF tips?
 * Visit http://webservices20.blogspot.com/
 */


namespace WebServices20.SampleService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(EchoService)))
            {
                host.Open();                
                Console.WriteLine("The service is ready.");
                Console.WriteLine(String.Format("Metadata is at {0}?WSDL", host.Description.Endpoints[0].Address));
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("***********************");
                Console.WriteLine("Want more WCF tips?");
                Console.WriteLine("Visit http://webservices20.blogspot.com/");
                Console.WriteLine("***********************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
