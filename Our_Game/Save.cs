using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Game
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void Save_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit(); //хз как это работает, но просто так не хочет закрваться
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Save(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Save(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Save(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.SForm.Hide();
        }
    }
}
