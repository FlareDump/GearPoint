using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Admin : Form
    {
        private DatabaseHandler dbHandler = new DatabaseHandler();

        public Admin()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StartingPoint start = new StartingPoint();
            start.Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Load data into the CartListGrid1
            LoadHistoryData();

            // Create a Button Column for Deletion
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Action";  // Header for the delete button column
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            if (!CartListGrid1.Columns.Contains("DeleteButton"))
            {
                CartListGrid1.Columns.Add(deleteButtonColumn);
            }

            // Set column widths
            CartListGrid1.Columns[0].Width = 125;// Item column
            CartListGrid1.Columns[1].Width = 55; // Gender column
            CartListGrid1.Columns[2].Width = 45; // Size column
            CartListGrid1.Columns[3].Width = 50; // Quantity column
            CartListGrid1.Columns[4].Width = 60; // Price column
            CartListGrid1.Columns[5].Width = 60; // Reference Column
            CartListGrid1.Columns[6].Width = 60; // Delete Button

        }

        private void LoadHistoryData()
        {
            DataTable historyData = dbHandler.GetHistory();
            CartListGrid1.DataSource = historyData;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Confirm deletion of all records
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all history entries?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Call the database handler to delete all rows
                if (dbHandler.DeleteAllHistory())
                {
                    MessageBox.Show("All history entries deleted successfully!");
                    LoadHistoryData(); // Refresh the grid to show no records
                }
                else
                {
                    MessageBox.Show("Failed to delete all history entries.");
                }
            }
        }


        private void CartListGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the delete button column
            if (e.ColumnIndex == CartListGrid1.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // Retrieve the Reference value from the selected row
                string reference = CartListGrid1.Rows[e.RowIndex].Cells["Reference"].Value.ToString();

                // Ask the user for confirmation before deleting
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the entry with Reference {reference}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Delete the history entry from the database
                    if (dbHandler.DeleteHistory(reference))
                    {
                        MessageBox.Show("History entry deleted successfully!");
                        LoadHistoryData(); // Refresh the grid after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete history entry.");
                    }
                }
            }
        }

    }
}
