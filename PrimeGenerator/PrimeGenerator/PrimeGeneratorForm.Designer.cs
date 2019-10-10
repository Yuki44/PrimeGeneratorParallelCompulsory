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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeNumbersGenerator));
            this.primeNumbersListBox = new System.Windows.Forms.ListBox();
            this.sequentialButton = new System.Windows.Forms.Button();
            this.parallelButton = new System.Windows.Forms.Button();
            this.startRangeTextBox = new System.Windows.Forms.TextBox();
            this.endRangeTextBox = new System.Windows.Forms.TextBox();
            this.startRangeLabel = new System.Windows.Forms.Label();
            this.endRangeLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.timeUsedLabel = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // primeNumbersListBox
            // 
            this.primeNumbersListBox.FormattingEnabled = true;
            this.primeNumbersListBox.Location = new System.Drawing.Point(53, 174);
            this.primeNumbersListBox.Name = "primeNumbersListBox";
            this.primeNumbersListBox.Size = new System.Drawing.Size(699, 264);
            this.primeNumbersListBox.TabIndex = 0;
            this.primeNumbersListBox.SelectedIndexChanged += new System.EventHandler(this.primeNumbersListBox_SelectedIndexChanged);
            // 
            // sequentialButton
            // 
            this.sequentialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sequentialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequentialButton.Location = new System.Drawing.Point(36, 93);
            this.sequentialButton.Name = "sequentialButton";
            this.sequentialButton.Size = new System.Drawing.Size(222, 46);
            this.sequentialButton.TabIndex = 3;
            this.sequentialButton.Text = "Start Sequential Prime Generator";
            this.sequentialButton.UseVisualStyleBackColor = true;
            this.sequentialButton.Click += new System.EventHandler(this.sequentialButton_Click);
            // 
            // parallelButton
            // 
            this.parallelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parallelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelButton.Location = new System.Drawing.Point(530, 93);
            this.parallelButton.Name = "parallelButton";
            this.parallelButton.Size = new System.Drawing.Size(222, 46);
            this.parallelButton.TabIndex = 4;
            this.parallelButton.Text = "Start Parallelized Prime Generator";
            this.parallelButton.UseVisualStyleBackColor = true;
            this.parallelButton.Click += new System.EventHandler(this.parallelButton_Click);
            // 
            // startRangeTextBox
            // 
            this.startRangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRangeTextBox.Location = new System.Drawing.Point(297, 33);
            this.startRangeTextBox.Name = "startRangeTextBox";
            this.startRangeTextBox.Size = new System.Drawing.Size(100, 21);
            this.startRangeTextBox.TabIndex = 1;
            this.startRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startRangeTextBox.TextChanged += new System.EventHandler(this.startRangeTextBox_TextChanged);
            // 
            // endRangeTextBox
            // 
            this.endRangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endRangeTextBox.Location = new System.Drawing.Point(410, 33);
            this.endRangeTextBox.Name = "endRangeTextBox";
            this.endRangeTextBox.Size = new System.Drawing.Size(100, 21);
            this.endRangeTextBox.TabIndex = 2;
            this.endRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endRangeTextBox.TextChanged += new System.EventHandler(this.endRangeTextBox_TextChanged);
            // 
            // startRangeLabel
            // 
            this.startRangeLabel.AutoSize = true;
            this.startRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRangeLabel.Location = new System.Drawing.Point(294, 14);
            this.startRangeLabel.Name = "startRangeLabel";
            this.startRangeLabel.Size = new System.Drawing.Size(76, 16);
            this.startRangeLabel.TabIndex = 10;
            this.startRangeLabel.Text = "Start range:";
            // 
            // endRangeLabel
            // 
            this.endRangeLabel.AutoSize = true;
            this.endRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endRangeLabel.Location = new System.Drawing.Point(407, 14);
            this.endRangeLabel.Name = "endRangeLabel";
            this.endRangeLabel.Size = new System.Drawing.Size(73, 16);
            this.endRangeLabel.TabIndex = 11;
            this.endRangeLabel.Text = "End range:";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.Location = new System.Drawing.Point(354, 69);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(105, 30);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear the generator";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // timeUsedLabel
            // 
            this.timeUsedLabel.AutoSize = true;
            this.timeUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeUsedLabel.Location = new System.Drawing.Point(360, 140);
            this.timeUsedLabel.Name = "timeUsedLabel";
            this.timeUsedLabel.Size = new System.Drawing.Size(83, 17);
            this.timeUsedLabel.TabIndex = 12;
            this.timeUsedLabel.Text = "Time used";
            this.timeUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeUsedLabel.Click += new System.EventHandler(this.timeUsedLabel_Click);
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.InitialImage = ((System.Drawing.Image)(resources.GetObject("image.InitialImage")));
            this.image.Location = new System.Drawing.Point(21, 93);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(752, 551);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.image.TabIndex = 13;
            this.image.TabStop = false;
            // 
            // PrimeNumbersGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.endRangeLabel);
            this.Controls.Add(this.startRangeLabel);
            this.Controls.Add(this.endRangeTextBox);
            this.Controls.Add(this.startRangeTextBox);
            this.Controls.Add(this.parallelButton);
            this.Controls.Add(this.sequentialButton);
            this.Controls.Add(this.image);
            this.Controls.Add(this.primeNumbersListBox);
            this.Controls.Add(this.timeUsedLabel);
            this.Name = "PrimeNumbersGenerator";
            this.Text = "Prime Numbers Generator  -  Team Ground Zero";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
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
        private System.Windows.Forms.Label timeUsedLabel;
        private System.Windows.Forms.PictureBox image;
    }
}

