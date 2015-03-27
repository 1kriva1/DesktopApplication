using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace MouseBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            text_x.Text = "";
            text_y.Text = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            text_x.Text += x.ToString()+Environment.NewLine;
            text_y.Text += y.ToString()+ Environment.NewLine;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        private void button_repeat_Click(object sender, EventArgs e)
        {
            int x, y;
            for (int i = 0; i < text_x.Lines.Length-1; i++)
            {
                x= Convert.ToInt16(text_x.Lines[i]);
                y =Convert.ToInt16(text_y.Lines[i]);
                DoMouseClick(x, y);
            }
        }

        private void save_x_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                File.WriteAllText(saveFD.FileName, text_x.Text, System.Text.Encoding.UTF8);


            }
            catch
            {
                MessageBox.Show("Save file imposible", "Warning");
            }
        }

        private void save_y_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                File.WriteAllText(saveFD.FileName, text_y.Text, System.Text.Encoding.UTF8);


            }
            catch
            {
                MessageBox.Show("Save file imposible", "Warning");
            }
        }

        private void open_x_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                text_x.Text = File.ReadAllText(openFD.FileName, System.Text.Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Open file imposible", "Warning");
            }
        }

        private void open_y_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                text_y.Text = File.ReadAllText(openFD.FileName, System.Text.Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Open file imposible", "Warning");
            }
        }

        
    }
}
