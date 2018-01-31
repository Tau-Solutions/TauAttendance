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
    public partial class EventsForm : Form
    {
        SQLiteConnection dbConnection;
        Dictionary<object, object> events = new Dictionary<object, object>();

        public EventsForm()
        {
            InitializeComponent();
        }

        public String ListBoxValue
        {
            get
            {
                return this.listBoxEvents.SelectedItem.ToString();
            }
        }

        private void buttonViewAttendance_Click(object sender, EventArgs e)
        {
            EventAttendanceForm attendanceForm = new EventAttendanceForm(listBoxEvents.SelectedValue.ToString());
            attendanceForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            
            dbConnection = new SQLiteConnection("Data Source=TauAttendance.sqlite;Version=3;");
            dbConnection.Open();
            string eventQuery = "SELECT event_id, title, date FROM Events ORDER BY Date";

            SQLiteCommand command = new SQLiteCommand(eventQuery, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                events.Add(reader["Event_ID"], reader["Title"]);
                listBoxEvents.DataSource = new BindingSource(events, null);
                listBoxEvents.DisplayMember = "Value";
                listBoxEvents.ValueMember = "Key";
                listBox1.Items.Add(reader["Date"]);
                //listBoxEvents.Items.Add(reader["Title"]);
                //listBox1.Items.Add(reader["Date"]);
            }

            dbConnection.Close();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = listBoxEvents.SelectedValue.ToString();
        }
    }
}
