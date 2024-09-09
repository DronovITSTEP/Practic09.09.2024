using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic09._09._2024
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            bool call = phone.Call("57568");
            if (call)
                Console.WriteLine("Звонок пошел");
            else
                Console.WriteLine("Абонент не доступен!");
            Console.WriteLine(phone.Vendor);
            phone.Vendor = "Apple";

            phone.Weidth = 45;
            Console.WriteLine(phone.Weidth);
            Console.WriteLine(phone.Vendor);
            /*Mathematic mathematic = new Mathematic();
            int res;

            res = mathematic.Sub(14, 5);
            Console.WriteLine(res);

            int a = 6, b = 5;
            res = mathematic.Mult(a, b);
            Console.WriteLine(res);

            res = mathematic.Div(8, 0);
            Console.WriteLine(res);*/
        }
    }
}
