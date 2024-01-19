namespace Övningar_24_01_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            //string fileName = @"mytekst.txt";

            //try
            //{
            //    //Ta bort filen om den finns
            //    if (File.Exists(fileName))
            //    {
            //        File.Delete(fileName);
            //    }

            //    Console.Write("Create a file med text and read the file:\n");
            //    Console.WriteLine("-------------------------------------------\n");

            //    //Skapar och skriver till filen
            //    using (StreamWriter fileStr = File.CreateText(fileName)) 
            //    {
            //        fileStr.WriteLine(" Hello and Welcome");
            //        fileStr.WriteLine(" It is the first content");
            //        fileStr.WriteLine(" of the text file mytekst.txt");
            //    }
            //    //Läs från filen
            //    using (StreamReader sr = File.OpenText(fileName))
            //    {
            //        string s = "";
            //        Console.WriteLine(" Here is the content of the file mytekst.txt : ");
            //        while ((s = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(s);
            //        }
            //        Console.WriteLine("");
            //    }
            //}
            //catch (Exception MyExcep) 
            //{
            //    Console.WriteLine(MyExcep.ToString());
            //}

            //Övning 2

            string fileName = @"mytekst.txt";

            Console.Write("Create a file med write an array of strings : \n");
            Console.WriteLine("-------------------------------------------\n");

            //Ta bort filen om den finns
            if (File.Exists(fileName))
                File.Delete(fileName);

            Console.WriteLine(" Input number of lines to write in the file  :");
            int n = int.Parse(Console.ReadLine());
            
            string [] ArrLines = new string[n];
            Console.WriteLine($" Input {n} strings below: \n");

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($"Input line {i+1}");
                ArrLines[i] = Console.ReadLine();
            }

            File.WriteAllLines(fileName, ArrLines);

            Console.WriteLine();

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file mytekst.txt : ");
                while ((s = sr.ReadLine()) != null)
                {
                Console.WriteLine(s);
                }
                Console.WriteLine();
            }


        }
    }
}
