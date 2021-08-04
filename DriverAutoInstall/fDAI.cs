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
        public fDAI()
        {
            InitializeComponent();
        }

        private void fDAI_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(ucSet);
            ucSet.Dock = DockStyle.Fill;
        }

        private void fDAI_KeyDown(object sender, KeyEventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();

            if (e.Control && e.KeyCode == Keys.S)
            {
                ucSet.IzveziXML(xdoc);
            }

            else if (e.Control && e.KeyCode == Keys.O)
            {
                using (OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "XML | *.xml"
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        xdoc.Load(ofd.FileName);
                        ucSet.UveziXML(xdoc); 
                    }
                }
            }
        }
    }
}
