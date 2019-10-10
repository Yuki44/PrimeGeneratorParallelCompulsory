namespace PrimeGenerator
{
    partial class PrimeNumbersGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.primeNumbersListBox = new System.Windows.Forms.ListBox();
            this.sequentialButton = new System.Windows.Forms.Button();
            this.parallelButton = new System.Windows.Forms.Button();
            this.startRangeTextBox = new System.Windows.Forms.TextBox();
            this.endRangeTextBox = new System.Windows.Forms.TextBox();
            this.startRangeLabel = new System.Windows.Forms.Label();
            this.endRangeLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeNumbersListBox
            // 
            this.primeNumbersListBox.FormattingEnabled = true;
            this.primeNumbersListBox.Location = new System.Drawing.Point(53, 148);
            this.primeNumbersListBox.Name = "primeNumbersListBox";
            this.primeNumbersListBox.Size = new System.Drawing.Size(699, 290);
            this.primeNumbersListBox.TabIndex = 0;
            this.primeNumbersListBox.SelectedIndexChanged += new System.EventHandler(this.primeNumbersListBox_SelectedIndexChanged);
            // 
            // sequentialButton
            // 
            this.sequentialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sequentialButton.Location = new System.Drawing.Point(53, 93);
            this.sequentialButton.Name = "sequentialButton";
            this.sequentialButton.Size = new System.Drawing.Size(216, 36);
            this.sequentialButton.TabIndex = 3;
            this.sequentialButton.Text = "Start Sequential Prime Generator";
            this.sequentialButton.UseVisualStyleBackColor = true;
            this.sequentialButton.Click += new System.EventHandler(this.sequentialButton_Click);
            // 
            // parallelButton
            // 
            this.parallelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parallelButton.Location = new System.Drawing.Point(536, 93);
            this.parallelButton.Name = "parallelButton";
            this.parallelButton.Size = new System.Drawing.Size(216, 36);
            this.parallelButton.TabIndex = 4;
            this.parallelButton.Text = "Start Parallelized Prime Generator";
            this.parallelButton.UseVisualStyleBackColor = true;
            this.parallelButton.Click += new System.EventHandler(this.parallelButton_Click);
            // 
            // startRangeTextBox
            // 
            this.startRangeTextBox.Location = new System.Drawing.Point(297, 33);
            this.startRangeTextBox.Name = "startRangeTextBox";
            this.startRangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.startRangeTextBox.TabIndex = 1;
            this.startRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startRangeTextBox.TextChanged += new System.EventHandler(this.startRangeTextBox_TextChanged);
            // 
            // endRangeTextBox
            // 
            this.endRangeTextBox.Location = new System.Drawing.Point(410, 33);
            this.endRangeTextBox.Name = "endRangeTextBox";
            this.endRangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.endRangeTextBox.TabIndex = 2;
            this.endRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endRangeTextBox.TextChanged += new System.EventHandler(this.endRangeTextBox_TextChanged);
            // 
            // startRangeLabel
            // 
            this.startRangeLabel.AutoSize = true;
            this.startRangeLabel.Location = new System.Drawing.Point(294, 17);
            this.startRangeLabel.Name = "startRangeLabel";
            this.startRangeLabel.Size = new System.Drawing.Size(62, 13);
            this.startRangeLabel.TabIndex = 10;
            this.startRangeLabel.Text = "Start range:";
            // 
            // endRangeLabel
            // 
            this.endRangeLabel.AutoSize = true;
            this.endRangeLabel.Location = new System.Drawing.Point(407, 17);
            this.endRangeLabel.Name = "endRangeLabel";
            this.endRangeLabel.Size = new System.Drawing.Size(59, 13);
            this.endRangeLabel.TabIndex = 11;
            this.endRangeLabel.Text = "End range:";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.Location = new System.Drawing.Point(354, 69);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(105, 23);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear the generator";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // PrimeNumbersGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.endRangeLabel);
            this.Controls.Add(this.startRangeLabel);
            this.Controls.Add(this.endRangeTextBox);
            this.Controls.Add(this.startRangeTextBox);
            this.Controls.Add(this.parallelButton);
            this.Controls.Add(this.sequentialButton);
            this.Controls.Add(this.primeNumbersListBox);
            this.Name = "PrimeNumbersGenerator";
            this.Text = "Prime Numbers Generator  -  Team Ground Zero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox primeNumbersListBox;
        private System.Windows.Forms.Button sequentialButton;
        private System.Windows.Forms.Button parallelButton;
        private System.Windows.Forms.TextBox startRangeTextBox;
        private System.Windows.Forms.TextBox endRangeTextBox;
        private System.Windows.Forms.Label startRangeLabel;
        private System.Windows.Forms.Label endRangeLabel;
        private System.Windows.Forms.Button clearAllButton;
    }
}

