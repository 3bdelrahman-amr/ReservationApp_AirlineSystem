namespace project
{
    partial class UpdatePlaneStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePlaneStatus));
            this.PlaneSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.planeView = new System.Windows.Forms.DataGridView();
            this.PlaneStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetPlaneBySerial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planeView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaneSerial
            // 
            this.PlaneSerial.Location = new System.Drawing.Point(48, 63);
            this.PlaneSerial.Name = "PlaneSerial";
            this.PlaneSerial.Size = new System.Drawing.Size(191, 22);
            this.PlaneSerial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plane_SerialNumber";
            // 
            // planeView
            // 
            this.planeView.AllowUserToAddRows = false;
            this.planeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planeView.Location = new System.Drawing.Point(75, 242);
            this.planeView.Name = "planeView";
            this.planeView.ReadOnly = true;
            this.planeView.RowHeadersWidth = 51;
            this.planeView.RowTemplate.Height = 24;
            this.planeView.Size = new System.Drawing.Size(629, 100);
            this.planeView.TabIndex = 2;
            // 
            // PlaneStatus
            // 
            this.PlaneStatus.FormattingEnabled = true;
            this.PlaneStatus.Items.AddRange(new object[] {
            "Pending",
            "Done"});
            this.PlaneStatus.Location = new System.Drawing.Point(545, 61);
            this.PlaneStatus.Name = "PlaneStatus";
            this.PlaneStatus.Size = new System.Drawing.Size(184, 24);
            this.PlaneStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set_Status";
            // 
            // GetPlaneBySerial
            // 
            this.GetPlaneBySerial.BackColor = System.Drawing.Color.SeaGreen;
            this.GetPlaneBySerial.Location = new System.Drawing.Point(75, 160);
            this.GetPlaneBySerial.Name = "GetPlaneBySerial";
            this.GetPlaneBySerial.Size = new System.Drawing.Size(135, 37);
            this.GetPlaneBySerial.TabIndex = 5;
            this.GetPlaneBySerial.Text = "GetPlaneBySerialNumber";
            this.GetPlaneBySerial.UseVisualStyleBackColor = false;
            this.GetPlaneBySerial.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(569, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "UpdateStatus";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdatePlaneStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GetPlaneBySerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaneStatus);
            this.Controls.Add(this.planeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaneSerial);
            this.Name = "UpdatePlaneStatus";
            this.Text = "UpdatePlaneStatus";
            ((System.ComponentModel.ISupportInitialize)(this.planeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaneSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView planeView;
        private System.Windows.Forms.ComboBox PlaneStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetPlaneBySerial;
        private System.Windows.Forms.Button button2;
    }
}