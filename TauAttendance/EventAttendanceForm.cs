﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TauAttendance
{
    public partial class EventAttendanceForm : Form
    {
        public EventAttendanceForm()
        {
            InitializeComponent();
        }

        private void EventAttendanceForm_Load(object sender, EventArgs e)
        {
           
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
