using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class TextFunctionality
    {
        public string WordEnteredByUser()
        {
            Console.WriteLine("Please Enter the word (i,e.) either find, replaceAll, remove, captilize");
            string enteredWord = Console.ReadLine();
            return enteredWord;
        }
        public void ReplaceWordWithParticularWord(List<string> words)
        {
            Console.WriteLine("Replace all words with the particular word");
            string findWord = WordEnteredByUser();
            if (words.Contains(findWord))
            {
                Console.WriteLine("Enter the word to replace the above word...");
                string replaceWithThisWord = Console.ReadLine();
                words = words.Select(word => word.Equals(findWord) ? word.Replace(word, replaceWithThisWord) : word).ToList();
                UsingStringBufferToStoreWordsFromDifferentFunctions(words);
            }
            else
            {
                Console.WriteLine("No such word found in the list of words please try again !!");
            }
        }
        public struct StoredWordsLines
        {
            public List<string> wordsOfTextFile;
            public List<string> linesOfTextFile;
        }
        public StoredWordsLines ReadTextFileAsWords(string filePath)     
        {
            StoredWordsLines storedwordslines = new StoredWordsLines();
            string text = File.ReadAllText(filePath);
            string[] lines = File.ReadAllLines(filePath);
            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> wordsOfTextFile = (from word in words select word).ToList();
            storedwordslines.wordsOfTextFile = wordsOfTextFile;
            storedwordslines.linesOfTextFile = lines.ToList();
            return storedwordslines;
        }
        public void FindAllOccurenceOfWordsAndReturnItsCount(List<string> words)    
        {
            Console.WriteLine("Finding all occurence of words in text file with the particular word");
            string userInput = WordEnteredByUser();
            if (words.Contains(userInput))
            {
                List<string> ListOfAllOccurenceOfWords = (from word in words where word.Equals(userInput) select word).ToList();
                Console.WriteLine("The count of occurence of words in the text file is :" + ListOfAllOccurenceOfWords.Count());
                UsingStringBufferToStoreWordsFromDifferentFunctions(ListOfAllOccurenceOfWords);
            }
            else
            {
                Console.WriteLine("No such word found in the list of words");
            }
        }
        public void RemoveAllWordsOccurencewithParticularWord(List<string> words)
        {
            Console.WriteLine("Removing all occurennce of words in text file with the particular word");
            string userInput = WordEnteredByUser();
            if (words.Contains(userInput))
            {
                words.RemoveAll(word=>word.Equals(userInput));
                UsingStringBufferToStoreWordsFromDifferentFunctions(words);
            }
            else
            {
                Console.WriteLine("No such word is present in the list of words");
            }
        }
        public void DisplayContentOnLeftCenterRightCorners(StringBuilder contents)         //Displaying text on console
        {
            Console.WriteLine(contents.ToString());
        }
        public StringBuilder AlignTextToRightCornerOfConsoleScreen(List<string> lines, int fixedLength)  // right of screen
        {
            StringBuilder alignTextToRightCorner = new StringBuilder();
            foreach (var line in lines)
            {
                string textLine = line.Trim();
                alignTextToRightCorner.Append(textLine.PadLeft((fixedLength - textLine.Length) + textLine.Length));
            }
            return alignTextToRightCorner;
        }
        public StringBuilder AlignTextToLeftCornerOfConsoleScreen(List<string> lines , int fixedLength)   //Left of screen
        {
            StringBuilder alignedTextToLeftCorner = new StringBuilder();
            foreach (var line in lines)
            {
                alignedTextToLeftCorner.Append(line.PadRight((fixedLength - line.Length) + line.Length));
            }
            return alignedTextToLeftCorner;
        }
        public StringBuilder AlignTextToCenterOfConsoleScreen(List<string> lines, int fixedLength)     //center of screen
        {
            StringBuilder alignedTextToCenterScreen = new StringBuilder();
            foreach (var line in lines)
            {
                alignedTextToCenterScreen.AppendLine((line.PadLeft((fixedLength - line.Length)/2 + line.Length)));
            }
            return alignedTextToCenterScreen;
        }
        public void FindAllWordsAsNumeric(List<string> words)
        {
            Console.WriteLine("Finding all the numreic string in the text file");
            int countNumreicWord = 0;
            List<string> listOfNumrericString = new List<string>();
            foreach (string word in words)
            {
                bool isReturned = InnerFunctionalityOfFindAllwordsAsNumeric(word);
                if (isReturned)
                {
                    countNumreicWord++;
                    listOfNumrericString.Add(word);
                }
            }
            Console.WriteLine("Total count of Numeric string in different format is : " +listOfNumrericString.Count);
            Console.WriteLine("Printing the numeric String in text file as Below ");
            UsingStringBufferToStoreWordsFromDifferentFunctions(listOfNumrericString);
        }
        public bool InnerFunctionalityOfFindAllwordsAsNumeric(string word)
        {
            bool isIntInWord = int.TryParse(word, out int resultInInt);
            bool isFloatInWord = float.TryParse(word, out float resultInFloat);
            bool isDoubleInWord = double.TryParse(word, out double resultIDouble);
            bool isLongInWord = long.TryParse(word, out long resultInLong);
            bool isShortInword = short.TryParse(word, out short resultInShort);
            return isIntInWord || isFloatInWord || isShortInword || isDoubleInWord || isLongInWord;
        }
        public void UsingStringBufferToStoreWordsFromDifferentFunctions(List<string> words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            words.ForEach(word => stringBuilder.Append(word).Append(" "));
            Console.WriteLine("Result after operation is : " + stringBuilder.ToString());
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
        public void CapitalizeAllwordsWithParticularWord(List<string> words)
        {
            Console.WriteLine("Capitalize all words in text with the particular word");
            string userInput = WordEnteredByUser();
            if (words.Contains(userInput))
            {
                words = words.Select(word => word.Equals(userInput) ? word.ToUpper() : word).ToList();
                UsingStringBufferToStoreWordsFromDifferentFunctions(words);
            }
            else
            {
                Console.WriteLine("Please Enter the input such that it matches with the list of words");
            }
        }
    }
}
