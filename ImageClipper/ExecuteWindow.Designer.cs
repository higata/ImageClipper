namespace ImageClipper
{
    partial class ExecuteWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultPicture = new System.Windows.Forms.PictureBox();
            this.execButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.saveDirBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNum = new System.Windows.Forms.NumericUpDown();
            this.allNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNum)).BeginInit();
            this.SuspendLayout();
            // 
            // resultPicture
            // 
            this.resultPicture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultPicture.Location = new System.Drawing.Point(12, 8);
            this.resultPicture.Name = "resultPicture";
            this.resultPicture.Size = new System.Drawing.Size(96, 96);
            this.resultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resultPicture.TabIndex = 0;
            this.resultPicture.TabStop = false;
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(283, 81);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(75, 23);
            this.execButton.TabIndex = 0;
            this.execButton.Text = "保存";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(364, 81);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "中止";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(170, 31);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.ReadOnly = true;
            this.fileNameBox.Size = new System.Drawing.Size(269, 19);
            this.fileNameBox.TabIndex = 2;
            this.fileNameBox.TabStop = false;
            // 
            // saveDirBox
            // 
            this.saveDirBox.Location = new System.Drawing.Point(170, 56);
            this.saveDirBox.Name = "saveDirBox";
            this.saveDirBox.ReadOnly = true;
            this.saveDirBox.Size = new System.Drawing.Size(269, 19);
            this.saveDirBox.TabIndex = 2;
            this.saveDirBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "→出力名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "保存先";
            // 
            // fileNameStr
            // 
            this.fileNameStr.Location = new System.Drawing.Point(170, 8);
            this.fileNameStr.Name = "fileNameStr";
            this.fileNameStr.Size = new System.Drawing.Size(162, 19);
            this.fileNameStr.TabIndex = 2;
            this.fileNameStr.TextChanged += new System.EventHandler(this.fileNameStr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "ファイル名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "連番";
            // 
            // serialNum
            // 
            this.serialNum.Location = new System.Drawing.Point(373, 9);
            this.serialNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.serialNum.Name = "serialNum";
            this.serialNum.Size = new System.Drawing.Size(66, 19);
            this.serialNum.TabIndex = 3;
            this.serialNum.ValueChanged += new System.EventHandler(this.serialNum_ValueChanged);
            // 
            // allNum
            // 
            this.allNum.AutoSize = true;
            this.allNum.Location = new System.Drawing.Point(168, 86);
            this.allNum.Name = "allNum";
            this.allNum.Size = new System.Drawing.Size(0, 12);
            this.allNum.TabIndex = 4;
            // 
            // ExecuteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(451, 116);
            this.Controls.Add(this.serialNum);
            this.Controls.Add(this.fileNameStr);
            this.Controls.Add(this.allNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveDirBox);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.resultPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExecuteWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "分割実行";
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resultPicture;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.TextBox saveDirBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown serialNum;
        private System.Windows.Forms.Label allNum;
    }
}