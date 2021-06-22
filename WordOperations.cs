using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class WordOperations
    {
       public enum WordsOfOperation
       {
            ReplaceAllWords = 1,
            CapitalAllWords,
            FindAllWords,
            NumericAllWords,
            RemoveAllWords,
            AlignTextToLeft,
            AlignTextToRight,
            AlignTextToCenter,
       };
        TextFunctionality textfunctionality = new TextFunctionality();
        public void OptionsController(List<string> words, List<string> allLines, int fixedLength)
        {
            bool isContinueFurther = true;
            while (isContinueFurther)
            {
                Console.WriteLine("enter the below operations as \n" +
                    " 1 is for ReplaceAllWords \n" +
                    " 2 is for CapitalAllWords \n" +
                    " 3 is for FindAllWords \n" +
                    " 4 is for NumreicAllWords \n" +
                    " 5 is for RemoveAllWords \n"+
                    " 6 is for AlignTextToLeft \n"+
                    " 7 is for AlignTextToRight \n" +
                    " 8 is for AlignTextToCenter \n" +
                    "foreg: enter 1 , 2 , 3 so on..");
                bool isInteger = int.TryParse(Console.ReadLine(), out int operation);
                if(isInteger)
                {
                    WordsOfOperation wordoperation = (WordsOfOperation)operation;
                    switch (wordoperation)
                    {
                        case WordsOfOperation.ReplaceAllWords:
                            textfunctionality.ReplaceWordWithParticularWord(words);
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.CapitalAllWords:
                            textfunctionality.CapitalizeAllwordsWithParticularWord(words);
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.FindAllWords:
                            textfunctionality.FindAllOccurenceOfWordsAndReturnItsCount(words);
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.NumericAllWords:
                            textfunctionality.FindAllWordsAsNumeric(words);
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.RemoveAllWords:
                            textfunctionality.RemoveAllWordsOccurencewithParticularWord(words);
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.AlignTextToLeft:
                            textfunctionality.DisplayContentOnLeftCenterRightCorners(textfunctionality.AlignTextToLeftCornerOfConsoleScreen(allLines, fixedLength));
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.AlignTextToRight:
                            textfunctionality.DisplayContentOnLeftCenterRightCorners(textfunctionality.AlignTextToRightCornerOfConsoleScreen(allLines, fixedLength));
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        case WordsOfOperation.AlignTextToCenter:
                            textfunctionality.DisplayContentOnLeftCenterRightCorners(textfunctionality.AlignTextToCenterOfConsoleScreen(allLines, fixedLength));
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                        default:
                            Console.WriteLine("you have entered an unknow option.. please choose the correct options");
                            isContinueFurther = IsContinueFurtherProgramExecution();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("you have entered an unknow value please enter again...");
                }
                
            }
        }
        public bool IsContinueFurtherProgramExecution()
        {
            bool isContinueFurther = false;
            Console.WriteLine("\nDo you want to continue Further enter either Yes/No");
            string enterString = Console.ReadLine();
            isContinueFurther = enterString.ToLower().Equals("yes") ? true : false;
            return isContinueFurther;
        }
    }
}
