namespace USF_Student_Registration
{
    partial class AddCourse_Window
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
            this.Back_From_Add_BTN = new System.Windows.Forms.Button();
            this.AddedClasses_LTVW = new System.Windows.Forms.ListView();
            this.CRN_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subj_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Crse_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credits_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRN_TXTBX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddClass_BTN = new System.Windows.Forms.Button();
            this.Group_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Professor_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Back_From_Add_BTN
            // 
            this.Back_From_Add_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_From_Add_BTN.Location = new System.Drawing.Point(154, 513);
            this.Back_From_Add_BTN.Name = "Back_From_Add_BTN";
            this.Back_From_Add_BTN.Size = new System.Drawing.Size(75, 35);
            this.Back_From_Add_BTN.TabIndex = 0;
            this.Back_From_Add_BTN.Text = "Back";
            this.Back_From_Add_BTN.UseVisualStyleBackColor = true;
            this.Back_From_Add_BTN.Click += new System.EventHandler(this.Back_From_Add_BTN_Click);
            // 
            // AddedClasses_LTVW
            // 
            this.AddedClasses_LTVW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CRN_COL,
            this.Subj_COL,
            this.Crse_COL,
            this.Sec,
            this.Level_COL,
            this.Title_COL,
            this.Credits_COL,
            this.Group_COL,
            this.Professor_COL});
            this.AddedClasses_LTVW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedClasses_LTVW.FullRowSelect = true;
            this.AddedClasses_LTVW.GridLines = true;
            this.AddedClasses_LTVW.HideSelection = false;
            this.AddedClasses_LTVW.Location = new System.Drawing.Point(25, 112);
            this.AddedClasses_LTVW.Name = "AddedClasses_LTVW";
            this.AddedClasses_LTVW.Size = new System.Drawing.Size(810, 306);
            this.AddedClasses_LTVW.TabIndex = 1;
            this.AddedClasses_LTVW.UseCompatibleStateImageBehavior = false;
            this.AddedClasses_LTVW.View = System.Windows.Forms.View.Details;
            // 
            // CRN_COL
            // 
            this.CRN_COL.Text = "CRN";
            this.CRN_COL.Width = 90;
            // 
            // Subj_COL
            // 
            this.Subj_COL.Text = "Subject";
            // 
            // Crse_COL
            // 
            this.Crse_COL.Text = "Course";
            this.Crse_COL.Width = 80;
            // 
            // Sec
            // 
            this.Sec.Text = "Section";
            // 
            // Level_COL
            // 
            this.Level_COL.Text = "Level";
            this.Level_COL.Width = 120;
            // 
            // Title_COL
            // 
            this.Title_COL.Text = "Title";
            this.Title_COL.Width = 120;
            // 
            // Credits_COL
            // 
            this.Credits_COL.Text = "Credits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Class Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Added Classes:";
            // 
            // CRN_TXTBX
            // 
            this.CRN_TXTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRN_TXTBX.Location = new System.Drawing.Point(141, 452);
            this.CRN_TXTBX.Name = "CRN_TXTBX";
            this.CRN_TXTBX.Size = new System.Drawing.Size(179, 26);
            this.CRN_TXTBX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter CRN:";
            // 
            // AddClass_BTN
            // 
            this.AddClass_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass_BTN.Location = new System.Drawing.Point(25, 513);
            this.AddClass_BTN.Name = "AddClass_BTN";
            this.AddClass_BTN.Size = new System.Drawing.Size(105, 35);
            this.AddClass_BTN.TabIndex = 6;
            this.AddClass_BTN.Text = "Add Class";
            this.AddClass_BTN.UseVisualStyleBackColor = true;
            this.AddClass_BTN.Click += new System.EventHandler(this.AddClass_BTN_Click);
            // 
            // Group_COL
            // 
            this.Group_COL.Text = "Group";
            this.Group_COL.Width = 120;
            // 
            // Professor_COL
            // 
            this.Professor_COL.Text = "Professor";
            this.Professor_COL.Width = 100;
            // 
            // AddCourse_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 582);
            this.Controls.Add(this.AddClass_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CRN_TXTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddedClasses_LTVW);
            this.Controls.Add(this.Back_From_Add_BTN);
            this.Name = "AddCourse_Window";
            this.Text = "AddCourse_Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_From_Add_BTN;
        private System.Windows.Forms.ListView AddedClasses_LTVW;
        private System.Windows.Forms.ColumnHeader CRN_COL;
        private System.Windows.Forms.ColumnHeader Subj_COL;
        private System.Windows.Forms.ColumnHeader Crse_COL;
        private System.Windows.Forms.ColumnHeader Sec;
        private System.Windows.Forms.ColumnHeader Level_COL;
        private System.Windows.Forms.ColumnHeader Title_COL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CRN_TXTBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddClass_BTN;
        private System.Windows.Forms.ColumnHeader Credits_COL;
        private System.Windows.Forms.ColumnHeader Group_COL;
        private System.Windows.Forms.ColumnHeader Professor_COL;
    }
}