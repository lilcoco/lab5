using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        FileOperations file = new FileOperations();
        CompBuilder cb = new CompBuilder();
        public Form1()
        {
            InitializeComponent();

            // Set the ListBox values
            methods.Items.AddRange(file.getModules().ToArray());

            // Set the current Value
            currValue.Text = cb.getCurrValue().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb = new CompBuilder(cb.getCurrValue(), Convert.ToDouble(inputTextBox.Text), (String)methods.SelectedItem);
            outputLabel.Text = cb.execute().ToString();

            currValue.Text = cb.getCurrValue().ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine((String)methods.SelectedItem);
            if ((String)methods.SelectedItem == "Log")
            {
                inputTextBox.Enabled = false;
            }
            else
            {
                inputTextBox.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
