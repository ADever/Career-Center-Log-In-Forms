namespace WindowsFormsAttempt4
{
    partial class Form2
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
            this.newUser = new System.Windows.Forms.Button();
            this.returningUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.Color.SkyBlue;
            this.newUser.FlatAppearance.BorderSize = 0;
            this.newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.ForeColor = System.Drawing.SystemColors.Control;
            this.newUser.Location = new System.Drawing.Point(55, 258);
            this.newUser.Name = "newUser";
            this.newUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newUser.Size = new System.Drawing.Size(225, 39);
            this.newUser.TabIndex = 0;
            this.newUser.Text = "New User";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // returningUser
            // 
            this.returningUser.BackColor = System.Drawing.Color.SkyBlue;
            this.returningUser.FlatAppearance.BorderSize = 0;
            this.returningUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returningUser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returningUser.ForeColor = System.Drawing.SystemColors.Control;
            this.returningUser.Location = new System.Drawing.Point(55, 326);
            this.returningUser.Name = "returningUser";
            this.returningUser.Size = new System.Drawing.Size(225, 38);
            this.returningUser.TabIndex = 1;
            this.returningUser.Text = "Returning User";
            this.returningUser.UseVisualStyleBackColor = false;
            this.returningUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Have you created an account before?";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 10);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 197);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAttempt4.Properties.Resources.mainformbackground;
            this.pictureBox1.Location = new System.Drawing.Point(-87, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returningUser);
            this.Controls.Add(this.newUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button returningUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}