using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortirovkaSGraphicom
{
    public partial class SortBinInsert : Form
    {
        public SortBinInsert()
        {
            InitializeComponent();
        }

        private void SortBinInsert_Shown(object sender, EventArgs e)
        {
            int[] a = new int[7];
            Random random = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(10);
            }

            List<Bitmap> list = DrawSort.BinSortInsert(a);
            for(int i = 0; i < list.Count; i++)
            {
                BackgroundImage = list[i];
                Thread.Sleep(750);
                this.Refresh();
            }
        }

        private void SortBinInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
