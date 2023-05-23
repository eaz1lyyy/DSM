namespace ПР12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatrixA = new System.Windows.Forms.DataGridView();
            this.Fill1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Num1x = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Num1y = new System.Windows.Forms.NumericUpDown();
            this.ABOper = new System.Windows.Forms.GroupBox();
            this.MultipMatrex = new System.Windows.Forms.Button();
            this.SubtrMatrex = new System.Windows.Forms.Button();
            this.SumMatrex = new System.Windows.Forms.Button();
            this.AOper = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.GroupResult = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MatrixB = new System.Windows.Forms.DataGridView();
            this.Fill2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num2y = new System.Windows.Forms.NumericUpDown();
            this.Num2x = new System.Windows.Forms.NumericUpDown();
            this.Exit = new System.Windows.Forms.Button();
            this.BtoA = new System.Windows.Forms.Button();
            this.AtoB = new System.Windows.Forms.Button();
            this.ResulttoB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1y)).BeginInit();
            this.ABOper.SuspendLayout();
            this.AOper.SuspendLayout();
            this.GroupResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2x)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MatrixA);
            this.groupBox1.Controls.Add(this.Fill1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Num1x);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Num1y);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матарица А:";
            // 
            // MatrixA
            // 
            this.MatrixA.AllowUserToAddRows = false;
            this.MatrixA.AllowUserToDeleteRows = false;
            this.MatrixA.AllowUserToResizeColumns = false;
            this.MatrixA.AllowUserToResizeRows = false;
            this.MatrixA.BackgroundColor = System.Drawing.Color.White;
            this.MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA.ColumnHeadersVisible = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.NullValue = "0";
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatrixA.DefaultCellStyle = dataGridViewCellStyle26;
            this.MatrixA.Location = new System.Drawing.Point(6, 36);
            this.MatrixA.Name = "MatrixA";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.NullValue = "0";
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatrixA.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.MatrixA.RowHeadersVisible = false;
            this.MatrixA.Size = new System.Drawing.Size(330, 151);
            this.MatrixA.TabIndex = 0;
            // 
            // Fill1
            // 
            this.Fill1.Location = new System.Drawing.Point(267, 11);
            this.Fill1.Name = "Fill1";
            this.Fill1.Size = new System.Drawing.Size(69, 20);
            this.Fill1.TabIndex = 99;
            this.Fill1.TabStop = false;
            this.Fill1.Text = "Заполнить ";
            this.Fill1.UseVisualStyleBackColor = true;
            this.Fill1.Click += new System.EventHandler(this.Fill1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Столбцов:";
            // 
            // Num1x
            // 
            this.Num1x.Location = new System.Drawing.Point(124, 11);
            this.Num1x.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num1x.Name = "Num1x";
            this.Num1x.Size = new System.Drawing.Size(37, 20);
            this.Num1x.TabIndex = 98;
            this.Num1x.TabStop = false;
            this.Num1x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Num1x.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строк:";
            // 
            // Num1y
            // 
            this.Num1y.Location = new System.Drawing.Point(224, 11);
            this.Num1y.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num1y.Name = "Num1y";
            this.Num1y.Size = new System.Drawing.Size(37, 20);
            this.Num1y.TabIndex = 2;
            this.Num1y.TabStop = false;
            this.Num1y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Num1y.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ABOper
            // 
            this.ABOper.Controls.Add(this.MultipMatrex);
            this.ABOper.Controls.Add(this.SubtrMatrex);
            this.ABOper.Controls.Add(this.SumMatrex);
            this.ABOper.Location = new System.Drawing.Point(364, 12);
            this.ABOper.Name = "ABOper";
            this.ABOper.Size = new System.Drawing.Size(424, 53);
            this.ABOper.TabIndex = 2;
            this.ABOper.TabStop = false;
            this.ABOper.Text = "Операции над матрицами А и В:  ";
            // 
            // MultipMatrex
            // 
            this.MultipMatrex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultipMatrex.ImageIndex = 8;
            this.MultipMatrex.Location = new System.Drawing.Point(282, 19);
            this.MultipMatrex.Name = "MultipMatrex";
            this.MultipMatrex.Size = new System.Drawing.Size(126, 23);
            this.MultipMatrex.TabIndex = 4;
            this.MultipMatrex.Text = "Умножение матриц";
            this.MultipMatrex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MultipMatrex.UseVisualStyleBackColor = true;
            this.MultipMatrex.Click += new System.EventHandler(this.MultipMatrix_Click);
            // 
            // SubtrMatrex
            // 
            this.SubtrMatrex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubtrMatrex.ImageIndex = 7;
            this.SubtrMatrex.Location = new System.Drawing.Point(150, 19);
            this.SubtrMatrex.Name = "SubtrMatrex";
            this.SubtrMatrex.Size = new System.Drawing.Size(126, 23);
            this.SubtrMatrex.TabIndex = 3;
            this.SubtrMatrex.Text = "Вычитание матриц";
            this.SubtrMatrex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubtrMatrex.UseVisualStyleBackColor = true;
            this.SubtrMatrex.Click += new System.EventHandler(this.SubtrMatrex_Click);
            // 
            // SumMatrex
            // 
            this.SumMatrex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SumMatrex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumMatrex.ImageIndex = 1;
            this.SumMatrex.Location = new System.Drawing.Point(18, 19);
            this.SumMatrex.Name = "SumMatrex";
            this.SumMatrex.Size = new System.Drawing.Size(126, 23);
            this.SumMatrex.TabIndex = 2;
            this.SumMatrex.Text = "Сложение матриц";
            this.SumMatrex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SumMatrex.UseVisualStyleBackColor = true;
            this.SumMatrex.Click += new System.EventHandler(this.SumMatrex_Click);
            // 
            // AOper
            // 
            this.AOper.Controls.Add(this.button10);
            this.AOper.Controls.Add(this.button7);
            this.AOper.Controls.Add(this.button9);
            this.AOper.Controls.Add(this.button5);
            this.AOper.Controls.Add(this.button8);
            this.AOper.Controls.Add(this.button6);
            this.AOper.Location = new System.Drawing.Point(364, 87);
            this.AOper.Name = "AOper";
            this.AOper.Size = new System.Drawing.Size(424, 79);
            this.AOper.TabIndex = 3;
            this.AOper.TabStop = false;
            this.AOper.Text = "Операции над матрицей А:";
            // 
            // button10
            // 
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.ImageIndex = 2;
            this.button10.Location = new System.Drawing.Point(282, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Умножить на число";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NaChislo_Click);
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 4;
            this.button7.Location = new System.Drawing.Point(282, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Ранг матринцы ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.RankMatrix_Click);
            // 
            // button9
            // 
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageIndex = 0;
            this.button9.Location = new System.Drawing.Point(18, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Определитель";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OpredMatrix_Click);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 5;
            this.button5.Location = new System.Drawing.Point(18, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обратная матрица";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ReverseMatrix_Click);
            // 
            // button8
            // 
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageIndex = 3;
            this.button8.Location = new System.Drawing.Point(150, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Минор элемента";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MinorsMatrix_Click);
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 6;
            this.button6.Location = new System.Drawing.Point(150, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Транспонирование";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.TranspMatrix_Click);
            // 
            // GroupResult
            // 
            this.GroupResult.Controls.Add(this.Result);
            this.GroupResult.Location = new System.Drawing.Point(391, 190);
            this.GroupResult.Name = "GroupResult";
            this.GroupResult.Size = new System.Drawing.Size(381, 184);
            this.GroupResult.TabIndex = 4;
            this.GroupResult.TabStop = false;
            this.GroupResult.Text = "Результат вычисления -";
            // 
            // Result
            // 
            this.Result.AllowUserToAddRows = false;
            this.Result.AllowUserToDeleteRows = false;
            this.Result.AllowUserToResizeColumns = false;
            this.Result.AllowUserToResizeRows = false;
            this.Result.BackgroundColor = System.Drawing.Color.White;
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.ColumnHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.NullValue = "0";
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Result.DefaultCellStyle = dataGridViewCellStyle28;
            this.Result.Location = new System.Drawing.Point(6, 19);
            this.Result.Name = "Result";
            this.Result.RowHeadersVisible = false;
            this.Result.Size = new System.Drawing.Size(369, 159);
            this.Result.TabIndex = 4;
            this.Result.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MatrixB);
            this.groupBox5.Controls.Add(this.Fill2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.Num2y);
            this.groupBox5.Controls.Add(this.Num2x);
            this.groupBox5.Location = new System.Drawing.Point(12, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 193);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Матрица В:";
            // 
            // MatrixB
            // 
            this.MatrixB.AllowUserToAddRows = false;
            this.MatrixB.AllowUserToDeleteRows = false;
            this.MatrixB.AllowUserToResizeColumns = false;
            this.MatrixB.AllowUserToResizeRows = false;
            this.MatrixB.BackgroundColor = System.Drawing.Color.White;
            this.MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB.ColumnHeadersVisible = false;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.NullValue = "0";
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatrixB.DefaultCellStyle = dataGridViewCellStyle29;
            this.MatrixB.Location = new System.Drawing.Point(6, 36);
            this.MatrixB.Name = "MatrixB";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.NullValue = "0";
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatrixB.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.MatrixB.RowHeadersVisible = false;
            this.MatrixB.Size = new System.Drawing.Size(330, 151);
            this.MatrixB.TabIndex = 1;
            // 
            // Fill2
            // 
            this.Fill2.Location = new System.Drawing.Point(267, 11);
            this.Fill2.Name = "Fill2";
            this.Fill2.Size = new System.Drawing.Size(69, 20);
            this.Fill2.TabIndex = 1;
            this.Fill2.TabStop = false;
            this.Fill2.Text = "Заполнить ";
            this.Fill2.UseVisualStyleBackColor = true;
            this.Fill2.Click += new System.EventHandler(this.Fill2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Столбцов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Строк:";
            // 
            // Num2y
            // 
            this.Num2y.Location = new System.Drawing.Point(224, 11);
            this.Num2y.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num2y.Name = "Num2y";
            this.Num2y.Size = new System.Drawing.Size(37, 20);
            this.Num2y.TabIndex = 2;
            this.Num2y.TabStop = false;
            this.Num2y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Num2y.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Num2x
            // 
            this.Num2x.Location = new System.Drawing.Point(124, 11);
            this.Num2x.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num2x.Name = "Num2x";
            this.Num2x.Size = new System.Drawing.Size(37, 20);
            this.Num2x.TabIndex = 97;
            this.Num2x.TabStop = false;
            this.Num2x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Num2x.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Exit
            // 
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.ImageIndex = 12;
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.TabStop = false;
            this.Exit.Text = "Выход";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BtoA
            // 
            this.BtoA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtoA.BackgroundImage")));
            this.BtoA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtoA.Location = new System.Drawing.Point(236, 209);
            this.BtoA.Name = "BtoA";
            this.BtoA.Size = new System.Drawing.Size(25, 25);
            this.BtoA.TabIndex = 8;
            this.BtoA.UseVisualStyleBackColor = true;
            this.BtoA.Click += new System.EventHandler(this.BtoA_Click);
            // 
            // AtoB
            // 
            this.AtoB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AtoB.BackgroundImage")));
            this.AtoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AtoB.Location = new System.Drawing.Point(123, 209);
            this.AtoB.Name = "AtoB";
            this.AtoB.Size = new System.Drawing.Size(25, 25);
            this.AtoB.TabIndex = 7;
            this.AtoB.UseVisualStyleBackColor = true;
            this.AtoB.Click += new System.EventHandler(this.AtoB_Click);
            // 
            // ResulttoB
            // 
            this.ResulttoB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResulttoB.BackgroundImage")));
            this.ResulttoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResulttoB.Location = new System.Drawing.Point(360, 291);
            this.ResulttoB.Name = "ResulttoB";
            this.ResulttoB.Size = new System.Drawing.Size(25, 25);
            this.ResulttoB.TabIndex = 6;
            this.ResulttoB.UseVisualStyleBackColor = true;
            this.ResulttoB.Click += new System.EventHandler(this.ResulttoB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtoA);
            this.Controls.Add(this.AtoB);
            this.Controls.Add(this.ResulttoB);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.GroupResult);
            this.Controls.Add(this.AOper);
            this.Controls.Add(this.ABOper);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Матричный калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1y)).EndInit();
            this.ABOper.ResumeLayout(false);
            this.AOper.ResumeLayout(false);
            this.GroupResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2x)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ABOper;
        private System.Windows.Forms.Button MultipMatrex;
        private System.Windows.Forms.Button SubtrMatrex;
        private System.Windows.Forms.Button SumMatrex;
        private System.Windows.Forms.GroupBox AOper;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView MatrixA;
        private System.Windows.Forms.GroupBox GroupResult;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView MatrixB;
        private System.Windows.Forms.Button Fill2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Num2y;
        private System.Windows.Forms.NumericUpDown Num2x;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Fill1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Num1x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num1y;
        private System.Windows.Forms.Button ResulttoB;
        private System.Windows.Forms.Button AtoB;
        private System.Windows.Forms.Button BtoA;
    }
}

