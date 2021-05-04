using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DriverAutoInstall
{
    public partial class ucSetInstall : UserControl
    {
        public ucSetInstall()
        {
            InitializeComponent();
        }

        private void dAdd_Click(object sender, EventArgs e)
        {
            DodajKontrole();
        }

        private void dDelCtrl_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Parent.Dispose();
        }

        private void dBrowse_Click(object sender, EventArgs e)
        {
            TableLayoutPanel tTlp = (sender as Button).Parent as TableLayoutPanel;

            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Executable|*.exe|All Files|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Upis(tTlp, ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dParHelp_Click(object sender, EventArgs e)
        {

        }

        private void flpDriveri_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void flpDriveri_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void dUp_Click(object sender, EventArgs e)
        {

        }

        private void dDown_Click(object sender, EventArgs e)
        {

        }

        private void dInstall_Click(object sender, EventArgs e)
        {

        }

        private void dSaveXml_Click(object sender, EventArgs e)
        {

        }

        private void dImpXml_Click(object sender, EventArgs e)
        {

        }

        private void dExit_Click(object sender, EventArgs e)
        {

        }

        private void DodajKontrole()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dDelCtrl = new Button();
            dBrowse = new Button();
            dParHelp = new Button();
            tbNaziv = new TextBox();
            tbPutanja = new TextBox();
            tbParametri = new TextBox();

            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dDelCtrl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPutanja, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbParametri, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dBrowse, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dParHelp, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // dDelCtrl
            // 
            this.dDelCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dDelCtrl.Location = new System.Drawing.Point(463, 4);
            this.dDelCtrl.Name = "dDelCtrl";
            this.dDelCtrl.Size = new System.Drawing.Size(27, 23);
            this.dDelCtrl.TabIndex = 2;
            this.dDelCtrl.Text = "X";
            this.dDelCtrl.UseVisualStyleBackColor = true;
            this.dDelCtrl.Click += new System.EventHandler(this.dDelCtrl_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Putanja:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parametri:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNaziv.Location = new System.Drawing.Point(74, 5);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(349, 20);
            this.tbNaziv.TabIndex = 1;
            // 
            // tbPutanja
            // 
            this.tbPutanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPutanja.Location = new System.Drawing.Point(74, 35);
            this.tbPutanja.Name = "tbPutanja";
            this.tbPutanja.Size = new System.Drawing.Size(349, 20);
            this.tbPutanja.TabIndex = 1;
            // 
            // tbParametri
            // 
            this.tbParametri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParametri.Location = new System.Drawing.Point(74, 66);
            this.tbParametri.Name = "tbParametri";
            this.tbParametri.Size = new System.Drawing.Size(349, 20);
            this.tbParametri.TabIndex = 1;
            // 
            // dBrowse
            // 
            this.dBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dBrowse.Location = new System.Drawing.Point(430, 34);
            this.dBrowse.Name = "dBrowse";
            this.dBrowse.Size = new System.Drawing.Size(26, 23);
            this.dBrowse.TabIndex = 2;
            this.dBrowse.Text = "...";
            this.dBrowse.UseVisualStyleBackColor = true;
            this.dBrowse.Click += new System.EventHandler(this.dBrowse_Click);
            // 
            // dParHelp
            // 
            this.dParHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dParHelp.Location = new System.Drawing.Point(430, 64);
            this.dParHelp.Name = "dParHelp";
            this.dParHelp.Size = new System.Drawing.Size(26, 24);
            this.dParHelp.TabIndex = 2;
            this.dParHelp.Text = "?";
            this.dParHelp.UseVisualStyleBackColor = true;
            this.dParHelp.Click += new System.EventHandler(this.dParHelp_Click);

            flpDriveri.Controls.Add(tableLayoutPanel1);
        }

        private void Upis(TableLayoutPanel tlp, string Putanja = "")
        {
            // FileVersionInfo se koristi za citanje Details kartice iz properties-a fajla
            FileVersionInfo fvi;

            try
            {
                if (!string.IsNullOrEmpty(Putanja))
                {
                    fvi = FileVersionInfo.GetVersionInfo(Putanja);
                    (tlp.Controls["tbPutanja"] as TextBox).Text = Putanja;
                    (tlp.Controls["tbNaziv"] as TextBox).Text = fvi.ProductName; 
                }
                else
                {
                    MessageBox.Show("Putanja programa ne postoji!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
