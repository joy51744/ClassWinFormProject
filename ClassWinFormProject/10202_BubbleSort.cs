﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10202_BubbleSort : Form
    {
        private static int total;

        public _10202_BubbleSort()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int[] myArray = new int[] { 5, 30, 70, 65, 80 };
            textBoxBefore.Text = "排序前：";
            textBoxAfter.Text = "排序後：";
            //顯示排序前的資料
            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                textBoxBefore.Text += myArray[i] + ", ";
            }
            BubbleSort(ref myArray);

            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                textBoxAfter.Text += myArray[i] + ", ";
            }
        }

        private void BubbleSort(ref int[] vArray)
        {
            int i, j, temp;
            for (i = vArray.GetUpperBound(0); i > 0; i--)//第幾輪Pass
            {
                for (j = 0; j < i; j++)
                {
                    if (vArray[j] > vArray[j + 1])
                    {
                        temp = vArray[j];//兩陣列內容互換
                        vArray[j] = vArray[j + 1];
                        vArray[j + 1] = temp;
                        label1.Text = "總共執行" + i.ToString() + "回合" + "\r\n";
                    }
                }
            }
        }

        private void ButtonLowerSort_Click(object sender, EventArgs e)
        {
            int[] myArray = new int[] { 5, 3, 65, 90, 80 };
            textBoxSortBefore.Text = "排序前：";
            textBoxSortAfter.Text = "排序後：";
            //顯示排序前的資料
            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                textBoxSortBefore.Text += myArray[i] + ", ";
            }
            BubbleLowerSort(ref myArray);

            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                textBoxSortAfter.Text += myArray[i] + ", ";
            }
        }

        private void BubbleLowerSort(ref int[] vArray)
        {
            int i, j, temp;
            for (i = vArray.GetUpperBound(0); i > 0; i--)//第幾輪Pass
            {
                for (j = 0; j < i; j++)
                {
                    if (vArray[j] < vArray[j + 1])
                    {
                        temp = vArray[j];//兩陣列內容互換
                        vArray[j] = vArray[j + 1];
                        vArray[j + 1] = temp;
                        label2.Text = "總共執行" + i.ToString() + "回合" + "\r\n";
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _10201_Sort sort = new _10201_Sort();
            this.Visible = false;
            sort.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}