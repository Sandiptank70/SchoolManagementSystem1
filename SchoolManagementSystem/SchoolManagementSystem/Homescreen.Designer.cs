namespace SchoolManagementSystem
{
    partial class Homescreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staffBtn = new System.Windows.Forms.Button();
            this.classesBtn = new System.Windows.Forms.Button();
            this.studentesBtn = new System.Windows.Forms.Button();
            this.feesBtn = new System.Windows.Forms.Button();
            this.timetableBtn = new System.Windows.Forms.Button();
            this.Roles = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Roles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timetableBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.feesBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentesBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.classesBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 51);
            this.panel1.TabIndex = 1;
            // 
            // staffBtn
            // 
            this.staffBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffBtn.FlatAppearance.BorderSize = 3;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Location = new System.Drawing.Point(3, 3);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(174, 90);
            this.staffBtn.TabIndex = 0;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // classesBtn
            // 
            this.classesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesBtn.FlatAppearance.BorderSize = 3;
            this.classesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classesBtn.Location = new System.Drawing.Point(183, 3);
            this.classesBtn.Name = "classesBtn";
            this.classesBtn.Size = new System.Drawing.Size(174, 90);
            this.classesBtn.TabIndex = 1;
            this.classesBtn.Text = "Classes";
            this.classesBtn.UseVisualStyleBackColor = true;
            this.classesBtn.Click += new System.EventHandler(this.classesBtn_Click);
            // 
            // studentesBtn
            // 
            this.studentesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentesBtn.FlatAppearance.BorderSize = 3;
            this.studentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentesBtn.Location = new System.Drawing.Point(363, 3);
            this.studentesBtn.Name = "studentesBtn";
            this.studentesBtn.Size = new System.Drawing.Size(174, 90);
            this.studentesBtn.TabIndex = 2;
            this.studentesBtn.Text = "Studentes";
            this.studentesBtn.UseVisualStyleBackColor = true;
            this.studentesBtn.Click += new System.EventHandler(this.studentesBtn_Click);
            // 
            // feesBtn
            // 
            this.feesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feesBtn.FlatAppearance.BorderSize = 3;
            this.feesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feesBtn.Location = new System.Drawing.Point(543, 3);
            this.feesBtn.Name = "feesBtn";
            this.feesBtn.Size = new System.Drawing.Size(174, 90);
            this.feesBtn.TabIndex = 3;
            this.feesBtn.Text = "Fees";
            this.feesBtn.UseVisualStyleBackColor = true;
            // 
            // timetableBtn
            // 
            this.timetableBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timetableBtn.FlatAppearance.BorderSize = 3;
            this.timetableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableBtn.Location = new System.Drawing.Point(723, 3);
            this.timetableBtn.Name = "timetableBtn";
            this.timetableBtn.Size = new System.Drawing.Size(175, 90);
            this.timetableBtn.TabIndex = 4;
            this.timetableBtn.Text = "Time Table";
            this.timetableBtn.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            this.Roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Roles.FlatAppearance.BorderSize = 3;
            this.Roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Roles.Location = new System.Drawing.Point(3, 99);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(174, 90);
            this.Roles.TabIndex = 5;
            this.Roles.Text = "Roles";
            this.Roles.UseVisualStyleBackColor = true;
            this.Roles.Click += new System.EventHandler(this.Roles_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(183, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 90);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(363, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 90);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(543, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 90);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 3;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(723, 99);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(175, 90);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 3;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(3, 195);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(174, 90);
            this.button11.TabIndex = 10;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 531);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Homescreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Roles;
        private System.Windows.Forms.Button timetableBtn;
        private System.Windows.Forms.Button feesBtn;
        private System.Windows.Forms.Button studentesBtn;
        private System.Windows.Forms.Button classesBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Panel panel1;
    }
}