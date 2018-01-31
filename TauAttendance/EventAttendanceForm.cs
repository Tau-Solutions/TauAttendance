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
    public partial class EventAttendanceForm : Form
    {
        string selectedEvent;
        SQLiteConnection dbConnection;

        public EventAttendanceForm(string input)
        {
            InitializeComponent();
            selectedEvent = input;
        }

        private void EventAttendanceForm_Load(object sender, EventArgs e)
        {
            //dbConnection = new SQLiteConnection("Data Source=TauAttendance.sqlite;Version=3;");
            //dbConnection.Open();
            //string eventQuery = "SELECT title, date FROM Events ORDER BY Date";

            //SQLiteCommand command = new SQLiteCommand(eventQuery, dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    listBoxNames.Items.Add(reader["Title"]);
            //    listBoxAttended.Items.Add(reader["Date"]);
            //}

            //dbConnection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this method will perform an update statement to the database.
            //If a value is changed in attendance, then we will update the Attended field
            //for the name in the Attendance Table.
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
