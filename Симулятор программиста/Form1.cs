using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Симулятор_программиста
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OutputUpdate();
            button1.Click += new EventHandler((object s, EventArgs e) => { Programmer.Eat(); OutputUpdate(); });
            button2.Click += new EventHandler((object s, EventArgs e) => { Programmer.Rest(); OutputUpdate(); });
            button3.Click += new EventHandler((object s, EventArgs e) => { Programmer.Work(); OutputUpdate(); });
            button4.Click += new EventHandler((object s, EventArgs e) => { Programmer.ChangeJob(); OutputUpdate(); });
            button5.Click += new EventHandler((object s, EventArgs e) => { Programmer.BuyHouse(); OutputUpdate(); });
            button6.Click += new EventHandler((object s, EventArgs e) => { Programmer.Practice(); OutputUpdate(); });
        }

        void OutputUpdate()
        {
            progressBar1.Value = Programmer.satiety;
            label1.Text = Programmer.satiety.ToString();
            progressBar2.Value = Programmer.energy;
            label2.Text = Programmer.energy.ToString();
            label3.Text = Programmer.money.ToString() + " ₽";
            label4.Text = Programmer.exp.ToString();
            if (Programmer.house != null)
            {
                label5.Text = Programmer.house.price.ToString() + " ₽";
                label6.Text = Programmer.house.square.ToString();
            }
            label13.Text = Programmer.job.income.ToString() + " ₽";
            label14.Text = Programmer.job.needexp.ToString() + " опыта";
        }
    }
}
