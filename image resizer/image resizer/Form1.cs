using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;

namespace image_resizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Computer Comp = new Computer();
        string folder = @"";
        string[] foldersList;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folder = folderBrowserDialog1.SelectedPath;
            FolderDir.Text = folder;
            foldersList = Directory.GetFiles(folder);
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            if (X.Text != "" || X.Text == "1")
            {
                X.Text = "10";
            }
            for (int i = 0; i < foldersList.Length; i++)
            {
                Bitmap input = new Bitmap(File.Open(foldersList[i], FileMode.Open));
                resizeAndSave(i, input);
            }
            MessageBox.Show("Ready!");
            Close();
        }

        void resizeAndSave(int i,Image input)
        {
            int size = Convert.ToInt32(X.Text);
            var ratioX = (double)size / input.Width;
            var ratioY = (double)size / input.Height;
            var ratio = Math.Min(ratioX, ratioY);
            var newWidth = (int)(input.Width * ratio);
            var newHeight = (int)(input.Height * ratio);
            Size S = new Size(newWidth, newHeight);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            Graphics grf = Graphics.FromImage((Bitmap)resizedImage);
            grf.DrawImage(input, new Rectangle(Point.Empty, S));
            resizedImage.Save($@"{folder}\{i}.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}