using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WallPaper
{
    public partial class Form1 : Form
    {
        Paper paper;
        string dir="paper//";
        string last_picture="";

        public Form1()
        {
            InitializeComponent();
            paper = new Paper(dir);
            combo_style.SelectedIndex = 0;
            ReloadPictures();
        }

        public void ReloadPictures() // load all paper from folder "paper" to list_box
        {
            listBox.Items.Clear();
            string [] list=Directory.GetFiles(dir, "*.jpg");
            foreach (string filename in list)
            {
                listBox.Items.Add(filename.Replace(dir, "").Replace(".jpg", ""));
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0)
                return;
            last_picture = listBox.SelectedItem.ToString() + ".jpg";
            string name = dir + last_picture;
            picture.Image = Image.FromFile(name);
        }

        private void button_place_Click(object sender, EventArgs e)
        {                       
            paper.PlacePicture(last_picture);
        }

        private void combo_style_SelectedIndexChanged(object sender, EventArgs e)
        {
            paper.SetStyle(combo_style.SelectedIndex);
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            paper.SaveImageFromLink(text_link.Text);
            text_link.Text = "";
            ReloadPictures();       
        }

        private void text_link_Click(object sender, EventArgs e)
        {
            text_link.SelectAll();
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBox.SelectedIndex < 0) return;
                File.Delete(dir + listBox.SelectedItem.ToString());
                ReloadPictures();
            }
        }

       

        
    }
}
