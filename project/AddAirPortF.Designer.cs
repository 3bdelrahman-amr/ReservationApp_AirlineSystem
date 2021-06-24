namespace project
{
    partial class AddAirPortF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAirPortF));
            this.NoOfPlanes = new System.Windows.Forms.TextBox();
            this.ACode = new System.Windows.Forms.TextBox();
            this.LCountry = new System.Windows.Forms.TextBox();
            this.AName = new System.Windows.Forms.TextBox();
            this.AddAirPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoOfPlanes
            // 
            this.NoOfPlanes.Location = new System.Drawing.Point(93, 40);
            this.NoOfPlanes.Name = "NoOfPlanes";
            this.NoOfPlanes.Size = new System.Drawing.Size(292, 22);
            this.NoOfPlanes.TabIndex = 0;
            // 
            // ACode
            // 
            this.ACode.Location = new System.Drawing.Point(383, 119);
            this.ACode.Name = "ACode";
            this.ACode.Size = new System.Drawing.Size(292, 22);
            this.ACode.TabIndex = 1;
            // 
            // LCountry
            // 
            this.LCountry.Location = new System.Drawing.Point(93, 226);
            this.LCountry.Name = "LCountry";
            this.LCountry.Size = new System.Drawing.Size(292, 22);
            this.LCountry.TabIndex = 2;
            // 
            // AName
            // 
            this.AName.Location = new System.Drawing.Point(383, 308);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(292, 22);
            this.AName.TabIndex = 3;
            // 
            // AddAirPort
            // 
            this.AddAirPort.BackColor = System.Drawing.Color.Green;
            this.AddAirPort.Location = new System.Drawing.Point(267, 392);
            this.AddAirPort.Name = "AddAirPort";
            this.AddAirPort.Size = new System.Drawing.Size(249, 37);
            this.AddAirPort.TabIndex = 4;
            this.AddAirPort.Text = "Add_AirPort";
            this.AddAirPort.UseVisualStyleBackColor = false;
            this.AddAirPort.Click += new System.EventHandler(this.AddAirPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NumberOfPlanes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "AirPortCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "LocationCountry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "AirPortName";
            // 
            // AddAirPortF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAirPort);
            this.Controls.Add(this.AName);
            this.Controls.Add(this.LCountry);
            this.Controls.Add(this.ACode);
            this.Controls.Add(this.NoOfPlanes);
            this.Name = "AddAirPortF";
            this.Text = "AirPortF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoOfPlanes;
        private System.Windows.Forms.TextBox ACode;
        private System.Windows.Forms.TextBox LCountry;
        private System.Windows.Forms.TextBox AName;
        private System.Windows.Forms.Button AddAirPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}