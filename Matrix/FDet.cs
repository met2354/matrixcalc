using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class FDet : Form
    {
        int n = 0;//Количество строк в матрице
        int m = 0;//Количество столбцов в матрице
        float[,] A = new float[5, 5];
        TextBox[,] tbA = new TextBox[5, 5];//Массив текстбоксов для ввода значений матрицы А
        Label ldet = new Label();//Будет выводить определитель

        public FDet()
        {
            InitializeComponent();
        }

        //при закрытии формы открывает главную форму
        private void FDet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        //Обработчик изменения значений в выппадающих списках, которые задают размер матрицы
        private void CBsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = cBsize.SelectedIndex + 2;//Количество строк в матрице
            m = cBsize.SelectedIndex + 2;//Количество столбцов в матрице
            RemoveTextBox(tbA);
            CreateTextBox(tbA, n, m, 20, 70);
            bdet.Location = new Point(20, 65 + 30 * n);
        }

        //Обработчик нажатия на кнопку
        private void Bdet_Click(object sender, EventArgs e)
        {
            if (!Filling(tbA, n, m, A))//Заполняет двумерный массив значениями из текстбоксов и выводит ошибку если что - то пошло не так
                MessageBox.Show("Не все поля заполнены или введены некорректные символы");
            else
            {
                MessageBox.Show("det |A| = " + Det(A, n).ToString());
            }
        }

        //создание полей для ввода элементов массива
        private void CreateTextBox(TextBox[,] tb, int n, int m, int x, int y)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tb[i, j] = new TextBox
                    {
                        Size = new Size(30, 20),
                        Location = new Point(x + 40 * j, y + 30 * i)
                    };
                    Controls.Add(tb[i, j]);
                }
            }
        }

        //Удаление текстбоксов
        private void RemoveTextBox(TextBox[,] tb)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Controls.Remove(tb[i, j]);
        }

        //Функция заполняет матрицу значениями из текстбоксов и возвращает false если что - то пошло не так
        private bool Filling(TextBox[,] tb, int n, int m, float[,] matrix)
        {
            bool success = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!float.TryParse(tb[i, j].Text, out matrix[i, j]))
                    {
                        success = false;
                        break;
                    }
                }
                if (!success)
                    break;
            }
            return success;
        }

        //Определитель
        private double Det(float[,] matrix, int n)
        {
            if (n == 2)
            {
                return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            }
            else if (n > 2)
            {
                double det = 0;
                float[,] minor = new float[n - 1, n - 1];
                int im = 0;
                int jm = 0;
                for(int k = 0; k < n; k++)
                {
                    for(int i = 1; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if(j != k)
                            {
                                minor[im, jm] = matrix[i, j];
                                jm++;
                            }

                        }
                        im++;
                        jm = 0;
                    }
                    det += Math.Pow((-1), (2 + k)) * matrix[0, k] * Det(minor, n - 1);
                    im = 0;
                }
                return det;
            }
            else
                return -1;
            
        }
    }
}
