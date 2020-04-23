using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            WordOperations wordoperations = new WordOperations();
            TextFunctionality text = new TextFunctionality();
            Console.WriteLine("Enter the file path location :");
            string filePathLocation = Console.ReadLine();
            Console.WriteLine("Enter the fixed length of the string that can be embeded on console screen :");
            try
            {
                int fixedLength = int.Parse(Console.ReadLine());
                TextFunctionality.StoredWordsLines storedwordsLines = text.ReadTextFileAsWords(filePathLocation);
                wordoperations.OptionsController(storedwordsLines.wordsOfTextFile, storedwordsLines.linesOfTextFile, fixedLength);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
