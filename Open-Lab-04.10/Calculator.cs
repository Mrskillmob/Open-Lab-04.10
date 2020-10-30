using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float vys = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                vys = vys + nums[i];
            }return vys / nums.Length;
        }      
    }
}
