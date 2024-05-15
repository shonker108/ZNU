namespace Lab_12
{
    partial class MainForm
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
            htmlButton = new Button();
            txtButton = new Button();
            binaryButton = new Button();
            label1 = new Label();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // htmlButton
            // 
            htmlButton.Location = new Point(21, 37);
            htmlButton.Name = "htmlButton";
            htmlButton.Size = new Size(94, 29);
            htmlButton.TabIndex = 0;
            htmlButton.Text = "HTML";
            htmlButton.UseVisualStyleBackColor = true;
            htmlButton.Click += htmlButton_Click;
            // 
            // txtButton
            // 
            txtButton.Location = new Point(21, 72);
            txtButton.Name = "txtButton";
            txtButton.Size = new Size(94, 29);
            txtButton.TabIndex = 1;
            txtButton.Text = ".txt";
            txtButton.UseVisualStyleBackColor = true;
            txtButton.Click += txtButton_Click;
            // 
            // binaryButton
            // 
            binaryButton.Location = new Point(21, 107);
            binaryButton.Name = "binaryButton";
            binaryButton.Size = new Size(94, 29);
            binaryButton.TabIndex = 2;
            binaryButton.Text = "Binary";
            binaryButton.UseVisualStyleBackColor = true;
            binaryButton.Click += binaryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 3;
            label1.Text = "Зберегти як:";
            // 
            // textBox
            // 
            textBox.Location = new Point(137, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(449, 212);
            textBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 236);
            Controls.Add(textBox);
            Controls.Add(label1);
            Controls.Add(binaryButton);
            Controls.Add(txtButton);
            Controls.Add(htmlButton);
            Name = "MainForm";
            Text = "Lab 12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button htmlButton;
        private Button txtButton;
        private Button binaryButton;
        private Label label1;
        private TextBox textBox;
    }
}
