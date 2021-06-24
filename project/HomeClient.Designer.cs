
namespace project
{
    partial class HomeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeClient));
            this.gridd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.e1 = new System.Windows.Forms.Button();
            this.co1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dest = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t22 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridd)).BeginInit();
            this.SuspendLayout();
            // 
            // gridd
            // 
            this.gridd.AllowUserToAddRows = false;
            this.gridd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridd.Location = new System.Drawing.Point(56, 162);
            this.gridd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridd.Name = "gridd";
            this.gridd.ReadOnly = true;
            this.gridd.RowHeadersWidth = 51;
            this.gridd.RowTemplate.Height = 24;
            this.gridd.Size = new System.Drawing.Size(329, 186);
            this.gridd.TabIndex = 1;
            this.gridd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Page";
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(84, 112);
            this.v1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(269, 46);
            this.v1.TabIndex = 3;
            this.v1.Text = "View Selected Flight Details and Number";
            this.v1.UseVisualStyleBackColor = true;
            this.v1.Click += new System.EventHandler(this.v1_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(611, 256);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(159, 34);
            this.b1.TabIndex = 4;
            this.b1.Text = "Book The Flight";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(615, 9);
            this.e1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(173, 36);
            this.e1.TabIndex = 5;
            this.e1.Text = "Edit Profile";
            this.e1.UseVisualStyleBackColor = true;
            this.e1.Click += new System.EventHandler(this.e1_Click);
            // 
            // co1
            // 
            this.co1.FormattingEnabled = true;
            this.co1.Items.AddRange(new object[] {
            "Low",
            "Economy",
            "Business",
            "First Class"});
            this.co1.Location = new System.Drawing.Point(611, 186);
            this.co1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.co1.Name = "co1";
            this.co1.Size = new System.Drawing.Size(121, 24);
            this.co1.TabIndex = 7;
            this.co1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(452, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please choose fare/type before booking a flight";
            // 
            // t11
            // 
            this.t11.Location = new System.Drawing.Point(455, 268);
            this.t11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t11.Name = "t11";
            this.t11.Size = new System.Drawing.Size(100, 22);
            this.t11.TabIndex = 10;
            this.t11.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(452, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Flight Number";
            // 
            // dest
            // 
            this.dest.Location = new System.Drawing.Point(56, 73);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(137, 22);
            this.dest.TabIndex = 12;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(238, 73);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(147, 22);
            this.to.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Destination Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Source Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t22
            // 
            this.t22.Location = new System.Drawing.Point(455, 402);
            this.t22.Name = "t22";
            this.t22.Size = new System.Drawing.Size(158, 22);
            this.t22.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Comment";
            // 
            // c1
            // 
            this.c1.FormattingEnabled = true;
            this.c1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.c1.Location = new System.Drawing.Point(455, 338);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(121, 24);
            this.c1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Or";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Rate";
            // 
            // HomeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.to);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.co1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeClient";
            this.Text = "HomeClient";
            this.Load += new System.EventHandler(this.HomeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button e1;
        private System.Windows.Forms.ComboBox co1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dest;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}