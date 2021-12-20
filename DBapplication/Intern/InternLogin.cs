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
    public partial class InternLogin : Form
    {
        string InternId;
        int CurrentYear;
        Controller controllerObj;
        public InternLogin(string internid, int year)
        {
            InitializeComponent();
            InternId = internid;    
            CurrentYear = year;
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
