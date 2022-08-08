using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode01_计算数组里相加结果合适的两个值
{
    internal class SumTwo
    {
        #region for方法进行多次遍历
        public void ArrayCalculate(int[] getIntArray, int target)
        {
            int[] n = new int[2];
            //string[] str = new string[];   
            for (int i = 0; i < getIntArray.Length; i++)
            {
                for (int j = i + 1; j < getIntArray.Length; j++)
                {
                    if (getIntArray[i] + getIntArray[j] == target)
                    {
                        n[0] = i;
                        n[1] = j;
                        Console.WriteLine("符合结果的下标是{0},{1}", n[0], n[1]);
                        return;
                    }
                }
            }
            Console.WriteLine("没找到");
            return;
        }
        #endregion
        static void Main(string[] args)
        {
            SumTwo Pro_1 = new SumTwo();
            Console.WriteLine("输入几个数字,以空格隔开");
            string stringArray = Console.ReadLine();
            int[] intArray = Array.ConvertAll(stringArray.Split(' '), int.Parse);

            Console.WriteLine("输入目标结果");
            int target = Convert.ToInt32(Console.ReadLine());

            Pro_1.ArrayCalculate(intArray, target);
            Console.ReadLine();
        }
    }
}
