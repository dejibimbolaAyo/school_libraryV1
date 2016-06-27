namespace WindowsFormsApplication1
{
    partial class FormLibraryHome
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
            this.buttonEnrollStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnrollStudents
            // 
            this.buttonEnrollStudents.Location = new System.Drawing.Point(101, 121);
            this.buttonEnrollStudents.Name = "buttonEnrollStudents";
            this.buttonEnrollStudents.Size = new System.Drawing.Size(176, 23);
            this.buttonEnrollStudents.TabIndex = 0;
            this.buttonEnrollStudents.Text = "Enroll Students";
            this.buttonEnrollStudents.UseVisualStyleBackColor = true;
            this.buttonEnrollStudents.Click += new System.EventHandler(this.buttonEnrollStudents_Click);
            // 
            // FormLibraryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.buttonEnrollStudents);
            this.Name = "FormLibraryHome";
            this.Text = "Library | Home";
            this.Load += new System.EventHandler(this.FormLibraryHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnrollStudents;
    }
}