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
        Ship[] pl1Ships, pl2Ships;
        const int mapSize = 11, 
            cellSize = 35;
        string letters = "ABCDEFGHIG";
        string[] digits = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        int numberClick = 0,
            pl1Cells = 20,
            pl2Cells = 20,
            createShips = 9;

        Random rand = new Random();
        Button[,] pl1Buttons = new Button[mapSize - 1, mapSize - 1],
            pl2Buttons = new Button[mapSize - 1, mapSize - 1];

        bool isPlaying = false,
            isPlayer1Step = false;
        public Form1()
        {
            InitializeComponent();
            OnAppStart();
        }
        private void OnAppStart()
        {
            Width = mapSize * 2 * cellSize + 52;
            Height = (mapSize + 1) * cellSize + ControlPanel.Height + 20;
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    if (x == 0 && y == 0) continue;
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
                        button.Tag = new CellInfo(x - 1, y - 1);
                        pl1Buttons[y - 1, x - 1] = button;
                    }
                    Controls.Add(button);
                }
            }
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    if (x == 0 && y == 0) continue;
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
                        button.Tag = new CellInfo(x - 1, y - 1);
                        pl2Buttons[y - 1, x - 1] = button;
                    }
                    Controls.Add(button);
                }
            }
        }

        private void ClearShips(object sender, EventArgs e)
        {
            if (mainButton.Text == "ПРОДОЛЖИТЬ")
            {
                ClearField(ref pl1Buttons, ref pl1Ships);
            }
            else if (mainButton.Text == "СТАРТ")
            {
                ClearField(ref pl2Buttons, ref pl2Ships);
            }
        }

        private void ClearField(ref Button[,] buttons, ref Ship[] ships)
        {
            ships = new Ship[] {
                new Ship(1), new Ship(1), new Ship(1), new Ship(1),
                new Ship(2), new Ship(2), new Ship(2),
                new Ship(3), new Ship(3),
                new Ship(4),
            };
            foreach (Button button in buttons)
            {
                button.BackColor = SystemColors.ButtonHighlight;
                ((CellInfo)button.Tag).isShip = false;
                ((CellInfo)button.Tag).ship = null;
            }
            createShips = 9;
            Palubs.Text = "4";
        }

        private void MainButtonClick(object sender, EventArgs e)
        {
            Button mainButton = ((Button)sender);
            switch (numberClick)
            {
                case 0:
                    ClearField(ref pl1Buttons, ref pl1Ships);
                    ClearField(ref pl2Buttons, ref pl2Ships);
                    pl1Cells = 20;
                    pl2Cells = 20;
                    mainButton.Text = "ПРОДОЛЖИТЬ";
                    Palubs.Visible = true;
                    MessageBox.Show("Игрок 1 расставляет корабли", "Морской бой");
                    foreach (Button button in pl1Buttons) button.Enabled = true;
                    numberClick++;
                    break;
                case 1:
                    if (createShips != -1)
                    {
                        MessageBox.Show($"Для продолжения все корабли должны быть расставлены.");
                        return;
                    }
                    createShips = 9;
                    Palubs.Text = "4";
                    mainButton.Text = "СТАРТ";
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
                    if (createShips != -1)
                    {
                        MessageBox.Show($"Для продолжения все корабли должны быть расставлены.");
                        return;
                    }
                    Palubs.Visible = false;
                    mainButton.Text = "ЗАВЕРШИТЬ";
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
                    foreach (Button button in pl1Buttons)
                    {
                        button.Enabled = false;
                        if (((CellInfo)button.Tag).isShip && button.BackColor != Color.Red) button.BackColor = Color.Blue;
                    }
                    foreach (Button button in pl2Buttons)
                    {
                        button.Enabled = false;
                        if (((CellInfo)button.Tag).isShip && button.BackColor != Color.Red) button.BackColor = Color.Blue;
                    }
                    if (pl1Cells > pl2Cells) MessageBox.Show("Выиграл игрок 1, т.к. у него осталось больше кораблей", "Морской бой");
                    else if (pl2Cells > pl1Cells) MessageBox.Show("Выиграл игрок 2, т.к. у него осталось больше кораблей", "Морской бой");
                    else MessageBox.Show("Ничья, кораблей одинаково у обоих игроков", "Морской бой");
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
                if (info.isShip) return;
                else
                {
                    if (createShips >= 0)
                    {
                        if (mainButton.Text == "ПРОДОЛЖИТЬ") PlaceShips(info, ref pl1Ships, ref pl1Buttons);
                        else if (mainButton.Text == "СТАРТ") PlaceShips(info, ref pl2Ships, ref pl2Buttons);
                    }
                    else MessageBox.Show("Корабли закончились", "Sea Battle");
                }
            }
            else
            {
                if (clickedButton.BackColor == Color.FromArgb(203, 242, 245) || clickedButton.BackColor == Color.Red) return;
                if (info.isShip)
                {
                    if (isPlayer1Step) pl2Cells--;
                    else pl1Cells--;
                    clickedButton.BackColor = Color.Red;
                    shipShot = true;
                    info.ship.decks--;
                    Button[,] buttons = isPlayer1Step ? pl2Buttons : pl1Buttons;
                    if (info.ship.decks == 0)
                    {
                        foreach (Button cell in info.ship.cells)
                        {
                            CellInfo inf = (CellInfo)cell.Tag;
                            for (int y = Math.Max(inf.y - 1, 0); y <= Math.Min(inf.y + 1, mapSize - 2); y++)
                            {
                                for (int x = Math.Max(inf.x - 1, 0); x <= Math.Min(inf.x + 1, mapSize - 2); x++)
                                {
                                    if (!((CellInfo)buttons[y, x].Tag).isShip) buttons[y, x].BackColor = Color.FromArgb(203, 242, 245);
                                }
                            }
                        }
                    }
                }
                else
                {
                    clickedButton.BackColor = Color.FromArgb(203, 242, 245);
                }

                if (!shipShot) isPlayer1Step = !isPlayer1Step;

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

                if (pl1Cells == 0 || pl2Cells == 0)
                {
                    foreach (Button button in pl1Buttons)
                    {
                        button.Enabled = false;
                        if (((CellInfo)button.Tag).isShip && button.BackColor != Color.Red) button.BackColor = Color.Blue;
                    }
                    foreach (Button button in pl2Buttons)
                    {
                        button.Enabled = false;
                        if (((CellInfo)button.Tag).isShip && button.BackColor != Color.Red) button.BackColor = Color.Blue;
                    }
                    if (pl1Cells == 0) MessageBox.Show("Игрок 2 выиграл!", "Морской бой");
                    if (pl2Cells == 0) MessageBox.Show("Игрок 1 выиграл!", "Морской бой");
                    mainButton.Text = "НАЧАТЬ ЗАНОВО";
                    isPlaying = false;
                    numberClick = 0;
                }
            }
        }

        private void PlaceShips(CellInfo info, ref Ship[] ships, ref Button[,] field)
        {
            for (int y = Math.Max(info.y - 1, 0); y <= Math.Min(info.y + (Horizontal.Checked ? 1 : ships[createShips].decks), mapSize - 2); y++)
            {
                for (int x = Math.Max(info.x - 1, 0); x <= Math.Min(info.x + (Horizontal.Checked ? ships[createShips].decks : 1), mapSize - 2); x++)
                {
                    CellInfo inf = (CellInfo)field[y, x].Tag;
                    if (inf.isShip)
                    {
                        MessageBox.Show("Невозможно расположить корабль: он касается соседних кораблей", "Sea Battle");
                        return;
                    }
                }
            }
            if ((Horizontal.Checked ? info.x : info.y) + ships[createShips].decks < mapSize)
            {
                for (int i = 0; i < ships[createShips].decks; i++)
                {
                    Button button = field[Horizontal.Checked ? info.y : info.y + i, Horizontal.Checked ? info.x + i : info.x];
                    CellInfo inf = (CellInfo)button.Tag;
                    inf.ship = ships[createShips];
                    inf.isShip = true;
                    inf.ship.cells[i] = button;
                    button.BackColor = Color.Blue;
                }
                createShips--;
                if (createShips != -1) Palubs.Text = ships[createShips].decks.ToString();
                else Palubs.Text = "0";
            }
            else
            {
                MessageBox.Show("Невозможно расположить корабль: он выходит за границы поля", "Sea Battle");
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