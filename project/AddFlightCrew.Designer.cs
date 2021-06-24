namespace project
{
    partial class AddFlightCrew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlightCrew));
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.Flight_CrewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(88, 88);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(174, 22);
            this.FNameTxt.TabIndex = 0;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(542, 88);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(174, 22);
            this.LName.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(88, 180);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(174, 22);
            this.ID.TabIndex = 2;
            this.ID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(542, 180);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(174, 22);
            this.Password.TabIndex = 3;
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(140, 125);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(53, 17);
            this.FName.TabIndex = 4;
            this.FName.Text = "FName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "LName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(88, 306);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(174, 22);
            this.Address.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role";
            // 
            // Role
            // 
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Captain",
            "Attendant"});
            this.Role.Location = new System.Drawing.Point(542, 306);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(174, 24);
            this.Role.TabIndex = 12;
            // 
            // Flight_CrewButton
            // 
            this.Flight_CrewButton.BackColor = System.Drawing.Color.LimeGreen;
            this.Flight_CrewButton.Location = new System.Drawing.Point(310, 383);
            this.Flight_CrewButton.Name = "Flight_CrewButton";
            this.Flight_CrewButton.Size = new System.Drawing.Size(186, 37);
            this.Flight_CrewButton.TabIndex = 13;
            this.Flight_CrewButton.Text = "Add_Flight_Crew";
            this.Flight_CrewButton.UseVisualStyleBackColor = false;
            this.Flight_CrewButton.Click += new System.EventHandler(this.Flight_CrewButton_Click);
            // 
            // AddFlightCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Flight_CrewButton);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FNameTxt);
            this.Name = "AddFlightCrew";
            this.Text = "AddEmployeeF";
            this.Load += new System.EventHandler(this.AddEmployeeF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Button Flight_CrewButton;
    }
}