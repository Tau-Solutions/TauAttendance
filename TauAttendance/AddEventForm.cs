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
    //comment
    public partial class AddEventForm : Form
    {
        SQLiteConnection dbConnection;
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateString = dateTimePickerEvent.Value.ToString("yyyy-MM-dd hh:mm:ss");
            //This method will take the data inserted into the Text Box and Date Picker
            //and build a query to insert the event into the database. We should have input 
            //checking to disallow blank or illegal characters. Prevent SQL injection
            dbConnection = new SQLiteConnection("Data Source=TauAttendance.sqlite;Version=3;");
            dbConnection.Open();
            string insertQuery = "INSERT INTO Events(Title, Date, Mandatory) VALUES (@param1,@param2,@param3)";
            SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, dbConnection);
            insertCommand.Parameters.Add(new SQLiteParameter("@param1", txtBoxEventTitle.Text));
            insertCommand.Parameters.Add(new SQLiteParameter("@param2",dateString));

            if(checkBoxMandatory.Checked == true)
            {
                insertCommand.Parameters.Add(new SQLiteParameter("@param3",1));
            }
            else
            {
                insertCommand.Parameters.Add(new SQLiteParameter("@param3", 0));
            }

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
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEventTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
