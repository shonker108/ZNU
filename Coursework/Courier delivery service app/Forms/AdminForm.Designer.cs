namespace Courier_delivery_service_app.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            menuStrip = new MenuStrip();
            accountNameGreetingLabel = new ToolStripTextBox();
            filterButton = new ToolStripMenuItem();
            manualQueryModeButton = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusStripLabel = new ToolStripStatusLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            clientsPanel = new FlowLayoutPanel();
            couriersPanel = new FlowLayoutPanel();
            parcelsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            courierTransportTypeInputBox = new ComboBox();
            addCourierButton = new Button();
            courierTransportPlateNumInputBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            courierEmailInputBox = new TextBox();
            courierPasswordInputBox = new TextBox();
            courierPhoneInputBox = new TextBox();
            courierFullNameInputBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            updateParcelsButton = new Button();
            updateCouriersButton = new Button();
            updateClientsButton = new Button();
            courierStatsButton = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.MediumSeaGreen;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { accountNameGreetingLabel, filterButton, manualQueryModeButton, courierStatsButton });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1469, 31);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // accountNameGreetingLabel
            // 
            accountNameGreetingLabel.BackColor = Color.MediumSeaGreen;
            accountNameGreetingLabel.ForeColor = Color.White;
            accountNameGreetingLabel.Name = "accountNameGreetingLabel";
            accountNameGreetingLabel.ReadOnly = true;
            accountNameGreetingLabel.Size = new Size(350, 27);
            // 
            // filterButton
            // 
            filterButton.ForeColor = Color.White;
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(78, 27);
            filterButton.Text = "Фільтри";
            filterButton.Click += filterButton_Click;
            // 
            // manualQueryModeButton
            // 
            manualQueryModeButton.ForeColor = Color.White;
            manualQueryModeButton.Name = "manualQueryModeButton";
            manualQueryModeButton.Size = new Size(226, 27);
            manualQueryModeButton.Text = "Ручний режим доступу до БД";
            manualQueryModeButton.Click += manualQueryModeButton_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
            statusStrip.Location = new Point(0, 782);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1469, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(0, 16);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 43);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 2;
            label1.Text = "Додати кур'єра:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(359, 43);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 3;
            label2.Text = "Клієнти:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(730, 44);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 4;
            label3.Text = "Кур'єри:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(1103, 47);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 5;
            label4.Text = "Посилки:";
            // 
            // clientsPanel
            // 
            clientsPanel.AutoScroll = true;
            clientsPanel.BorderStyle = BorderStyle.FixedSingle;
            clientsPanel.FlowDirection = FlowDirection.TopDown;
            clientsPanel.Location = new Point(359, 88);
            clientsPanel.Name = "clientsPanel";
            clientsPanel.Size = new Size(336, 673);
            clientsPanel.TabIndex = 6;
            clientsPanel.WrapContents = false;
            // 
            // couriersPanel
            // 
            couriersPanel.AutoScroll = true;
            couriersPanel.BorderStyle = BorderStyle.FixedSingle;
            couriersPanel.FlowDirection = FlowDirection.TopDown;
            couriersPanel.Location = new Point(730, 88);
            couriersPanel.Name = "couriersPanel";
            couriersPanel.Size = new Size(336, 673);
            couriersPanel.TabIndex = 7;
            couriersPanel.WrapContents = false;
            // 
            // parcelsPanel
            // 
            parcelsPanel.AutoScroll = true;
            parcelsPanel.BorderStyle = BorderStyle.FixedSingle;
            parcelsPanel.FlowDirection = FlowDirection.TopDown;
            parcelsPanel.Location = new Point(1103, 88);
            parcelsPanel.Name = "parcelsPanel";
            parcelsPanel.Size = new Size(336, 673);
            parcelsPanel.TabIndex = 8;
            parcelsPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(courierTransportTypeInputBox);
            panel1.Controls.Add(addCourierButton);
            panel1.Controls.Add(courierTransportPlateNumInputBox);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(courierEmailInputBox);
            panel1.Controls.Add(courierPasswordInputBox);
            panel1.Controls.Add(courierPhoneInputBox);
            panel1.Controls.Add(courierFullNameInputBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 428);
            panel1.TabIndex = 9;
            // 
            // courierTransportTypeInputBox
            // 
            courierTransportTypeInputBox.BackColor = Color.White;
            courierTransportTypeInputBox.DropDownStyle = ComboBoxStyle.DropDownList;
            courierTransportTypeInputBox.FormattingEnabled = true;
            courierTransportTypeInputBox.Location = new Point(86, 296);
            courierTransportTypeInputBox.Name = "courierTransportTypeInputBox";
            courierTransportTypeInputBox.Size = new Size(151, 28);
            courierTransportTypeInputBox.TabIndex = 5;
            // 
            // addCourierButton
            // 
            addCourierButton.BackColor = Color.MediumSeaGreen;
            addCourierButton.FlatStyle = FlatStyle.Flat;
            addCourierButton.ForeColor = Color.White;
            addCourierButton.Location = new Point(104, 380);
            addCourierButton.Name = "addCourierButton";
            addCourierButton.Size = new Size(94, 29);
            addCourierButton.TabIndex = 7;
            addCourierButton.Text = "Додати";
            addCourierButton.UseVisualStyleBackColor = false;
            addCourierButton.Click += addCourierButton_Click;
            // 
            // courierTransportPlateNumInputBox
            // 
            courierTransportPlateNumInputBox.Location = new Point(170, 329);
            courierTransportPlateNumInputBox.Name = "courierTransportPlateNumInputBox";
            courierTransportPlateNumInputBox.Size = new Size(125, 27);
            courierTransportPlateNumInputBox.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 332);
            label12.Name = "label12";
            label12.Size = new Size(122, 20);
            label12.TabIndex = 12;
            label12.Text = "Номерний знак:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 299);
            label13.Name = "label13";
            label13.Size = new Size(38, 20);
            label13.TabIndex = 11;
            label13.Text = "Тип:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(102, 256);
            label11.Name = "label11";
            label11.Size = new Size(92, 23);
            label11.TabIndex = 10;
            label11.Text = "Транспорт";
            // 
            // courierEmailInputBox
            // 
            courierEmailInputBox.Location = new Point(86, 48);
            courierEmailInputBox.Name = "courierEmailInputBox";
            courierEmailInputBox.Size = new Size(125, 27);
            courierEmailInputBox.TabIndex = 1;
            // 
            // courierPasswordInputBox
            // 
            courierPasswordInputBox.Location = new Point(86, 81);
            courierPasswordInputBox.Name = "courierPasswordInputBox";
            courierPasswordInputBox.PasswordChar = '●';
            courierPasswordInputBox.Size = new Size(125, 27);
            courierPasswordInputBox.TabIndex = 2;
            // 
            // courierPhoneInputBox
            // 
            courierPhoneInputBox.Location = new Point(86, 205);
            courierPhoneInputBox.Name = "courierPhoneInputBox";
            courierPhoneInputBox.Size = new Size(125, 27);
            courierPhoneInputBox.TabIndex = 4;
            // 
            // courierFullNameInputBox
            // 
            courierFullNameInputBox.Location = new Point(86, 169);
            courierFullNameInputBox.Name = "courierFullNameInputBox";
            courierFullNameInputBox.Size = new Size(125, 27);
            courierFullNameInputBox.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(77, 124);
            label10.Name = "label10";
            label10.Size = new Size(150, 23);
            label10.TabIndex = 5;
            label10.Text = "Персональні дані";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(87, 11);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 4;
            label9.Text = "Дані для входу";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 208);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 3;
            label8.Text = "Телефон:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 172);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 2;
            label7.Text = "ПІБ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 84);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 1;
            label6.Text = "Пароль:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 51);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // updateParcelsButton
            // 
            updateParcelsButton.BackColor = Color.MediumSeaGreen;
            updateParcelsButton.FlatStyle = FlatStyle.Flat;
            updateParcelsButton.ForeColor = Color.White;
            updateParcelsButton.Location = new Point(1291, 46);
            updateParcelsButton.Name = "updateParcelsButton";
            updateParcelsButton.Size = new Size(148, 29);
            updateParcelsButton.TabIndex = 10;
            updateParcelsButton.Text = "Оновити список";
            updateParcelsButton.UseVisualStyleBackColor = false;
            updateParcelsButton.Click += updateParcelsButton_Click;
            // 
            // updateCouriersButton
            // 
            updateCouriersButton.BackColor = Color.MediumSeaGreen;
            updateCouriersButton.FlatStyle = FlatStyle.Flat;
            updateCouriersButton.ForeColor = Color.White;
            updateCouriersButton.Location = new Point(918, 47);
            updateCouriersButton.Name = "updateCouriersButton";
            updateCouriersButton.Size = new Size(148, 29);
            updateCouriersButton.TabIndex = 11;
            updateCouriersButton.Text = "Оновити список";
            updateCouriersButton.UseVisualStyleBackColor = false;
            updateCouriersButton.Click += updateCouriersButton_Click;
            // 
            // updateClientsButton
            // 
            updateClientsButton.BackColor = Color.MediumSeaGreen;
            updateClientsButton.FlatStyle = FlatStyle.Flat;
            updateClientsButton.ForeColor = Color.White;
            updateClientsButton.Location = new Point(547, 46);
            updateClientsButton.Name = "updateClientsButton";
            updateClientsButton.Size = new Size(148, 29);
            updateClientsButton.TabIndex = 12;
            updateClientsButton.Text = "Оновити список";
            updateClientsButton.UseVisualStyleBackColor = false;
            updateClientsButton.Click += updateClientsButton_Click;
            // 
            // courierStatsButton
            // 
            courierStatsButton.ForeColor = Color.White;
            courierStatsButton.Name = "courierStatsButton";
            courierStatsButton.Size = new Size(156, 27);
            courierStatsButton.Text = "Статистика кур'єрів";
            courierStatsButton.Click += courierStatsButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 804);
            Controls.Add(updateClientsButton);
            Controls.Add(updateCouriersButton);
            Controls.Add(updateParcelsButton);
            Controls.Add(panel1);
            Controls.Add(parcelsPanel);
            Controls.Add(couriersPanel);
            Controls.Add(clientsPanel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "AdminForm";
            Text = "Courier Delivery Service";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripTextBox accountNameGreetingLabel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusStripLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel clientsPanel;
        private FlowLayoutPanel couriersPanel;
        private FlowLayoutPanel parcelsPanel;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label13;
        private Label label11;
        private TextBox courierEmailInputBox;
        private TextBox courierPasswordInputBox;
        private TextBox courierPhoneInputBox;
        private TextBox courierFullNameInputBox;
        private Label label10;
        private Button addCourierButton;
        private TextBox courierTransportPlateNumInputBox;
        private ComboBox courierTransportTypeInputBox;
        private Button updateParcelsButton;
        private ToolStripMenuItem manualQueryModeButton;
        private Button updateCouriersButton;
        private Button updateClientsButton;
        private ToolStripMenuItem filterButton;
        private ToolStripMenuItem courierStatsButton;
    }
}