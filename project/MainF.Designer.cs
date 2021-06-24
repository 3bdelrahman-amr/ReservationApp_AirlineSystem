
namespace project
{
    partial class MainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.AdminBut = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminBut
            // 
            this.AdminBut.Location = new System.Drawing.Point(127, 76);
            this.AdminBut.Name = "AdminBut";
            this.AdminBut.Size = new System.Drawing.Size(134, 39);
            this.AdminBut.TabIndex = 0;
            this.AdminBut.Text = "Admin";
            this.AdminBut.UseVisualStyleBackColor = true;
            this.AdminBut.Click += new System.EventHandler(this.AdminBut_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(514, 76);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(134, 39);
            this.LogInBtn.TabIndex = 1;
            this.LogInBtn.Text = "Log in Client";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log in Crew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.AdminBut);
            this.Name = "MainF";
            this.Text = "MainF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminBut;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}