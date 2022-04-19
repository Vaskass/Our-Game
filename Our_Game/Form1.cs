using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Our_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 35; i++)
            {
                Program.inventory[i] = "";
                Program.selecteditem[i] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.f2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.SForm.button4_Click(null,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.LForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Load(4);
            if (Program.loadError)
                this.Show();
            else
                Program.f4.Show();
            
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                string[] TryLoad = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\AutoSave2.txt").Split('.');
                TextReader saveRead = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SAVES\\AutoSave.txt");
                int[] TryLoad2 = saveRead.ReadToEnd().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
                saveRead.Close();
                if (TryLoad.Length == 37 && TryLoad2.Length == 15)
                    button3.Enabled = true;
                else button3.Enabled = false;
            }
            catch (Exception)
            {
                button3.Enabled = false;
            }

        }
    }
}
