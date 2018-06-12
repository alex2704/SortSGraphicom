using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortirovkaSGraphicom
{
    public class Utils
    {
        public static int[] SortInsertion(int[] mas, out int count, out int srav)
        {
            count = 0;
            srav = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                int j = i;
                int tmp = mas[j];
                srav++;
                //if (j > 0 && tmp < mas[j - 1])
                //{
                while (j > 0 && tmp < mas[j - 1])
                {
                    srav++;
                    mas[j] = mas[j - 1];
                    j--;
                    count++;
                }
                //count++;
                //}
                mas[j] = tmp;
                count++;
                srav++;
            }
            return mas;
        }

        public static int[] SortBinInsert(int[] a, out int count, out int srav)
        {
            count = 0;
            srav = 0;
            for (int i = 0; i < a.Length; i++)
            {
                srav++;
                int num = a[i];
                int Left = 0, Right = i - 1;
                while (Left <= Right)
                {
                    srav++;
                    if (a[(Left + Right) / 2] > num)
                    {
                        srav++;
                        Right = (Left + Right) / 2 - 1;
                    }
                    else
                    {
                        Left = (Left + Right) / 2 + 1;
                    }
                }
                for (int k = i; k > Left; k--)
                {
                    srav++;
                    a[k] = a[k - 1];
                    count++;
                }
                a[Left] = num;
                count++;
            }
            return a;
        }

        public static int[] CreateRandomIntArr(int length)
        {
            Random r = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = r.Next(int.MaxValue);
            }
            return arr;
        }
        public static int[] SortBuble(int[] InputeArr, out int count, out int numsrav)
        {
            count = 0;
            numsrav = 0;
            for (int i = 0; i < InputeArr.Length - 1; i++)
            {
                numsrav++;
                for (int j = i + 1; j < InputeArr.Length; j++)
                {
                    numsrav++;
                    if (InputeArr[i] < InputeArr[j])
                    {
                        numsrav++;
                        int k = InputeArr[i];
                        count++;
                        InputeArr[i] = InputeArr[j];
                        count++;
                        InputeArr[j] = k;
                        count++;
                    }
                }
            }
            return InputeArr;
        }
    }

}
