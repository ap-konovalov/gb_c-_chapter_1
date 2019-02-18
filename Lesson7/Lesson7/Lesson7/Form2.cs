using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form2 : Form
    {
        static Random rndNumber = new Random();
        public int number = rndNumber.Next(1, 100);


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int enteredAnswer = Int32.Parse(enteredNumber.Text);


                if (enteredAnswer == number)
                {
                    MessageBox.Show("Успех!", "Вы угадали");
                }
                else if (enteredAnswer > number)
                {
                    lblHint.Text = "Много";
                    enteredNumber.Text = "";
                }
                else
                {
                    lblHint.Text = "Мало";
                    enteredNumber.Text = "";
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = rndNumber.Next(1, 100);
        }
    }
}
