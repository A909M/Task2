namespace Task2
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
            this.studentID = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.Specialization = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(113, 102);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(130, 24);
            this.studentID.TabIndex = 1;
            this.studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(113, 158);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(130, 24);
            this.phone.TabIndex = 2;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Specialization
            // 
            this.Specialization.Location = new System.Drawing.Point(113, 225);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(129, 24);
            this.Specialization.TabIndex = 3;
            this.Specialization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "اسم الطالب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "رقم الطالب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "التخصص";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "تسجيل الدخول";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Specialization);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.studentID);
            this.panel1.Location = new System.Drawing.Point(223, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 371);
            this.panel1.TabIndex = 9;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(109, 51);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(131, 24);
            this.studentName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox Specialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox studentName;
    }
}

