namespace project
{
    partial class AdminF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminF));
            this.Flight = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FlightCrew = new System.Windows.Forms.Button();
            this.Plane = new System.Windows.Forms.Button();
            this.Ban = new System.Windows.Forms.Button();
            this.ModDelFlight = new System.Windows.Forms.Button();
            this.PlaneStatus = new System.Windows.Forms.Button();
            this.Review = new System.Windows.Forms.Button();
            this.Airport = new System.Windows.Forms.Button();
            this.ViewF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flight
            // 
            this.Flight.Location = new System.Drawing.Point(304, 12);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(156, 35);
            this.Flight.TabIndex = 0;
            this.Flight.Text = "Add_Flight";
            this.Flight.UseVisualStyleBackColor = true;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add_Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FlightCrew
            // 
            this.FlightCrew.Location = new System.Drawing.Point(555, 73);
            this.FlightCrew.Name = "FlightCrew";
            this.FlightCrew.Size = new System.Drawing.Size(156, 35);
            this.FlightCrew.TabIndex = 2;
            this.FlightCrew.Text = "Add_FlightCrew";
            this.FlightCrew.UseVisualStyleBackColor = true;
            this.FlightCrew.Click += new System.EventHandler(this.FlightCrew_Click);
            // 
            // Plane
            // 
            this.Plane.Location = new System.Drawing.Point(304, 143);
            this.Plane.Name = "Plane";
            this.Plane.Size = new System.Drawing.Size(156, 35);
            this.Plane.TabIndex = 3;
            this.Plane.Text = "Add_Plane";
            this.Plane.UseVisualStyleBackColor = true;
            this.Plane.Click += new System.EventHandler(this.Plane_Click);
            // 
            // Ban
            // 
            this.Ban.Location = new System.Drawing.Point(90, 220);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(156, 35);
            this.Ban.TabIndex = 4;
            this.Ban.Text = "Ban/Unban_Client";
            this.Ban.UseVisualStyleBackColor = true;
            this.Ban.Click += new System.EventHandler(this.Ban_Click);
            // 
            // ModDelFlight
            // 
            this.ModDelFlight.Location = new System.Drawing.Point(555, 220);
            this.ModDelFlight.Name = "ModDelFlight";
            this.ModDelFlight.Size = new System.Drawing.Size(156, 35);
            this.ModDelFlight.TabIndex = 5;
            this.ModDelFlight.Text = "Modify/Delete_Flight";
            this.ModDelFlight.UseVisualStyleBackColor = true;
            this.ModDelFlight.Click += new System.EventHandler(this.ModDelFlight_Click);
            // 
            // PlaneStatus
            // 
            this.PlaneStatus.Location = new System.Drawing.Point(304, 301);
            this.PlaneStatus.Name = "PlaneStatus";
            this.PlaneStatus.Size = new System.Drawing.Size(156, 35);
            this.PlaneStatus.TabIndex = 6;
            this.PlaneStatus.Text = "Update_Plane_Status";
            this.PlaneStatus.UseVisualStyleBackColor = true;
            this.PlaneStatus.Click += new System.EventHandler(this.PlaneStatus_Click);
            // 
            // Review
            // 
            this.Review.Location = new System.Drawing.Point(90, 367);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(156, 35);
            this.Review.TabIndex = 7;
            this.Review.Text = "View_Reviews";
            this.Review.UseVisualStyleBackColor = true;
            this.Review.Click += new System.EventHandler(this.Review_Click);
            // 
            // Airport
            // 
            this.Airport.Location = new System.Drawing.Point(555, 367);
            this.Airport.Name = "Airport";
            this.Airport.Size = new System.Drawing.Size(156, 35);
            this.Airport.TabIndex = 8;
            this.Airport.Text = "Add_Airport";
            this.Airport.UseVisualStyleBackColor = true;
            this.Airport.Click += new System.EventHandler(this.Airport_Click);
            // 
            // ViewF
            // 
            this.ViewF.Location = new System.Drawing.Point(304, 416);
            this.ViewF.Name = "ViewF";
            this.ViewF.Size = new System.Drawing.Size(156, 35);
            this.ViewF.TabIndex = 9;
            this.ViewF.Text = "ViewFlights";
            this.ViewF.UseVisualStyleBackColor = true;
            this.ViewF.Click += new System.EventHandler(this.ViewF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "ViewClients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewF);
            this.Controls.Add(this.Airport);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.PlaneStatus);
            this.Controls.Add(this.ModDelFlight);
            this.Controls.Add(this.Ban);
            this.Controls.Add(this.Plane);
            this.Controls.Add(this.FlightCrew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Flight);
            this.Name = "AdminF";
            this.Text = "AdminF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Flight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FlightCrew;
        private System.Windows.Forms.Button Plane;
        private System.Windows.Forms.Button Ban;
        private System.Windows.Forms.Button ModDelFlight;
        private System.Windows.Forms.Button PlaneStatus;
        private System.Windows.Forms.Button Review;
        private System.Windows.Forms.Button Airport;
        private System.Windows.Forms.Button ViewF;
        private System.Windows.Forms.Button button1;
    }
}