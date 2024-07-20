using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImageClipper
{
    public partial class Main : Form
    {
        private Bitmap srcBitmap;
        private string extension;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void imageFileOpenButton_Click(object sender, EventArgs e)
        {
            if (imageFileDialog.ShowDialog() == DialogResult.OK)
            {

                imageFileNameText.Text = imageFileDialog.FileName;

                toolTip.SetToolTip(imageFileNameText, imageFileNameText.Text);
                srcBitmap = new Bitmap(imageFileNameText.Text);
                srcImage.Image = srcBitmap;
                srcImage.Width = srcImage.Image.Width;
                srcImage.Height = srcImage.Image.Height;
                executeButton.Enabled = true;
                this.extension = Path.GetExtension(imageFileDialog.FileName);
                Console.WriteLine(extension);

            }
            else
            {
                executeButton.Enabled = false;
            }
        }

        private void saveDirectorySelectBotan_Click(object sender, EventArgs e)
        {
            if (saveFolderDialog.ShowDialog() == DialogResult.OK)
            {
                saveDirectoryText.Text = saveFolderDialog.SelectedPath;
                toolTip.SetToolTip(saveDirectoryText, saveDirectoryText.Text);
            }
        }

        private void isSquere_CheckedChanged(object sender, EventArgs e)
        {
            clipHeight.Enabled = !isSquere.Checked;
            hLabel.Enabled = !isSquere.Checked;
            hPxLabel.Enabled = !isSquere.Checked;
        }

        private void digitNum_ValueChanged(object sender, EventArgs e)
        {
            if (digitNum.Value > 2)
            {
                startNo.Maximum = this.DigitCalc((int)digitNum.Value);
            }
            else
            {
                startNo.Maximum = 99;
            }
        }

        private void isZeroFill_CheckedChanged(object sender, EventArgs e)
        {
            if (isZeroFill.Checked)
            {
                digitNum.Enabled = true;
                digitLabel.Enabled = true;
                startNo.Maximum = this.DigitCalc((int)digitNum.Value);
            }
            else
            {
                digitNum.Enabled = false;
                digitLabel.Enabled = false;
                startNo.Maximum = 9999999999;
            }
        }

        private int DigitCalc(int digit)
        {
            int tmpNum = 10;
            for (int i = 1; i < digit; i++)
            {
                tmpNum = tmpNum * 10;
            }
            tmpNum--;
            return tmpNum;
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (srcImage.Image != null)
            {
                decimal wNum = srcImage.Width % clipWidth.Value;
                decimal hNum;
                if (this.isSquere.Checked)
                {
                    hNum = wNum;
                }
                else
                {
                    hNum = srcImage.Height % clipHeight.Value;
                }
                if (wNum == 0 && hNum == 0)
                {
                    ExecuteWindow win = new ExecuteWindow(srcBitmap,
                        new Size((int)clipWidth.Value, (int)clipHeight.Value),
                        saveFileString.Text, extension, saveDirectoryText.Text,
                        (int)startNo.Value,
                        isAddFileNameBefore.Checked,
                        isZeroFill.Checked,
                        (int)digitNum.Value);
                    if (isNoCheckDialog.Checked)
                    {
                        while (win.executeClip()) { }
                    }
                    else
                    {
                        win.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("切り抜きサイズで画像ファイルのサイズを割り切ることができません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("画像ファイルが選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info infoBox = new Info();
            infoBox.ShowDialog();
        }





    }
}
