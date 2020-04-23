using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Class2
    {

        public void SentToFunc(string stringInput)
        {
            List<int> list = new List<int>();
            char[] result1 = stringInput.ToCharArray();
            var result = from chars in result1 group chars by chars;
            bool lessThanThree = false;
            int count = 0;
            foreach (var grp in result)
            {
                list.Add(grp.Count());
                if (grp.Count() > 3)
                    count++;
            }
            list.Sort();
            foreach(var inte in list)
            {
                lessThanThree = true; ;
            }
            int last = list.Count();
            int lastOne = list[last - 1];
            int index = 0, sum = 0;
            while (index < last-1)
            {
                sum += list[index];
                index++;
            }
            bool isLessthan = list.Contains(1) || list.Contains(2) ? true : false;
            if (sum == lastOne )
            {
                Console.WriteLine("Dynamic");

                
            }
            else
            {
                if(isLessthan)
                    Console.WriteLine("Dynamic");
                else
                Console.WriteLine("not");
            }
                
            
                
        }
        public static void Main()
        {
            Class2 pr = new Class2();
            int case11 = int.Parse(Console.ReadLine());
            for (int k = 0; k < case11; k++)
            {

                string stringInput = Console.ReadLine();

                pr.SentToFunc(stringInput);


            }
        }
    }
}