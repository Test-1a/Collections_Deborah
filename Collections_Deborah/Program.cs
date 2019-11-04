using System;

namespace Collections_Deborah
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------  Ch.3 Arrays ---------------
            //var colorOptions = new string[4];
            //colorOptions[0] = "Red";
            //colorOptions[1] = "Espresso";
            //colorOptions[2] = "White";
            //colorOptions[3] = "Navy";
            string[] colorOptions = { "Red", "Espresso", "White", "Navy" };
            //Console.WriteLine(colorOptions);    //=> System.String[]
            Console.WriteLine(colorOptions[1]);
            Console.WriteLine();

            foreach (var color in colorOptions)
            {
                Console.WriteLine($"The color is {color}");
            }

            Console.WriteLine();
            for (int i = 0; i < colorOptions.Length; i++)
            {
                Console.WriteLine(colorOptions[i].ToLower());
            }

            Console.WriteLine();
            var brownIndex = Array.IndexOf(colorOptions, "Espresso");
            Console.WriteLine(brownIndex);

            colorOptions.SetValue("Blue", 3);
            foreach (var color in colorOptions)
            {
                Console.WriteLine($"The color is {color}");
            }
            // -----------------------------------------




        }
    }
}
