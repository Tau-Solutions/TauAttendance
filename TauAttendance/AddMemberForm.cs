using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TauAttendance
{
    public partial class AddMemberForm : Form
    {
        RosterForm rf1;
        SQLiteConnection dbConnection;

        public AddMemberForm(RosterForm rf1)
        {
            //This Constructor takes RosterForm as a parameter to allow us to call the RefreshForm method in the RosterForm class
            //The RefreshForm() method clears the listbox and queries the data back into it so we can see the newly added member
            //after this form has been closed.

            this.rf1 = rf1;
            InitializeComponent();
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=TauAttendance.sqlite;Version=3;");
            dbConnection.Open();
            string insertQuery = "INSERT INTO Members(Name) VALUES (@param1)";
            SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, dbConnection);
            insertCommand.Parameters.Add(new SQLiteParameter("@param1", txtBoxMemberName.Text));

            try
            {
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("You did it!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            dbConnection.Close();

            btnSaveEvent.DialogResult = DialogResult.OK;
            rf1.RefreshForm();

            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
