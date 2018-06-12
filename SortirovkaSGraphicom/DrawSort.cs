using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortirovkaSGraphicom
{
    public class DrawSort
    {
        public static Bitmap DrawIter(int[] a, int k, int l,int q, int qq)
        {
            Bitmap bitmap = new Bitmap(400,200);
            Graphics graphics = Graphics.FromImage(bitmap);
            for(int i = 0; i < a.Length; i++)
            {
                if (i == k)
                {
                    graphics.FillRectangle(Brushes.Yellow, 5 + 30 *i, 5, 30, 30);
                }
                if (i == l)
                {
                    graphics.FillRectangle(Brushes.Orange, 5 + 30 * i, 5, 30, 30);
                }
                if (i == q)
                {
                    graphics.FillRectangle(Brushes.Blue, 5 + 30 * i, 5, 30, 30);
                }
                if (i == qq)
                {
                    graphics.FillRectangle(Brushes.BlueViolet, 5 + 30 * i, 5, 30, 30);
                }
                graphics.DrawRectangle(new Pen(Color.Black), 5 + 30 * i, 5, 30, 30);
                graphics.DrawString(Convert.ToString(a[i]), new Font("Arial", 22), Brushes.Black, 5 + 30 * i, 5);
            }
            return bitmap;
        }

        public static List<Bitmap> SortInsert(int[] mas)
        {
            List<Bitmap> sortlist = new List<Bitmap>();
            sortlist.Add(DrawIter(mas, -1, -1, -1, -1));
            for(int i = 1; i < mas.Length; i++)
            {
                sortlist.Add(DrawIter(mas, i, -1, -1, -1));
                int j = i;
                int tmp = mas[j];
                while(j>0 && tmp < mas[j - 1])
                {
                    sortlist.Add(DrawIter(mas, i, j, -1, -1));
                    mas[j] = mas[j - 1];
                    sortlist.Add(DrawIter(mas, i, j, -1, -1));
                    j--;
                    sortlist.Add(DrawIter(mas, i, j, -1, -1));
                }
                sortlist.Add(DrawIter(mas, i, j, i, j));
                mas[j] = tmp;
                sortlist.Add(DrawIter(mas, i, j, i, j));
            }
            sortlist.Add(DrawIter(mas, -1, -1, -1, -1));
            return sortlist;
        }

        public static List<Bitmap> BinSortInsert(int[] InputeArr)
        {
            List<Bitmap> returnlist = new List<Bitmap>();
            returnlist.Add(DrawIter(InputeArr, -1, -1, -1, -1));
            for (int i = 0; i < InputeArr.Length; i++)
            {
                returnlist.Add(DrawIter(InputeArr, i, -1, -1, -1));
                int num = InputeArr[i];
                int Left = 0, Right = i - 1;
                returnlist.Add(DrawIter(InputeArr, i, -1, Left, Right));
                while (Left <= Right)
                {
                    if (InputeArr[(Left + Right) / 2] > num)
                    {
                        returnlist.Add(DrawIter(InputeArr, i, (Left + Right) / 2, Left, Right));
                        Right = (Left + Right) / 2 - 1;
                        returnlist.Add(DrawIter(InputeArr, i, (Left + Right) / 2, Left, Right));
                    }
                    else
                    {
                        returnlist.Add(DrawIter(InputeArr, i, (Left + Right) / 2, Left, Right));
                        Left = (Left + Right) / 2 + 1;
                        returnlist.Add(DrawIter(InputeArr, i, (Left + Right) / 2, Left, Right));
                    }
                }
                for (int k = i; k > Left; k--)
                {
                    returnlist.Add(DrawIter(InputeArr, i, Left, k, k - 1));
                    InputeArr[k] = InputeArr[k - 1];
                    returnlist.Add(DrawIter(InputeArr, i, Left, k, k - 1));
                }
                returnlist.Add(DrawIter(InputeArr, i, Left, i, Left));
                InputeArr[Left] = num;
                returnlist.Add(DrawIter(InputeArr, i, Left, i, Left));
            }

            returnlist.Add(DrawIter(InputeArr, -1, -1, -1, -1));
            return returnlist;
        }

    }
}
