namespace USF_Student_Registration
{
    partial class Dashboard
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
            this.Add_BTN = new System.Windows.Forms.Button();
            this.Drop_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Class_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_BTN
            // 
            this.Add_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_BTN.Location = new System.Drawing.Point(258, 173);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(159, 29);
            this.Add_BTN.TabIndex = 2;
            this.Add_BTN.Text = "Add Class";
            this.Add_BTN.UseVisualStyleBackColor = true;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // Drop_BTN
            // 
            this.Drop_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_BTN.Location = new System.Drawing.Point(258, 228);
            this.Drop_BTN.Name = "Drop_BTN";
            this.Drop_BTN.Size = new System.Drawing.Size(159, 29);
            this.Drop_BTN.TabIndex = 3;
            this.Drop_BTN.Text = "Drop Class";
            this.Drop_BTN.UseVisualStyleBackColor = true;
            this.Drop_BTN.Click += new System.EventHandler(this.Drop_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses Portal";
            // 
            // Search_Class_BTN
            // 
            this.Search_Class_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Class_BTN.Location = new System.Drawing.Point(258, 284);
            this.Search_Class_BTN.Name = "Search_Class_BTN";
            this.Search_Class_BTN.Size = new System.Drawing.Size(159, 29);
            this.Search_Class_BTN.TabIndex = 4;
            this.Search_Class_BTN.Text = "Search Class";
            this.Search_Class_BTN.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.Search_Class_BTN);
            this.Controls.Add(this.Drop_BTN);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Button Drop_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_Class_BTN;
    }
}

