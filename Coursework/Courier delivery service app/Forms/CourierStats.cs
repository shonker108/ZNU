using Courier_delivery_service_app.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_delivery_service_app.Forms
{
    public partial class CourierStats : Form
    {
        private bool statsOfAllTime;
        public CourierStats()
        {
            InitializeComponent();

            allTimeRadioButton.Checked = true;

            statsOfAllTime = allTimeRadioButton.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ClearPanel(statsPanel);

            GetStats();
        }

        private void GetStats()
        {
            try
            {
                DatabaseAPI.Connect();

                if (!int.TryParse(idInputBox.Text, out int id))
                {
                    throw new ArgumentException("Невірно введене ID!");
                }

                DateTime fromDate = fromDateInputBox.Value;
                DateTime toDate = toDateInputBox.Value;

                if (!statsOfAllTime && (fromDate.CompareTo(toDate) > 0))
                {
                    throw new ArgumentException("Дата Від не може бути раніше дати До!");
                }

                var data = DatabaseAPI.GetCourierAndParcelsStats(id, statsOfAllTime ? null : fromDate, statsOfAllTime ? null : toDate);

                Label l1 = new Label();
                l1.AutoSize = true;
                l1.Text = "ПІБ: " + data.courier.fullName;

                Label l2 = new Label();
                l2.AutoSize = true;
                l2.Text = "Загалом посилок: " + data.parcelsStats[0];

                Label l3 = new Label();
                l3.AutoSize = true;
                float percentage = data.parcelsStats[0] == 0 ? 0 : (((float)data.parcelsStats[1] / data.parcelsStats[0]) * 100);
                l3.Text = "Доставлено посилок: " + data.parcelsStats[1] + " (" + percentage + "%)";

                Label l4 = new Label();
                l4.AutoSize = true;
                percentage = data.parcelsStats[0] == 0 ? 0 : (((float)data.parcelsStats[2] / data.parcelsStats[0]) * 100);
                l4.Text = "Скасованих посилок: " + data.parcelsStats[2] + " (" + percentage + "%)";

                Label l5 = new Label();
                l5.AutoSize = true;
                percentage = data.parcelsStats[0] == 0 ? 0 : (((float)data.parcelsStats[3] / data.parcelsStats[0]) * 100);
                l5.Text = "Посилок в дорозі: " + data.parcelsStats[3] + " (" + percentage + "%)";

                int parcelsWaiting = data.parcelsStats[0] - data.parcelsStats[1] - data.parcelsStats[2] - data.parcelsStats[3];

                Label l6 = new Label();
                l6.AutoSize = true;
                percentage = data.parcelsStats[0] == 0 ? 0 : (((float)parcelsWaiting / data.parcelsStats[0]) * 100);
                l6.Text = "Посилок в очікуванні: " + parcelsWaiting + " (" + percentage + "%)";

                statsPanel.Controls.Add(l1);
                statsPanel.Controls.Add(l2);
                statsPanel.Controls.Add(l3);
                statsPanel.Controls.Add(l4);
                statsPanel.Controls.Add(l5);
                statsPanel.Controls.Add(l6);

                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): Успішно створено статистику!";
            }
            catch (ArgumentException ex)
            {
                statusStripLabel.Text = $"Останнє повідомлення ({DateTime.Now}): {ex.Message}";
            }
            finally
            {
                DatabaseAPI.CloseConnection();
            }
        }

        private void ClearPanel(Control panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Dispose();
            }

            panel.Controls.Clear();
        }

        private void rangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rangeRadioButton.Checked)
            {
                statsOfAllTime = false;
            }
        }

        private void allTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allTimeRadioButton.Checked)
            {
                statsOfAllTime = true;
            }
        }
    }
}
