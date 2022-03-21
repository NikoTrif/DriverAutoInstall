using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DriverAutoInstall
{
    public partial class fDAI : Form
    {
        ucSetInstall ucSet = new ucSetInstall();
        string arg = "";
        
        public fDAI(string[] argument)
        {
            InitializeComponent();

            if (argument.Length != 0)
            {
                arg = argument[0];
            }
        }

        private void fDAI_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(ucSet);
            ucSet.Dock = DockStyle.Fill;
        }
    }
}
