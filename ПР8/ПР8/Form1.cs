using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ПР8
{
    public partial class Form1 : Form
    {
        bool drawing;
        int historyCounter;
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        Color historyColor;
        List<Image> History;
        public Form1()
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBarPen.Value;
            History = new List<Image>();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана Шикановым А.Р., Дмитриевым К.В. и Галинским И.П.", "About");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(picDrawingSurface.Size.Width, picDrawingSurface.Size.Height);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));
            Graphics grf = Graphics.FromImage(picDrawingSurface.Image);
            grf.Clear(Color.White);
            grf.DrawImage(picDrawingSurface.Image, 0, 0, picDrawingSurface.Width, picDrawingSurface.Height);
            grf.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                FileStream fs = (FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel) picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picDrawingSurface_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл");
                return;
            }
            if (e.Button == MouseButtons.Middle) currentPen.Color = ((Bitmap)picDrawingSurface.Image).GetPixel(e.X, e.Y);
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            if (e.Button == MouseButtons.Right)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                historyColor = currentPen.Color;
                currentPen.Color = Color.White;
            }
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
            drawing = false;
            if (e.Button == MouseButtons.Right) currentPen.Color = historyColor;
            try
            {
                currentPath.Dispose();
            }
            catch { }
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }

        private void trackBarPen_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.colorResult = currentPen.Color;
            f.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            else MessageBox.Show("История пуста");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            else MessageBox.Show("История пуста");
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }
    }
}
