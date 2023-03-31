using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anycam_picinserter
{
    public class Steuerung
    {
        private Form1 GUI;
        private Daten dieDaten = new Daten();

        public Steuerung(Form1 form1)
        {
            this.GUI = form1;
            loaddefaultvalues();
        }

        private void loaddefaultvalues()
        {
            GUI.textBoxOffset.Text = dieDaten.getOffset().ToString();
            GUI.textBoxBMHeight.Text = dieDaten.getBitmapHeight().ToString();
            GUI.textBoxBMWidth.Text = dieDaten.getBitmapWidth().ToString();
            GUI.textBoxTextSize.Text = dieDaten.getTextsize().ToString();
        }

        public void loadfile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    byte[] filecontent = File.ReadAllBytes(file);
                    dieDaten.setFilebuffer(filecontent);
                    dieDaten.setFilesize(filecontent.Length);
                    dieDaten.setFilepath(file);
                    GUI.setVScroll_max(filecontent.Length);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error loading file");
                }
            }
        }

        internal void saveval()
        {
            dieDaten.setOffset(Convert.ToInt32(GUI.getOffsetlabel()));
            dieDaten.setTextsize(Convert.ToInt32(GUI.textBoxTextSize.Text));
        }
        internal void incOffset()
        {
            dieDaten.setOffset(dieDaten.getOffset() + 1);
            GUI.setOffsetlabel(dieDaten.getOffset().ToString());
        }

        internal void decOffset()
        {
            dieDaten.setOffset(dieDaten.getOffset() - 1);
            GUI.setOffsetlabel(dieDaten.getOffset().ToString());
        }

        public void draw()
        {
            int begin = dieDaten.getOffset();
            int stride = 2*18;
            List<Bitmap> images = new List<Bitmap>();

            byte[] data = dieDaten.getFilebuffer();

            for (int i = 0; i < Convert.ToInt32(GUI.textBoxBMHeight.Text); i++)
                images.Add(ExtractBitmap(data, begin + i * stride));

            Bitmap temp = ConcatBitmaps(images.ToArray(), Convert.ToInt32(GUI.textBoxBMWidth.Text));

            GUI.setSize(temp.Size);
            GUI.setBitmap(temp);
        }


        public Bitmap ConcatBitmaps(Bitmap[] bitmaps, int columns)
        { 
            int bitmapHeight = (int)Math.Ceiling((double)bitmaps.Length / (double)columns);

            Bitmap bmp = new Bitmap(columns * 12, bitmapHeight * 18, PixelFormat.Format16bppRgb555);

            for (int i = 0; i < bitmaps.Length; i++)
                for (int y = 0; y < 18; y++)
                    for (int x = 0; x < 12; x++)
                        bmp.SetPixel((i%columns)*12+x, (i/columns)*18+y, bitmaps[i].GetPixel(x, y));
            
            return bmp;
        }

        public Bitmap ExtractBitmap(byte[] data, int offset)
        {
            Bitmap bmp = new Bitmap(12, 18, PixelFormat.Format16bppRgb555);
            ushort[] imageData = new ushort[bmp.Height];

            for (int i = 0; i < imageData.Length; i++)
            {
                imageData[i] |= Convert.ToUInt16(data[offset + 2 * i] << 8);
                imageData[i] |= data[offset + 2 * i + 1];
            }

            for (int y = 0; y < imageData.Length; y++)
            {
                ushort mask = 0b1000_0000_0000_0000;
                for (int i = 0; i < 12; i++)
                {
                    bmp.SetPixel(i, y, (mask & imageData[y]) != 0 ? Color.Black : Color.White);
                    mask >>= 1;
                }
            }
            
            return bmp;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
        public void test()
        {
            Bitmap bmp = GUI.getBitmap();

            Console.WriteLine(ByteArrayToString(ConvertBitmapToBytes(bmp, Convert.ToInt32(GUI.textBoxBMWidth.Text))));
        }

        public static byte[] ConvertBitmapToBytes(Bitmap bmp, int columns)
        {
            int width = bmp.Width;
            int height = bmp.Height;

            int rows = (int)Math.Ceiling((double)height / 18);
            int stride = 2 * 18;

            byte[] data = new byte[rows * columns * stride];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int x = j * 12;
                    int y = i * 18;
                    int dataIndex = i * columns * stride + j * stride;

                    for (int k = 0; k < 18; k++)
                    {
                        ushort pixelData = 0;

                        for (int l = 0; l < 12; l++)
                        {
                            Color c = bmp.GetPixel(x + l, y + k);
                            if (c.GetBrightness() < 0.5)
                                pixelData |= (ushort)(1 << (15 - l));
                        }

                        data[dataIndex + 2 * k] = (byte)(pixelData >> 8);
                        data[dataIndex + 2 * k + 1] = (byte)(pixelData & 0xFF);
                    }
                }
            }

            return data;
        }


        public void patch()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Dump File|*.dt43d";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int offset = dieDaten.getOffset();
                byte[] patched = ReplaceArrayData(dieDaten.getFilebuffer(), ConvertBitmapToBytes(GUI.getBitmap(), Convert.ToInt32(GUI.textBoxBMWidth.Text)), offset);
                var writer = new BinaryWriter(File.OpenWrite(dialog.FileName));
                writer.Write(patched);
                writer.Close();
            }
        }
        public byte[] ReplaceArrayData(byte[] bigArray, byte[] smallArray, int offset)
        {
            byte[] newArray = new byte[bigArray.Length];
            Array.Copy(bigArray, newArray, bigArray.Length);

            for (int i = 0; i < smallArray.Length; i++)
            {
                newArray[i + offset] = smallArray[i];
            }

            return newArray;
        }

    }
}
