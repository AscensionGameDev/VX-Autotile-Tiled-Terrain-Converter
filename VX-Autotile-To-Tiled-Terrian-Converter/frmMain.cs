using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Purpose_Graphic_Splitter
{
    public partial class frmMain : Form
    {
        private Bitmap sampleImg;
        private Rectangle selectRect = Rectangle.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Multiselect = false;
            fbd.CheckFileExists = true;
            fbd.DefaultExt = ".png";
            fbd.Filter = "Png Files|*.png";
            grpStep2.Hide();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = fbd.FileName;
                if (File.Exists(fbd.FileName))
                {
                    grpStep2.Show();
                    sampleImg = new Bitmap(fbd.FileName);
                    UpdatePreview();
                }
            }
        }

        private void UpdatePreview()
        {
            int i = 0;
            int w = 0;
            int h = 0;
            var img = new Bitmap(sampleImg.Width, sampleImg.Height);
            pnlSampleImg.Width = sampleImg.Width;
            pnlSampleImg.Height = sampleImg.Height;
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, pnlSampleImg.Width, pnlSampleImg.Height));
            g.DrawImage(sampleImg, new Rectangle(0, 0, sampleImg.Width, sampleImg.Height), new Rectangle(0, 0, sampleImg.Width, sampleImg.Height),GraphicsUnit.Pixel);
            if (selectRect != Rectangle.Empty)
            {
                g.DrawRectangle(new Pen(Color.White, 4f),selectRect);
            }
            g.Dispose();
            pnlSampleImg.BackgroundImage = img;
        }

        private void pnlSampleImg_MouseDown(object sender, MouseEventArgs e)
        {
            var x = (int)Math.Floor(e.X / 32f);
            var y = (int)Math.Floor(e.Y / 32f);
            selectRect = Rectangle.Empty;
            if (x >= 0 && y >= 0 && (x * 32 + 64) <= pnlSampleImg.Width && (y * 32 + 96) <= pnlSampleImg.Height)
            {
                selectRect = new Rectangle(x * 32, y * 32, 64, 96);
            }
            UpdatePreview();
        }

        private void pnlSampleImg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var x = (int)Math.Floor(e.X / 32f);
            var y = (int)Math.Floor(e.Y / 32f);
            if (selectRect != Rectangle.Empty && selectRect.X == x * 32 && selectRect.Y == y * 32)
            {
                var b = new Bitmap(128, 64);
                var g = Graphics.FromImage(b);
                g.Clear(Color.Transparent);


                //Top Left
                g.DrawImage(sampleImg, new Rectangle(0, 0, 16, 16), new Rectangle(selectRect.X + 48, selectRect.Y + 16, 16,16), GraphicsUnit.Pixel);
                //Left
                g.DrawImage(sampleImg, new Rectangle(0, 16, 16, 32), new Rectangle(selectRect.X + 48, selectRect.Y + 48, 16, 32), GraphicsUnit.Pixel);
                //Bottom Left
                g.DrawImage(sampleImg, new Rectangle(0, 48, 16, 16), new Rectangle(selectRect.X + 48, selectRect.Y + 0, 16, 16), GraphicsUnit.Pixel);
                //Top
                g.DrawImage(sampleImg, new Rectangle(16, 0, 32, 16), new Rectangle(selectRect.X + 16, selectRect.Y + 80, 32, 16), GraphicsUnit.Pixel);
                //Bottom
                g.DrawImage(sampleImg, new Rectangle(16, 48, 32, 16), new Rectangle(selectRect.X + 16, selectRect.Y + 32, 32, 16), GraphicsUnit.Pixel);
                //Top Right
                g.DrawImage(sampleImg, new Rectangle(48, 0, 16, 16), new Rectangle(selectRect.X + 32, selectRect.Y + 16, 16, 16), GraphicsUnit.Pixel);
                //Right
                g.DrawImage(sampleImg, new Rectangle(48, 16, 16, 32), new Rectangle(selectRect.X + 0, selectRect.Y + 48, 16, 32), GraphicsUnit.Pixel);
                //Bottom Right
                g.DrawImage(sampleImg, new Rectangle(48, 48, 16, 16), new Rectangle(selectRect.X + 32, selectRect.Y + 0, 16, 16), GraphicsUnit.Pixel);



                //Right Chunk
                g.DrawImage(sampleImg, new Rectangle(64, 0, 64, 64), new Rectangle(selectRect.X, selectRect.Y + 32, 64, 64), GraphicsUnit.Pixel);

                g.Dispose();

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Png Image|*.png";
                saveFileDialog1.Title = "Save Terrain Tile";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog1.FileName != "")
                {
                    b.Save(saveFileDialog1.FileName,ImageFormat.Png);
                }
            }
        }
    }
}
