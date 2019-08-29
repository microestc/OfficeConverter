using Newtonsoft.Json;
using Microestc.OfficeConverter;
using System;

namespace DockerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OfficeService();
            service.Convert(new TaskSetup("1000", @"/app/app/1.doc", @"/app/app"));
            Console.WriteLine("Hello World!");
        }
    }
}
