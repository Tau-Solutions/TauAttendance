using System;
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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void buttonViewAttendance_Click(object sender, EventArgs e)
        {
            EventAttendanceForm attendanceForm = new EventAttendanceForm();
            attendanceForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            //this method should perform a query of the database to grab all events in the
            //Events table. The event title and dates will be loaded into their
            //own listBox
        }
    }
}
