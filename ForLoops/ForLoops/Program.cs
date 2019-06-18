using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,5,6,3,8,9 };
            for (int i=0;i<nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();
        }
    }
}
