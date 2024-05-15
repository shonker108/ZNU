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
    public partial class FilterForm : Form
    {
        private AdminForm parentForm;
        public FilterForm(AdminForm parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();
        }

        private void clientFilterOkButton_Click(object sender, EventArgs e)
        {
            string name = clientNameInputBox.Text;
            string surname = clientSurnameInputBox.Text;

            parentForm.FilterClients(name, surname);
        }

        private void courierFilterOkButton_Click(object sender, EventArgs e)
        {
            string name = courierNameInputBox.Text;
            string surname = courierSurnameInputBox.Text;
            string transportNumber = transportNumberInputBox.Text;

            parentForm.FilterCouriers(name, surname, transportNumber);
        }

        private void parcelFilterOkButton_Click(object sender, EventArgs e)
        {
            DateTime acceptDateTime = acceptDateTimeBox.Value;
            DateTime sendingDateTime = sendingDateTimeBox.Value;
            DateTime arrivalDateTime = arrivalDateTimeBox.Value;

            parentForm.FilterParcels(acceptDateTime, sendingDateTime, arrivalDateTime);
        }
    }
}
