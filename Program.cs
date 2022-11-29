using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\intel\1.txt"; 
           
              //  Console.Write($"Введите путь файла:");
           // string path = Console.ReadLine();
            Console.WriteLine(path);
            if (File.Exists(path))
            {
                string txt = File.ReadAllText(path);
            }
            else
            {
                File.Create(path);
            }


            book book1 = new book();
            book book2 = new book();

            book1.title = "Колобок";
            book1.author = "Русская народная сказка";
            book1.page = 10;

            List<book> books = new List<book>();
            books.Add(book1);


            string a1;

            a1 = Path.GetExtension(path);

            if (a1 == ".txt")
            {
                string json = JsonConvert.SerializeObject(books);
                File.WriteAllText(path, json);
                List<book> result;
            }
            else
            {
                XmlSerializer xml = new XmlSerializer(typeof(book));
                using (FileStream f = new FileStream(path, FileMode.OpenOrCreate))

                    xml.Serialize(f, book1);

                {

                }


            }
        }
    }
}