namespace Courier_delivery_service_app.Forms
{
    partial class CourierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourierForm));
            menuStrip1 = new MenuStrip();
            accountNameGreetingLabel = new ToolStripTextBox();
            label1 = new Label();
            label2 = new Label();
            statusStrip = new StatusStrip();
            statusStripLabel = new ToolStripStatusLabel();
            availibleParcelsPanel = new FlowLayoutPanel();
            acceptedParcelsPanel = new FlowLayoutPanel();
            updateAcceptedParcelsButton = new Button();
            updateAvailibleParcelsButton = new Button();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountNameGreetingLabel });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1192, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountNameGreetingLabel
            // 
            accountNameGreetingLabel.BackColor = Color.MediumSeaGreen;
            accountNameGreetingLabel.ForeColor = Color.White;
            accountNameGreetingLabel.Name = "accountNameGreetingLabel";
            accountNameGreetingLabel.ReadOnly = true;
            accountNameGreetingLabel.Size = new Size(300, 27);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 2;
            label1.Text = "Прийняті посилки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(643, 48);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 3;
            label2.Text = "Стіл запитів на доставку:";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
            statusStrip.Location = new Point(0, 543);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1192, 22);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(0, 16);
            // 
            // availibleParcelsPanel
            // 
            availibleParcelsPanel.AutoScroll = true;
            availibleParcelsPanel.BorderStyle = BorderStyle.FixedSingle;
            availibleParcelsPanel.FlowDirection = FlowDirection.TopDown;
            availibleParcelsPanel.Location = new Point(643, 90);
            availibleParcelsPanel.Name = "availibleParcelsPanel";
            availibleParcelsPanel.Size = new Size(537, 435);
            availibleParcelsPanel.TabIndex = 5;
            availibleParcelsPanel.WrapContents = false;
            // 
            // acceptedParcelsPanel
            // 
            acceptedParcelsPanel.AutoScroll = true;
            acceptedParcelsPanel.BorderStyle = BorderStyle.FixedSingle;
            acceptedParcelsPanel.FlowDirection = FlowDirection.TopDown;
            acceptedParcelsPanel.Location = new Point(12, 90);
            acceptedParcelsPanel.Name = "acceptedParcelsPanel";
            acceptedParcelsPanel.Size = new Size(537, 435);
            acceptedParcelsPanel.TabIndex = 6;
            acceptedParcelsPanel.WrapContents = false;
            // 
            // updateAcceptedParcelsButton
            // 
            updateAcceptedParcelsButton.BackColor = Color.MediumSeaGreen;
            updateAcceptedParcelsButton.FlatStyle = FlatStyle.Flat;
            updateAcceptedParcelsButton.ForeColor = Color.White;
            updateAcceptedParcelsButton.Location = new Point(393, 51);
            updateAcceptedParcelsButton.Name = "updateAcceptedParcelsButton";
            updateAcceptedParcelsButton.Size = new Size(156, 29);
            updateAcceptedParcelsButton.TabIndex = 7;
            updateAcceptedParcelsButton.Text = "Оновити список";
            updateAcceptedParcelsButton.UseVisualStyleBackColor = false;
            updateAcceptedParcelsButton.Click += updateAcceptedParcelsButton_Click;
            // 
            // updateAvailibleParcelsButton
            // 
            updateAvailibleParcelsButton.BackColor = Color.MediumSeaGreen;
            updateAvailibleParcelsButton.FlatStyle = FlatStyle.Flat;
            updateAvailibleParcelsButton.ForeColor = Color.White;
            updateAvailibleParcelsButton.Location = new Point(1024, 51);
            updateAvailibleParcelsButton.Name = "updateAvailibleParcelsButton";
            updateAvailibleParcelsButton.Size = new Size(156, 29);
            updateAvailibleParcelsButton.TabIndex = 8;
            updateAvailibleParcelsButton.Text = "Оновити список";
            updateAvailibleParcelsButton.UseVisualStyleBackColor = false;
            updateAvailibleParcelsButton.Click += updateAvailibleParcelsButton_Click;
            // 
            // CourierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 565);
            Controls.Add(updateAvailibleParcelsButton);
            Controls.Add(updateAcceptedParcelsButton);
            Controls.Add(acceptedParcelsPanel);
            Controls.Add(availibleParcelsPanel);
            Controls.Add(statusStrip);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "CourierForm";
            Text = "Courier Delivery Service";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripTextBox accountNameGreetingLabel;
        private Label label1;
        private Label label2;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusStripLabel;
        private FlowLayoutPanel availibleParcelsPanel;
        private FlowLayoutPanel acceptedParcelsPanel;
        private Button updateAcceptedParcelsButton;
        private Button updateAvailibleParcelsButton;
    }
}