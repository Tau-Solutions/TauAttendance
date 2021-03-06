﻿using System;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEventForm addForm = new AddEventForm();
            addForm.ShowDialog();
        }

        private void btnPastEvents_Click(object sender, EventArgs e)
        {
            EventsForm eventForm = new EventsForm();
            eventForm.ShowDialog();
        }

        private void btnViewRoster_Click(object sender, EventArgs e)
        {
            RosterForm rosterForm = new RosterForm();
            rosterForm.ShowDialog();
        }
    }
}
