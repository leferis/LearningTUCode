using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TULearning
{
    public partial class Form1 : Form
    { 
        int questionsCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question Form2 = new Question(questionsCount);
            
            this.Hide();
            Form2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count;
            int.TryParse(textBox1.Text, out count);
            questionsCount = count;
            if(questionsCount > 0)
            {
                button1.Enabled = true;
            }

        }
    }
}
