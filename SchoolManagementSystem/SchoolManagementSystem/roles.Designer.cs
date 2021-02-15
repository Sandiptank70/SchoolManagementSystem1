namespace SchoolManagementSystem
{
    partial class roles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rolenameTxt = new System.Windows.Forms.TextBox();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.Details = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolenameerror = new System.Windows.Forms.Label();
            this.rolestatuserror = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(873, 71);
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(873, 20);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(873, 414);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Size = new System.Drawing.Size(873, 348);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rolestatuserror);
            this.panel4.Controls.Add(this.rolenameerror);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.statusDD);
            this.panel4.Controls.Add(this.rolenameTxt);
            this.panel4.Size = new System.Drawing.Size(873, 66);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Details);
            this.panel7.Size = new System.Drawing.Size(873, 320);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(873, 28);
            // 
            // rolenameTxt
            // 
            this.rolenameTxt.Location = new System.Drawing.Point(102, 14);
            this.rolenameTxt.Name = "rolenameTxt";
            this.rolenameTxt.Size = new System.Drawing.Size(100, 20);
            this.rolenameTxt.TabIndex = 2;
            this.rolenameTxt.TextChanged += new System.EventHandler(this.rolenameTxt_TextChanged);
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "in-active"});
            this.statusDD.Location = new System.Drawing.Point(443, 22);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(121, 21);
            this.statusDD.TabIndex = 3;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // Details
            // 
            this.Details.Controls.Add(this.dataGridView1);
            this.Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Details.Location = new System.Drawing.Point(0, 0);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(873, 320);
            this.Details.TabIndex = 0;
            this.Details.TabStop = false;
            this.Details.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolesIDGV,
            this.snogv,
            this.rolegv,
            this.statusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(867, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // rolesIDGV
            // 
            this.rolesIDGV.HeaderText = "Role ID";
            this.rolesIDGV.Name = "rolesIDGV";
            this.rolesIDGV.ReadOnly = true;
            this.rolesIDGV.Visible = false;
            // 
            // snogv
            // 
            this.snogv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snogv.HeaderText = "No";
            this.snogv.Name = "snogv";
            this.snogv.ReadOnly = true;
            this.snogv.Width = 46;
            // 
            // rolegv
            // 
            this.rolegv.HeaderText = "Role";
            this.rolegv.Name = "rolegv";
            this.rolegv.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role Status";
            // 
            // rolenameerror
            // 
            this.rolenameerror.AutoSize = true;
            this.rolenameerror.Location = new System.Drawing.Point(85, 14);
            this.rolenameerror.Name = "rolenameerror";
            this.rolenameerror.Size = new System.Drawing.Size(11, 13);
            this.rolenameerror.TabIndex = 6;
            this.rolenameerror.Text = "*";
            // 
            // rolestatuserror
            // 
            this.rolestatuserror.AutoSize = true;
            this.rolestatuserror.Location = new System.Drawing.Point(426, 21);
            this.rolestatuserror.Name = "rolestatuserror";
            this.rolestatuserror.Size = new System.Drawing.Size(11, 13);
            this.rolestatuserror.TabIndex = 7;
            this.rolestatuserror.Text = "*";
            // 
            // roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 505);
            this.Name = "roles";
            this.Text = "roles";
            this.Load += new System.EventHandler(this.roles_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.TextBox rolenameTxt;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rolestatuserror;
        private System.Windows.Forms.Label rolenameerror;
    }
}