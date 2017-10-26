using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _8queens
{
    public partial class Form1 : Form
    {
        private List<Pair<string, bool[,]>> resultsList1 = new List<Pair<string, bool[,]>>();
        private List<Pair<string, bool[,]>> resultsList2 = new List<Pair<string, bool[,]>>();
        private List<Pair<string, bool[,]>> resultsList3 = new List<Pair<string, bool[,]>>();
        private List<Pair<string, bool[,]>> resultsList4 = new List<Pair<string, bool[,]>>();

        private double[] times = new double[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            this.listBox4.Items.Clear();

            this.resultsList1.Clear();
            this.resultsList2.Clear();
            this.resultsList3.Clear();
            this.resultsList4.Clear();

            this.listBox1.Items.Add(1);
            this.listBox2.Items.Add(1);
            this.listBox3.Items.Add(1);
            this.listBox4.Items.Add(1);

            this.execute(0, 7);
            this.twoThreads();
            this.fourThreads();
            this.eightThreads();

            for (int i = 0; i < this.resultsList1.Count; i++)
            {
                this.listBox1.Items.Add(this.resultsList1[i].first);
                this.listBox2.Items.Add(this.resultsList2[i].first);
                this.listBox3.Items.Add(this.resultsList3[i].first);
                this.listBox4.Items.Add(this.resultsList4[i].first);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = this.listBox1.SelectedItem.ToString();
            bool[,] r = this.getResultMatrix(currentItem, 1);

            Result result = new Result(r);
            result.Text = result.Text + " " + currentItem;
            result.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = this.listBox2.SelectedItem.ToString();
            bool[,] r = this.getResultMatrix(currentItem, 2);

            Result result = new Result(r);
            result.Text = result.Text + " " + currentItem;
            result.Show();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = this.listBox3.SelectedItem.ToString();
            bool[,] r = this.getResultMatrix(currentItem, 3);

            Result result = new Result(r);
            result.Text = result.Text + " " + currentItem;
            result.Show();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = this.listBox4.SelectedItem.ToString();
            bool[,] r = this.getResultMatrix(currentItem, 4);

            Result result = new Result(r);
            result.Text = result.Text + " " + currentItem;
            result.Show();
        }

        private bool[,] getResultMatrix(string item, int list)
        {
            if (list == 1)
            {
                for (int i = 0; i < this.resultsList1.Count; i++)
                {
                    if (this.resultsList1[i].first == item)
                    {
                        return this.resultsList1[i].second;
                    }
                }
            }
            else if (list == 2)
            {
                for (int i = 0; i < this.resultsList2.Count; i++)
                {
                    if (this.resultsList2[i].first == item)
                    {
                        return this.resultsList2[i].second;
                    }
                }
            }
            else if (list == 3)
            {
                for (int i = 0; i < this.resultsList3.Count; i++)
                {
                    if (this.resultsList3[i].first == item)
                    {
                        return this.resultsList3[i].second;
                    }
                }
            }
            else if (list == 4)
            {
                for (int i = 0; i < this.resultsList4.Count; i++)
                {
                    if (this.resultsList4[i].first == item)
                    {
                        return this.resultsList4[i].second;
                    }
                }
            }

            return new bool[8, 8];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0 && this.listBox2.Items.Count > 0 &&
                this.listBox3.Items.Count > 0 && this.listBox4.Items.Count > 0)
            {
                SpeedUp speedUp = new SpeedUp(this.times.ToArray());
                speedUp.Show();
            }
            else
            {
                MessageBox.Show(this, "Gere os resultados antes do cálculo do SpeedUp", "ERRO", MessageBoxButtons.OK);
            }
        }

        private void execute(int inicio, int fim)
        {
            
        }

        private void twoThreads()
        {
            Thread thread = new Thread(() => this.execute(0, 3));
            Thread thread1 = new Thread(() => this.execute(4, 7));

            thread.Start();
            thread1.Start();
        }

        private void fourThreads()
        {
            Thread thread = new Thread(() => this.execute(0, 1));
            Thread thread1 = new Thread(() => this.execute(2, 3));
            Thread thread2 = new Thread(() => this.execute(4, 5));
            Thread thread3 = new Thread(() => this.execute(6, 7));

            thread.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void eightThreads()
        {
            Thread thread = new Thread(() => this.execute(0, 0));
            Thread thread1 = new Thread(() => this.execute(1, 1));
            Thread thread2 = new Thread(() => this.execute(2, 2));
            Thread thread3 = new Thread(() => this.execute(3, 3));
            Thread thread4 = new Thread(() => this.execute(4, 4));
            Thread thread5 = new Thread(() => this.execute(5, 5));
            Thread thread6 = new Thread(() => this.execute(6, 6));
            Thread thread7 = new Thread(() => this.execute(7, 7));

            thread.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
        }
    }
}
