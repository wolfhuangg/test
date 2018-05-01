using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");


            int counter = 0;
            string line;
            string line2 = "高雄很美";
            // Read the file and display it line by line.  
            System.IO.StreamReader file =new System.IO.StreamReader(@"test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {1} lines.{0}", counter,line2);
            // Suspend the screen.  
            System.Console.ReadLine();



            // third


           

        }
    }
}
