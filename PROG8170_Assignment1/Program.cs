using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle.GetLength().ToString());
            Console.ReadKey();
        }
    }
}
