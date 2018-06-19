using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnapSackTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void solveButton_Click(object sender, EventArgs e)
        {

            //int[] value = { 20,30,25,6,10 };
            string[] valueStr = valueBox.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int[] value = new int[valueStr.Length];
            for (int i = 0; i < valueStr.Length; i++)
            {
                value[i] = Int32.Parse(valueStr[i]);
            }

            //int[] weight = { 55, 10, 20, 30,50 };
            string[] weightStr = weightBox.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int[] weight = new int[weightStr.Length];
            for (int i = 0; i < weightStr.Length; i++)
            {
                weight[i] = Int32.Parse(weightStr[i]);
            }

            int capacity = Int32.Parse(capacityBox.Text);
            int itemsCount = weight.Length;

            int result = SolveKnapSack(capacity, weight, value, itemsCount);

            resultBox.Text = "Value Result : "+result.ToString()+"\n";

        }

        public static int SolveKnapSack(int capacity, int[] weight, int[] value, int itemsCount)
        {
            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int w = 0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (weight[i - 1] <= w)
                        K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[itemsCount, capacity];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
