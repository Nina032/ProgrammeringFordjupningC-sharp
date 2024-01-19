using Newtonsoft.Json;
using System.Data;

namespace BookMedJSON
{
    internal class Program
    {
        public class Book
        {
            public string title { get; set; }
            public string author { get; set; }
            public string code { get; set; }
        }

        public class  Root
        {
            public List<Book> book { get; set; }
        }

        public static void checkInputs(int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
        } 

        public static Root importJSON()
        {
            Root import = JsonConvert.DeserializeObject<Root>(File.ReadAllText("data.json"));
            return import;
        }

        public static void DisplayBookInfo(Book book)
        {
            Console.WriteLine("Title: " + book.title);
            Console.WriteLine("Author: " + book.author);
            Console.WriteLine("Code: " + book.code);

        }

        static void Main(string[] args)
        {
            try
            {
                Root importedData = importJSON();

                if (importedData != null && importedData.book.Count > 0)
                {
                    foreach (Book book in importedData.book)
                    {
                        DisplayBookInfo(book);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No data found in the JSON file.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }
    }
}
