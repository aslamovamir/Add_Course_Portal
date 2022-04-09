namespace USF_Student_Registration
{
    partial class DropCourse_Window
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
            this.Back_From_Drop_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_From_Drop_BTN
            // 
            this.Back_From_Drop_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_From_Drop_BTN.Location = new System.Drawing.Point(328, 295);
            this.Back_From_Drop_BTN.Name = "Back_From_Drop_BTN";
            this.Back_From_Drop_BTN.Size = new System.Drawing.Size(75, 35);
            this.Back_From_Drop_BTN.TabIndex = 1;
            this.Back_From_Drop_BTN.Text = "Back";
            this.Back_From_Drop_BTN.UseVisualStyleBackColor = true;
            this.Back_From_Drop_BTN.Click += new System.EventHandler(this.Back_From_Drop_BTN_Click);
            // 
            // DropCourse_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_From_Drop_BTN);
            this.Name = "DropCourse_Window";
            this.Text = "DropCourse_Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_From_Drop_BTN;
    }
}