// Booking_Flight application purpose is to allow people to search certain destinations 
// (Minneapolis, Los Angeles, New York, Chicago and Miami), select a date and choose the 
// best airline option to book their flight as well as figure out which attraction to visit.

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
            this.flightsTableAdapter.Fill(this.bookingFlightDataSet.Flights);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will close the application.
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var flightClass = comboBox_economy.SelectedItem != null ? comboBox_economy.SelectedItem.ToString() : "";
            var departure = comboBox_departure.SelectedItem != null ? comboBox_departure.SelectedItem.ToString() : "";
            var destination = comboBox_destination.SelectedItem != null ? comboBox_destination.SelectedItem.ToString() : "";
             
            string date_time = dateTimePicker_start_date.Value.ToString();
            string date = date_time.Substring(0, 10);

            string filter = "";
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
            if (!string.IsNullOrEmpty(date))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "[Date & Time] = '" + date + "'";
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView_flights.DataSource;
            bs.Filter = filter;
            dataGridView_flights.DataSource = bs;
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            try
            {
                String airline = dataGridView_flights.CurrentRow.Cells[1].Value.ToString();
                String date = dataGridView_flights.CurrentRow.Cells[2].Value.ToString();
                String airline_id = dataGridView_flights.CurrentRow.Cells[3].Value.ToString();
                String departure = dataGridView_flights.CurrentRow.Cells[4].Value.ToString();
                String destination = dataGridView_flights.CurrentRow.Cells[5].Value.ToString();
                String price = dataGridView_flights.CurrentRow.Cells[6].Value.ToString();

                String message = "This is a confirmation that your flight has been booked. \n" +
                    "Your itinerary is: \n\n" +
                    " Airline: " + airline + "\n" +
                    " Date: " + date + "\n" +
                    " Airline ID: " + airline_id + "\n" +
                    " Departure: " + departure + " to " + destination + "\n" +
                    " Price: $" + price;

                MessageBox.Show(message);
            } catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message + " > Maybe you did not select a flight to book");
            }
        }

        // Things to do in each destination
        String[] msp_ttd = { "Mall of America", "Duluth", "Twin Cities" };
        String[] mia_ttd = { "Everglades", "Key West","Vizcaya Museum" };
        String[] lax_ttd = { "Hollywood Walk of Fame", "Santa Monica Pier", "Malibu Beach" };
        String[] jfk_ttd = { "NY Times Square", "Apollo Theater", "Empire State Building" };
        String[] ord_ttd = { "Cloud Gate", "Millennium Park", "Navy Pier" };

        private void btn_things_to_do_Click(object sender, EventArgs e)
        {
            String destination = dataGridView_flights.CurrentRow.Cells[5].Value.ToString();
            String message = "Welcome to " + destination + "!\n" + "Don't forget to visit ";

            if (destination == "MSP") message = message + rand_item_array(msp_ttd);
            else if (destination == "MIA") message = message + rand_item_array(mia_ttd);
            else if (destination == "LAX") message = message + rand_item_array(lax_ttd);
            else if (destination == "JFK") message = message + rand_item_array(jfk_ttd);
            else if (destination == "ORD") message = message + rand_item_array(ord_ttd);

            MessageBox.Show(message);
        }

        private String rand_item_array(String[] arr) 
        {
            int index = new Random().Next(0, arr.Length);
            return arr[index];
        }
    }
}
