namespace lab_1
{
    partial class InfoForm
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
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(343, 186);
            label2.TabIndex = 1;
            label2.Text = "Text";
            // 
            // button1
            // 
            button1.Location = new Point(138, 198);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "I've read it";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(367, 239);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "InfoForm";
            Text = "Info";
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button button1;
    }
}