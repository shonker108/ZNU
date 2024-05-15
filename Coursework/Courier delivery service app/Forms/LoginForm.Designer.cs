namespace Courier_delivery_service_app.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            regAcceptButton = new Button();
            regPasswordInputBox = new TextBox();
            regEmailInputBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            alreadyRegisteredLink = new LinkLabel();
            registrationGroupBox = new GroupBox();
            regPhoneInputBox = new TextBox();
            regFullNameInputBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            regPasswordConfirmationInputBox = new TextBox();
            statusStrip1 = new StatusStrip();
            statusStripLabel = new ToolStripStatusLabel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            hasntRegisteredLink = new LinkLabel();
            loginAcceptButton = new Button();
            loginEmailBox = new TextBox();
            loginPasswordBox = new TextBox();
            loginGroupBox = new GroupBox();
            registrationGroupBox.SuspendLayout();
            statusStrip1.SuspendLayout();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // regAcceptButton
            // 
            regAcceptButton.BackColor = Color.MediumSeaGreen;
            regAcceptButton.FlatAppearance.BorderSize = 0;
            regAcceptButton.FlatStyle = FlatStyle.Flat;
            regAcceptButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            regAcceptButton.ForeColor = Color.Transparent;
            regAcceptButton.Location = new Point(345, 317);
            regAcceptButton.Name = "regAcceptButton";
            regAcceptButton.Size = new Size(94, 29);
            regAcceptButton.TabIndex = 13;
            regAcceptButton.Text = "ОК";
            regAcceptButton.UseVisualStyleBackColor = false;
            regAcceptButton.Click += regAcceptButton_Click;
            // 
            // regPasswordInputBox
            // 
            regPasswordInputBox.Location = new Point(232, 215);
            regPasswordInputBox.Name = "regPasswordInputBox";
            regPasswordInputBox.PasswordChar = '●';
            regPasswordInputBox.Size = new Size(125, 27);
            regPasswordInputBox.TabIndex = 12;
            // 
            // regEmailInputBox
            // 
            regEmailInputBox.Location = new Point(232, 171);
            regEmailInputBox.Name = "regEmailInputBox";
            regEmailInputBox.Size = new Size(125, 27);
            regEmailInputBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 218);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 174);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 134);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 8;
            label2.Text = "Введіть дані для реєстрації:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 84);
            label1.Name = "label1";
            label1.Size = new Size(178, 41);
            label1.TabIndex = 7;
            label1.Text = "Вітаємо! 👋";
            // 
            // alreadyRegisteredLink
            // 
            alreadyRegisteredLink.AutoSize = true;
            alreadyRegisteredLink.LinkColor = Color.Blue;
            alreadyRegisteredLink.Location = new Point(262, 358);
            alreadyRegisteredLink.Name = "alreadyRegisteredLink";
            alreadyRegisteredLink.Size = new Size(259, 20);
            alreadyRegisteredLink.TabIndex = 14;
            alreadyRegisteredLink.TabStop = true;
            alreadyRegisteredLink.Text = "Вже зареєстровані? Натисніть сюди";
            alreadyRegisteredLink.LinkClicked += alreadyRegisteredLink_LinkClicked;
            // 
            // registrationGroupBox
            // 
            registrationGroupBox.Controls.Add(regPhoneInputBox);
            registrationGroupBox.Controls.Add(regFullNameInputBox);
            registrationGroupBox.Controls.Add(label11);
            registrationGroupBox.Controls.Add(label10);
            registrationGroupBox.Controls.Add(tableLayoutPanel1);
            registrationGroupBox.Controls.Add(label9);
            registrationGroupBox.Controls.Add(regPasswordConfirmationInputBox);
            registrationGroupBox.Controls.Add(label1);
            registrationGroupBox.Controls.Add(alreadyRegisteredLink);
            registrationGroupBox.Controls.Add(label2);
            registrationGroupBox.Controls.Add(regAcceptButton);
            registrationGroupBox.Controls.Add(label3);
            registrationGroupBox.Controls.Add(regPasswordInputBox);
            registrationGroupBox.Controls.Add(label4);
            registrationGroupBox.Controls.Add(regEmailInputBox);
            registrationGroupBox.Location = new Point(11, 12);
            registrationGroupBox.Name = "registrationGroupBox";
            registrationGroupBox.Size = new Size(793, 413);
            registrationGroupBox.TabIndex = 15;
            registrationGroupBox.TabStop = false;
            registrationGroupBox.Visible = false;
            // 
            // regPhoneInputBox
            // 
            regPhoneInputBox.Location = new Point(461, 215);
            regPhoneInputBox.Name = "regPhoneInputBox";
            regPhoneInputBox.Size = new Size(125, 27);
            regPhoneInputBox.TabIndex = 22;
            // 
            // regFullNameInputBox
            // 
            regFullNameInputBox.Location = new Point(461, 171);
            regFullNameInputBox.Name = "regFullNameInputBox";
            regFullNameInputBox.Size = new Size(125, 27);
            regFullNameInputBox.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 218);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 20;
            label11.Text = "Телефон:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(419, 171);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 19;
            label10.Text = "ПІБ:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(290, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(0, 0);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 264);
            label9.Name = "label9";
            label9.Size = new Size(147, 20);
            label9.TabIndex = 16;
            label9.Text = "Підтвердіть пароль:";
            // 
            // regPasswordConfirmationInputBox
            // 
            regPasswordConfirmationInputBox.Location = new Point(232, 261);
            regPasswordConfirmationInputBox.Name = "regPasswordConfirmationInputBox";
            regPasswordConfirmationInputBox.PasswordChar = '●';
            regPasswordConfirmationInputBox.Size = new Size(125, 27);
            regPasswordConfirmationInputBox.TabIndex = 15;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStripLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(816, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new Size(0, 16);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(311, 84);
            label5.Name = "label5";
            label5.Size = new Size(178, 41);
            label5.TabIndex = 0;
            label5.Text = "Вітаємо! 👋";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 138);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 1;
            label6.Text = "Введіть дані для входу:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 177);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 2;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(272, 214);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 3;
            label8.Text = "Пароль:";
            // 
            // hasntRegisteredLink
            // 
            hasntRegisteredLink.AutoSize = true;
            hasntRegisteredLink.Location = new Point(249, 305);
            hasntRegisteredLink.Name = "hasntRegisteredLink";
            hasntRegisteredLink.Size = new Size(278, 20);
            hasntRegisteredLink.TabIndex = 4;
            hasntRegisteredLink.TabStop = true;
            hasntRegisteredLink.Text = "Ще не зареєстровані? Натисніть сюди.";
            hasntRegisteredLink.LinkClicked += hasntRegisteredLink_LinkClicked;
            // 
            // loginAcceptButton
            // 
            loginAcceptButton.BackColor = Color.MediumSeaGreen;
            loginAcceptButton.FlatAppearance.BorderSize = 0;
            loginAcceptButton.FlatStyle = FlatStyle.Flat;
            loginAcceptButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginAcceptButton.ForeColor = Color.Transparent;
            loginAcceptButton.Location = new Point(343, 262);
            loginAcceptButton.Name = "loginAcceptButton";
            loginAcceptButton.Size = new Size(94, 29);
            loginAcceptButton.TabIndex = 3;
            loginAcceptButton.Text = "ОК";
            loginAcceptButton.UseVisualStyleBackColor = false;
            loginAcceptButton.Click += loginAcceptButton_Click;
            // 
            // loginEmailBox
            // 
            loginEmailBox.Location = new Point(343, 177);
            loginEmailBox.Name = "loginEmailBox";
            loginEmailBox.Size = new Size(125, 27);
            loginEmailBox.TabIndex = 1;
            // 
            // loginPasswordBox
            // 
            loginPasswordBox.Location = new Point(343, 214);
            loginPasswordBox.Name = "loginPasswordBox";
            loginPasswordBox.PasswordChar = '●';
            loginPasswordBox.Size = new Size(125, 27);
            loginPasswordBox.TabIndex = 2;
            // 
            // loginGroupBox
            // 
            loginGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginGroupBox.Controls.Add(loginPasswordBox);
            loginGroupBox.Controls.Add(loginEmailBox);
            loginGroupBox.Controls.Add(loginAcceptButton);
            loginGroupBox.Controls.Add(hasntRegisteredLink);
            loginGroupBox.Controls.Add(label8);
            loginGroupBox.Controls.Add(label7);
            loginGroupBox.Controls.Add(label6);
            loginGroupBox.Controls.Add(label5);
            loginGroupBox.Location = new Point(11, 12);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(793, 407);
            loginGroupBox.TabIndex = 16;
            loginGroupBox.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(loginGroupBox);
            Controls.Add(statusStrip1);
            Controls.Add(registrationGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Courier Delivery Service";
            registrationGroupBox.ResumeLayout(false);
            registrationGroupBox.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regAcceptButton;
        private TextBox regPasswordInputBox;
        private TextBox regEmailInputBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel alreadyRegisteredLink;
        private GroupBox registrationGroupBox;
        private Label label9;
        private TextBox regPasswordConfirmationInputBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStripLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox loginGroupBox;
        private TextBox loginPasswordBox;
        private TextBox loginEmailBox;
        private Button loginAcceptButton;
        private LinkLabel hasntRegisteredLink;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox regPhoneInputBox;
        private TextBox regFullNameInputBox;
        private Label label11;
        private Label label10;
    }
}