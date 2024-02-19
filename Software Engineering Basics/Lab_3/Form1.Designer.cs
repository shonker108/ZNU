namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileButton = new Button();
            label1 = new Label();
            fileNameTextBox = new TextBox();
            fileContentTextBox = new TextBox();
            fileStatisticTextBox = new TextBox();
            trimButton = new Button();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(12, 12);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(94, 29);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open File";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 17);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Current file:";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(238, 14);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.ReadOnly = true;
            fileNameTextBox.Size = new Size(178, 27);
            fileNameTextBox.TabIndex = 2;
            // 
            // fileContentTextBox
            // 
            fileContentTextBox.Location = new Point(12, 47);
            fileContentTextBox.Multiline = true;
            fileContentTextBox.Name = "fileContentTextBox";
            fileContentTextBox.ReadOnly = true;
            fileContentTextBox.ScrollBars = ScrollBars.Vertical;
            fileContentTextBox.Size = new Size(404, 391);
            fileContentTextBox.TabIndex = 3;
            fileContentTextBox.Text = "There will be file content here...\r\n";
            // 
            // fileStatisticTextBox
            // 
            fileStatisticTextBox.Location = new Point(422, 47);
            fileStatisticTextBox.Multiline = true;
            fileStatisticTextBox.Name = "fileStatisticTextBox";
            fileStatisticTextBox.ReadOnly = true;
            fileStatisticTextBox.ScrollBars = ScrollBars.Vertical;
            fileStatisticTextBox.Size = new Size(295, 391);
            fileStatisticTextBox.TabIndex = 4;
            fileStatisticTextBox.Text = "File statistic will be here...";
            // 
            // trimButton
            // 
            trimButton.Location = new Point(422, 14);
            trimButton.Name = "trimButton";
            trimButton.Size = new Size(94, 29);
            trimButton.TabIndex = 5;
            trimButton.Text = "Trim file";
            trimButton.UseVisualStyleBackColor = true;
            trimButton.Click += trimButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "All files | *.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(trimButton);
            Controls.Add(fileStatisticTextBox);
            Controls.Add(fileContentTextBox);
            Controls.Add(fileNameTextBox);
            Controls.Add(label1);
            Controls.Add(openFileButton);
            Name = "Form1";
            Text = "Lab 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFileButton;
        private Label label1;
        private TextBox fileNameTextBox;
        private TextBox fileContentTextBox;
        private TextBox fileStatisticTextBox;
        private Button trimButton;
        private OpenFileDialog openFileDialog;
    }
}
