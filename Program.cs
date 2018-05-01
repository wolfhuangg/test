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



            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary.


            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" ,"fourth"};
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"WriteLines.txt", lines);


            // Example #2: Write one string to a text file.
            //string text = "A class is the most powerful data type in C#. Like a structure, " +
                        //   "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
           // System.IO.File.WriteAllText(@"WriteText.txt", text);

            // Example #3: Write only some strings in an array to a file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
           // using (System.IO.StreamWriter file2 =new System.IO.StreamWriter(@"WriteLines2.txt"))
            //{
             //   foreach (string line3 in lines)
              //  {
                    // If the line doesn't contain the word 'Second', write the line to the file.

                //    if (!line.Contains("Second"))
                  //  {
                    //    file2.WriteLine(line3);
                    //}
                //}
            //}

            // Example #4: Append new text to an existing file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
          //  using (System.IO.StreamWriter file2 =new System.IO.StreamWriter(@"WriteLines2.txt", true))
           // {
             //   file2.WriteLine("Fourth line");
            //}



        }
    }
}
