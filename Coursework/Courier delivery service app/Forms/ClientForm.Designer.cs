namespace Courier_delivery_service_app.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            menuStrip1 = new MenuStrip();
            accountNameGreetingLabel = new ToolStripTextBox();
            acceptButton = new Button();
            parcelsPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            calculatePriceButton = new Button();
            priceOutputBox = new TextBox();
            label20 = new Label();
            weightInputBox = new TextBox();
            label19 = new Label();
            label18 = new Label();
            recieverPhoneInputBox = new TextBox();
            recieverFullNameInputBox = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            sendingAddrApartmentInputBox = new TextBox();
            sendingAddrHouseInputBox = new TextBox();
            arrivalAddrApartmentInputBox = new TextBox();
            arrivalAddrHouseInputBox = new TextBox();
            sendingAddrStreetInputBox = new TextBox();
            sendingAddrCityInputBox = new TextBox();
            sendingAddrRegionInputBox = new TextBox();
            arrivalAddrStreetInputBox = new TextBox();
            arrivalAddrCityInputBox = new TextBox();
            arrivalAddrRegionInputBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            statusStrip = new StatusStrip();
            statusStripLabel = new ToolStripStatusLabel();
            updateButton = new Button();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
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
            // acceptButton
            // 
            acceptButton.Location = new Point(480, 359);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(123, 29);
            acceptButton.TabIndex = 1;
            acceptButton.Text = "Підтвердити";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // parcelsPanel
            // 
            parcelsPanel.AutoScroll = true;
            parcelsPanel.BackColor = SystemColors.Control;
            parcelsPanel.BorderStyle = BorderStyle.FixedSingle;
            parcelsPanel.FlowDirection = FlowDirection.TopDown;
            parcelsPanel.Location = new Point(691, 72);
            parcelsPanel.Name = "parcelsPanel";
            parcelsPanel.Size = new Size(489, 407);
            parcelsPanel.TabIndex = 2;
            parcelsPanel.WrapContents = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(calculatePriceButton);
            panel4.Controls.Add(priceOutputBox);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(weightInputBox);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(recieverPhoneInputBox);
            panel4.Controls.Add(recieverFullNameInputBox);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(sendingAddrApartmentInputBox);
            panel4.Controls.Add(sendingAddrHouseInputBox);
            panel4.Controls.Add(arrivalAddrApartmentInputBox);
            panel4.Controls.Add(arrivalAddrHouseInputBox);
            panel4.Controls.Add(sendingAddrStreetInputBox);
            panel4.Controls.Add(sendingAddrCityInputBox);
            panel4.Controls.Add(sendingAddrRegionInputBox);
            panel4.Controls.Add(arrivalAddrStreetInputBox);
            panel4.Controls.Add(arrivalAddrCityInputBox);
            panel4.Controls.Add(arrivalAddrRegionInputBox);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(acceptButton);
            panel4.Location = new Point(12, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(673, 407);
            panel4.TabIndex = 3;
            // 
            // calculatePriceButton
            // 
            calculatePriceButton.Location = new Point(108, 359);
            calculatePriceButton.Name = "calculatePriceButton";
            calculatePriceButton.Size = new Size(115, 29);
            calculatePriceButton.TabIndex = 34;
            calculatePriceButton.Text = "Розрахувати";
            calculatePriceButton.UseVisualStyleBackColor = true;
            calculatePriceButton.Click += calculatePriceButton_Click;
            // 
            // priceOutputBox
            // 
            priceOutputBox.Location = new Point(240, 322);
            priceOutputBox.Name = "priceOutputBox";
            priceOutputBox.ReadOnly = true;
            priceOutputBox.Size = new Size(80, 27);
            priceOutputBox.TabIndex = 33;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 325);
            label20.Name = "label20";
            label20.Size = new Size(217, 20);
            label20.TabIndex = 32;
            label20.Text = "Приблизна вартість доставки:";
            // 
            // weightInputBox
            // 
            weightInputBox.Location = new Point(478, 199);
            weightInputBox.MaxLength = 4;
            weightInputBox.Name = "weightInputBox";
            weightInputBox.Size = new Size(125, 27);
            weightInputBox.TabIndex = 31;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(402, 202);
            label19.Name = "label19";
            label19.Size = new Size(70, 20);
            label19.TabIndex = 30;
            label19.Text = "Вага (кг):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(497, 155);
            label18.Name = "label18";
            label18.Size = new Size(79, 23);
            label18.TabIndex = 29;
            label18.Text = "Посилка";
            // 
            // recieverPhoneInputBox
            // 
            recieverPhoneInputBox.Location = new Point(478, 86);
            recieverPhoneInputBox.MaxLength = 10;
            recieverPhoneInputBox.Name = "recieverPhoneInputBox";
            recieverPhoneInputBox.Size = new Size(125, 27);
            recieverPhoneInputBox.TabIndex = 28;
            // 
            // recieverFullNameInputBox
            // 
            recieverFullNameInputBox.Location = new Point(478, 52);
            recieverFullNameInputBox.MaxLength = 100;
            recieverFullNameInputBox.Name = "recieverFullNameInputBox";
            recieverFullNameInputBox.Size = new Size(125, 27);
            recieverFullNameInputBox.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(400, 89);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 26;
            label17.Text = "Телефон:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(436, 55);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 25;
            label16.Text = "ПІБ:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(487, 15);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 24;
            label15.Text = "Отримувач";
            // 
            // sendingAddrApartmentInputBox
            // 
            sendingAddrApartmentInputBox.Location = new Point(316, 86);
            sendingAddrApartmentInputBox.MaxLength = 3;
            sendingAddrApartmentInputBox.Name = "sendingAddrApartmentInputBox";
            sendingAddrApartmentInputBox.Size = new Size(52, 27);
            sendingAddrApartmentInputBox.TabIndex = 23;
            // 
            // sendingAddrHouseInputBox
            // 
            sendingAddrHouseInputBox.Location = new Point(316, 52);
            sendingAddrHouseInputBox.MaxLength = 3;
            sendingAddrHouseInputBox.Name = "sendingAddrHouseInputBox";
            sendingAddrHouseInputBox.Size = new Size(52, 27);
            sendingAddrHouseInputBox.TabIndex = 22;
            // 
            // arrivalAddrApartmentInputBox
            // 
            arrivalAddrApartmentInputBox.Location = new Point(316, 233);
            arrivalAddrApartmentInputBox.MaxLength = 3;
            arrivalAddrApartmentInputBox.Name = "arrivalAddrApartmentInputBox";
            arrivalAddrApartmentInputBox.Size = new Size(52, 27);
            arrivalAddrApartmentInputBox.TabIndex = 21;
            // 
            // arrivalAddrHouseInputBox
            // 
            arrivalAddrHouseInputBox.Location = new Point(316, 199);
            arrivalAddrHouseInputBox.MaxLength = 3;
            arrivalAddrHouseInputBox.Name = "arrivalAddrHouseInputBox";
            arrivalAddrHouseInputBox.Size = new Size(52, 27);
            arrivalAddrHouseInputBox.TabIndex = 20;
            // 
            // sendingAddrStreetInputBox
            // 
            sendingAddrStreetInputBox.Location = new Point(98, 119);
            sendingAddrStreetInputBox.MaxLength = 100;
            sendingAddrStreetInputBox.Name = "sendingAddrStreetInputBox";
            sendingAddrStreetInputBox.Size = new Size(125, 27);
            sendingAddrStreetInputBox.TabIndex = 19;
            // 
            // sendingAddrCityInputBox
            // 
            sendingAddrCityInputBox.Location = new Point(98, 86);
            sendingAddrCityInputBox.MaxLength = 100;
            sendingAddrCityInputBox.Name = "sendingAddrCityInputBox";
            sendingAddrCityInputBox.Size = new Size(125, 27);
            sendingAddrCityInputBox.TabIndex = 18;
            // 
            // sendingAddrRegionInputBox
            // 
            sendingAddrRegionInputBox.Location = new Point(98, 52);
            sendingAddrRegionInputBox.MaxLength = 35;
            sendingAddrRegionInputBox.Name = "sendingAddrRegionInputBox";
            sendingAddrRegionInputBox.Size = new Size(125, 27);
            sendingAddrRegionInputBox.TabIndex = 17;
            // 
            // arrivalAddrStreetInputBox
            // 
            arrivalAddrStreetInputBox.Location = new Point(98, 266);
            arrivalAddrStreetInputBox.MaxLength = 100;
            arrivalAddrStreetInputBox.Name = "arrivalAddrStreetInputBox";
            arrivalAddrStreetInputBox.Size = new Size(125, 27);
            arrivalAddrStreetInputBox.TabIndex = 16;
            // 
            // arrivalAddrCityInputBox
            // 
            arrivalAddrCityInputBox.Location = new Point(98, 233);
            arrivalAddrCityInputBox.MaxLength = 100;
            arrivalAddrCityInputBox.Name = "arrivalAddrCityInputBox";
            arrivalAddrCityInputBox.Size = new Size(125, 27);
            arrivalAddrCityInputBox.TabIndex = 15;
            // 
            // arrivalAddrRegionInputBox
            // 
            arrivalAddrRegionInputBox.Location = new Point(98, 199);
            arrivalAddrRegionInputBox.MaxLength = 35;
            arrivalAddrRegionInputBox.Name = "arrivalAddrRegionInputBox";
            arrivalAddrRegionInputBox.Size = new Size(125, 27);
            arrivalAddrRegionInputBox.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(232, 236);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 13;
            label10.Text = "Квартира:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(240, 202);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 12;
            label11.Text = "Будинок:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 269);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 11;
            label12.Text = "Вулиця:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 202);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 10;
            label13.Text = "Область:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 236);
            label14.Name = "label14";
            label14.Size = new Size(51, 20);
            label14.TabIndex = 9;
            label14.Text = "Місто:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(232, 89);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 8;
            label9.Text = "Квартира:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(240, 55);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 7;
            label8.Text = "Будинок:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 119);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Вулиця:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 55);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Область:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 89);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Місто:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(80, 15);
            label4.Name = "label4";
            label4.Size = new Size(153, 23);
            label4.TabIndex = 3;
            label4.Text = "Адреса відправки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(80, 155);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 2;
            label3.Text = "Адреса прибуття";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(691, 41);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 4;
            label1.Text = "Ваші посилки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 41);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 5;
            label2.Text = "Замовити посилку:";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
            statusStrip.Location = new Point(0, 543);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1192, 22);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(0, 16);
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.MediumSeaGreen;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(691, 497);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(168, 29);
            updateButton.TabIndex = 7;
            updateButton.Text = "Оновити список";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 565);
            Controls.Add(updateButton);
            Controls.Add(statusStrip);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(parcelsPanel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "ClientForm";
            Text = "Courier Delivery Service";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripTextBox accountNameGreetingLabel;
        private Button acceptButton;
        private FlowLayoutPanel parcelsPanel;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox arrivalAddrStreetInputBox;
        private TextBox arrivalAddrCityInputBox;
        private TextBox arrivalAddrRegionInputBox;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox sendingAddrApartmentInputBox;
        private TextBox sendingAddrHouseInputBox;
        private TextBox arrivalAddrApartmentInputBox;
        private TextBox arrivalAddrHouseInputBox;
        private TextBox sendingAddrStreetInputBox;
        private TextBox sendingAddrCityInputBox;
        private TextBox sendingAddrRegionInputBox;
        private TextBox weightInputBox;
        private Label label19;
        private Label label18;
        private TextBox recieverPhoneInputBox;
        private TextBox recieverFullNameInputBox;
        private Label label17;
        private Label label16;
        private Label label15;
        private Button calculatePriceButton;
        private TextBox priceOutputBox;
        private Label label20;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusStripLabel;
        private Button updateButton;
    }
}