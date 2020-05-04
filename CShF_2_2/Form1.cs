using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShF_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime d;
                int n;

                d = Convert.ToDateTime(now_date.Text);

                n = Convert.ToInt32(days.Text);

                rez.Text = d.AddDays(-n).ToString("dd.MM.yyyy");
            }

            catch
            {
                rez.Text = "Некоректный ввод данных!";
            }
        }
    }
}
