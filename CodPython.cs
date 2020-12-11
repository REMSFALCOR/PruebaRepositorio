using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace PyCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola rems");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Dato REMS Nº " + i);
            }
            var input = Console.ReadLine();
            var py = Python.CreateEngine();
            //var py = Python.;
            try
            {
                py.Execute("*from Python:"+ input + "')");
            }
            catch (Exception ex) {
                Console.WriteLine("");//ex.Message.ToString
            }

            Console.ReadLine();
        }
    }
}
