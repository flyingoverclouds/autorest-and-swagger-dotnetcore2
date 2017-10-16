using Clients.ApiProxy;
using System;

namespace CliClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            var px = new ProjEvaNico(new Uri("http://localhost:8379/"));
            var r = px.ApiValuesByIdGet(1);
            Console.WriteLine($"Result = {r}");
        }
    }
}
