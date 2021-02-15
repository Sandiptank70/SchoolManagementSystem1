using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class staff : Semple
    {
        public staff()
        {
            InitializeComponent();
        }
        int edit = 0;

        private void staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel4);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel4);
            edit = 0;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (staffnameTxt.Text == "") { nameer.Visible = true; } else { nameer.Visible = false; }
            if (staffusernameTxt.Text == "") { usnameer.Visible = true; } else { usnameer.Visible = false; }
            if (staffroleDD.SelectedIndex == -1) { roleer.Visible = true; } else { roleer.Visible = false; }
            if (stffmobile1.Text == "") { mobileer.Visible = true; } else { mobileer.Visible = false; }
            if (staffemailTxt.Text == "") { emailer.Visible = true; } else { emailer.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuser.Visible = true; } else { statuser.Visible = false; }
            if (nameer.Visible || usnameer.Visible || roleer.Visible || statuser.Visible || mobileer.Visible || emailer.Visible)
            {
                MainClass.showmsg("Fields with * is mandatory", "Stop....", "Error");
            }
            else
            {
                if (edit == 0)  //code for save operation
                { 

                }
                else if (edit == 1) //code for update
                { 
                
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffnameTxt_TextChanged(object sender, EventArgs e)
        {
            if (staffnameTxt.Text == "") { nameer.Visible = true; } else { nameer.Visible = false; }
        }

        private void staffusernameTxt_TextChanged(object sender, EventArgs e)
        {

            if (staffusernameTxt.Text == "") { usnameer.Visible = true; } else { usnameer.Visible = false; }
        }

        private void staffroleDD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (staffroleDD.SelectedIndex == -1) { roleer.Visible = true; } else { roleer.Visible = false; }
            
        }

        private void stffmobile1_TextChanged(object sender, EventArgs e)
        {
            if (stffmobile1.Text == "") { mobileer.Visible = true; } else { mobileer.Visible = false; }
 
        }

        private void staffmobile2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (statusDD.SelectedIndex== -1) { statuser.Visible = true; } else { statuser.Visible = false; }
        }

        private void staffemailTxt_TextChanged(object sender, EventArgs e)
        {
            if (staffemailTxt.Text == "") { emailer.Visible = true; } else { emailer.Visible = false; }
        }

        private void adminpasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffimageBtn_Click(object sender, EventArgs e)
        {
           DialogResult dr= openFileDialog1.ShowDialog();
           if (dr == DialogResult.OK)
           {
               Image i =new Bitmap(openFileDialog1.FileName);
               pictureBox1.Image = i;
               pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           }

        }

    }
}
