using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kyrsach
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            DBHelper dbHelper = new DBHelper();

            string username = LogLog.Text;
            string password = LogPass.Text;

            if (dbHelper.ValidateLogin(username, password))
            {
                this.Hide();
                CalcForm calcForm = new CalcForm();
                calcForm.Show();
            }
            else
            {
                MessageBox.Show("Не правильно введён логин или пароль", "Ошибка!");
            }
        }

        private void RegButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
