namespace WindowsFormsAttempt4
{
    partial class Form1
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
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.socialNum = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.Label();
            this.socialNumtxt = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(303, 97);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 0;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(303, 250);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 22);
            this.age.TabIndex = 1;
            // 
            // socialNum
            // 
            this.socialNum.Location = new System.Drawing.Point(303, 172);
            this.socialNum.Name = "socialNum";
            this.socialNum.Size = new System.Drawing.Size(100, 22);
            this.socialNum.TabIndex = 2;
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(48, 97);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(45, 17);
            this.nametxt.TabIndex = 3;
            this.nametxt.Text = "Name";
            // 
            // socialNumtxt
            // 
            this.socialNumtxt.AutoSize = true;
            this.socialNumtxt.Location = new System.Drawing.Point(48, 172);
            this.socialNumtxt.Name = "socialNumtxt";
            this.socialNumtxt.Size = new System.Drawing.Size(139, 17);
            this.socialNumtxt.TabIndex = 4;
            this.socialNumtxt.Text = "Social Security last 4";
            // 
            // agetxt
            // 
            this.agetxt.AutoSize = true;
            this.agetxt.Location = new System.Drawing.Point(48, 250);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(33, 17);
            this.agetxt.TabIndex = 5;
            this.agetxt.Text = "Age";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(648, 250);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.socialNumtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.socialNum);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox socialNum;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label socialNumtxt;
        private System.Windows.Forms.Label agetxt;
        private System.Windows.Forms.Button submit;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

