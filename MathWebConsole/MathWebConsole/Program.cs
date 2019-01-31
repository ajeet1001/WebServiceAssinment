using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWebConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //myservicereference.MyService obj = new myservicereference.MyService();
            localhost.WebService1 obj = new localhost.WebService1();
            Console.WriteLine(" Calling Web Methods");
            Console.WriteLine("---------------------");
            Console.WriteLine("\n Calling show Method");
            Console.WriteLine("  " + obj.show());
            Console.WriteLine("\n\n" + " Calling showdate Method ");
            Console.WriteLine("  " + obj.showdate());
            Console.WriteLine("\n Calling add Method ");
            Console.Write("  Enter First Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter Second Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n  Addition is:" + obj.add(a, b).ToString());

            //Console.WriteLine("\n Calling Subtract Method ");
            //Console.Write("  Enter First Number:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("  Enter Second Number:");
            //b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n  Subtratcion is:" + obj.Subtract(a, b).ToString());
            Console.Write("  \n\nEnter List of no's you want to add with (seperate no's with space)space ");
            string listNum = Console.ReadLine();
            Console.WriteLine("\n Addition of n no's  is:" + obj.addMoreThan2Numbers(listNum));

            Console.ReadLine();


        }
    }
}
