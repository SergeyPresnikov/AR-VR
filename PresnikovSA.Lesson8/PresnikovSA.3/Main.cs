using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{/// <summary>
/// а) Создать приложение, показанное на уроке, добавив в него защиту 
/// от возможных ошибок (не создана база данных, обращение к несуществующему
/// вопросу, открытие слишком большого файла и т.д.).
///б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив 
///другие «косметические» улучшения на свое усмотрение.
///в) Добавить в приложение меню «О программе» с информацией о программе
///(автор, версия, авторские права и др.).
///г)* Добавить пункт меню Save As, в котором можно выбрать имя для 
///сохранения базы данных(элемент SaveFileDialog).
/// </summary>
 
///Пресников С.А.
    public partial class Main : Form
    {//База данных с вопросами
        private TrueFalse database;


        public Main()
        {
            InitializeComponent();
        }
        //Обработка пункта меню Выход
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Обработка пункта меню Создать
        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("   ", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }
        //Обработка пункта меню Открыть
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        //Обработка пункта меню Сохранить
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана", "Сообщение");
        }
        // Обработка  изменений значения nudNumber
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text; 
                cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch 
            {
                MessageBox.Show("Вы обратились к несуществующему вопросу", "Сообщение");
            }
        }
        // Обработка кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add("#" + (database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработка кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработка кнопки Сохранить (вопрос)
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(database!= null)
            {
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else MessageBox.Show("Создайте вопрос", "Сообщение");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: GeekBrains\n Редактор: Сергей Пресников\n Версия: 8.3в\n Все права защищены", "О программе");
        }

        
    }
}
