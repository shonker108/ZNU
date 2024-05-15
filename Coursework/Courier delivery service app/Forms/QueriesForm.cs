using Courier_delivery_service_app.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_delivery_service_app.Forms
{
    public partial class QueriesForm : Form
    {
        public QueriesForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string query = queryInputBox.Text;

            RunQuery(query);
        }

        private void RunQuery(string query)
        {
            DatabaseAPI.Connect();

            try
            {
                query = query.Trim();

                query = query.Replace('"', '\'');

                string targetWord = "select";
                bool returnsValues = query.Substring(0, targetWord.Length).ToLower() == targetWord;

                

                SqlCommand command = new SqlCommand(query, DatabaseAPI.connection);

                if (!returnsValues)
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    statusStripLabel.Text = $"Останнє повідомлення (UTC: {DateTime.UtcNow}): Задіяно {rowsAffected} рядків.";
                }
                else
                {
                    ClearResultTable();

                    queryResultTable.SuspendLayout();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int rowCounter = 0;
                        int columnCount = reader.FieldCount;

                        queryResultTable.ColumnCount = columnCount;

                        for (int i = 0; i < columnCount; i++)
                        {
                            Label columnName = new Label();
                            columnName.Dock = DockStyle.Fill;
                            columnName.Text = reader.GetName(i);

                            queryResultTable.Controls.Add(columnName, i, rowCounter);
                        }

                        rowCounter++;

                        while (reader.Read())
                        {
                            for (int i = 0; i < columnCount; i++)
                            {
                                Label valueLabel = new Label();
                                valueLabel.Dock = DockStyle.Fill;
                                valueLabel.Text = reader[i].ToString();

                                queryResultTable.Controls.Add(valueLabel, i, rowCounter);
                            }

                            rowCounter++;
                        }
                    }

                    queryResultTable.ResumeLayout(true);
                }
            }
            catch (Exception ex)
            {
                statusStripLabel.Text = $"Останнє повідомлення (UTC: {DateTime.UtcNow}): {ex.Message}";
            }
            finally
            {
                DatabaseAPI.CloseConnection();
            }
        }

        private void ClearResultTable()
        {
            for (int i = queryResultTable.Controls.Count - 1; i >= 0; i--)
            {
                queryResultTable.Controls[i].Dispose();
            }

            queryResultTable.Controls.Clear();
            queryResultTable.RowCount = 0;
        }
    }
}
