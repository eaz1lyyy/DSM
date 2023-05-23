using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixActions;

namespace ПР12
{
    public partial class Form1 : Form
    {
        private double[,] matrix1 = new double[0, 0], matrix2 = new double[0, 0], result = new double[0, 0];
        public Form1()
        {
            InitializeComponent();

            Result.ColumnCount = (int)Num1x.Value;
            Result.RowCount = (int)Num1y.Value;
            MatrixA.ColumnCount = (int)Num1x.Value;
            MatrixA.RowCount = (int)Num1y.Value;
            MatrixB.ColumnCount = (int)Num1x.Value;
            MatrixB.RowCount = (int)Num1y.Value;

            ResourceManager rm = Properties.Resources.ResourceManager;
            ImageList imgs = new ImageList();
            for (int i = 1; i <= 13; i++)
                imgs.Images.Add((Bitmap)rm.GetObject($"Img__{i}_"));
            imgs.ImageSize = new Size(15, 15);
            foreach (Button button in ABOper.Controls.OfType<Button>()) button.ImageList = imgs;
            foreach (Button button in AOper.Controls.OfType<Button>()) button.ImageList = imgs;
            Exit.ImageList = imgs;
        }

        private void SumMatrex_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            FillArray(MatrixB, ref matrix2);
            result = Matrix.SumMatrix(matrix1, matrix2);
            if (result == null)
            {
                MessageBox.Show("Матрицы должны быть с одинаковым количеством столбцов и строк", "Матричный калькулятор");
                return;
            }
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - сложение";
        }

        private void SubtrMatrex_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            FillArray(MatrixB, ref matrix2);
            result = Matrix.SubtractMatrix(matrix1, matrix2);
            if (result == null)
            {
                MessageBox.Show("Матрицы должны быть с одинаковым количеством столбцов и строк", "Матричный калькулятор");
                return;
            }
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - вычитание";
        }

        private void Fill1_Click(object sender, EventArgs e)
        {
            MatrixA.ColumnCount = (int)Num1y.Value;
            MatrixA.RowCount = (int)Num1x.Value;
        }

        private void Fill2_Click(object sender, EventArgs e)
        {
            MatrixB.ColumnCount = (int)Num2y.Value;
            MatrixB.RowCount = (int)Num2x.Value;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MultipMatrix_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            FillArray(MatrixB, ref matrix2);
            result = Matrix.MultipMatrix(matrix1, matrix2);
            if (result == null)
            {
                MessageBox.Show("Количество столбцов в первой матрице и строк во второй должны быть равны", "Матричный калькулятор");
                return;
            }
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - умножение";
        }

        private void TranspMatrix_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            result = Matrix.TranspMatrix(matrix1);
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - транспонирование";
        }

        private void NaChislo_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            result = Matrix.ByNumber(matrix1, Convert.ToDouble(MatrixB[0, 0].Value));
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - умножение на число";
        }

        private void OpredMatrix_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            FillGrid(Result, new double[Result.RowCount, Result.ColumnCount]);
            double? resultat = Matrix.Opred(matrix1);
            if (resultat == null)
            {
                MessageBox.Show("Матрица должна быть квадратной", "Матричный калькулятор");
                return;
            }
            Result.ColumnCount = 1;
            Result.RowCount = 1;
            Result[0, 0].Value = Matrix.Opred(matrix1);
            GroupResult.Text = "Результат вычисления - определитель";
        }

        private void MinorsMatrix_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            result = Matrix.MinorsMatrix(matrix1);
            if (result == null)
            {
                MessageBox.Show("Матрица должна быть квадратной", "Матричный калькулятор");
                return;
            }
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - миноры";
        }

        private void ReverseMatrix_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            result = Matrix.ReverseMatrix(matrix1);
            if (result == null)
            {
                MessageBox.Show("Матрица должна быть квадратной", "Матричный калькулятор");
                return;
            }
            FillGrid(Result, result);
            GroupResult.Text = "Результат вычисления - обратная матрица";
        }

        private void FillArray(DataGridView dataGrid, ref double[,] data)
        {
            data = new double[dataGrid.RowCount, dataGrid.ColumnCount];
            for (int y = 0; y < dataGrid.RowCount; y++)
            {
                for (int x = 0; x < dataGrid.ColumnCount; x++)
                {
                    data[y, x] = Convert.ToDouble(dataGrid[x, y].Value);
                }
            }
        }

        private void FillGrid(DataGridView dataGrid, double[,] data)
        {
            dataGrid.RowCount = data.GetLength(0);
            dataGrid.ColumnCount = data.GetLength(1);
            for (int y = 0; y < data.GetLength(0); y++)
            {
                for (int x = 0; x < data.GetLength(1); x++)
                {
                    dataGrid[x, y].Value = data[y, x];
                }
            }
        }

        private void AtoB_Click(object sender, EventArgs e) => CopyDataGrid(MatrixA, MatrixB);

        private void BtoA_Click(object sender, EventArgs e) => CopyDataGrid(MatrixB, MatrixA);

        private void ResulttoB_Click(object sender, EventArgs e) => CopyDataGrid(Result, MatrixB);

        private void RankMatrix_Click(object sender, EventArgs e)
        {
            FillArray(MatrixA, ref matrix1);
            int? resultat;
            resultat = Matrix.RankMatrix(matrix1);
            if (resultat == null)
            {
                MessageBox.Show("Матрица должна быть квадратной", "Матричный калькулятор");
                return;
            }
            Result.ColumnCount = 1;
            Result.RowCount = 1;
            Result[0, 0].Value = resultat;
            GroupResult.Text = "Результат вычисления - ранг";
        }

        private void CopyDataGrid(DataGridView source, DataGridView destination)
        {
            destination.ColumnCount = source.ColumnCount;
            destination.RowCount = source.RowCount;
            for (int y = 0; y < destination.RowCount; y++)
            {
                for (int x = 0; x < destination.ColumnCount; x++)
                {
                    destination[y, x].Value = source[y, x].Value;
                }
            }
        }
    }
}
