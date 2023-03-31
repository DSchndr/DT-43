using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anycam_picinserter
{
    public partial class Form1 : Form
    {
        Steuerung dieSteuerung;
        public Form1()
        {
            InitializeComponent();
            dieSteuerung = new Steuerung(this);
        }

        private void button_loaddump_Click(object sender, EventArgs e)
        {
            dieSteuerung.loadfile();
        }

        private void offsetadd_Click(object sender, EventArgs e)
        {
            dieSteuerung.incOffset();
            dieSteuerung.saveval();
            dieSteuerung.draw();
            vScrollBar1.Value = Convert.ToInt32(textBoxOffset.Text);
        }

        private void offsetdec_Click(object sender, EventArgs e)
        {
            dieSteuerung.decOffset();
            dieSteuerung.saveval();
            dieSteuerung.draw();
            vScrollBar1.Value = Convert.ToInt32(textBoxOffset.Text);
        }

        public void setOffsetlabel(string pText)
        {
            textBoxOffset.Text = pText;
        }

        public string getOffsetlabel()
        {
            return textBoxOffset.Text;
        }

        public void setBitmap(Bitmap bmp)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bmp;
        }

        public Bitmap getBitmap()
        {
            return (Bitmap)pictureBox1.Image;
        }

        public void setSize(Size size)
        {
            pictureBox1.Size = size;
        }
        public Size getSize()
        {
            return pictureBox1.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dieSteuerung.draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dieSteuerung.saveval();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxOffset.Text = e.NewValue.ToString();
            dieSteuerung.saveval();
            dieSteuerung.draw();

        }

        public void setVScroll_max(int val)
        {
            vScrollBar1.Maximum = val-1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dieSteuerung.test();
        }

        private void bSaveBitmap_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap|*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = pictureBox1.Width;
                int height = pictureBox1.Height;
                using (Bitmap bmp = new Bitmap(width, height, PixelFormat.Format16bppRgb555))
                {
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void bLoadBitmap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Bitmap|*.bmp|PNG|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = pictureBox1.Width;
                int height = pictureBox1.Height;
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    setBitmap((Bitmap) Image.FromFile(dialog.FileName));

                }
            }
        }

        private void button_patchdump_Click(object sender, EventArgs e)
        {
            dieSteuerung.patch();
        }
    }
}
