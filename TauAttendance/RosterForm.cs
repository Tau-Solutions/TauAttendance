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
    public partial class RosterForm : Form
    {
        SQLiteConnection dbConnection;

        public RosterForm()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemForm = new AddMemberForm();
            addMemForm.ShowDialog();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAttendance_Click(object sender, EventArgs e)
        {
            MemberAttendanceForm memAttendanceForm = new MemberAttendanceForm();
            memAttendanceForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RosterForm_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=TauAttendance.sqlite;Version=3;");
            dbConnection.Open();
            string memberQuery = "SELECT * FROM Members ORDER BY Name";

            SQLiteCommand command = new SQLiteCommand(memberQuery, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBoxNames.Items.Add(reader["Name"]);
            }

            dbConnection.Close();
        }
    }
}
