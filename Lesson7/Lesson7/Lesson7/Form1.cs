using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Application;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Stack<string> _resultStack = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
            btnPlus.Text = "+1";
            btnReset.Text = "Сброс";
            btnMultiply.Text = "x2";
            lblNumberResult.Text = "0";
            this.Text = "Удвоитель";
        }

        private void WinCheck(string result)
        {
            if (lblExpectedResult.Text == result)
            {
                MessageBox.Show("ПОБЕДА!!!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumberResult.Text = "0";
            lblOperationsCount.Text = "0";
            lblExpectedResult.Text = "-";
            _resultStack.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNumberResult.Text = (int.Parse(lblNumberResult.Text) + 1).ToString();

            lblOperationsCount.Text = (int.Parse(lblOperationsCount.Text) + 1).ToString();

            _resultStack.Push(lblNumberResult.Text);

            WinCheck(lblNumberResult.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblNumberResult.Text = (int.Parse(lblNumberResult.Text) * 2).ToString();

            lblOperationsCount.Text = (int.Parse(lblOperationsCount.Text) + 1).ToString();

            _resultStack.Push(lblNumberResult.Text);

            WinCheck(lblNumberResult.Text);
        }

        private void игратьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Random numRandom = new Random();
            string expectedResult = numRandom.Next(1, 100).ToString();
            MessageBox.Show(expectedResult,"За минимальное число ходов получите это число");
            lblExpectedResult.Text = expectedResult ;
            lblNumberResult.Text = "0";
            lblOperationsCount.Text = "0";
        }

        private void отменитьХодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_resultStack.Count > 1)
            {
                _resultStack.Pop();
                lblNumberResult.Text = _resultStack.Peek();
                lblOperationsCount.Text = (int.Parse(lblOperationsCount.Text) - 1).ToString();
            }
            else
            {
                MessageBox.Show("Отменять больше нечего", "Не получится");
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void поигратьВУгадайЧислоToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form f2 = new Form2();
            f2.Show();
        }
    }


}
