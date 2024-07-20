using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageClipper
{
    public partial class ExecuteWindow : Form
    {
        Bitmap srcBitmap;
        Bitmap clippedBitmap;


        Size clipSize;
        string saveFileString;
        string extension;
        string saveDir;
        int startNum;
        bool addBefore;
        bool isZeroFill;
        int zeroFillNum;

        int verticalNum;
        int horizonalNum;

        int nowNum;

        public ExecuteWindow(Bitmap srcBitmap, Size clipSize, string saveFileString, string extension, string saveDir, int startNum, bool addBefore, bool isZeroFill, int zeroFillNum)
        {
            InitializeComponent();

            this.srcBitmap = srcBitmap;
            this.clipSize = clipSize;
            this.saveFileString = saveFileString;
            this.extension = extension;
            this.saveDir = saveDir;
            this.startNum = startNum;
            this.addBefore = addBefore;
            this.isZeroFill = isZeroFill;
            this.zeroFillNum = zeroFillNum;

            this.verticalNum = this.srcBitmap.Height / clipSize.Height;
            this.horizonalNum = this.srcBitmap.Width / clipSize.Width;

            Rectangle rect = this.GetRect();

            this.clippedBitmap = this.srcBitmap.Clone(rect, srcBitmap.PixelFormat);

            this.saveDirBox.Text = this.saveDir;
            this.fileNameBox.Text = createName();

            resultPicture.Image = clippedBitmap;
            this.nowNum = 0;

            fileNameStr.Text = this.saveFileString;
            serialNum.Value = this.startNum + this.nowNum;

            allNum.Text = (nowNum + 1).ToString() + " / " + (this.verticalNum * this.horizonalNum).ToString();

        }

        private Rectangle GetRect()
        {
            int x;
            int y;
            if (nowNum < horizonalNum)
            {
                x = nowNum;
                y = 0;
            }
            else
            {
                x = nowNum % horizonalNum;
                y = (nowNum) / horizonalNum;
            }

            return new Rectangle(this.clipSize.Width * x, this.clipSize.Height * y, clipSize.Width, clipSize.Height);
        }

        private string createName()
        {
            string tmpFileName = this.fileNameStr.Text;
            string tmpSerial = this.serialNum.Value.ToString();
            if (isZeroFill && this.zeroFillNum > tmpSerial.Length)
            {
                int tmpi = this.zeroFillNum - tmpSerial.Length;
                for (int i = 0; i < tmpi; i++)
                {
                    tmpSerial = "0" + tmpSerial;
                }
            }
            if (addBefore)
            {
                tmpFileName = tmpSerial + tmpFileName;
            }
            else
            {
                tmpFileName = tmpFileName + tmpSerial;
            }
            return tmpFileName + extension;
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            if (!executeClip())
            {
                this.Close();
            }
        }

        public bool executeClip()
        {
            clippedBitmap.Save(this.saveDir + @"\" + createName(), srcBitmap.RawFormat);

            if ((this.verticalNum) * (this.horizonalNum) > nowNum + 1)
            {
                nowNum++;
                serialNum.Value++;
                allNum.Text = (nowNum + 1).ToString() + " / " + (this.verticalNum * this.horizonalNum).ToString();
                this.fileNameBox.Text = createName();
                this.clippedBitmap = this.srcBitmap.Clone(GetRect(), srcBitmap.PixelFormat);

                resultPicture.Image = clippedBitmap;

                this.Refresh();
                return true;
            }
            MessageBox.Show("分割処理が完了しました");
            return false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serialNum_ValueChanged(object sender, EventArgs e)
        {
            this.startNum = (int)serialNum.Value;
            this.fileNameBox.Text = createName();
        }

        private void fileNameStr_TextChanged(object sender, EventArgs e)
        {
            this.fileNameBox.Text = createName();
        }
    }
}
