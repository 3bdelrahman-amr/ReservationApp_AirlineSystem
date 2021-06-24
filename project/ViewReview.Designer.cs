namespace project
{
    partial class ViewReview
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
            this.components = new System.ComponentModel.Container();
            this.FlightId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FlightBut = new System.Windows.Forms.Button();
            this.FlightReview = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FlightReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightId
            // 
            this.FlightId.Location = new System.Drawing.Point(265, 49);
            this.FlightId.Name = "FlightId";
            this.FlightId.Size = new System.Drawing.Size(254, 22);
            this.FlightId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(338, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FlightNumber";
            // 
            // FlightBut
            // 
            this.FlightBut.BackColor = System.Drawing.Color.LightSalmon;
            this.FlightBut.Location = new System.Drawing.Point(304, 136);
            this.FlightBut.Name = "FlightBut";
            this.FlightBut.Size = new System.Drawing.Size(171, 46);
            this.FlightBut.TabIndex = 2;
            this.FlightBut.Text = "VIew_Flight_Review";
            this.FlightBut.UseVisualStyleBackColor = false;
            this.FlightBut.Click += new System.EventHandler(this.FlightBut_Click);
            // 
            // FlightReview
            // 
            this.FlightReview.AllowUserToAddRows = false;
            this.FlightReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightReview.Location = new System.Drawing.Point(12, 255);
            this.FlightReview.Name = "FlightReview";
            this.FlightReview.ReadOnly = true;
            this.FlightReview.RowHeadersWidth = 51;
            this.FlightReview.RowTemplate.Height = 24;
            this.FlightReview.Size = new System.Drawing.Size(776, 90);
            this.FlightReview.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ViewReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlightReview);
            this.Controls.Add(this.FlightBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlightId);
            this.Name = "ViewReview";
            this.Text = "ViewReview";
            ((System.ComponentModel.ISupportInitialize)(this.FlightReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FlightId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FlightBut;
        private System.Windows.Forms.DataGridView FlightReview;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}