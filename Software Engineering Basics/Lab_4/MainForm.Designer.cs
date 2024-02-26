namespace Lab_4
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
            panel1 = new Panel();
            textBox = new TextBox();
            openFileDialog = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copySelectedToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            labTasksToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            task2_1toolStripMenuItem = new ToolStripMenuItem();
            task2_2toolStripMenuItem = new ToolStripMenuItem();
            task2_3toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            task3_1toolStripMenuItem = new ToolStripMenuItem();
            tast3_2toolStripMenuItem = new ToolStripMenuItem();
            task3_3toolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 407);
            panel1.TabIndex = 4;
            // 
            // textBox
            // 
            textBox.Location = new Point(3, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(770, 401);
            textBox.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, aboutToolStripMenuItem, labTasksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsToolStripMenuItem, openToolStripMenuItem, statisticsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 24);
            fileToolStripMenuItem.Text = "File...";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(224, 26);
            statisticsToolStripMenuItem.Text = "Statistic...";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, toolStripSeparator1, copySelectedToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 24);
            editToolStripMenuItem.Text = "Edit...";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(126, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(123, 6);
            // 
            // copySelectedToolStripMenuItem
            // 
            copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            copySelectedToolStripMenuItem.Size = new Size(126, 26);
            copySelectedToolStripMenuItem.Text = "Copy";
            copySelectedToolStripMenuItem.Click += copySelectedToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(126, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // labTasksToolStripMenuItem
            // 
            labTasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem6 });
            labTasksToolStripMenuItem.Name = "labTasksToolStripMenuItem";
            labTasksToolStripMenuItem.Size = new Size(83, 24);
            labTasksToolStripMenuItem.Text = "Lab tasks";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { task2_1toolStripMenuItem, task2_2toolStripMenuItem, task2_3toolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(100, 26);
            toolStripMenuItem2.Text = "2";
            // 
            // task2_1toolStripMenuItem
            // 
            task2_1toolStripMenuItem.Name = "task2_1toolStripMenuItem";
            task2_1toolStripMenuItem.Size = new Size(100, 26);
            task2_1toolStripMenuItem.Text = "1";
            task2_1toolStripMenuItem.Click += task2_1toolStripMenuItem_Click;
            // 
            // task2_2toolStripMenuItem
            // 
            task2_2toolStripMenuItem.Name = "task2_2toolStripMenuItem";
            task2_2toolStripMenuItem.Size = new Size(100, 26);
            task2_2toolStripMenuItem.Text = "2";
            task2_2toolStripMenuItem.Click += task2_2toolStripMenuItem_Click;
            // 
            // task2_3toolStripMenuItem
            // 
            task2_3toolStripMenuItem.Name = "task2_3toolStripMenuItem";
            task2_3toolStripMenuItem.Size = new Size(100, 26);
            task2_3toolStripMenuItem.Text = "3";
            task2_3toolStripMenuItem.Click += task2_3toolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { task3_1toolStripMenuItem, tast3_2toolStripMenuItem, task3_3toolStripMenuItem });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(100, 26);
            toolStripMenuItem6.Text = "3";
            // 
            // task3_1toolStripMenuItem
            // 
            task3_1toolStripMenuItem.Name = "task3_1toolStripMenuItem";
            task3_1toolStripMenuItem.Size = new Size(100, 26);
            task3_1toolStripMenuItem.Text = "1";
            task3_1toolStripMenuItem.Click += task3_1toolStripMenuItem_Click;
            // 
            // tast3_2toolStripMenuItem
            // 
            tast3_2toolStripMenuItem.Name = "tast3_2toolStripMenuItem";
            tast3_2toolStripMenuItem.Size = new Size(100, 26);
            tast3_2toolStripMenuItem.Text = "2";
            tast3_2toolStripMenuItem.Click += tast3_2toolStripMenuItem_Click;
            // 
            // task3_3toolStripMenuItem
            // 
            task3_3toolStripMenuItem.Name = "task3_3toolStripMenuItem";
            task3_3toolStripMenuItem.Size = new Size(100, 26);
            task3_3toolStripMenuItem.Text = "3";
            task3_3toolStripMenuItem.Click += task3_3toolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.RestoreDirectory = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Lab 4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox textBox;
        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem copySelectedToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem labTasksToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem task2_1toolStripMenuItem;
        private ToolStripMenuItem task2_2toolStripMenuItem;
        private ToolStripMenuItem task2_3toolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem task3_1toolStripMenuItem;
        private ToolStripMenuItem tast3_2toolStripMenuItem;
        private ToolStripMenuItem task3_3toolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
    }
}
