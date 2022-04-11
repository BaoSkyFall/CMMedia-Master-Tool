using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMMedia_Master_Tool
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_management_Click(object sender, EventArgs e)
        {

        }

        private void checkVia1_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.closeAllChrome();
        }
        private void closeAllChrome()
        {
            //foreach(var Pross in Process.GetProcessesByName("chrome"))
            //{
            //    Pross.Kill();
            //}
            foreach (var Pross in Process.GetProcessesByName("chromedriver"))
            {
                Pross.Kill();
            }
        }

        private void checkVia1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
