namespace project
{
    partial class Modify_Delet_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify_Delet_flight));
            this.FlightNumb = new System.Windows.Forms.TextBox();
            this.flghtnumb = new System.Windows.Forms.Label();
            this.FlightView = new System.Windows.Forms.DataGridView();
            this.ModValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ModifyBox = new System.Windows.Forms.ComboBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightView)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightNumb
            // 
            this.FlightNumb.Location = new System.Drawing.Point(51, 48);
            this.FlightNumb.Name = "FlightNumb";
            this.FlightNumb.Size = new System.Drawing.Size(189, 22);
            this.FlightNumb.TabIndex = 0;
            // 
            // flghtnumb
            // 
            this.flghtnumb.AutoSize = true;
            this.flghtnumb.Location = new System.Drawing.Point(101, 87);
            this.flghtnumb.Name = "flghtnumb";
            this.flghtnumb.Size = new System.Drawing.Size(92, 17);
            this.flghtnumb.TabIndex = 1;
            this.flghtnumb.Text = "FlightNumber";
            // 
            // FlightView
            // 
            this.FlightView.AllowUserToAddRows = false;
            this.FlightView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightView.Location = new System.Drawing.Point(12, 273);
            this.FlightView.Name = "FlightView";
            this.FlightView.ReadOnly = true;
            this.FlightView.RowHeadersWidth = 51;
            this.FlightView.RowTemplate.Height = 24;
            this.FlightView.Size = new System.Drawing.Size(776, 114);
            this.FlightView.TabIndex = 2;
            // 
            // ModValue
            // 
            this.ModValue.Location = new System.Drawing.Point(546, 48);
            this.ModValue.Name = "ModValue";
            this.ModValue.Size = new System.Drawing.Size(186, 22);
            this.ModValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ValueToBeModified";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(282, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select A Column To Modify It";
            // 
            // ModifyBut
            // 
            this.ModifyBut.BackColor = System.Drawing.Color.LimeGreen;
            this.ModifyBut.Location = new System.Drawing.Point(133, 148);
            this.ModifyBut.Name = "ModifyBut";
            this.ModifyBut.Size = new System.Drawing.Size(158, 50);
            this.ModifyBut.TabIndex = 6;
            this.ModifyBut.Text = "Modify";
            this.ModifyBut.UseVisualStyleBackColor = false;
            this.ModifyBut.Click += new System.EventHandler(this.ModifyBut_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(457, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(285, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "SelectFlight";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyBox
            // 
            this.ModifyBox.FormattingEnabled = true;
            this.ModifyBox.Items.AddRange(new object[] {
            "PassengerNo",
            "DestCode",
            "SourceCode",
            "FlightStatus",
            "NoStuff"});
            this.ModifyBox.Location = new System.Drawing.Point(314, 12);
            this.ModifyBox.Name = "ModifyBox";
            this.ModifyBox.Size = new System.Drawing.Size(121, 24);
            this.ModifyBox.TabIndex = 9;
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "OnLand",
            "OnAir"});
            this.StatusBox.Location = new System.Drawing.Point(314, 170);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 24);
            this.StatusBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(328, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Status\r\n";
            // 
            // Modify_Delet_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.ModifyBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ModifyBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModValue);
            this.Controls.Add(this.FlightView);
            this.Controls.Add(this.flghtnumb);
            this.Controls.Add(this.FlightNumb);
            this.Name = "Modify_Delet_flight";
            this.Text = "Modify_Delet_flight";
            ((System.ComponentModel.ISupportInitialize)(this.FlightView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FlightNumb;
        private System.Windows.Forms.Label flghtnumb;
        private System.Windows.Forms.DataGridView FlightView;
        private System.Windows.Forms.TextBox ModValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModifyBut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ModifyBox;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label label3;
    }
}