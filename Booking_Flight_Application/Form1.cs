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

        private void btn_search_Click(object sender, EventArgs e)
        {
            var trip = comboBox_trip.SelectedItem != null ? comboBox_trip.SelectedItem.ToString() : "";
            var flightClass = comboBox_economy.SelectedItem != null ? comboBox_economy.SelectedItem.ToString() : "";
            var departure = comboBox_departure.SelectedItem != null ? comboBox_departure.SelectedItem.ToString() : "";
            var destination = comboBox_destination.SelectedItem != null ? comboBox_destination.SelectedItem.ToString() : "";

            var startDate = dateTimePicker_start_date.Value.ToString();
            var endDate = dateTimePicker_end_date.Value.ToString();

            string filter = "";
            // Check if text fields are not null before adding to filter. 
            if (!string.IsNullOrEmpty(trip))
            {
                //Logic for trip
            }
            if (!string.IsNullOrEmpty(flightClass))
            {
                //Median Price of Flight
                var filterPrice = 250;
                if (flightClass == "First")
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "Price >= '" + filterPrice + "' ";
                }
                else if (flightClass == "Economy")
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "Price < '" + filterPrice + "' ";

                }


            }
            if (!string.IsNullOrEmpty(departure))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "Departure = '" + departure.Substring(departure.Length - 4, 3) + "'";
            }

            if (!string.IsNullOrEmpty(destination))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "Destination = '" + destination.Substring(destination.Length - 4, 3) + "'";
            }

            /*
            if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
            {
                var columnName = "Date & Time";
                if (filter.Length > 0) filter += "AND ";
                filter += columnName + "Between '%" + startDate + "%' AND '%" + endDate + "%'";
            }*/

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView_flights.DataSource;
            bs.Filter = filter;
            dataGridView_flights.DataSource = bs;
        }
    }
}
