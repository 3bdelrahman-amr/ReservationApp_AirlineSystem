namespace project
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.FName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.WeeklyHours = new System.Windows.Forms.TextBox();
            this.AddEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(70, 63);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(198, 22);
            this.FName.TabIndex = 0;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(541, 63);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(198, 22);
            this.LName.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(70, 180);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(198, 22);
            this.ID.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(541, 180);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(198, 22);
            this.Password.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(70, 307);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(198, 22);
            this.Address.TabIndex = 4;
            // 
            // WeeklyHours
            // 
            this.WeeklyHours.Location = new System.Drawing.Point(541, 307);
            this.WeeklyHours.Name = "WeeklyHours";
            this.WeeklyHours.Size = new System.Drawing.Size(198, 22);
            this.WeeklyHours.TabIndex = 5;
            // 
            // AddEmp
            // 
            this.AddEmp.BackColor = System.Drawing.Color.SeaGreen;
            this.AddEmp.Location = new System.Drawing.Point(297, 369);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(198, 44);
            this.AddEmp.TabIndex = 6;
            this.AddEmp.Text = "Add_Employee";
            this.AddEmp.UseVisualStyleBackColor = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "FName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "LName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "WeeklyHours";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEmp);
            this.Controls.Add(this.WeeklyHours);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FName);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox WeeklyHours;
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}