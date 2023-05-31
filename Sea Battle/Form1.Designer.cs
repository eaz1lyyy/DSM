
namespace Sea_Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Horizontal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rule = new System.Windows.Forms.Button();
            this.Vertical = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.Palubs = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.ColumnCount = 6;
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ControlPanel.Controls.Add(this.Horizontal, 1, 1);
            this.ControlPanel.Controls.Add(this.label1, 0, 0);
            this.ControlPanel.Controls.Add(this.Rule, 5, 1);
            this.ControlPanel.Controls.Add(this.Vertical, 2, 1);
            this.ControlPanel.Controls.Add(this.Clear, 4, 1);
            this.ControlPanel.Controls.Add(this.mainButton, 3, 1);
            this.ControlPanel.Controls.Add(this.Palubs, 0, 1);
            this.ControlPanel.Controls.Add(this.label2, 4, 0);
            this.ControlPanel.Controls.Add(this.checkBox1, 2, 0);
            this.ControlPanel.Location = new System.Drawing.Point(12, 387);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.RowCount = 2;
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlPanel.Size = new System.Drawing.Size(776, 51);
            this.ControlPanel.TabIndex = 1;
            // 
            // Horizontal
            // 
            this.Horizontal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Horizontal.AutoSize = true;
            this.Horizontal.Checked = true;
            this.Horizontal.Location = new System.Drawing.Point(142, 29);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(102, 17);
            this.Horizontal.TabIndex = 2;
            this.Horizontal.TabStop = true;
            this.Horizontal.Text = "Горизонтально";
            this.Horizontal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.ControlPanel.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(567, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ПОЛЕ ВТОРОГО ИГРОКА";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.ControlPanel.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПОЛЕ ПЕРВОГО ИГРОКА";
            // 
            // Rule
            // 
            this.Rule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rule.BackColor = System.Drawing.Color.DarkRed;
            this.Rule.ForeColor = System.Drawing.Color.White;
            this.Rule.Location = new System.Drawing.Point(673, 28);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(75, 20);
            this.Rule.TabIndex = 0;
            this.Rule.Text = "ПРАВИЛА";
            this.Rule.UseVisualStyleBackColor = false;
            this.Rule.Click += new System.EventHandler(this.Rules);
            // 
            // Vertical
            // 
            this.Vertical.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vertical.AutoSize = true;
            this.Vertical.Location = new System.Drawing.Point(277, 29);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(91, 17);
            this.Vertical.TabIndex = 3;
            this.Vertical.Text = "Вертикально";
            this.Vertical.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear.BackColor = System.Drawing.Color.Bisque;
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(543, 28);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 20);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "СБРОС";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.ClearShips);
            // 
            // mainButton
            // 
            this.mainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainButton.AutoSize = true;
            this.mainButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainButton.BackColor = System.Drawing.Color.YellowGreen;
            this.mainButton.ForeColor = System.Drawing.Color.Black;
            this.mainButton.Location = new System.Drawing.Point(414, 28);
            this.mainButton.MinimumSize = new System.Drawing.Size(75, 20);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 20);
            this.mainButton.TabIndex = 5;
            this.mainButton.Text = "НАЧАТЬ";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.MainButtonClick);
            // 
            // Palubs
            // 
            this.Palubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Palubs.AutoSize = true;
            this.Palubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Palubs.Location = new System.Drawing.Point(56, 29);
            this.Palubs.Name = "Palubs";
            this.Palubs.Size = new System.Drawing.Size(16, 18);
            this.Palubs.TabIndex = 6;
            this.Palubs.Text = "4";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.ControlPanel.SetColumnSpan(this.checkBox1, 2);
            this.checkBox1.Location = new System.Drawing.Point(353, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "С ботом";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Морской бой";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ControlPanel;
        private System.Windows.Forms.Button Rule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Horizontal;
        private System.Windows.Forms.RadioButton Vertical;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Label Palubs;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

