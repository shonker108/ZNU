namespace Courier_delivery_service_app.Forms
{
    partial class QueriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueriesForm));
            queryInputBox = new TextBox();
            label1 = new Label();
            statusStrip = new StatusStrip();
            statusStripLabel = new ToolStripStatusLabel();
            runButton = new Button();
            queryResultTable = new TableLayoutPanel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // queryInputBox
            // 
            queryInputBox.AcceptsTab = true;
            queryInputBox.AllowDrop = true;
            queryInputBox.Location = new Point(12, 40);
            queryInputBox.Multiline = true;
            queryInputBox.Name = "queryInputBox";
            queryInputBox.Size = new Size(397, 437);
            queryInputBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 1;
            label1.Text = "Запит";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
            statusStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
            statusStrip.Location = new Point(0, 559);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1192, 6);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(0, 0);
            // 
            // runButton
            // 
            runButton.BackColor = Color.MediumSeaGreen;
            runButton.FlatStyle = FlatStyle.Flat;
            runButton.ForeColor = Color.White;
            runButton.Location = new Point(143, 483);
            runButton.Name = "runButton";
            runButton.Size = new Size(120, 29);
            runButton.TabIndex = 3;
            runButton.Text = "Виконати";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // queryResultTable
            // 
            queryResultTable.AutoScroll = true;
            queryResultTable.AutoScrollMinSize = new Size(1, 1);
            queryResultTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            queryResultTable.ColumnCount = 1;
            queryResultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            queryResultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            queryResultTable.Dock = DockStyle.Right;
            queryResultTable.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 204);
            queryResultTable.Location = new Point(446, 0);
            queryResultTable.Name = "queryResultTable";
            queryResultTable.RowCount = 1;
            queryResultTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            queryResultTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            queryResultTable.Size = new Size(746, 559);
            queryResultTable.TabIndex = 4;
            // 
            // QueriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 565);
            Controls.Add(queryResultTable);
            Controls.Add(runButton);
            Controls.Add(statusStrip);
            Controls.Add(label1);
            Controls.Add(queryInputBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QueriesForm";
            Text = "Courier Delivery Service";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryInputBox;
        private Label label1;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusStripLabel;
        private Button runButton;
        private TableLayoutPanel queryResultTable;
    }
}