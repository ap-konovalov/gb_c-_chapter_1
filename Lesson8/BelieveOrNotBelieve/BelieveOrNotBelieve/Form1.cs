using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        private TrueFalse database;

        private bool DbIsCreated
        {
            get
            {
                if (database == null)
                {
                    MessageBox.Show("Создайте базу данных", "Сообщение");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files(*.xml)|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123",true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
            ;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (DbIsCreated)
            {
                database.Save();
            }
         }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (DbIsCreated)
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(DbIsCreated)
            {
                database.Add((database.Count + 1).ToString(), true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;

        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files(*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (DbIsCreated)
            {
                database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var FormTaskOneTwo = new Form2();
            FormTaskOneTwo.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана на курса C# часть 1 от GeekBrains\nАвтор: Александр К.\nВерсия 1.0", "Информация", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files(*.xml)|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (DbIsCreated)
                {
                    string fileName = sfd.FileName;
                    database.Save(fileName);
                }
            }
        }
    }
}
