using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string userName = tbName.Text.Trim(); //Тут мы передаем из tbName(Текстовый блок) информацию в userName и в последствии очищаем текст блок(Функция Trim(), а Text служит для получения текста)
            if (userName.Length < 3) //userName.Length - Получение длинны текста
            {
                MessageBox.Show("Введите имя больше чем 3 символа!", "Error"); //Показывает сообщение 1 аргумент текст который будет написан, 2 - что написанно сверху
            }
            else
            {
                MessageBox.Show("Привет " + userName, "Привет!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Выход из приложения
            Application.Exit();
        }
    }
}
