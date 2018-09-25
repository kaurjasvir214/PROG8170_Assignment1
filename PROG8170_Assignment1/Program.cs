using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment1
{
    class Program
    {
        static Rectangle rec = new Rectangle();
        static bool continueTillExit = true;
        static void Main(string[] args)
        {
            try
            {
                Program driveClass = new Program();
                driveClass.Run();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.ReadKey();
            }
        }

        public void Run()
        {

            Program driveClass = new Program();

            int length = driveClass.GetIntegerValueFromUser("Please enter length of Rectangle ( > 0 )");
            rec.SetLength(length);

            int width = driveClass.GetIntegerValueFromUser("Please enter width of Rectangle ( > 0 )");
            rec.SetWidth(width);

            do
            {
                int selectedValue = driveClass.PrintMenuOptions();
                if (selectedValue == 1)
                {

                    length = rec.GetLength();
                    Console.WriteLine("Rectangle Length is : " + length);
                }
                if (selectedValue == 2)
                {

                    length = driveClass.GetIntegerValueFromUser("Please enter length of Rectangle ( > 0 )");
                    rec.SetLength(length);
                    Console.WriteLine("New Length is : " + length);
                }
                if (selectedValue == 3)
                {

                    width = rec.GetWidth();
                    Console.WriteLine("Rectangle Width is : " + width);
                }
                if (selectedValue == 4)
                {

                    width = driveClass.GetIntegerValueFromUser("Please enter width of Rectangle ( > 0 )");
                    rec.SetWidth(width);
                    Console.WriteLine("New Width is : " + width);

                }
                if (selectedValue == 5)
                {

                    int perimeter = rec.GetPerimeter();
                    Console.WriteLine("Perimeter of rectangle : " + perimeter);
                }
                if (selectedValue == 6)
                {

                    int area = rec.GetArea();
                    Console.WriteLine("Area of rectangle : " + area);
                }
                if (selectedValue == 7)
                {
                    continueTillExit = false;
                }
            }
            while (continueTillExit);



        }


        private int GetIntegerValueFromUser(string message)
        {
            string response = string.Empty;
            int output = 0;

            do
            {
                Console.Write(message + " : ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0);
            return output;
        }

        private int PrintMenuOptions()
        {
            string response = string.Empty;
            bool repeatMenuAgain = false;
            int output = 0;
            do
            {
                repeatMenuAgain = false;
                Console.WriteLine("Please select an option");
                Console.WriteLine();
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine();
                response = Console.ReadLine();

                if (!int.TryParse(response, out output))
                {
                    repeatMenuAgain = true;
                }
                if (output <= 0)
                {
                    repeatMenuAgain = true;
                }
                if (output > 7)
                {
                    repeatMenuAgain = true;
                }
                if (repeatMenuAgain)
                {
                    Console.WriteLine("Wrong option");
                }

            } while (repeatMenuAgain);

            return output;
        }

    }
}
