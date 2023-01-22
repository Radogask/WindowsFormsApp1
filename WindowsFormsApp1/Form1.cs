using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int global;
        
        public void Form1_Load_1(object sender, EventArgs e)
        {
            Disk d1 = new Disk();
            Disk d2 = new Disk();
            Disk d3 = new Disk();

            d1.type = "DVD";            
            d2.type = "CD-R";
            d3.type = "mini-disc";

            comboBox1.Items.Add(d1.type);
            comboBox1.Items.Add(d2.type);
            comboBox1.Items.Add(d3.type);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
   
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "DVD")
            {
                comboBox2.Items.Clear();
                Disk d1 = new Disk();
                d1.category = "фильм";
                comboBox2.Items.Add(d1.category);
            }
            if (comboBox1.SelectedItem.ToString() == "CD-R")
            {
                comboBox2.Items.Clear();
                Disk d2 = new Disk();
                d2.category = "фильм";
                comboBox2.Items.Add(d2.category);
                d2.category = "музыка";
                comboBox2.Items.Add(d2.category);
            }
            if (comboBox1.SelectedItem.ToString() == "mini-disc")
            {
                comboBox2.Items.Clear();
                Disk d3 = new Disk();
                d3.category = "ПО";
                comboBox2.Items.Add(d3.category);
            }
        }
        
        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            global += 1;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "DVD" && comboBox2.SelectedItem.ToString() == "фильм")
            {
                if (global != 0)
                {
                    textBox1.Clear();
                    Disk d1 = new Disk();
                    d1.description = textBox1.Text;
                    textBox1.Text = d1.description;
                    global = 0;
                }
                else
                {
                    textBox1.Text = "DVD фильм";
                }
            }
            if (comboBox1.SelectedItem.ToString() == "CD-R" && comboBox2.SelectedItem.ToString() == "фильм")
            {
                if (global != 0)
                {
                    textBox1.Clear();
                    Disk d2 = new Disk();
                    d2.description = textBox1.Text;
                    textBox1.Text = d2.description;
                    global = 0;
                }
                else
                {
                    textBox1.Text = "CD-R фильм";
                }
                
            }
            if (comboBox1.SelectedItem.ToString() == "CD-R" && comboBox2.SelectedItem.ToString() == "музыка")
            {
                if (global != 0)
                {
                    textBox1.Clear();
                    Disk d2 = new Disk();
                    d2.description = textBox1.Text;
                    textBox1.Text = d2.description;
                    global = 0;
                }
               
                 else
                {
                    textBox1.Text = "CD-R музыка";
                }
            }
           
            if (comboBox1.SelectedItem.ToString() == "mini-disc" && comboBox2.SelectedItem.ToString() == "ПО")
            {
                if (global != 0)
                {
                    Disk d3 = new Disk();
                    d3.description = textBox1.Text;
                    textBox1.Text = d3.description;
                    global = 0;
                }
                else
                {
                    textBox1.Text = "mini-disc ПО";
                }
            }
            
        }
        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void Form1_Load(object sender, EventArgs e)
        { }
    }

}
