using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anycam_picinserter
{
    public class Daten
    {
        private string Filepath = "";
        private int Filesize = -1;
        private byte[] Filebuffer;
        private int offset = 55644;
        private int bitmapwidth = 16;
        private int bitmapheight = 18*10;
        private int textsize = 32;

        public void setFilepath(string pFilepath)
        {
            Filepath = pFilepath;   
        }

        public string getFilepath()
        {
            return Filepath;
        }

        public void setFilesize(int pFilesize)
        {
            Filesize = pFilesize;
        }

        public int getFilesize()
        {
            return Filesize;
        }

        public void setFilebuffer(byte[] pFilebuffer)
        {
            Filebuffer = pFilebuffer;
        }

        public byte[] getFilebuffer()
        {
            return Filebuffer;
        }

        public void setOffset(int pInt)
        {
            offset = pInt;
        }

        public int getOffset()
        {
            return offset;
        }

        public void setBitmapWidth(int pBw)
        {
            bitmapwidth = pBw;
        }
        public int getBitmapWidth()
        {
            return bitmapwidth;
        }

        public void setBitmapHeight(int pBh)
        {
            bitmapheight = pBh;
        }
        public int getBitmapHeight()
        {
            return bitmapheight;
        }
        public int getTextsize()
        {
            return textsize;
        }
        public void setTextsize(int pTextsize)
        {
            textsize = pTextsize;
        }

    }
}
