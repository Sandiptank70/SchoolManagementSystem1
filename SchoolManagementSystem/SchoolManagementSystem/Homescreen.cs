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
    public partial class Homescreen : Form
    {
        public Homescreen()
        {
            InitializeComponent();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            staff stf=new staff();
            MainClass.showWind(stf, this, Mdi.ActiveForm);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            classes cls = new classes();
            MainClass.showWind(cls, this, Mdi.ActiveForm);
        }

        private void studentesBtn_Click(object sender, EventArgs e)
        {

        }

        private void Roles_Click(object sender, EventArgs e)
        {
            roles rs = new roles();
            MainClass.showWind(rs, this, Mdi.ActiveForm);
        }
    }
}
