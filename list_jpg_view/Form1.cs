using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_jpg_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public
        int width = 150;
        public
        int height = 150;
        public
        string pub_s;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(
            @"C:\temp", "*.jpg", System.IO.SearchOption.AllDirectories);

            listBox1.Items.AddRange(files);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBox1.Text;
            pub_s = s;
            Bitmap gazou = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics obj = Graphics.FromImage(gazou);

            Bitmap image = new Bitmap(pub_s);
            obj.DrawImage(image, 0, 0, width, height);

            pictureBox1.Image = gazou;

            obj = Graphics.FromImage(gazou);
        }
    }
}
