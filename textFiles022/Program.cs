using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textFiles022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var info = new TextFileInfo();
            info.GetTextFileInfo();
            WriteAllLines.WriteToFile(info.infoList); 
        }
    }

    public class TextFileInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public List<string> infoList = new List<string>();

        public void GetTextFileInfo()
        {
            Console.WriteLine("What is your full name?");
            Console.Write("Type your first name: ");
            FirstName = Console.ReadLine();
            infoList.Add(FirstName);
            Console.WriteLine();
            Console.Write("Type your last name: ");
            LastName = Console.ReadLine();
            infoList.Add(LastName);
            Console.WriteLine();
            Console.Write("What is your height? ");
            Height = Console.ReadLine();
            infoList.Add(Height);
            Console.WriteLine();
            Console.Write("What is your weight? ");
            Weight = Console.ReadLine();
            infoList.Add(Weight);
            Console.WriteLine();

        }
    }


    public class WriteAllLines
    {
        public static void WriteToFile(List<string> list)
        {
            var filePath = "C:\\Users\\Business\\temp\\textFiles022Project\\tempTextFiles022Project.txt";

            File.WriteAllLines(filePath, list);
        }
    }


}
