namespace Booking_Flight_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_trip = new System.Windows.Forms.Label();
            this.comboBox_trip = new System.Windows.Forms.ComboBox();
            this.comboBox_economy = new System.Windows.Forms.ComboBox();
            this.lbl_departure = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.comboBox_departure = new System.Windows.Forms.ComboBox();
            this.comboBox_destination = new System.Windows.Forms.ComboBox();
            this.dataGridView_flights = new System.Windows.Forms.DataGridView();
            this.Column1_airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_departing_flights = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dateTimePicker_start_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.dateTimePicker_end_date = new System.Windows.Forms.DateTimePicker();
            this.btn_things_to_do = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_class = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_trip
            // 
            this.lbl_trip.AutoSize = true;
            this.lbl_trip.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trip.Location = new System.Drawing.Point(24, 33);
            this.lbl_trip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trip.Name = "lbl_trip";
            this.lbl_trip.Size = new System.Drawing.Size(50, 22);
            this.lbl_trip.TabIndex = 0;
            this.lbl_trip.Text = "Trip";
            // 
            // comboBox_trip
            // 
            this.comboBox_trip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_trip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trip.FormattingEnabled = true;
            this.comboBox_trip.Items.AddRange(new object[] {
            "One way",
            "Round trip"});
            this.comboBox_trip.Location = new System.Drawing.Point(131, 33);
            this.comboBox_trip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_trip.Name = "comboBox_trip";
            this.comboBox_trip.Size = new System.Drawing.Size(160, 24);
            this.comboBox_trip.TabIndex = 1;
            this.comboBox_trip.UseWaitCursor = true;
            // 
            // comboBox_economy
            // 
            this.comboBox_economy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_economy.FormattingEnabled = true;
            this.comboBox_economy.Items.AddRange(new object[] {
            "Economy",
            "First"});
            this.comboBox_economy.Location = new System.Drawing.Point(499, 31);
            this.comboBox_economy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_economy.Name = "comboBox_economy";
            this.comboBox_economy.Size = new System.Drawing.Size(160, 24);
            this.comboBox_economy.TabIndex = 2;
            // 
            // lbl_departure
            // 
            this.lbl_departure.AutoSize = true;
            this.lbl_departure.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departure.Location = new System.Drawing.Point(24, 87);
            this.lbl_departure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_departure.Name = "lbl_departure";
            this.lbl_departure.Size = new System.Drawing.Size(101, 22);
            this.lbl_departure.TabIndex = 3;
            this.lbl_departure.Text = "Departure";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destination.Location = new System.Drawing.Point(369, 87);
            this.lbl_destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(111, 22);
            this.lbl_destination.TabIndex = 4;
            this.lbl_destination.Text = "Destination";
            // 
            // comboBox_departure
            // 
            this.comboBox_departure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_departure.FormattingEnabled = true;
            this.comboBox_departure.Items.AddRange(new object[] {
            "",
            "Minneapolis (MSP)",
            "Los Angeles (LAX)",
            "New York (JFK)",
            "Miami (MIA)",
            "Chicago (ORD)"});
            this.comboBox_departure.Location = new System.Drawing.Point(131, 84);
            this.comboBox_departure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_departure.Name = "comboBox_departure";
            this.comboBox_departure.Size = new System.Drawing.Size(160, 24);
            this.comboBox_departure.TabIndex = 5;
            // 
            // comboBox_destination
            // 
            this.comboBox_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_destination.FormattingEnabled = true;
            this.comboBox_destination.Items.AddRange(new object[] {
            "",
            "Minneapolis (MSP)",
            "Los Angeles (LAX)",
            "New York (JFK)",
            "Miami (MIA)",
            "Chicago (ORD)"});
            this.comboBox_destination.Location = new System.Drawing.Point(499, 86);
            this.comboBox_destination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_destination.Name = "comboBox_destination";
            this.comboBox_destination.Size = new System.Drawing.Size(160, 24);
            this.comboBox_destination.TabIndex = 6;
            // 
            // dataGridView_flights
            // 
            this.dataGridView_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_airline,
            this.Column2_,
            this.Column3_Price});
            this.dataGridView_flights.Location = new System.Drawing.Point(28, 293);
            this.dataGridView_flights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_flights.Name = "dataGridView_flights";
            this.dataGridView_flights.RowHeadersWidth = 51;
            this.dataGridView_flights.Size = new System.Drawing.Size(632, 185);
            this.dataGridView_flights.TabIndex = 7;
            // 
            // Column1_airline
            // 
            this.Column1_airline.HeaderText = "Airline";
            this.Column1_airline.MinimumWidth = 6;
            this.Column1_airline.Name = "Column1_airline";
            this.Column1_airline.Width = 150;
            // 
            // Column2_
            // 
            this.Column2_.HeaderText = "Time";
            this.Column2_.MinimumWidth = 6;
            this.Column2_.Name = "Column2_";
            this.Column2_.Width = 150;
            // 
            // Column3_Price
            // 
            this.Column3_Price.HeaderText = "Price";
            this.Column3_Price.MinimumWidth = 6;
            this.Column3_Price.Name = "Column3_Price";
            this.Column3_Price.Width = 150;
            // 
            // lbl_departing_flights
            // 
            this.lbl_departing_flights.AutoSize = true;
            this.lbl_departing_flights.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departing_flights.Location = new System.Drawing.Point(23, 247);
            this.lbl_departing_flights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_departing_flights.Name = "lbl_departing_flights";
            this.lbl_departing_flights.Size = new System.Drawing.Size(278, 32);
            this.lbl_departing_flights.TabIndex = 8;
            this.lbl_departing_flights.Text = "Departing Flights";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_search.Location = new System.Drawing.Point(499, 135);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(161, 34);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker_start_date
            // 
            this.dateTimePicker_start_date.Location = new System.Drawing.Point(131, 143);
            this.dateTimePicker_start_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_start_date.Name = "dateTimePicker_start_date";
            this.dateTimePicker_start_date.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_start_date.TabIndex = 10;
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start_date.Location = new System.Drawing.Point(24, 149);
            this.lbl_start_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(101, 22);
            this.lbl_start_date.TabIndex = 11;
            this.lbl_start_date.Text = "Start Date";
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_book.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.Transparent;
            this.btn_book.Location = new System.Drawing.Point(28, 503);
            this.btn_book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(161, 34);
            this.btn_book.TabIndex = 12;
            this.btn_book.Text = "Book Flight";
            this.btn_book.UseVisualStyleBackColor = false;
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end_date.Location = new System.Drawing.Point(24, 185);
            this.lbl_end_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(93, 22);
            this.lbl_end_date.TabIndex = 13;
            this.lbl_end_date.Text = "End Date";
            // 
            // dateTimePicker_end_date
            // 
            this.dateTimePicker_end_date.Location = new System.Drawing.Point(131, 185);
            this.dateTimePicker_end_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            this.dateTimePicker_end_date.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_end_date.TabIndex = 14;
            // 
            // btn_things_to_do
            // 
            this.btn_things_to_do.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_things_to_do.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_things_to_do.ForeColor = System.Drawing.Color.Transparent;
            this.btn_things_to_do.Location = new System.Drawing.Point(265, 503);
            this.btn_things_to_do.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_things_to_do.Name = "btn_things_to_do";
            this.btn_things_to_do.Size = new System.Drawing.Size(161, 34);
            this.btn_things_to_do.TabIndex = 15;
            this.btn_things_to_do.Text = "Things to do";
            this.btn_things_to_do.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(499, 503);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(161, 34);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 185);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(369, 38);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(111, 22);
            this.lbl_class.TabIndex = 18;
            this.lbl_class.Text = "Flight Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 569);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_things_to_do);
            this.Controls.Add(this.dateTimePicker_end_date);
            this.Controls.Add(this.lbl_end_date);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.lbl_start_date);
            this.Controls.Add(this.dateTimePicker_start_date);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_departing_flights);
            this.Controls.Add(this.dataGridView_flights);
            this.Controls.Add(this.comboBox_destination);
            this.Controls.Add(this.comboBox_departure);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.lbl_departure);
            this.Controls.Add(this.comboBox_economy);
            this.Controls.Add(this.comboBox_trip);
            this.Controls.Add(this.lbl_trip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Booking Flight System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_trip;
        private System.Windows.Forms.ComboBox comboBox_trip;
        private System.Windows.Forms.ComboBox comboBox_economy;
        private System.Windows.Forms.Label lbl_departure;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.ComboBox comboBox_departure;
        private System.Windows.Forms.ComboBox comboBox_destination;
        private System.Windows.Forms.DataGridView dataGridView_flights;
        private System.Windows.Forms.Label lbl_departing_flights;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start_date;
        private System.Windows.Forms.Label lbl_start_date;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_airline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_Price;
        private System.Windows.Forms.Button btn_things_to_do;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_class;
    }
}

