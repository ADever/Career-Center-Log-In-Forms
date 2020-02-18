
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsAttempt4
{
    partial class Form3
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.socialLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.socialNum = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(90, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // socialLabel
            // 
            this.socialLabel.AutoSize = true;
            this.socialLabel.Location = new System.Drawing.Point(13, 92);
            this.socialLabel.Name = "socialLabel";
            this.socialLabel.Size = new System.Drawing.Size(122, 17);
            this.socialLabel.TabIndex = 1;
            this.socialLabel.Text = "Last four of Social";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(198, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 3;
            // 
            // socialNum
            // 
            this.socialNum.Location = new System.Drawing.Point(198, 92);
            this.socialNum.Name = "socialNum";
            this.socialNum.Size = new System.Drawing.Size(100, 22);
            this.socialNum.TabIndex = 5;
            this.socialNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.socialNum_KeyPress);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(223, 150);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 217);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.socialNum);
            this.Controls.Add(this.name);
            this.Controls.Add(this.socialLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label socialLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox socialNum;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private System.Windows.Forms.Button submit;
    }
}