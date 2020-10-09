using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOfSelectOperation
{
    
    // 定义委托-find the even value
    delegate bool FindEven(int item);

    class Program
    {
        static void Main(string[] args)
        {
            
            //in the histroy, we use this kind of method
            // 查询出数组中的偶数并排序
            int[] ints = { 5, 2, 0, 66, 4, 32, 7, 1 };
            // 定义一个整数类型的集合，用来存放数组中的偶数
            List<int> list = new List<int>();
            // 遍历数组查询出偶数放到集合中
            foreach (int i in ints)
            {
                // 如果是偶数，把偶数加入到集合中
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
            }

            // 正序排序
            list.Sort();
            // 反转
            list.Reverse();
            // 输出
            Console.WriteLine(string.Join(",", list));


            ///===============================================//
            //now we use LINQ（Language Integrated Query）即语言集成查询。
            //delegate(int item){return item % 2 == 0;}表示委托的实现
            List<int> list2 = IntExtension.where(ints, delegate (int item)
            {
             return item % 2 == 0;
            }).ToList();
            // 正序排序
            list2.Sort();
            // 反转
            list2.Reverse();
            // 输出
            Console.WriteLine(string.Join(",", list2));
            ///===============================================//



            Console.ReadKey();
        }
    }

     class IntExtension
     {
         public static int[] where(int[] array, FindEven deleg)
         {
             int[] result = new int[5];
             int i = 0;
             foreach (int item in array)
             {
                 if (deleg(item))
                 {
                    result[i]=item;
                    i++;
                 }
             }
             return result;
         }
     }
}
