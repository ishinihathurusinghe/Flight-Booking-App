using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingProject
{
    public partial class BookingSummary : Form
    {
        public BookingSummary()
        {
            InitializeComponent();
        }

        private void BookingSummary_Load(object sender, EventArgs e)
        {
            lblFullName.Text = FlightBooking.fullName;
            lblDepart.Text = FlightBooking.departure;
            lblDest.Text = FlightBooking.destination;
            lblTrip.Text = FlightBooking.tripDates;
            lblPassNo.Text = FlightBooking.passportNo;
            lblPassExpiryDate.Text = FlightBooking.passExpiry.ToString();
            lblEstimate.Text = FlightBooking.estimateWeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FlightBooking obj = new FlightBooking();
            obj.Show();
        }
    }
}
