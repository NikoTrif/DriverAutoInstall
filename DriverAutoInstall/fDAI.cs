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
            try
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml("<driverAutoInstall></driverAutoInstall>");

                    XmlElement xel;
                    XmlNode xn;
                    int i = 0;
                    foreach (TableLayoutPanel t in pMain.Controls[0].Controls["flpDriveri"].Controls)
                    {
                        xel = xdoc.CreateElement(pMain.Controls[0].Controls["flpDriveri"].Controls.IndexOf(t).ToString());
                        //xdoc.ChildNodes[0].AppendChild(xel);
                        //xel.
                        foreach (Control tb in t.Controls)
                        {
                            if (tb is TextBox)
                            {
                                xel.AppendChild(xdoc.CreateNode(XmlNodeType.Element, tb.Name, tb.Name));
                                xel.ChildNodes[0].InnerText = tb.Text;  
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
