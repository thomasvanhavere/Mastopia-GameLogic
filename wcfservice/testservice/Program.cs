using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testservice.ServiceReference1Cal;
namespace testservice
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new CalculateServiceClient();
            Console.WriteLine(cal.Add(20, 10));
            Console.ReadLine();
        }
    }
}
