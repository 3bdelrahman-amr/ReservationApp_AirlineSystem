namespace project
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(529, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 284);
            this.dataGridView1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 73);
            this.button3.TabIndex = 21;
            this.button3.Text = "View Availabe flights";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "ClientID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Flightno";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Client ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Number of the flight";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(375, 78);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Enter The Class (A,B,C)/fare";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 68);
            this.button4.TabIndex = 28;
            this.button4.Text = "Add client to a flight";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 63);
            this.button1.TabIndex = 29;
            this.button1.Text = "DeleteClientFromFlight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        //    private employee_newDataSet employee_newDataSet;
        //    private System.Windows.Forms.BindingSource clientBindingSource;
        //    private employee_newDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        //    private employee_newDataSet1 employee_newDataSet1;
        //    private System.Windows.Forms.BindingSource flightBindingSource;
        //    private employee_newDataSet1TableAdapters.FlightTableAdapter flightTableAdapter;
        //    private Airline_ProjectDataSet airline_ProjectDataSet;
        //    private System.Windows.Forms.BindingSource clientBindingSource1;
        //    private Airline_ProjectDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        //    private Airline_ProjectDataSet1 airline_ProjectDataSet1;
        //    private System.Windows.Forms.BindingSource flightBindingSource1;
        //    private Airline_ProjectDataSet1TableAdapters.FlightTableAdapter flightTableAdapter1;
        //    private System.Windows.Forms.Button button5;
        //    private airline_NEWPROJECTDataSet airline_NEWPROJECTDataSet;
        //    private System.Windows.Forms.BindingSource clientBindingSource2;
        //    private airline_NEWPROJECTDataSetTableAdapters.ClientTableAdapter clientTableAdapter2;
        //    private airline_NEWPROJECTDataSet1 airline_NEWPROJECTDataSet1;
        //    private System.Windows.Forms.BindingSource flightBindingSource2;
        //    private airline_NEWPROJECTDataSet1TableAdapters.FlightTableAdapter flightTableAdapter2;
        //
    }
}

