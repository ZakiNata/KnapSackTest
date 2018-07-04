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

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void LPButton_Click(object sender, EventArgs e)
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


            List<Bag.Item> knapsackItems = new List<Bag.Item>();

            for (int j=0; j< itemsCount;j++)
            {
                knapsackItems.Add(new Bag.Item() { Name = weight[j].ToString(), Weight = weight[j], Value = value[j] });
            }

            Bag b = new Bag();
            
            b.setCapacity(capacity);
            b.Calculate(knapsackItems);
            //b.All(x => { Console.WriteLine(x); return true; });
            //Console.WriteLine(b.Sum(x => x.Weight));
            //Console.ReadKey();

            LPBox.Text = b.Sum(x => x.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "50";
            weightBox.Text = "30,50,10,20";
            valueBox.Text = "5,40,15,50";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "100";
            weightBox.Text = "30,50,10,20,120,10,50";
            valueBox.Text = "5,40,15,50,400,150,70";
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
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


            List<Bag.Item> knapsackItems = new List<Bag.Item>();

            for (int j = 0; j < itemsCount; j++)
            {
                knapsackItems.Add(new Bag.Item() { Name = weight[j].ToString(), Weight = weight[j], Value = value[j] });
            }

            Bag b = new Bag();

            b.setCapacity(capacity);

            List<Bag.Item> choosenItems = new List<Bag.Item>();
            choosenItems = b.DynamicProgramming(knapsackItems);
            resultBox.Text = choosenItems.Sum(x => x.Value).ToString();
        }



        private void Sample3Button_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "7";
            weightBox.Text = "1,3,4,5";
            valueBox.Text = "1,4,5,7";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SolveKsButton_Click(object sender, EventArgs e)
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //// the code that you want to measure comes here
            //watch.Stop();
            //var elapsedMs = watch.ElapsedMilliseconds;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            LPButton_Click(sender, e);
            watch.Stop();
            var LPelapsedMs = watch.ElapsedMilliseconds;
            var LPTicks = watch.ElapsedTicks;
            LPRuntimeBox.Text = LPelapsedMs.ToString()+" , "+LPTicks.ToString();

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            DynamicButton_Click(sender, e);
            watch2.Stop();
            var DPelapsedMs = watch2.ElapsedMilliseconds;
            var DPTicks = watch2.ElapsedTicks;
            DPRuntimeBox.Text = DPelapsedMs.ToString()+" , "+DPTicks.ToString();

            //BFbutton_Click
            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            BFbutton_Click(sender, e);
            watch3.Stop();
            var BFelapsedMs = watch3.ElapsedMilliseconds;
            var BFTicks = watch3.ElapsedTicks;
            BFRuntimeBox.Text = BFelapsedMs.ToString() + " , " + BFTicks.ToString();
        }

        private void BFbutton_Click(object sender, EventArgs e)
        {
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


            List<Bag.Item> knapsackItems = new List<Bag.Item>();

            for (int j = 0; j < itemsCount; j++)
            {
                knapsackItems.Add(new Bag.Item() { Name = weight[j].ToString(), Weight = weight[j], Value = value[j] });
            }

            Bag b = new Bag();

            b.setCapacity(capacity);

            List<Bag.Item> choosenItems = new List<Bag.Item>();
            choosenItems = b.BruteForce(knapsackItems);
            BFBox.Text = choosenItems.Sum(x => x.Value).ToString();
        }
    }

    class Bag : IEnumerable<Bag.Item>
    {
        List<Item> items;
        int MaxWeightAllowed;

        public Bag()
        {
            items = new List<Item>();
        }

        void AddItem(Item i)
        {
            if ((TotalWeight + i.Weight) <= MaxWeightAllowed)
                items.Add(i);
        }

        public void setCapacity(int capacity)
        {
            MaxWeightAllowed = capacity;
        }

        public List<Bag.Item> DynamicProgramming(List<Item> items)
        {
            List<Bag.Item> choosenItems = new List<Bag.Item>();
            int itemsCount = items.Count;
            int capacity = MaxWeightAllowed;
            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int w = 0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (items[i - 1].Weight <= w) 
                        K[i, w] = Math.Max(items[i - 1].Value + K[i - 1, w - items[i - 1].Weight], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            int m = capacity;
            int n = itemsCount;

            while (m >= 0 && n >= 0)
            {
                if (m == 0 || n == 0 || K[n, m] == 0)
                {
                    if (K[n, m] == 0)
                        break;
                    else
                    {
                        choosenItems.Add(items[0]);
                        n--;
                    }
                }
                else if (K[n, m] == K[n - 1, m])
                {
                    n--;
                }
                else if (K[n, m] == K[n, m - 1])
                {
                    m--;
                }
                else if (K[n,m] != K[n - 1, m] && K[n, m] != K[n, m-1])
                {
                    choosenItems.Add(items[n-1]);
                    m -= items[n - 1].Weight;
                    n --;
                }

            }

            return choosenItems;
        }


        public List<Bag.Item> BruteForce(List<Item> items)
        {
            List<Bag.Item> choosenItems = new List<Bag.Item>();
            int itemsCount = items.Count;
            int capacity = MaxWeightAllowed;
            int[,] permutations = new int[(int)Math.Pow(2,itemsCount), itemsCount];

            for (int i = 0; i < permutations.GetLength(0); i++)
                for (int j = 0; j < permutations.GetLength(1); j++)
                    permutations[i,j] = 0;

            for(int k=0;k < permutations.GetLength(0); k++)
            {
                string binary = Convert.ToString(k, 2);
                int temp = int.Parse(binary);

                for (int l=0; l < binary.Length ;l++)
                {
                    int bit = temp % 10;
                    temp = temp / 10;
                    permutations[k, l] = bit;
                }
            }

            int maxValue = 0;
            int chosenPermutation = -1;

            for (int m = 0; m < permutations.GetLength(0); m++)
            {
                int currentValue = 0;
                int currentWeight = 0;
                for (int n = 0; n < permutations.GetLength(1); n++)
                {
                    currentValue += permutations[m, n] * items[n].Value;
                    currentWeight += permutations[m, n] * items[n].Weight;
                }

                if (currentValue > maxValue && currentWeight <= capacity)
                {
                    maxValue = currentValue;
                    chosenPermutation = m;
                }
            }

            for (int n = 0; n < permutations.GetLength(1); n++)
            {
                if(permutations[chosenPermutation,n]==1)
                {
                    choosenItems.Add(items[n]);
                }
            }

            return choosenItems;
        }

        public void Calculate(List<Item> items)
        {
            foreach (Item i in Sorte(items))
            {
                AddItem(i);
            }
        }

        List<Item> Sorte(List<Item> inputItems)
        {
            List<Item> choosenItems = new List<Item>();
            for (int i = 0; i < inputItems.Count; i++)
            {
                int j = -1;
                if (i == 0)
                {
                    choosenItems.Add(inputItems[i]);
                }
                if (i > 0)
                {
                    if (!RecursiveF(inputItems, choosenItems, i, choosenItems.Count - 1, false, ref j))
                    {
                        choosenItems.Add(inputItems[i]);
                    }
                }
            }
            return choosenItems;
        }

        bool RecursiveF(List<Item> knapsackItems, List<Item> choosenItems, int i, int lastBound, bool dec, ref int indxToAdd)
        {
            if (!(lastBound < 0))
            {
                if (knapsackItems[i].ResultWV < choosenItems[lastBound].ResultWV)
                {
                    indxToAdd = lastBound;
                }
                return RecursiveF(knapsackItems, choosenItems, i, lastBound - 1, true, ref indxToAdd);
            }
            if (indxToAdd > -1)
            {
                choosenItems.Insert(indxToAdd, knapsackItems[i]);
                return true;
            }
            return false;
        }

        #region IEnumerable<Item> Members
        IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
        {
            foreach (Item i in items)
                yield return i;
        }
        #endregion

        #region IEnumerable Members
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
        #endregion

        public int TotalWeight
        {
            get
            {
                var sum = 0;
                foreach (Item i in this)
                {
                    sum += i.Weight;
                }
                return sum;
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Value { get; set; }
            public int ResultWV { get { return Weight - Value; } }
            public override string ToString()
            {
                return "Name : " + Name + "        Weight : " + Weight + "       Value : " + Value + "     ResultWV : " + ResultWV;
            }
        }
    }
}
