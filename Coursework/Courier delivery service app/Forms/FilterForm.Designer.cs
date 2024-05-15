namespace Courier_delivery_service_app.Forms
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            panel2 = new Panel();
            parcelFilterOkButton = new Button();
            courierFilterOkButton = new Button();
            clientFilterOkButton = new Button();
            arrivalDateTimeBox = new DateTimePicker();
            sendingDateTimeBox = new DateTimePicker();
            acceptDateTimeBox = new DateTimePicker();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            transportNumberInputBox = new TextBox();
            label21 = new Label();
            courierSurnameInputBox = new TextBox();
            courierNameInputBox = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            clientSurnameInputBox = new TextBox();
            clientNameInputBox = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(parcelFilterOkButton);
            panel2.Controls.Add(courierFilterOkButton);
            panel2.Controls.Add(clientFilterOkButton);
            panel2.Controls.Add(arrivalDateTimeBox);
            panel2.Controls.Add(sendingDateTimeBox);
            panel2.Controls.Add(acceptDateTimeBox);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(transportNumberInputBox);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(courierSurnameInputBox);
            panel2.Controls.Add(courierNameInputBox);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(clientSurnameInputBox);
            panel2.Controls.Add(clientNameInputBox);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(12, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 200);
            panel2.TabIndex = 17;
            // 
            // parcelFilterOkButton
            // 
            parcelFilterOkButton.BackColor = Color.MediumSeaGreen;
            parcelFilterOkButton.FlatStyle = FlatStyle.Flat;
            parcelFilterOkButton.ForeColor = Color.White;
            parcelFilterOkButton.Location = new Point(843, 154);
            parcelFilterOkButton.Name = "parcelFilterOkButton";
            parcelFilterOkButton.Size = new Size(125, 29);
            parcelFilterOkButton.TabIndex = 23;
            parcelFilterOkButton.Text = "Застосувати";
            parcelFilterOkButton.UseVisualStyleBackColor = false;
            parcelFilterOkButton.Click += parcelFilterOkButton_Click;
            // 
            // courierFilterOkButton
            // 
            courierFilterOkButton.BackColor = Color.MediumSeaGreen;
            courierFilterOkButton.FlatStyle = FlatStyle.Flat;
            courierFilterOkButton.ForeColor = Color.White;
            courierFilterOkButton.Location = new Point(474, 154);
            courierFilterOkButton.Name = "courierFilterOkButton";
            courierFilterOkButton.Size = new Size(125, 29);
            courierFilterOkButton.TabIndex = 22;
            courierFilterOkButton.Text = "Застосувати";
            courierFilterOkButton.UseVisualStyleBackColor = false;
            courierFilterOkButton.Click += courierFilterOkButton_Click;
            // 
            // clientFilterOkButton
            // 
            clientFilterOkButton.BackColor = Color.MediumSeaGreen;
            clientFilterOkButton.FlatStyle = FlatStyle.Flat;
            clientFilterOkButton.ForeColor = Color.White;
            clientFilterOkButton.Location = new Point(104, 154);
            clientFilterOkButton.Name = "clientFilterOkButton";
            clientFilterOkButton.Size = new Size(125, 29);
            clientFilterOkButton.TabIndex = 21;
            clientFilterOkButton.Text = "Застосувати";
            clientFilterOkButton.UseVisualStyleBackColor = false;
            clientFilterOkButton.Click += clientFilterOkButton_Click;
            // 
            // arrivalDateTimeBox
            // 
            arrivalDateTimeBox.CustomFormat = "dd/MM/yyyy";
            arrivalDateTimeBox.Format = DateTimePickerFormat.Custom;
            arrivalDateTimeBox.Location = new Point(843, 108);
            arrivalDateTimeBox.Name = "arrivalDateTimeBox";
            arrivalDateTimeBox.Size = new Size(224, 27);
            arrivalDateTimeBox.TabIndex = 20;
            // 
            // sendingDateTimeBox
            // 
            sendingDateTimeBox.CustomFormat = "dd/MM/yyyy";
            sendingDateTimeBox.Format = DateTimePickerFormat.Custom;
            sendingDateTimeBox.Location = new Point(843, 77);
            sendingDateTimeBox.Name = "sendingDateTimeBox";
            sendingDateTimeBox.Size = new Size(224, 27);
            sendingDateTimeBox.TabIndex = 19;
            // 
            // acceptDateTimeBox
            // 
            acceptDateTimeBox.CustomFormat = "dd/MM/yyyy";
            acceptDateTimeBox.Format = DateTimePickerFormat.Custom;
            acceptDateTimeBox.Location = new Point(843, 46);
            acceptDateTimeBox.Name = "acceptDateTimeBox";
            acceptDateTimeBox.Size = new Size(224, 27);
            acceptDateTimeBox.TabIndex = 18;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(726, 113);
            label22.Name = "label22";
            label22.Size = new Size(111, 20);
            label22.TabIndex = 17;
            label22.Text = "Дата прибуття:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label23.Location = new Point(862, 12);
            label23.Name = "label23";
            label23.Size = new Size(79, 23);
            label23.TabIndex = 14;
            label23.Text = "Посилка";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(719, 82);
            label24.Name = "label24";
            label24.Size = new Size(118, 20);
            label24.TabIndex = 13;
            label24.Text = "Дата відправки:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(684, 51);
            label25.Name = "label25";
            label25.Size = new Size(153, 20);
            label25.TabIndex = 12;
            label25.Text = "Дата підтвердження:";
            // 
            // transportNumberInputBox
            // 
            transportNumberInputBox.Location = new Point(474, 110);
            transportNumberInputBox.Name = "transportNumberInputBox";
            transportNumberInputBox.Size = new Size(125, 27);
            transportNumberInputBox.TabIndex = 11;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(325, 113);
            label21.Name = "label21";
            label21.Size = new Size(143, 20);
            label21.TabIndex = 10;
            label21.Text = "Номер транспорту:";
            // 
            // courierSurnameInputBox
            // 
            courierSurnameInputBox.Location = new Point(474, 79);
            courierSurnameInputBox.Name = "courierSurnameInputBox";
            courierSurnameInputBox.Size = new Size(125, 27);
            courierSurnameInputBox.TabIndex = 9;
            // 
            // courierNameInputBox
            // 
            courierNameInputBox.Location = new Point(474, 48);
            courierNameInputBox.Name = "courierNameInputBox";
            courierNameInputBox.Size = new Size(125, 27);
            courierNameInputBox.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(508, 12);
            label18.Name = "label18";
            label18.Size = new Size(59, 23);
            label18.TabIndex = 7;
            label18.Text = "Кур'єр";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(388, 82);
            label19.Name = "label19";
            label19.Size = new Size(80, 20);
            label19.TabIndex = 6;
            label19.Text = "Прізвище:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(430, 51);
            label20.Name = "label20";
            label20.Size = new Size(38, 20);
            label20.TabIndex = 5;
            label20.Text = "Ім'я:";
            // 
            // clientSurnameInputBox
            // 
            clientSurnameInputBox.Location = new Point(104, 79);
            clientSurnameInputBox.Name = "clientSurnameInputBox";
            clientSurnameInputBox.Size = new Size(125, 27);
            clientSurnameInputBox.TabIndex = 4;
            // 
            // clientNameInputBox
            // 
            clientNameInputBox.Location = new Point(104, 48);
            clientNameInputBox.Name = "clientNameInputBox";
            clientNameInputBox.Size = new Size(125, 27);
            clientNameInputBox.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.Location = new Point(135, 12);
            label17.Name = "label17";
            label17.Size = new Size(60, 23);
            label17.TabIndex = 2;
            label17.Text = "Клієнт";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 82);
            label16.Name = "label16";
            label16.Size = new Size(80, 20);
            label16.TabIndex = 1;
            label16.Text = "Прізвище:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 51);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 0;
            label15.Text = "Ім'я:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(12, 9);
            label14.Name = "label14";
            label14.Size = new Size(87, 28);
            label14.TabIndex = 16;
            label14.Text = "Фільтри";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 255);
            Controls.Add(panel2);
            Controls.Add(label14);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilterForm";
            Text = "Фільтри";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button parcelFilterOkButton;
        private Button courierFilterOkButton;
        private Button clientFilterOkButton;
        private DateTimePicker arrivalDateTimeBox;
        private DateTimePicker sendingDateTimeBox;
        private DateTimePicker acceptDateTimeBox;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private TextBox transportNumberInputBox;
        private Label label21;
        private TextBox courierSurnameInputBox;
        private TextBox courierNameInputBox;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox clientSurnameInputBox;
        private TextBox clientNameInputBox;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}