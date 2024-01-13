using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegButt_Click(object sender, EventArgs e)
        {
            DBHelper dbHelper = new DBHelper();

            string username = RegLog.Text;
            string password_1 = RegPass_1.Text;
            string password_2 = RegPass_2.Text;

            if (password_1 != password_2)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка!");
            }
            else if (password_1 != "" && password_2 != "" && username != "")
            {
                if (dbHelper.RegisterUser(username, password_1))
                {
                    this.Hide();
                    CalcForm calcForm = new CalcForm();
                    calcForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким именем уже есть", "Ошибка!");
                }

            }
            else
            {
                MessageBox.Show("Заполните поля", "Ошибка!");
            }
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
