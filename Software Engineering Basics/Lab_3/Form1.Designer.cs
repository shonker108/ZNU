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
            confirmButton = new Button();
            label1 = new Label();
            fileNameTextBox = new TextBox();
            fileContentTextBox = new TextBox();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(12, 12);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(94, 29);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += button1_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(fileContentTextBox);
            Controls.Add(fileNameTextBox);
            Controls.Add(label1);
            Controls.Add(confirmButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmButton;
        private Label label1;
        private TextBox fileNameTextBox;
        private TextBox fileContentTextBox;
    }
}
