using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_ExtensionMethod
{
    public static class myUtils
    { /* Câu 1 : Cài đặt 1 hàm TongTu1toN
       * vào kiểu int của microsoft
       */
        public static int TongTu1toN(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int Cong(this int a, int b)
        {
            return a + b;
        }
        public static void SapXepTangDan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void TaoMang(this int[] arr)
        {
            Random random = new Random();
            for(int i = 0;i < arr.Length;i++)
            {
                arr[i] = random.Next(100);
            }
        }
        public static void XuatMang(this int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
