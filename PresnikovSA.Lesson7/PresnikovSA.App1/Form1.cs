using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresnikovSA.App1
{/// <summary>
/// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
///б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
///Игрок должен получить это число за минимальное количество ходов.
///в) Добавить кнопку «Отменить», которая отменяет последние ходы.
///Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int> Stack.
///Вся логика игры должна быть реализована в классе с удвоителем.
/// </summary>
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public static int myCountCommand = 0;
        private int mNumber = 0;
       
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            lblNumber2.Text = "0";
            this.Text = "Удвоитель";
            labelNumber.Text = "0";
            labelTeam.Text = "0";
            mNumber = rand.Next(2, 25);
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            myCountCommand++;
            lblNumber2.Text = myCountCommand.ToString();
           
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            myCountCommand++;
            lblNumber2.Text = myCountCommand.ToString();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblNumber2.Text = "0";
            
        }


        private void buttonСancellation_Click(object sender, EventArgs e)
        {

        }

        private int countCommand(int num)
        {
            int temp = num;
            int countCom = 0;
            for (; temp != 1;)
            {
                if (temp % 2 == 0)
                    temp /= 2;
                else temp -= 1;

                countCom++;
            }
            return countCom;
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            panelGame.Left = 305;
            labelNumber.Text = mNumber.ToString();
            labelTeam.Text = countCommand(mNumber).ToString();

        }
        
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

