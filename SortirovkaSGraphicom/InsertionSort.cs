using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortirovkaSGraphicom
{
    public partial class InsertionSort : Form
    {
        public InsertionSort()
        {
            InitializeComponent();
        }

        private void buttonDrawGraphics_Click(object sender, EventArgs e)
        {
            chartGraphics.Series[0].Points.Clear();
            chartGraphics.Series[1].Points.Clear();
            chartGraphics.Series[2].Points.Clear();
            chartComparison.Series[0].Points.Clear();
            chartComparison.Series[1].Points.Clear();
            chartComparison.Series[2].Points.Clear();
            int count = 0;
            int srav = 0;
            //int[] arr1 = new int[16] { 20,19,18,17,16,14,13,12,11,10,9,22,23,23,24,35};
            //int[] arr2 = new int[8] { 5, 4, 6, 7, 8, 9, 10, 3 };
            //int[] arr4 = new int[10] { 5, 4, 3, 2, 1, 9, 10, 13, 12, 11 };
            //int count1 = Utils.SortInsertion(arr1);
            //int count2 = Utils.SortInsertion(arr2);
            //int count4 = Utils.SortInsertion(arr4);
            //chartGraphics.Series[1].Points.AddXY(arr1.Length, count1);
            //chartGraphics.Series[1].Points.AddXY(arr2.Length, count2);
            //chartGraphics.Series[1].Points.AddXY(arr4.Length, count4);
            //for (int i = 100; i < 1000; i += 1)
            //{
            //int[] arr1 = Utils.CreateRandomIntArr(i);
            //Utils.SortInsertion(arr1,out count,out srav);
            //chartGraphics.Series[1].Points.AddXY(arr1.Length, count);
            //chartComparison.Series[1].Points.AddXY(arr1.Length, srav);
            //}
            //for (int i = 100; i < 1000; i += 1)
            //{
            //    int[] arr2 = Utils.CreateRandomIntArr(i);
            //    Utils.SortBinInsert(arr2,out count, out srav);
            //    chartGraphics.Series[0].Points.AddXY(arr2.Length, count);
            //    chartComparison.Series[0].Points.AddXY(arr2.Length, srav);
            //}
            //for (int i = 100; i < 1000; i += 1)
            //{
            //    int[] arr3 = Utils.CreateRandomIntArr(i);
            //    Utils.SortBuble(arr3, out count, out srav);
            //    chartGraphics.Series[2].Points.AddXY(arr3.Length, count);
            //    chartComparison.Series[2].Points.AddXY(arr3.Length, srav);
            //}

            for (int i = 100; i < 1000; i += 1)
            {
                int[] arr1 = Utils.CreateRandomIntArr(i);
                int[] arr2 = new int[arr1.Length];
                int[] arr3 = new int[arr1.Length];
                for (int j = 0; j < arr1.Length; j++)
                {
                    arr2[j] = arr1[j];
                    arr3[j] = arr1[j];
                }
                Utils.SortInsertion(arr1, out count, out srav);
                chartGraphics.Series[1].Points.AddXY(arr1.Length, count);
                chartComparison.Series[1].Points.AddXY(arr1.Length, srav);
                Utils.SortBinInsert(arr2, out count, out srav);
                chartGraphics.Series[0].Points.AddXY(arr2.Length, count);
                chartComparison.Series[0].Points.AddXY(arr2.Length, srav);
                Utils.SortBuble(arr3, out count, out srav);
                chartGraphics.Series[2].Points.AddXY(arr3.Length, count);
                chartComparison.Series[2].Points.AddXY(arr3.Length, srav);
            }

        }

        private void chartGraphics_Click(object sender, EventArgs e)
        {

        }

        private void DemoSortInsertion_Click(object sender, EventArgs e)
        {
            SortInsert form = new SortInsert();
            form.ShowDialog();
        }

        private void DemoBinSort_Click(object sender, EventArgs e)
        {
            SortBinInsert form = new SortBinInsert();
            form.ShowDialog();
        }
    }
}
