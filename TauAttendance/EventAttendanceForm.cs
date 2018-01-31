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
            //example of inserting at a certain index:     myListBox.Items.Insert(0, "First");

            /* First thing we must do in this method is query the Attendance table and check for any records that match the Event_ID we pass into this form.
             * If no records are returned from this query, then we just have to load the Roster into listBoxNames. 
             * If there are records returned from the query, then we must load the member name and the value in the Attended field.
             * The above example is a way that we can insert the matching Attended value next to the member name.
             */ 

            dbConnection = new SQLiteConnection("Data Source=TauAttendance.sqlite;Version=3;");
            dbConnection.Open();
            string attendanceQuery = "SELECT Member_name, Attended FROM Attendance WHERE event_id = @param1 ORDER BY Member_name";
            string rosterQuery = "SELECT Mem_ID, Name FROM Members ORDER BY Name";

            SQLiteCommand command = new SQLiteCommand(attendanceQuery, dbConnection);
            command.Parameters.Add(new SQLiteParameter("@param1", selectedEvent));
            SQLiteDataReader reader = command.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBoxNames.Items.Add(reader["Member_name"]);
                    listBoxAttended.Items.Add(reader["Attended"]);
                }
               
            }
            else
            {
                SQLiteCommand command2 = new SQLiteCommand(rosterQuery, dbConnection);
                SQLiteDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    listBoxNames.Items.Add(reader2["Name"]);
                }
                
            }
            
            //TODO: Add mock data to attendance table and test first query.
            //TODO: Make the check boxes and selected Names change the attended list box

            dbConnection.Close();
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
