using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace Kyrsach
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
            m1Box.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n1Box.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            m2Box.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n2Box.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            hideAll();
        }


        public void hideAll()
        {
            m1Box.Hide();
            n1Box.Hide();
            matr1.Hide();
            MatrButt1.Hide();

            sign.Hide();

            CBox.Hide();

            m2Box.Hide();
            n2Box.Hide();
            matr2.Hide();
            MatrButt2.Hide();

            equel.Hide();

            detRev.Hide();

            matr3.Hide();
            detAnsw.Hide();
            AnswButt.Hide();

        }
        public void Sum_Substract(string s)
        {
            if ((matr2.RowCount == matr1.RowCount) && (matr2.ColumnCount == matr1.ColumnCount))
            {
                matr3.RowCount = int.Parse(m2Box.Text);
                matr3.ColumnCount = int.Parse(n2Box.Text);
                for (int i = 0; i < matr3.RowCount; i++)
                {
                    for (int j = 0; j < matr3.ColumnCount; j++)
                    {
                        if (double.TryParse($"{matr1.Rows[i].Cells[j].Value}", out double a) && (double.TryParse($"{matr2.Rows[i].Cells[j].Value}", out double b)))
                        {
                            if (s == "-")
                                matr3.Rows[i].Cells[j].Value = a - b;
                            if (s == "+")
                                matr3.Rows[i].Cells[j].Value = a + b;
                        }
                        else
                        {
                            matr3.Rows[i].Cells[j].Value = "error";
                            //MessageBox.Show($"Не правильно введены числа!\nПроверьте индекс: {i+1}, {j+1}", "Ошибка!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Размеры матриц не совпадают, попробуйте ещё раз", "Ошибка!");
            }
        }
        public void Multi()
        {
            if (matr1.ColumnCount == matr2.RowCount)
            {
                matr3.RowCount = int.Parse(m1Box.Text);
                matr3.ColumnCount = int.Parse(n2Box.Text);

                for (int i = 0; i < matr3.RowCount; i++)
                {
                    for (int j = 0; j < matr3.ColumnCount; j++)
                    {
                        matr3.Rows[i].Cells[j].Value = "0";
                    }
                }

                for (int m = 0; m < matr3.RowCount; m++)
                {
                    for (int p = 0; p < matr3.ColumnCount; p++)
                    {
                        for (int n = 0; n < matr1.ColumnCount; n++)
                        {
                            if (double.TryParse($"{matr1.Rows[m].Cells[n].Value}", out double a) &&
                                (double.TryParse($"{matr2.Rows[n].Cells[p].Value}", out double b)) &&
                                double.TryParse($"{matr3.Rows[m].Cells[p].Value}", out double c))
                            {
                                matr3.Rows[m].Cells[p].Value = c + a * b;
                            }
                            else
                            {
                                matr3.Rows[m].Cells[p].Value = "error";
                                //MessageBox.Show("Не правильно введены числа, попробуйте ещё раз", "Ошибка!");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Размеры матриц не совпадают, попробуйте ещё раз", "Ошибка!");
            }
        }

        public void MultiC()
        {

            if (double.TryParse(CBox.Text, out double C))
            {
                matr3.RowCount = int.Parse(m1Box.Text);
                matr3.ColumnCount = int.Parse(n1Box.Text);

                for (int m = 0; m < matr1.RowCount; m++)
                {

                    for (int n = 0; n < matr1.ColumnCount; n++)
                    {
                        if (double.TryParse($"{matr1.Rows[m].Cells[n].Value}", out double a))
                        {
                            matr3.Rows[m].Cells[n].Value = a * C;
                        }
                        else
                        {
                            matr3.Rows[m].Cells[n].Value = "error";
                            //MessageBox.Show("Не правильно введены числа, попробуйте ещё раз", "Ошибка!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не правильно введена константа", "Ошибка!");
            }
        }
        public void Trans()
        {
            matr3.RowCount = int.Parse(n1Box.Text);
            matr3.ColumnCount = int.Parse(m1Box.Text);

            for (int m = 0; m < matr1.RowCount; m++)
            {
                for (int n = 0; n < matr1.ColumnCount; n++)
                {
                    if (double.TryParse($"{matr1.Rows[m].Cells[n].Value}", out double a))
                    {
                        matr3.Rows[n].Cells[m].Value = matr1.Rows[m].Cells[n].Value;
                    }
                    else
                    {
                        matr3.Rows[n].Cells[m].Value = "error";
                        //MessageBox.Show("Не правильно введены числа, попробуйте ещё раз", "Ошибка!");
                    }
                }
            }
        }
        public void ExpC()
        {

            if ((int.TryParse(CBox.Text, out int C)) && C > 0)
            {
                m2Box.Text = m1Box.Text;
                n2Box.Text = n1Box.Text;
                matr3.RowCount = int.Parse(m1Box.Text);
                matr3.ColumnCount = int.Parse(n1Box.Text);
                matr2.RowCount = int.Parse(m1Box.Text);
                matr2.ColumnCount = int.Parse(n1Box.Text);
                // Matr2 = Matr1
                for (int m = 0; m < matr1.RowCount; m++)
                {
                    for (int n = 0; n < matr1.ColumnCount; n++)
                    {
                        if (double.TryParse($"{matr1.Rows[m].Cells[n].Value}", out double a))
                        {
                            matr2.Rows[m].Cells[n].Value = a;
                        }
                        else
                        {
                            matr2.Rows[m].Cells[n].Value = "error";
                            //MessageBox.Show("Не правильно введены числа, попробуйте ещё раз", "Ошибка!");
                        }
                    }
                }

                for (int c = 1; c < C; c++)
                {
                    Console.WriteLine(c);
                    Multi();
                    for (int m = 0; m < matr3.RowCount; m++)
                    {
                        for (int n = 0; n < matr3.ColumnCount; n++)
                        {
                            if (double.TryParse($"{matr3.Rows[m].Cells[n].Value}", out double a))
                            {
                                matr2.Rows[m].Cells[n].Value = a;
                            }
                            else
                            {
                                matr2.Rows[m].Cells[n].Value = "error";
                                //MessageBox.Show("Не правильно введены числа, попробуйте ещё раз", "Ошибка!");
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Не правильно введена константа", "Ошибка!");
            }
        }
        public void Det()
        {
            if (matr1.ColumnCount == matr1.RowCount)
            {
                double[,] mass = new double[matr1.RowCount, matr1.ColumnCount];

                for (int m = 0; m < matr1.RowCount; m++)
                {
                    for (int n = 0; n < matr1.ColumnCount; n++)
                    {

                        if (double.TryParse($"{matr1.Rows[m].Cells[n].Value}", out double a))
                        {
                            mass[m, n] = a;
                        }
                        else
                        {
                            MessageBox.Show("Не правильная запись числа! Попробуйте ещё раз", "Ошибка!");
                            return;
                        }
                    }
                }

                var matrix = Matrix<double>.Build.DenseOfArray(mass);
                double determinant = matrix.Determinant();
                detAnsw.Text = determinant.ToString();

            }
            else
            {
                MessageBox.Show("Матрица не квадратная! Попробуйте ещё раз", "Ошибка!");
            }

        }
        public void Reverse()
        {
            Det();
            if (detAnsw.Text != "0")
            {
                detRev.Text = detAnsw.Text;
                matr3.RowCount = int.Parse(n1Box.Text);
                matr3.ColumnCount = int.Parse(m1Box.Text);
                double[,] mass = new double[matr1.RowCount, matr1.ColumnCount];

                for (int m = 0; m < matr1.RowCount; m++)
                {
                    for (int n = 0; n < matr1.ColumnCount; n++)
                    {

                        if (double.TryParse($"{matr1.Rows[m].Cells[n].Value}", out double a))
                        {
                            mass[m, n] = a;
                        }
                        else
                        {
                            MessageBox.Show("Не правильная запись числа! Попробуйте ещё раз", "Ошибка!");
                            return;
                        }
                    }
                }

                var matrix = Matrix<double>.Build.DenseOfArray(mass);
                var inverseMatrix = matrix.Inverse();
                for (int m = 0; m < matr1.RowCount; m++)
                {
                    for (int n = 0; n < matr1.ColumnCount; n++)
                    {
                        matr3.Rows[m].Cells[n].Value = inverseMatrix[m, n];
                    }
                }


            }
            else
            {
                MessageBox.Show("Обратной матрицы нет! Определитель равен нулю", "Ошибка!");
            }

        }
        private void MatrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAll();
            DoBox.Items.Clear();
            if (MatrBox.SelectedIndex == 0)
            {
                DoBox.Items.AddRange(new string[] { "det A", "A*C", "A^C", "A^T", "A^(-1)" });
            }
            else
            {
                DoBox.Items.AddRange(new string[] { "A+B", "A-B", "AxB" });
            }

        }

        private void DoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAll();

            m1Box.Show();
            n1Box.Show();
            matr1.Show();
            MatrButt1.Show();

            equel.Show();
            AnswButt.Show();

            if (MatrBox.SelectedItem.ToString() == "1")
            {
                switch (DoBox.SelectedItem.ToString())
                {
                    case "A^T":
                        matr3.Show();
                        break;

                    case "A^(-1)":
                        matr3.Show();
                        detRev.Show();
                        break;

                    case "A*C":
                        sign.Show();
                        sign.Text = "*";
                        CBox.Show();
                        matr3.Show();
                        break;

                    case "A^C":
                        sign.Show();
                        sign.Text = "^";
                        CBox.Show();
                        matr3.Show();
                        break;

                    case "det A":
                        detAnsw.Show();
                        break;
                }
            }
            else
            {
                matr2.Show();
                m2Box.Show();
                n2Box.Show();
                MatrButt2.Show();
                matr3.Show();

                switch (DoBox.SelectedItem.ToString())
                {
                    case "A+B":
                        sign.Text = "+";
                        sign.Show();
                        break;

                    case "A-B":
                        sign.Text = "-";
                        sign.Show();
                        break;

                    case "AxB":
                        sign.Text = "x";
                        sign.Show();
                        break;
                }
            }
        }

        private void MatrButt1_Click(object sender, EventArgs e)
        {
            if (m1Box.Text != "" && n1Box.Text != "")
            {
                matr1.RowCount = int.Parse(m1Box.Text);
                matr1.ColumnCount = int.Parse(n1Box.Text);
            }
        }

        private void MatrButt2_Click(object sender, EventArgs e)
        {

            if (m2Box.Text != "" && n2Box.Text != "")
            {
                matr2.RowCount = int.Parse(m2Box.Text);
                matr2.ColumnCount = int.Parse(n2Box.Text);
            }

        }

        private void AnswButt_Click(object sender, EventArgs e)
        {
            if (matr1.RowCount != 0 && matr1.ColumnCount != 0)
            {
                // Заполнить нулями matr1
                for (int i = 0; i < matr1.RowCount; i++)
                {
                    for (int j = 0; j < matr1.ColumnCount; j++)
                    {
                        if (matr1.Rows[i].Cells[j].Value == null)
                        {
                            matr1.Rows[i].Cells[j].Value = "0";
                        }
                    }
                }

                if (MatrBox.Text == "2")
                {
                    if (matr2.RowCount != 0 && matr2.ColumnCount != 0)
                    {
                        // Заполнить нулями matr2
                        for (int i = 0; i < matr2.RowCount; i++)
                        {
                            for (int j = 0; j < matr2.ColumnCount; j++)
                            {
                                if (matr2.Rows[i].Cells[j].Value == null)
                                {
                                    matr2.Rows[i].Cells[j].Value = "0";
                                }
                            }
                        }

                        if (DoBox.Text == "A+B")
                        {
                            Sum_Substract("+");
                        }
                        if (DoBox.Text == "A-B")
                        {
                            Sum_Substract("-");
                        }
                        if (DoBox.Text == "AxB")
                        {
                            Multi();
                        }
                    }
                }

                else
                {
                    if (DoBox.Text == "A*C")
                    {
                        MultiC();
                    }
                    else if (DoBox.Text == "A^T")
                    {
                        Trans();
                    }
                    else if (DoBox.Text == "A^C")
                    {
                        ExpC();
                    }
                    else if (DoBox.Text == "det A")
                    {
                        Det();
                    }
                    else if (DoBox.Text == "A^(-1)")
                    {
                        Reverse();
                    }
                }
            }

        }

        private void CalcForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
