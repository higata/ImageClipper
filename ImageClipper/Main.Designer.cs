namespace ImageClipper
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.imageFileOpenButton = new System.Windows.Forms.Button();
            this.saveDirectorySelectBotan = new System.Windows.Forms.Button();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageFileLabel = new System.Windows.Forms.Label();
            this.imageFileNameText = new System.Windows.Forms.TextBox();
            this.saveDirectoryText = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveDirLabel = new System.Windows.Forms.Label();
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.fileDirectoryGroup = new System.Windows.Forms.GroupBox();
            this.clipOptionGroup = new System.Windows.Forms.GroupBox();
            this.clipHeight = new System.Windows.Forms.NumericUpDown();
            this.clipWidth = new System.Windows.Forms.NumericUpDown();
            this.isSquere = new System.Windows.Forms.CheckBox();
            this.wLabel = new System.Windows.Forms.Label();
            this.hPxLabel = new System.Windows.Forms.Label();
            this.wPxLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isZeroFill = new System.Windows.Forms.CheckBox();
            this.isAddFileNameBefore = new System.Windows.Forms.CheckBox();
            this.digitLabel = new System.Windows.Forms.Label();
            this.startNoLabel = new System.Windows.Forms.Label();
            this.digitNum = new System.Windows.Forms.NumericUpDown();
            this.startNo = new System.Windows.Forms.NumericUpDown();
            this.saveFileStringLabel = new System.Windows.Forms.Label();
            this.saveFileString = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.executeButton = new System.Windows.Forms.Button();
            this.saveFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.isNoCheckDialog = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            this.fileDirectoryGroup.SuspendLayout();
            this.clipOptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageFileOpenButton
            // 
            this.imageFileOpenButton.Location = new System.Drawing.Point(271, 21);
            this.imageFileOpenButton.Name = "imageFileOpenButton";
            this.imageFileOpenButton.Size = new System.Drawing.Size(48, 19);
            this.imageFileOpenButton.TabIndex = 0;
            this.imageFileOpenButton.Text = "参照";
            this.imageFileOpenButton.UseVisualStyleBackColor = true;
            this.imageFileOpenButton.Click += new System.EventHandler(this.imageFileOpenButton_Click);
            // 
            // saveDirectorySelectBotan
            // 
            this.saveDirectorySelectBotan.Location = new System.Drawing.Point(271, 46);
            this.saveDirectorySelectBotan.Name = "saveDirectorySelectBotan";
            this.saveDirectorySelectBotan.Size = new System.Drawing.Size(48, 19);
            this.saveDirectorySelectBotan.TabIndex = 1;
            this.saveDirectorySelectBotan.Text = "参照";
            this.saveDirectorySelectBotan.UseVisualStyleBackColor = true;
            this.saveDirectorySelectBotan.Click += new System.EventHandler(this.saveDirectorySelectBotan_Click);
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.Filter = "画像ファイル(*.bmp;*.gif;*.png)|*.bmp;*.gif;*.png";
            this.imageFileDialog.Title = "画像ファイルの選択";
            // 
            // imageFileLabel
            // 
            this.imageFileLabel.AutoSize = true;
            this.imageFileLabel.Location = new System.Drawing.Point(6, 24);
            this.imageFileLabel.Name = "imageFileLabel";
            this.imageFileLabel.Size = new System.Drawing.Size(63, 12);
            this.imageFileLabel.TabIndex = 2;
            this.imageFileLabel.Text = "画像ファイル";
            // 
            // imageFileNameText
            // 
            this.imageFileNameText.Location = new System.Drawing.Point(75, 21);
            this.imageFileNameText.Name = "imageFileNameText";
            this.imageFileNameText.ReadOnly = true;
            this.imageFileNameText.Size = new System.Drawing.Size(190, 19);
            this.imageFileNameText.TabIndex = 3;
            this.imageFileNameText.TabStop = false;
            // 
            // saveDirectoryText
            // 
            this.saveDirectoryText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveDirectoryText.Location = new System.Drawing.Point(75, 46);
            this.saveDirectoryText.Name = "saveDirectoryText";
            this.saveDirectoryText.ReadOnly = true;
            this.saveDirectoryText.Size = new System.Drawing.Size(190, 19);
            this.saveDirectoryText.TabIndex = 3;
            this.saveDirectoryText.TabStop = false;
            this.saveDirectoryText.Text = ".\\";
            this.saveDirectoryText.WordWrap = false;
            // 
            // saveDirLabel
            // 
            this.saveDirLabel.AutoSize = true;
            this.saveDirLabel.Location = new System.Drawing.Point(6, 49);
            this.saveDirLabel.Name = "saveDirLabel";
            this.saveDirLabel.Size = new System.Drawing.Size(53, 12);
            this.saveDirLabel.TabIndex = 2;
            this.saveDirLabel.Text = "保存場所";
            // 
            // srcImage
            // 
            this.srcImage.BackColor = System.Drawing.SystemColors.Control;
            this.srcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcImage.Location = new System.Drawing.Point(0, 0);
            this.srcImage.Margin = new System.Windows.Forms.Padding(0);
            this.srcImage.Name = "srcImage";
            this.srcImage.Size = new System.Drawing.Size(0, 0);
            this.srcImage.TabIndex = 4;
            this.srcImage.TabStop = false;
            // 
            // fileDirectoryGroup
            // 
            this.fileDirectoryGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDirectoryGroup.AutoSize = true;
            this.fileDirectoryGroup.Controls.Add(this.saveDirectorySelectBotan);
            this.fileDirectoryGroup.Controls.Add(this.imageFileOpenButton);
            this.fileDirectoryGroup.Controls.Add(this.saveDirectoryText);
            this.fileDirectoryGroup.Controls.Add(this.imageFileLabel);
            this.fileDirectoryGroup.Controls.Add(this.imageFileNameText);
            this.fileDirectoryGroup.Controls.Add(this.saveDirLabel);
            this.fileDirectoryGroup.Location = new System.Drawing.Point(367, 14);
            this.fileDirectoryGroup.Name = "fileDirectoryGroup";
            this.fileDirectoryGroup.Size = new System.Drawing.Size(325, 83);
            this.fileDirectoryGroup.TabIndex = 5;
            this.fileDirectoryGroup.TabStop = false;
            this.fileDirectoryGroup.Text = "ファイル・ディレクトリ";
            // 
            // clipOptionGroup
            // 
            this.clipOptionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clipOptionGroup.AutoSize = true;
            this.clipOptionGroup.Controls.Add(this.clipHeight);
            this.clipOptionGroup.Controls.Add(this.clipWidth);
            this.clipOptionGroup.Controls.Add(this.isSquere);
            this.clipOptionGroup.Controls.Add(this.wLabel);
            this.clipOptionGroup.Controls.Add(this.hPxLabel);
            this.clipOptionGroup.Controls.Add(this.wPxLabel);
            this.clipOptionGroup.Controls.Add(this.hLabel);
            this.clipOptionGroup.Location = new System.Drawing.Point(367, 103);
            this.clipOptionGroup.Name = "clipOptionGroup";
            this.clipOptionGroup.Size = new System.Drawing.Size(325, 58);
            this.clipOptionGroup.TabIndex = 6;
            this.clipOptionGroup.TabStop = false;
            this.clipOptionGroup.Text = "分割時オプション";
            // 
            // clipHeight
            // 
            this.clipHeight.Location = new System.Drawing.Point(121, 21);
            this.clipHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.clipHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clipHeight.Name = "clipHeight";
            this.clipHeight.Size = new System.Drawing.Size(47, 19);
            this.clipHeight.TabIndex = 3;
            this.clipHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // clipWidth
            // 
            this.clipWidth.Location = new System.Drawing.Point(26, 21);
            this.clipWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.clipWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clipWidth.Name = "clipWidth";
            this.clipWidth.Size = new System.Drawing.Size(47, 19);
            this.clipWidth.TabIndex = 2;
            this.clipWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // isSquere
            // 
            this.isSquere.AutoSize = true;
            this.isSquere.Location = new System.Drawing.Point(201, 22);
            this.isSquere.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.isSquere.Name = "isSquere";
            this.isSquere.Size = new System.Drawing.Size(118, 16);
            this.isSquere.TabIndex = 4;
            this.isSquere.Text = "縦横を同じ値にする";
            this.isSquere.UseVisualStyleBackColor = true;
            this.isSquere.CheckedChanged += new System.EventHandler(this.isSquere_CheckedChanged);
            // 
            // wLabel
            // 
            this.wLabel.AutoSize = true;
            this.wLabel.Location = new System.Drawing.Point(6, 24);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(14, 12);
            this.wLabel.TabIndex = 2;
            this.wLabel.Text = "W";
            // 
            // hPxLabel
            // 
            this.hPxLabel.AutoSize = true;
            this.hPxLabel.Location = new System.Drawing.Point(172, 24);
            this.hPxLabel.Name = "hPxLabel";
            this.hPxLabel.Size = new System.Drawing.Size(17, 12);
            this.hPxLabel.TabIndex = 2;
            this.hPxLabel.Text = "px";
            // 
            // wPxLabel
            // 
            this.wPxLabel.AutoSize = true;
            this.wPxLabel.Location = new System.Drawing.Point(79, 24);
            this.wPxLabel.Name = "wPxLabel";
            this.wPxLabel.Size = new System.Drawing.Size(17, 12);
            this.wPxLabel.TabIndex = 2;
            this.wPxLabel.Text = "px";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(102, 24);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 12);
            this.hLabel.TabIndex = 2;
            this.hLabel.Text = "H";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.isZeroFill);
            this.groupBox2.Controls.Add(this.isAddFileNameBefore);
            this.groupBox2.Controls.Add(this.digitLabel);
            this.groupBox2.Controls.Add(this.startNoLabel);
            this.groupBox2.Controls.Add(this.digitNum);
            this.groupBox2.Controls.Add(this.startNo);
            this.groupBox2.Controls.Add(this.saveFileStringLabel);
            this.groupBox2.Controls.Add(this.saveFileString);
            this.groupBox2.Location = new System.Drawing.Point(367, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 98);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "保存時オプション";
            // 
            // isZeroFill
            // 
            this.isZeroFill.AutoSize = true;
            this.isZeroFill.Location = new System.Drawing.Point(192, 67);
            this.isZeroFill.Name = "isZeroFill";
            this.isZeroFill.Size = new System.Drawing.Size(104, 16);
            this.isZeroFill.TabIndex = 9;
            this.isZeroFill.Text = "0で左端を詰める";
            this.isZeroFill.UseVisualStyleBackColor = true;
            this.isZeroFill.CheckedChanged += new System.EventHandler(this.isZeroFill_CheckedChanged);
            // 
            // isAddFileNameBefore
            // 
            this.isAddFileNameBefore.AutoSize = true;
            this.isAddFileNameBefore.Location = new System.Drawing.Point(192, 45);
            this.isAddFileNameBefore.Name = "isAddFileNameBefore";
            this.isAddFileNameBefore.Size = new System.Drawing.Size(127, 16);
            this.isAddFileNameBefore.TabIndex = 7;
            this.isAddFileNameBefore.Text = "ファイル名先頭に追加";
            this.isAddFileNameBefore.UseVisualStyleBackColor = true;
            // 
            // digitLabel
            // 
            this.digitLabel.AutoSize = true;
            this.digitLabel.Location = new System.Drawing.Point(8, 66);
            this.digitLabel.Name = "digitLabel";
            this.digitLabel.Size = new System.Drawing.Size(29, 12);
            this.digitLabel.TabIndex = 2;
            this.digitLabel.Text = "桁数";
            // 
            // startNoLabel
            // 
            this.startNoLabel.AutoSize = true;
            this.startNoLabel.Location = new System.Drawing.Point(8, 45);
            this.startNoLabel.Name = "startNoLabel";
            this.startNoLabel.Size = new System.Drawing.Size(53, 12);
            this.startNoLabel.TabIndex = 2;
            this.startNoLabel.Text = "開始番号";
            // 
            // digitNum
            // 
            this.digitNum.Enabled = false;
            this.digitNum.Location = new System.Drawing.Point(77, 64);
            this.digitNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.digitNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.digitNum.Name = "digitNum";
            this.digitNum.Size = new System.Drawing.Size(103, 19);
            this.digitNum.TabIndex = 8;
            this.digitNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.digitNum.ValueChanged += new System.EventHandler(this.digitNum_ValueChanged);
            // 
            // startNo
            // 
            this.startNo.Location = new System.Drawing.Point(77, 43);
            this.startNo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.startNo.Name = "startNo";
            this.startNo.Size = new System.Drawing.Size(103, 19);
            this.startNo.TabIndex = 6;
            this.startNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveFileStringLabel
            // 
            this.saveFileStringLabel.AutoSize = true;
            this.saveFileStringLabel.Location = new System.Drawing.Point(8, 24);
            this.saveFileStringLabel.Name = "saveFileStringLabel";
            this.saveFileStringLabel.Size = new System.Drawing.Size(51, 12);
            this.saveFileStringLabel.TabIndex = 2;
            this.saveFileStringLabel.Text = "ファイル名";
            // 
            // saveFileString
            // 
            this.saveFileString.Location = new System.Drawing.Point(77, 21);
            this.saveFileString.Name = "saveFileString";
            this.saveFileString.Size = new System.Drawing.Size(244, 19);
            this.saveFileString.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.srcImage);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 417);
            this.panel1.TabIndex = 8;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Enabled = false;
            this.executeButton.Location = new System.Drawing.Point(617, 407);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 11;
            this.executeButton.Text = "実行";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // isNoCheckDialog
            // 
            this.isNoCheckDialog.AutoSize = true;
            this.isNoCheckDialog.Location = new System.Drawing.Point(507, 411);
            this.isNoCheckDialog.Name = "isNoCheckDialog";
            this.isNoCheckDialog.Size = new System.Drawing.Size(101, 16);
            this.isNoCheckDialog.TabIndex = 10;
            this.isNoCheckDialog.Text = "確認なしで実行";
            this.isNoCheckDialog.UseVisualStyleBackColor = true;
            this.isNoCheckDialog.CheckedChanged += new System.EventHandler(this.isZeroFill_CheckedChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(367, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "このソフトについて";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isNoCheckDialog);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clipOptionGroup);
            this.Controls.Add(this.fileDirectoryGroup);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ImageClipper v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            this.fileDirectoryGroup.ResumeLayout(false);
            this.fileDirectoryGroup.PerformLayout();
            this.clipOptionGroup.ResumeLayout(false);
            this.clipOptionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imageFileOpenButton;
        private System.Windows.Forms.Button saveDirectorySelectBotan;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
        private System.Windows.Forms.Label imageFileLabel;
        private System.Windows.Forms.TextBox imageFileNameText;
        private System.Windows.Forms.TextBox saveDirectoryText;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label saveDirLabel;
        private System.Windows.Forms.PictureBox srcImage;
        private System.Windows.Forms.GroupBox fileDirectoryGroup;
        private System.Windows.Forms.GroupBox clipOptionGroup;
        private System.Windows.Forms.CheckBox isSquere;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Label hPxLabel;
        private System.Windows.Forms.Label wPxLabel;
        private System.Windows.Forms.NumericUpDown clipHeight;
        private System.Windows.Forms.NumericUpDown clipWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label startNoLabel;
        private System.Windows.Forms.NumericUpDown startNo;
        private System.Windows.Forms.Label saveFileStringLabel;
        private System.Windows.Forms.TextBox saveFileString;
        private System.Windows.Forms.CheckBox isAddFileNameBefore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.FolderBrowserDialog saveFolderDialog;
        private System.Windows.Forms.Label digitLabel;
        private System.Windows.Forms.NumericUpDown digitNum;
        private System.Windows.Forms.CheckBox isZeroFill;
        private System.Windows.Forms.CheckBox isNoCheckDialog;
        private System.Windows.Forms.Button button1;
    }
}