using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ПР7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }   

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK && listBox3.Items.Count != 0)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox3.Items.Count; i++)
                    Writer.WriteLine((string)listBox3.Items[i]);
                Writer.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение создано разработчиками Шикановым А.Р., Галинским И.П, и Дмитриевым К.В.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox2.Items.Add(Str);
                if (radioButton2.Checked) if (Regex.IsMatch(Str, @"\d")) listBox2.Items.Add(Str);
                if (radioButton3.Checked) if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox2.Items.Add(Str);
            }
            listBox2.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            richTextBox1.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked) foreach (string String in listBox2.Items) if (String.Contains(Find)) listBox1.Items.Add(String);
            if (checkBox2.Checked) foreach (string String in listBox3.Items) if (String.Contains(Find)) listBox1.Items.Add(String);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) DeleteSelectedStrings(listBox2);
            if (checkBox2.Checked) DeleteSelectedStrings(listBox3);
        }

        private void DeleteSelectedStrings(ListBox list)
        {
            for (int i = list.Items.Count - 1; i >= 0; i--) if (list.GetSelected(i)) list.Items.RemoveAt(i);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
                if (listBox2.GetSelected(i))
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                    listBox2.Items.RemoveAt(i);
                };
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
                if (listBox3.GetSelected(i))
                {
                    listBox2.Items.Add(listBox3.Items[i]);
                    listBox3.Items.RemoveAt(i);
                };
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox3.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox3.Items);
            listBox3.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            string biggest = "";
            List<string> sorted = new List<string>();
            switch (comboBox1.SelectedIndex) {
                case 0:
                    listBox2.Sorted = true;
                    listBox2.Sorted = false;
                break;
                case 1:
                    foreach (string element in listBox2.Items) sorted.Add(element);
                    listBox2.Items.Clear();
                    sorted.Sort();
                    sorted.Reverse();
                    listBox2.Items.AddRange(sorted.ToArray());
                    sorted.Clear();
                break;
                case 2:
                    for (int i = listBox2.Items.Count; i > 0; i--)
                    {
                        foreach (string element in listBox2.Items) if (element.Length > biggest.Length) biggest = element;
                        sorted.Add(biggest);
                        listBox2.Items.Remove(biggest);
                        biggest = "";
                    }
                    sorted.Reverse();
                    listBox2.Items.AddRange(sorted.ToArray());
                    sorted.Clear();
                break;
                case 3:
                    for (int i = listBox2.Items.Count; i > 0; i--)
                    {
                        foreach (string element in listBox2.Items) if (element.Length > biggest.Length) biggest = element;
                        sorted.Add(biggest);
                        listBox2.Items.Remove(biggest);
                        biggest = "";
                    }
                    listBox2.Items.AddRange(sorted.ToArray());
                    sorted.Clear();
                    break;
            }
            listBox2.EndUpdate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox3.BeginUpdate();
            string biggest = "";
            List<string> sorted = new List<string>();
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    listBox3.Sorted = true;
                    listBox3.Sorted = false;
                    break;
                case 1:
                    foreach (string element in listBox3.Items) sorted.Add(element);
                    listBox3.Items.Clear();
                    sorted.Sort();
                    sorted.Reverse();
                    listBox3.Items.AddRange(sorted.ToArray());
                    sorted.Clear();
                    break;
                case 2:
                    for (int i = listBox3.Items.Count; i > 0; i--)
                    {
                        foreach (string element in listBox3.Items) if (element.Length > biggest.Length) biggest = element;
                        sorted.Add(biggest);
                        listBox3.Items.Remove(biggest);
                        biggest = "";
                    }
                    sorted.Reverse();
                    listBox3.Items.AddRange(sorted.ToArray());
                    sorted.Clear();
                    break;
                case 3:
                    for (int i = listBox3.Items.Count; i > 0; i--)
                    {
                        foreach (string element in listBox3.Items) if (element.Length > biggest.Length) biggest = element;
                        sorted.Add(biggest);
                        listBox3.Items.Remove(biggest);
                        biggest = "";
                    }
                    listBox3.Items.AddRange(sorted.ToArray());
                    sorted.Clear();
                    break;
            }
            listBox3.EndUpdate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }
    }
}
