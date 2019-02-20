using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form2 : Form
    {

        public Form2()
        {
           InitializeComponent();
            prop1.Text = "Свойства структуры DateTime:\n" + GetDateTimeProperties();
        }

        // получаем свойства структуры DateTime
        private string GetDateTimeProperties()
        {
            //записали тип DateTime
            Type type = typeof(DateTime);
            //Положили в массив свойства для типа DateTime
            PropertyInfo[] props = type.GetProperties();
            //Пробежались по массиву и записали названия свойств в propNamesQuerry
            var propNamesQuerry = props.Select(x => x.Name);
            // преобразовали в массив названия свойств
            string[] propNames = propNamesQuerry.ToArray();
            //Записали в строку все свойства = элементам массива propNames
            string propNamesStr = string.Join("\n", propNames);
            return propNamesStr;
        }

        // При изменении значения в NumericUpDown меняем значение в TextBox а при клике по TextBox 
        // меняем Значение в NumericUpDown
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(NumericUpDown))
            {
                textBox1.Text = (((NumericUpDown) sender).Value).ToString();
            }
            else if (sender.GetType() == typeof(TextBox))
            {
                numericUpDown1.Value = Convert.ToInt32(((TextBox)sender).Text);
            }
        }

     }
}
