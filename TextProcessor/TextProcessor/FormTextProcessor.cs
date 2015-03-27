using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace TextProcessor
{
    public partial class FormTextProcessor : Form
    {
        public FormTextProcessor()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                textBox_editor.Text = File.ReadAllText(openFD.FileName, System.Text.Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Open file imposible", "Warning");
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                File.WriteAllText(saveFD.FileName, textBox_editor.Text, System.Text.Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Save file imposible", "Warning");
            }
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            if (textBox_pattern.Text == "")
                return;
            textBox_editor.Text = textBox_editor.Text.Replace(textBox_pattern.Text, textBox_change.Text);
        }
    }
}
