using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ApplicantLogin : Form
    {
        public ApplicantLogin()
        {
            InitializeComponent();
        }

        private void Apply_ToCourse_Click(object sender, EventArgs e)
        {
            ApplyToCourse a = new ApplyToCourse();  
            a.Show();   
        }
    }
}
