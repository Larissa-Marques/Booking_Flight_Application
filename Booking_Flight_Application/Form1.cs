// Booking_Flight application purpose is to allow people to search certain destinations 
// (Minneapolis, Los Angeles, New York, Chicago and Miami), select a date and choose the 
// best airline option to book their flight.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_Flight_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingFlightDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.bookingFlightDataSet.Flights);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
