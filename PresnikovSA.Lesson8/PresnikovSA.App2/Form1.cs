using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresnikovSA.App2
{/// <summary>
/// Создайте простую форму на котором свяжите свойство Text 
/// элемента TextBox со свойством Value элемента NumericUpDown.
/// </summary>
//Пресников С.А.
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            this.Text = "Равенство элементов Text and Value";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             textBox1.Text = numericUpDown1.Value.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Value = decimal.Parse(textBox1.Text);
            }
            catch (ArgumentOutOfRangeException AEx)
            {
                MessageBox.Show($"Некорректный ввод: {AEx.Message}");
            }
            catch (FormatException FEx)
            {
                MessageBox.Show($"Некорректный ввод: { FEx.Message}");
            }
        }

    }
}
