namespace Taschenrechner
{
    partial class CalculationForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lpButton = new System.Windows.Forms.Button();
            this.rpButton = new System.Windows.Forms.Button();
            this.msButton = new System.Windows.Forms.Button();
            this.mPlusButton = new System.Windows.Forms.Button();
            this.mMinusButton = new System.Windows.Forms.Button();
            this.eraseLastEntryButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.algRootButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.oneDevidXButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.CalculationRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 319);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lpButton
            // 
            this.lpButton.Location = new System.Drawing.Point(12, 86);
            this.lpButton.Name = "lpButton";
            this.lpButton.Size = new System.Drawing.Size(32, 26);
            this.lpButton.TabIndex = 1;
            this.lpButton.Text = "(";
            this.lpButton.UseVisualStyleBackColor = true;
            this.lpButton.Click += new System.EventHandler(this.lpButton_Click);
            // 
            // rpButton
            // 
            this.rpButton.Location = new System.Drawing.Point(51, 86);
            this.rpButton.Name = "rpButton";
            this.rpButton.Size = new System.Drawing.Size(32, 26);
            this.rpButton.TabIndex = 2;
            this.rpButton.Text = ")";
            this.rpButton.UseVisualStyleBackColor = true;
            this.rpButton.Click += new System.EventHandler(this.rpButton_Click);
            // 
            // msButton
            // 
            this.msButton.Location = new System.Drawing.Point(90, 86);
            this.msButton.Name = "msButton";
            this.msButton.Size = new System.Drawing.Size(32, 26);
            this.msButton.TabIndex = 3;
            this.msButton.UseVisualStyleBackColor = true;
            this.msButton.Click += new System.EventHandler(this.msButton_Click);
            // 
            // mPlusButton
            // 
            this.mPlusButton.Location = new System.Drawing.Point(129, 86);
            this.mPlusButton.Name = "mPlusButton";
            this.mPlusButton.Size = new System.Drawing.Size(32, 26);
            this.mPlusButton.TabIndex = 4;
            this.mPlusButton.UseVisualStyleBackColor = true;
            this.mPlusButton.Click += new System.EventHandler(this.mPlusButton_Click);
            // 
            // mMinusButton
            // 
            this.mMinusButton.Location = new System.Drawing.Point(168, 86);
            this.mMinusButton.Name = "mMinusButton";
            this.mMinusButton.Size = new System.Drawing.Size(32, 26);
            this.mMinusButton.TabIndex = 5;
            this.mMinusButton.UseVisualStyleBackColor = true;
            this.mMinusButton.Click += new System.EventHandler(this.mMinusButton_Click);
            // 
            // eraseLastEntryButton
            // 
            this.eraseLastEntryButton.Location = new System.Drawing.Point(12, 118);
            this.eraseLastEntryButton.Name = "eraseLastEntryButton";
            this.eraseLastEntryButton.Size = new System.Drawing.Size(32, 26);
            this.eraseLastEntryButton.TabIndex = 6;
            this.eraseLastEntryButton.Text = "<----";
            this.eraseLastEntryButton.UseVisualStyleBackColor = true;
            this.eraseLastEntryButton.Click += new System.EventHandler(this.eraseLastEntryButton_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Location = new System.Drawing.Point(51, 118);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(32, 26);
            this.clearEntryButton.TabIndex = 7;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(90, 118);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(32, 26);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Location = new System.Drawing.Point(129, 118);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(32, 26);
            this.plusMinusButton.TabIndex = 9;
            this.plusMinusButton.Text = "±";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            this.plusMinusButton.Click += new System.EventHandler(this.plusMinusButton_Click);
            // 
            // algRootButton
            // 
            this.algRootButton.Location = new System.Drawing.Point(168, 118);
            this.algRootButton.Name = "algRootButton";
            this.algRootButton.Size = new System.Drawing.Size(32, 26);
            this.algRootButton.TabIndex = 10;
            this.algRootButton.Text = "√";
            this.algRootButton.UseVisualStyleBackColor = true;
            this.algRootButton.Click += new System.EventHandler(this.algRootButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(12, 150);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(32, 26);
            this.sevenButton.TabIndex = 11;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(51, 150);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(32, 26);
            this.eightButton.TabIndex = 12;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(90, 150);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(32, 26);
            this.nineButton.TabIndex = 13;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // devideButton
            // 
            this.devideButton.Location = new System.Drawing.Point(129, 150);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(32, 26);
            this.devideButton.TabIndex = 14;
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = true;
            this.devideButton.Click += new System.EventHandler(this.devideButton_Click);
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(168, 150);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(32, 26);
            this.modButton.TabIndex = 15;
            this.modButton.Text = "%";
            this.modButton.UseVisualStyleBackColor = true;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(12, 182);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(32, 26);
            this.fourButton.TabIndex = 16;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(51, 182);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(32, 26);
            this.fiveButton.TabIndex = 17;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(90, 182);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(32, 26);
            this.sixButton.TabIndex = 18;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(129, 182);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(32, 26);
            this.multiplyButton.TabIndex = 19;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // oneDevidXButton
            // 
            this.oneDevidXButton.Location = new System.Drawing.Point(168, 182);
            this.oneDevidXButton.Name = "oneDevidXButton";
            this.oneDevidXButton.Size = new System.Drawing.Size(32, 26);
            this.oneDevidXButton.TabIndex = 20;
            this.oneDevidXButton.Text = "1/x";
            this.oneDevidXButton.UseVisualStyleBackColor = true;
            this.oneDevidXButton.Click += new System.EventHandler(this.oneDevidXButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(12, 214);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(32, 26);
            this.oneButton.TabIndex = 21;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(51, 214);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(32, 26);
            this.twoButton.TabIndex = 22;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(90, 214);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(32, 26);
            this.threeButton.TabIndex = 23;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(129, 214);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(32, 26);
            this.minusButton.TabIndex = 24;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(12, 246);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(71, 26);
            this.zeroButton.TabIndex = 25;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(90, 246);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(32, 26);
            this.dotButton.TabIndex = 26;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(129, 246);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(32, 26);
            this.plusButton.TabIndex = 27;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(168, 214);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(32, 58);
            this.calculateButton.TabIndex = 28;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // CalculationRichTextBox
            // 
            this.CalculationRichTextBox.HideSelection = false;
            this.CalculationRichTextBox.Location = new System.Drawing.Point(12, 31);
            this.CalculationRichTextBox.Name = "CalculationRichTextBox";
            this.CalculationRichTextBox.ReadOnly = true;
            this.CalculationRichTextBox.Size = new System.Drawing.Size(188, 49);
            this.CalculationRichTextBox.TabIndex = 29;
            this.CalculationRichTextBox.Text = "";
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 285);
            this.Controls.Add(this.CalculationRichTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.oneDevidXButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.devideButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.algRootButton);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.eraseLastEntryButton);
            this.Controls.Add(this.mMinusButton);
            this.Controls.Add(this.mPlusButton);
            this.Controls.Add(this.msButton);
            this.Controls.Add(this.rpButton);
            this.Controls.Add(this.lpButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taschenrechner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lpButton;
        private System.Windows.Forms.Button rpButton;
        private System.Windows.Forms.Button msButton;
        private System.Windows.Forms.Button mPlusButton;
        private System.Windows.Forms.Button mMinusButton;
        private System.Windows.Forms.Button eraseLastEntryButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button algRootButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button oneDevidXButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RichTextBox CalculationRichTextBox;
    }
}

