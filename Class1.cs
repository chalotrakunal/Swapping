using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Class1
    {


        public void SentToFunc(string stringInput)
        {
            List<int> list = new List<int>();
            char[] result1 = stringInput.ToCharArray();

            var result = from chars in result1 group chars by chars;

            foreach (var grp in result)
            {
                list.Add(grp.Count());
            }
            list.Sort();
            int last = list.Count();

            int lastOne = list[last - 1];

            int index = 0,sum=0;
            while(index<list.Count()-1)
            {
                 sum += list[index];

            }
            if(sum==lastOne)
                Console.WriteLine("Dynamic");
            else
                Console.WriteLine("Not");
        }
        public static void Main()
        {
            Test pr = new Test();
            int case11 = int.Parse(Console.ReadLine());
            for (int k = 0; k < case11; k++)
            {

                string stringInput = Console.ReadLine();

                pr.SentToFunc(stringInput);


            }
        }
    }
}
