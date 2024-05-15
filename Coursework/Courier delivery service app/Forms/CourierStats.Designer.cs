namespace Courier_delivery_service_app.Forms
{
    partial class CourierStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourierStats));
            idInputBox = new TextBox();
            fromDateInputBox = new DateTimePicker();
            panel2 = new Panel();
            allTimeRadioButton = new RadioButton();
            rangeRadioButton = new RadioButton();
            label1 = new Label();
            toDateInputBox = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            okButton = new Button();
            statusStrip = new StatusStrip();
            statusStripLabel = new ToolStripStatusLabel();
            statsPanel = new FlowLayoutPanel();
            panel2.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // idInputBox
            // 
            idInputBox.Location = new Point(98, 14);
            idInputBox.Name = "idInputBox";
            idInputBox.Size = new Size(125, 27);
            idInputBox.TabIndex = 0;
            // 
            // fromDateInputBox
            // 
            fromDateInputBox.CustomFormat = "dd/MM/yyyy";
            fromDateInputBox.Format = DateTimePickerFormat.Custom;
            fromDateInputBox.Location = new Point(98, 47);
            fromDateInputBox.Name = "fromDateInputBox";
            fromDateInputBox.Size = new Size(179, 27);
            fromDateInputBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(allTimeRadioButton);
            panel2.Controls.Add(rangeRadioButton);
            panel2.Location = new Point(319, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 90);
            panel2.TabIndex = 3;
            // 
            // allTimeRadioButton
            // 
            allTimeRadioButton.AutoSize = true;
            allTimeRadioButton.Location = new Point(9, 53);
            allTimeRadioButton.Name = "allTimeRadioButton";
            allTimeRadioButton.Size = new Size(97, 24);
            allTimeRadioButton.TabIndex = 1;
            allTimeRadioButton.TabStop = true;
            allTimeRadioButton.Text = "Увесь час";
            allTimeRadioButton.UseVisualStyleBackColor = true;
            allTimeRadioButton.CheckedChanged += allTimeRadioButton_CheckedChanged;
            // 
            // rangeRadioButton
            // 
            rangeRadioButton.AutoSize = true;
            rangeRadioButton.Location = new Point(9, 23);
            rangeRadioButton.Name = "rangeRadioButton";
            rangeRadioButton.Size = new Size(101, 24);
            rangeRadioButton.TabIndex = 0;
            rangeRadioButton.TabStop = true;
            rangeRadioButton.Text = "Проміжок";
            rangeRadioButton.UseVisualStyleBackColor = true;
            rangeRadioButton.CheckedChanged += rangeRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "Статистика за:";
            // 
            // toDateInputBox
            // 
            toDateInputBox.CustomFormat = "dd/MM/yyyy";
            toDateInputBox.Format = DateTimePickerFormat.Custom;
            toDateInputBox.Location = new Point(98, 80);
            toDateInputBox.Name = "toDateInputBox";
            toDateInputBox.Size = new Size(179, 27);
            toDateInputBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 14);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "ID кур'єра:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 47);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 7;
            label3.Text = "Від:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 80);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 8;
            label4.Text = "До:";
            // 
            // okButton
            // 
            okButton.BackColor = Color.MediumSeaGreen;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(59, 200);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 9;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
            statusStrip.Location = new Point(0, 325);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(627, 22);
            statusStrip.TabIndex = 10;
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(0, 16);
            // 
            // statsPanel
            // 
            statsPanel.AutoScroll = true;
            statsPanel.BorderStyle = BorderStyle.FixedSingle;
            statsPanel.FlowDirection = FlowDirection.TopDown;
            statsPanel.Location = new Point(176, 117);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(352, 191);
            statsPanel.TabIndex = 11;
            statsPanel.WrapContents = false;
            // 
            // CourierStats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 347);
            Controls.Add(statsPanel);
            Controls.Add(statusStrip);
            Controls.Add(okButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(toDateInputBox);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(fromDateInputBox);
            Controls.Add(idInputBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CourierStats";
            Text = "Статистика кур'єрів";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idInputBox;
        private DateTimePicker fromDateInputBox;
        private Panel panel2;
        private RadioButton allTimeRadioButton;
        private RadioButton rangeRadioButton;
        private Label label1;
        private DateTimePicker toDateInputBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button okButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusStripLabel;
        private FlowLayoutPanel statsPanel;
    }
}