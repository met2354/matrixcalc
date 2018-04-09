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
    public partial class FCalc : Form
    {

        int n = 0;//Количество строк в матрице
        int m = 0;//Количество столбцов в матрице
        float[,] A = new float[5, 5];
        float[,] B = new float[5, 5];
        float[,] C = new float[5, 5];
        TextBox[,] tbA = new TextBox[5, 5];//Массив текстбоксов для ввода значений матрицы А
        TextBox[,] tbB = new TextBox[5 , 5];//Массив текстбоксов для ввода значений матрицы В         
        Label lsign = new Label();//Будет выводить на экран +, - или *
        Label[,] lresult = new Label[5, 5];//Будет выводить результат

        public FCalc()
        {
            InitializeComponent();
        }

        private void FCalc_Shown(object sender, EventArgs e)
        {
            /*Данная форма используется для сложения, вычитания и умножения. При переходе на эту форму 
            значение поля Text формы может быть: "A + B", "A - B" или "A * B".*/ 
            lsign.Text = Text[2].ToString();
            lsign.Size = new Size(10, 10);
        }
      
        //при закрытии формы открывает главную форму
        private void FCalc_FormClosed(object sender, FormClosedEventArgs e)
        {          
            Application.OpenForms[0].Show();
        }
        
        //Обработчик изменения значений в выппадающих списках, которые задают размер матриц
        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = cBLine.SelectedIndex + 2;//Количество строк в матрице
            m = cBColumn.SelectedIndex + 2;//Количество столбцов в матрице
            ClearResult(lresult);
            if (cBColumn.SelectedIndex != -1 && cBLine.SelectedIndex != -1)
            {
                //удаляем все текстбоксы и создаем новые, также меняем положение кнопки и знака
                RemoveTextBox(tbA);
                RemoveTextBox(tbB);
                CreateTextBox(tbA, n, m, 20, 70);
                CreateTextBox(tbB, n, m, 40 + 40 * m, 70);
                bResult.Location = new Point(20, 65 + 30 * n); 
                lsign.Location = new Point(20 + 40 * m, 60 + 15 * n);
                Controls.Add(lsign);
                this.Refresh();//Для прорисовки линий
            }
        }

        //Обработчик нажатия на кнопку
        private void BResult_Click(object sender, EventArgs e)
        {
            ClearResult(lresult);//Удаляет с экрана старый результат
            if (!Filling(tbA, n, m, A) || !Filling(tbB, n, m, B))//Заполняет двумерные массивы значениями из текстбоксов и выводит ошибку если что - то пошло не так
                MessageBox.Show("Не все поля заполнены или введены некорректные символы");
            else
            {
                if (Text[2].ToString() == "+")
                {
                    Amount(A, B, C, n, m);//А + В = С
                    DisplayMatrix(lresult, C, n, m);//Вывести С... Далее аналогично
                }                    
                else if (Text[2].ToString() == "-")
                {
                    Difference(A, B, C, n, m);
                    DisplayMatrix(lresult, C, n, m);
                }                    
                else if (n == m)
                {
                    Product(A, B, C, n, m);
                    DisplayMatrix(lresult, C, n, m);
                }
                else
                    MessageBox.Show("Такие матрицы нельзя перемножить");
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

        //Отображение линий
        private void FCalc_Paint(object sender, PaintEventArgs e)
        {
            if (cBColumn.SelectedIndex != -1 && cBLine.SelectedIndex != -1)
            {


                // Create pen.
                Pen blackPen = new Pen(Color.Black, 1);

                // Create points that define line.
                PointF point1 = new PointF(15, 70);
                PointF point2 = new PointF(15, 60 + 30 * n);
                PointF point3 = new PointF(15 + 40 * m, 70);
                PointF point4 = new PointF(15 + 40 * m, 60 + 30 * n);
                PointF point5 = new PointF(35 + 40 * m, 70);
                PointF point6 = new PointF(35 + 40 * m, 60 + 30 * n);
                PointF point7 = new PointF(35 + 80 * m, 70);
                PointF point8 = new PointF(35 + 80 * m, 60 + 30 * n);

                // Draw line to screen.
                e.Graphics.DrawLine(blackPen, point1, point2);
                e.Graphics.DrawLine(blackPen, point3, point4);
                e.Graphics.DrawLine(blackPen, point5, point6);
                e.Graphics.DrawLine(blackPen, point7, point8);
            }
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

        //Сумма матриц
        private void Amount(float[,] a, float[,] b, float[,] c, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
        }

        //Разность матриц
        private void Difference(float[,] a, float[,] b, float[,] c, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }
        }

        //Произведение матриц
        private void Product(float[,] a, float[,] b, float[,] c, int n, int m)
        {
            //обнулить матрицу С
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    c[i, j] = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                        c[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        //Выводит матрицу на экран
        private void DisplayMatrix(Label[,] label, float[,] matrix, int n, int m)
        {
            //Заполняем двумерный массив лэйблов значениями из матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    label[i, j] = new Label
                    {
                        Text = matrix[i, j].ToString(),
                    };
            }

            //Находим максимальную длину элемента в каждом столбце
            int max = 0;
            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                    if (label[i, j].Text.Length > max)
                        max = label[i, j].Text.Length;
            //Задаёт лэйблу размер и ширину в зависимости от max 
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    label[i, j] = new Label
                    {
                        Text = matrix[i, j].ToString(),
                        Size = new Size(10 * label[i, j].Text.Length, 15),
                        Location = new Point(30 + 10 * max * j + (max - label[i, j].Text.Length) * 5 / 2, 90 + 30 * n + 15 * i)
                    };
                    Controls.Add(label[i, j]);
                }
            }
        }

        //Удаляет лейблы
        private void ClearResult(Label[,] label)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Controls.Remove(label[i, j]);
        }
    }
}
