using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    public partial class Form1 : Form
    {
        Button mainButton;
        const int mapSize = 11, 
            cellSize = 35;
        string letters = "ABCDEFGHIG";
        string[] digits = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        int numberClick = 0,
            pl1Ships = 0,
            pl2Ships = 0;

        Random rand = new Random();
        Button[,] pl1Buttons = new Button[mapSize - 1, mapSize - 1],
            pl2Buttons = new Button[mapSize - 1, mapSize - 1];

        bool isPlaying = false,
            isPlayer1Step = false;
        public Form1()
        {
            InitializeComponent();
            CreateFields();
        }
        private void CreateFields()
        {
            Width = mapSize * 2 * cellSize + 52;
            Height = (mapSize + 1) * cellSize + 80;
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    Button button = new Button();
                    button.Location = new Point(x * cellSize, y * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.Enabled = false;
                    if (x == 0 || y == 0)
                    {
                        button.BackColor = Color.LightBlue;
                        button.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold);
                        if (x == 0 && y > 0) button.Text = digits[y - 1];
                        else if (y == 0 && x > 0) button.Text = letters[x - 1].ToString();
                    }
                    else
                    {
                        button.BackColor = SystemColors.ButtonHighlight;
                        button.Click += new EventHandler(ButtonClick);
                        button.Tag = new CellInfo();
                        pl1Buttons[x - 1, y - 1] = button;
                    }
                    Controls.Add(button);
                }
            }
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    Button button = new Button();
                    button.Location = new Point(cellSize * mapSize + x * cellSize + 36, y * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.Enabled = false;
                    if (x == 0 || y == 0)
                    {
                        button.BackColor = Color.FromArgb(255, 100, 100);
                        button.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold);
                        if (x == 0 && y > 0) button.Text = digits[y - 1];
                        else if (y == 0 && x > 0) button.Text = letters[x - 1].ToString();
                    }
                    else
                    {
                        button.BackColor = SystemColors.ButtonHighlight;
                        button.Click += new EventHandler(ButtonClick);
                        button.Tag = new CellInfo();
                        pl2Buttons[x - 1, y - 1] = button;
                    }
                    Controls.Add(button);
                }
            }
            Label map1 = new Label();
            map1.ForeColor = Color.Blue; 
            map1.Text = "ПОЛЕ ПЕРВОГО ИГРОКА";
            map1.Font = new Font(map1.Font, FontStyle.Bold);
            map1.AutoSize = true;
            map1.Location = new Point(cellSize * mapSize / 2 - map1.Width / 2, mapSize * cellSize + 20);
            Controls.Add(map1);

            Label map2 = new Label();
            map2.ForeColor = Color.Red;
            map2.Text = "ПОЛЕ ВТОРОГО ИГРОКА";
            map2.Font = new Font(map2.Font, FontStyle.Bold);
            map2.AutoSize = true;
            map2.Location = new Point((cellSize * mapSize / 2 - map1.Width / 2) + (cellSize * mapSize) + 36, mapSize * cellSize + 20);
            Controls.Add(map2);

            mainButton = new Button();
            mainButton.BackColor = Color.YellowGreen;
            mainButton.Text = "НАЧАТЬ";
            mainButton.AutoSize = true;
            mainButton.Click += new EventHandler(MainButtonClick);
            mainButton.Location = new Point(Width / 2 - mainButton.Width / 2, mapSize * cellSize + 40);
            mainButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(mainButton);

            Button rulesButton = new Button();
            rulesButton.BackColor = Color.DarkRed;
            rulesButton.ForeColor = Color.White;
            rulesButton.Text = "ПРАВИЛА";
            rulesButton.AutoSize = true;
            rulesButton.Click += new EventHandler(Rules);
            rulesButton.Location = new Point(Width - rulesButton.Width - 36, Height - rulesButton.Height - 50);
            Controls.Add(rulesButton);
        }
        private void MainButtonClick(object sender, EventArgs e)
        {
            Button mainButton = ((Button)sender);
            switch (numberClick)
            {
                case 0:
                    foreach (Button button in pl1Buttons)
                    {
                        button.BackColor = SystemColors.ButtonHighlight;
                        ((CellInfo)button.Tag).isShip = false;
                    }
                    foreach (Button button in pl2Buttons)
                    {
                        button.BackColor = SystemColors.ButtonHighlight;
                        ((CellInfo)button.Tag).isShip = false;
                    }
                    pl1Ships = 0;
                    pl2Ships = 0;
                    mainButton.Text = "ПРОДОЛЖИТЬ";
                    mainButton.Location = new Point(Width / 2 - mainButton.Width / 2, mapSize * cellSize + 40);
                    MessageBox.Show("Игрок 1 расставляет корабли", "Морской бой");
                    foreach (Button button in pl1Buttons) button.Enabled = true;
                    numberClick++;
                    break;
                case 1:
                    if (pl1Ships != 20)
                    {
                        MessageBox.Show($"Для продолжения на поле должно быть 20 кораблей. Сейчас количество кораблей {pl1Ships}");
                        return;
                    }
                    mainButton.Text = "СТАРТ";
                    mainButton.Location = new Point(Width / 2 - mainButton.Width / 2, mapSize * cellSize + 40);
                    foreach (Button button in pl1Buttons)
                    {
                        button.Enabled = false;
                        button.BackColor = SystemColors.ButtonHighlight;
                    }
                    MessageBox.Show("Игрок 2 расставляет корабли", "Морской бой");
                    foreach (Button button in pl2Buttons) button.Enabled = true;
                    numberClick++;
                    break;
                case 2:
                    if (pl2Ships != 20)
                    {
                        MessageBox.Show($"Для продолжения на поле должно быть 20 кораблей. Сейчас количество кораблей {pl2Ships}");
                        return;
                    }
                    mainButton.Text = "ЗАВЕРШИТЬ";
                    mainButton.Location = new Point(Width / 2 - mainButton.Width / 2, mapSize * cellSize + 40);
                    if (rand.Next(0, 2) == 0) isPlayer1Step = true;
                    else isPlayer1Step = false;
                    isPlaying = true;
                    if (isPlayer1Step)
                    {
                        foreach (Button button in pl2Buttons) button.BackColor = SystemColors.ButtonHighlight;
                        MessageBox.Show("Начинает игрок 1", "Морской бой");
                    }
                    else
                    {
                        foreach (Button button in pl1Buttons) button.Enabled = true;
                        foreach (Button button in pl2Buttons)
                        {
                            button.Enabled = false;
                            button.BackColor = SystemColors.ButtonHighlight;
                        }
                        MessageBox.Show("Начинает игрок 2", "Морской бой");
                    }
                    numberClick++;
                    break;
                case 3:
                    mainButton.Text = "НАЧАТЬ ЗАНОВО";
                    foreach (Button button in pl1Buttons) button.Enabled = false;
                    foreach (Button button in pl2Buttons) button.Enabled = false;
                    if (pl1Ships > pl2Ships) MessageBox.Show("Выиграл игрок 1, т.к. у него осталось больше кораблей", "Морской бой");
                    else if (pl2Ships > pl1Ships) MessageBox.Show("Выиграл игрок 2, т.к. у него осталось больше кораблей", "Морской бой");
                    else MessageBox.Show("Ничья, кораблей одинаково у обоих игроков", "Морской бой");
                    mainButton.Location = new Point(Width / 2 - mainButton.Width / 2, mapSize * cellSize + 40);
                    isPlaying = false;
                    numberClick = 0;
                    break;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            CellInfo info = (CellInfo)clickedButton.Tag;
            bool shipShot = false;
            if (!isPlaying)
            {
                if (!info.isShip)
                {
                    if (numberClick == 1) pl1Ships++;
                    else pl2Ships++;
                    info.isShip = true;
                    clickedButton.BackColor = Color.Blue;
                }
                else
                {
                    if (numberClick == 1) pl1Ships--;
                    else pl2Ships--;
                    info.isShip = false;
                    clickedButton.BackColor = SystemColors.ButtonHighlight;
                }
            }
            else
            {
                if (clickedButton.BackColor == Color.DarkCyan || clickedButton.BackColor == Color.Red) return;
                if (info.isShip && isPlayer1Step)
                {
                    pl2Ships--;
                    clickedButton.BackColor = Color.Red;
                    shipShot = true;
                }
                else if (info.isShip && !isPlayer1Step)
                {
                    pl1Ships--;
                    clickedButton.BackColor = Color.Red;
                    shipShot = true;
                }
                else
                {
                    clickedButton.BackColor = Color.DarkCyan;
                }

                if (!shipShot)
                {
                    isPlayer1Step = !isPlayer1Step;
                }

                if (!isPlayer1Step)
                {
                    foreach (Button button in pl1Buttons) button.Enabled = true;
                    foreach (Button button in pl2Buttons) button.Enabled = false;
                }
                else
                {
                    foreach (Button button in pl1Buttons) button.Enabled = false;
                    foreach (Button button in pl2Buttons) button.Enabled = true;
                }

                if (pl1Ships == 0 || pl2Ships == 0)
                {
                    foreach (Button button in pl1Buttons) button.Enabled = false;
                    foreach (Button button in pl2Buttons) button.Enabled = false;
                    if (pl1Ships == 0) MessageBox.Show("Игрок 2 выиграл!", "Морской бой");
                    if (pl2Ships == 0) MessageBox.Show("Игрок 1 выиграл!", "Морской бой");
                    mainButton.Text = "НАЧАТЬ ЗАНОВО";
                    mainButton.Location = new Point(Width / 2 - mainButton.Width / 2, mapSize * cellSize + 40);
                    isPlaying = false;
                    numberClick = 0;
                }
            }
        }
        private void Rules(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("https://legkonauchim.ru/igry/kak-nauchitsya-igrat-v-morskoj-boj");
            process.Start();
        }
    }
}

