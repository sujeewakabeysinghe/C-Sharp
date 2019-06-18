using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,8,6,4,1,0,9,4,3,7 };
            string[] names = new string[5];
            names[0] = "sujeewa";
            names[1] = "hiruni";
            names[2] = "kasun";
            names[3] = "palitha";
            Console.WriteLine(nums[5]);
            Console.WriteLine(nums.Length);
            Console.WriteLine(names[2]);
            Console.WriteLine(names.Length);

            int[,] twoDimentionArray = {
                { 1,5,9,8 },
                { 7,2,0,2 },
                { 9,4,3,7 }
            };
            Console.WriteLine(twoDimentionArray[1,3]);

            Console.ReadLine();
        }
    }
}
