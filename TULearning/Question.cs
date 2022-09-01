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
    public partial class Question : Form
    {
        public Question(int questionCount)
        {
            InitializeComponent();
            //OnInit the API should be queried for questions URL: https://opentdb.com/api_config.php
        }

        public Question(object newClass) //Should pass next LinkedList 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invokeNext(); // Should check if the user has answered correctly and mark the results
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void invokeNext()
        {
            Question Form2 = new Question(new object()); // Create new  Form, pass results and questions
            this.Hide();
            Form2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
