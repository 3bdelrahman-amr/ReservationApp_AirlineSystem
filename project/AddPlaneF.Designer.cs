namespace project
{
    partial class AddPlaneF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlaneF));
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.SNumberTxt = new System.Windows.Forms.TextBox();
            this.ECap = new System.Windows.Forms.TextBox();
            this.SNumber = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.AddPlaneBtn = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.FCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(245, 80);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(253, 22);
            this.ModelTxt.TabIndex = 0;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(643, 83);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(46, 17);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // SNumberTxt
            // 
            this.SNumberTxt.Location = new System.Drawing.Point(245, 148);
            this.SNumberTxt.Name = "SNumberTxt";
            this.SNumberTxt.Size = new System.Drawing.Size(253, 22);
            this.SNumberTxt.TabIndex = 2;
            // 
            // ECap
            // 
            this.ECap.Location = new System.Drawing.Point(245, 238);
            this.ECap.Name = "ECap";
            this.ECap.Size = new System.Drawing.Size(253, 22);
            this.ECap.TabIndex = 3;
            this.ECap.TextChanged += new System.EventHandler(this.CapacityTxt_TextChanged);
            // 
            // SNumber
            // 
            this.SNumber.AutoSize = true;
            this.SNumber.Location = new System.Drawing.Point(634, 153);
            this.SNumber.Name = "SNumber";
            this.SNumber.Size = new System.Drawing.Size(94, 17);
            this.SNumber.TabIndex = 5;
            this.SNumber.Text = "SerialNumber";
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(634, 243);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(125, 17);
            this.Capacity.TabIndex = 6;
            this.Capacity.Text = "EconomyClassCap";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(643, 296);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(48, 17);
            this.Status.TabIndex = 7;
            this.Status.Text = "Status";
            // 
            // AddPlaneBtn
            // 
            this.AddPlaneBtn.BackColor = System.Drawing.Color.Green;
            this.AddPlaneBtn.Location = new System.Drawing.Point(561, 374);
            this.AddPlaneBtn.Name = "AddPlaneBtn";
            this.AddPlaneBtn.Size = new System.Drawing.Size(227, 34);
            this.AddPlaneBtn.TabIndex = 8;
            this.AddPlaneBtn.Text = "AddPlane";
            this.AddPlaneBtn.UseVisualStyleBackColor = false;
            this.AddPlaneBtn.Click += new System.EventHandler(this.AddPlaneBtn_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(245, 289);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(253, 24);
            this.StatusBox.TabIndex = 10;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // FCap
            // 
            this.FCap.Location = new System.Drawing.Point(245, 187);
            this.FCap.Name = "FCap";
            this.FCap.Size = new System.Drawing.Size(253, 22);
            this.FCap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "FirstClassCap";
            // 
            // AddPlaneF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FCap);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.AddPlaneBtn);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.SNumber);
            this.Controls.Add(this.ECap);
            this.Controls.Add(this.SNumberTxt);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.ModelTxt);
            this.Name = "AddPlaneF";
            this.Text = "AddPlaneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.TextBox SNumberTxt;
        private System.Windows.Forms.TextBox ECap;
        private System.Windows.Forms.Label SNumber;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button AddPlaneBtn;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.TextBox FCap;
        private System.Windows.Forms.Label label1;
    }
}

