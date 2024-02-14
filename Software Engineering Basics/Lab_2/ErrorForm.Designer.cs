namespace lab_1
{
    partial class ErrorForm
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(101, 164);
            button1.Name = "button1";
            button1.Size = new Size(190, 49);
            button1.TabIndex = 0;
            button1.Text = "I've read it";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 141);
            label1.TabIndex = 1;
            label1.Text = "Some error occured!\r\nError text: ";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 225);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ErrorForm";
            Text = "Error Message";
            Load += ErrorForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}