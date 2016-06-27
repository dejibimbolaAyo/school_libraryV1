namespace WindowsFormsApplication1
{
    partial class formBorrowBooks
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
            this.firstName = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.Label();
            this.session = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBook1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBook2 = new System.Windows.Forms.TextBox();
            this.textBoxBook3 = new System.Windows.Forms.TextBox();
            this.textBoxBook4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(41, 71);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(0, 13);
            this.firstName.TabIndex = 0;
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(41, 96);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(0, 13);
            this.department.TabIndex = 0;
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Location = new System.Drawing.Point(203, 96);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(0, 13);
            this.faculty.TabIndex = 0;
            // 
            // session
            // 
            this.session.AutoSize = true;
            this.session.Location = new System.Drawing.Point(41, 147);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(0, 13);
            this.session.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // textBoxBook1
            // 
            this.textBoxBook1.Location = new System.Drawing.Point(44, 296);
            this.textBoxBook1.Name = "textBoxBook1";
            this.textBoxBook1.Size = new System.Drawing.Size(287, 20);
            this.textBoxBook1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Books Borrowed";
            // 
            // textBoxBook2
            // 
            this.textBoxBook2.Location = new System.Drawing.Point(44, 322);
            this.textBoxBook2.Name = "textBoxBook2";
            this.textBoxBook2.Size = new System.Drawing.Size(287, 20);
            this.textBoxBook2.TabIndex = 1;
            // 
            // textBoxBook3
            // 
            this.textBoxBook3.Location = new System.Drawing.Point(44, 348);
            this.textBoxBook3.Name = "textBoxBook3";
            this.textBoxBook3.Size = new System.Drawing.Size(287, 20);
            this.textBoxBook3.TabIndex = 1;
            // 
            // textBoxBook4
            // 
            this.textBoxBook4.Location = new System.Drawing.Point(44, 374);
            this.textBoxBook4.Name = "textBoxBook4";
            this.textBoxBook4.Size = new System.Drawing.Size(287, 20);
            this.textBoxBook4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(41, 30);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(32, 13);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "stdID";
            this.labelStudentID.Click += new System.EventHandler(this.labelStudentID_Click);
            // 
            // formBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBook4);
            this.Controls.Add(this.textBoxBook3);
            this.Controls.Add(this.textBoxBook2);
            this.Controls.Add(this.textBoxBook1);
            this.Controls.Add(this.session);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.firstName);
            this.Name = "formBorrowBooks";
            this.Text = "Borrow Books";
            this.Load += new System.EventHandler(this.formBorrowBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label faculty;
        private System.Windows.Forms.Label session;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBook1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBook2;
        private System.Windows.Forms.TextBox textBoxBook3;
        private System.Windows.Forms.TextBox textBoxBook4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStudentID;
    }
}