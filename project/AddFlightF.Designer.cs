namespace project
{
    partial class AddFlightF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlightF));
            this.FlightNumbTxt = new System.Windows.Forms.TextBox();
            this.NoOfPassTxt = new System.Windows.Forms.TextBox();
            this.ArrivalCodeTxt = new System.Windows.Forms.TextBox();
            this.DepartureTxt = new System.Windows.Forms.TextBox();
            this.StuffNumbTxt = new System.Windows.Forms.TextBox();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FlightNumbTxt
            // 
            this.FlightNumbTxt.Location = new System.Drawing.Point(12, 106);
            this.FlightNumbTxt.Name = "FlightNumbTxt";
            this.FlightNumbTxt.Size = new System.Drawing.Size(216, 22);
            this.FlightNumbTxt.TabIndex = 0;
            // 
            // NoOfPassTxt
            // 
            this.NoOfPassTxt.Location = new System.Drawing.Point(586, 106);
            this.NoOfPassTxt.Name = "NoOfPassTxt";
            this.NoOfPassTxt.Size = new System.Drawing.Size(215, 22);
            this.NoOfPassTxt.TabIndex = 1;
            // 
            // ArrivalCodeTxt
            // 
            this.ArrivalCodeTxt.Location = new System.Drawing.Point(43, 245);
            this.ArrivalCodeTxt.Name = "ArrivalCodeTxt";
            this.ArrivalCodeTxt.Size = new System.Drawing.Size(216, 22);
            this.ArrivalCodeTxt.TabIndex = 2;
            // 
            // DepartureTxt
            // 
            this.DepartureTxt.Location = new System.Drawing.Point(563, 245);
            this.DepartureTxt.Name = "DepartureTxt";
            this.DepartureTxt.Size = new System.Drawing.Size(216, 22);
            this.DepartureTxt.TabIndex = 3;
            // 
            // StuffNumbTxt
            // 
            this.StuffNumbTxt.Location = new System.Drawing.Point(307, 344);
            this.StuffNumbTxt.Name = "StuffNumbTxt";
            this.StuffNumbTxt.Size = new System.Drawing.Size(216, 22);
            this.StuffNumbTxt.TabIndex = 4;
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.BackColor = System.Drawing.Color.Green;
            this.AddFlightButton.Location = new System.Drawing.Point(287, 151);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(236, 51);
            this.AddFlightButton.TabIndex = 6;
            this.AddFlightButton.Text = "AddFlight";
            this.AddFlightButton.UseVisualStyleBackColor = false;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "FlightNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "NoOfPassenger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Arrival_Airport_Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "FlightStatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "StuffNumber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Departure_Airport_code";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Pending",
            "Done"});
            this.StatusBox.Location = new System.Drawing.Point(307, 12);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(216, 24);
            this.StatusBox.TabIndex = 15;
            // 
            // AddFlightF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.StuffNumbTxt);
            this.Controls.Add(this.DepartureTxt);
            this.Controls.Add(this.ArrivalCodeTxt);
            this.Controls.Add(this.NoOfPassTxt);
            this.Controls.Add(this.FlightNumbTxt);
            this.Name = "AddFlightF";
            this.Text = "AddFlightF";
            this.Load += new System.EventHandler(this.AddFlightF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FlightNumbTxt;
        private System.Windows.Forms.TextBox NoOfPassTxt;
        private System.Windows.Forms.TextBox ArrivalCodeTxt;
        private System.Windows.Forms.TextBox DepartureTxt;
        private System.Windows.Forms.TextBox StuffNumbTxt;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StatusBox;
    }
}