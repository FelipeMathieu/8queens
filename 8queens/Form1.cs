using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8queens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Teste");
            this.listBox1.Items.Add("Teste1");
            this.listBox1.Items.Add("Teste2");
            this.listBox1.Items.Add("Teste3");
            this.listBox1.Items.Add("Teste4");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = this.listBox1.SelectedItem.ToString();

            Result result = new Result();
            result.Text = result.Text + " " + currentItem;
            result.Show();
        }
    }
}
