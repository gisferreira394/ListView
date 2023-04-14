using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
             textBox4.Clear();
            textBox1.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ID não pode estar vazio!!");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Produto não inserido !!");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Insira a quantidade !!");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Insira um preço !!");
                textBox4.Focus();
                return;
            }

            String[] produtos = new String[4];
            produtos[0] = textBox1.Text;
            produtos[1] = textBox2.Text;
            produtos[2] = textBox3.Text;
            produtos[3] = textBox4.Text;

            ListViewItem L = new ListViewItem(produtos);
            listView1.Items.Add(L);
            limpar();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }
    }
}
