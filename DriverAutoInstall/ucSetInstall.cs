using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Xml;

namespace DriverAutoInstall
{
    public partial class ucSetInstall : UserControl
    {
        int leavedIndex = 0;
        bool delCtrlVisible = false;
        
        public ucSetInstall()
        {
            InitializeComponent();
        }

        private void dAdd_Click(object sender, EventArgs e)
        {
            DodajKontrole();
        }

        private void dRemove_Click(object sender, EventArgs e)
        {
            if (!delCtrlVisible)
            {
                foreach (TableLayoutPanel tlp in flpDriveri.Controls)
                {
                    (tlp.Controls["dDelCtrl"] as Button).Visible = true;
                }

                delCtrlVisible = true;
            }

            else
            {
                foreach (TableLayoutPanel tlp in flpDriveri.Controls)
                {
                    (tlp.Controls["dDelCtrl"] as Button).Visible = false;
                }

                delCtrlVisible = false;
            }
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
            /*todo probati izmeniti help da se dobiju postojeci parametri, ako postoji mogucnost proveriti koji je
                   tip fajla u pitanju pa ih postaviti automatski*/

            //ovo radi kod nekih fajlova ne kod svih
            string fName = (sender as Button).Parent.Controls["tbPutanja"].Text;
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = fName,
                    Arguments = "/?"
                }
            };
            proc.Start();
        }

        private void dHHelp_Click(object sender, EventArgs e)
        {
            /*todo probati izmeniti help da se dobiju postojeci parametri, ako postoji mogucnost proveriti koji je
                   tip fajla u pitanju pa ih postaviti automatski*/
            try
            {
                Process.Start("hHelp.html");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void flpDriveri_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fajl = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach(string s in fajl)
                {
                    DodajKontrole();
                    Upis(flpDriveri.Controls[flpDriveri.Controls.Count -1] as TableLayoutPanel, s);
                }
            }
        }

        private void flpDriveri_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dUp_Click(object sender, EventArgs e)
        {
            if (flpDriveri.Controls.Count != 0)
            {
                UpDown(true); 
            }
        }

        private void dDown_Click(object sender, EventArgs e)
        {
            if (flpDriveri.Controls.Count != 0)
            {
                UpDown(false); 
            }
        }

        private void dInstall_Click(object sender, EventArgs e)
        {
            bool cancClicked = false;

            if (flpDriveri.Controls.Count != 0)
            {
                Process inst;
                int i = 1;
                List<string> instalirano = new List<string>();
                List<string> saGreskom = new List<string>();

                fInst fin = new fInst();

                //ProgressBar
                fin.pbInstall.Maximum = flpDriveri.Controls.Count;
                fin.pbInstall.Minimum = 1;
                fin.pbInstall.Step = 1;

                fin.Show();

                foreach (Control c in flpDriveri.Controls)
                {
                    try
                    {
                        inst = new Process

                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = (c.Controls["tbPutanja"] as TextBox).Text,
                                Arguments = (c.Controls["tbParametri"] as TextBox).Text
                            }
                        };

                        fin.lCurrentDrv.Text = (c.Controls["tbNaziv"] as TextBox).Text;
                        fin.lNum.Text = string.Format("{0} / {1}", i.ToString(), flpDriveri.Controls.Count);

                        inst.Start();
                        
                        //kada se u finst pritisne Cancel prekidaju se instalacije
                        while (!inst.HasExited)
                        {
                            Thread.Sleep(100);
                            Application.DoEvents();
                            
                            if (fin.DialogResult == DialogResult.Cancel)
                            {
                                inst.Kill();
                                inst.Close();
                                inst.Dispose();
                                fin.Close();
                                MessageBox.Show("Aborted by user", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                cancClicked = true;
                                break;
                            } 
                        }

                        if (cancClicked)
                        {
                            break;
                        }
                        
                        fin.pbInstall.PerformStep();
                        instalirano.Add((c.Controls["tbNaziv"] as TextBox).Text);
                        i++;
                    }

                    catch (Exception ex)
                    {
                        saGreskom.Add((c.Controls["tbNaziv"] as TextBox).Text);

                        WriteLog(ex, "Install_Click");
                    }
                }

                fin.Dispose();

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Instalirano:");
                foreach (string ins in instalirano)
                {
                    sb.AppendLine(ins);
                }

                sb.AppendLine("\nGreske:");
                foreach (string gr in saGreskom)
                {
                    sb.AppendLine(gr);
                }

                MessageBox.Show(sb.ToString());

                if (MessageBox.Show("Da li želite da restartujete računar", "Restart", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("shutdown.exe", "-r -t 10");
                    Application.Exit();
                }
            }
        }

        private void dExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DodajKontrole()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dDelCtrl = new Button();
            dBrowse = new Button();
            dParHelp = new Button();
            dHHelp = new Button();
            tbNaziv = new TextBox();
            tbPutanja = new TextBox();
            tbParametri = new TextBox();

            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(dDelCtrl, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(tbNaziv, 1, 0);
            tableLayoutPanel1.Controls.Add(tbPutanja, 1, 1);
            tableLayoutPanel1.Controls.Add(tbParametri, 1, 2);
            tableLayoutPanel1.Controls.Add(dBrowse, 2, 1);
            tableLayoutPanel1.Controls.Add(dParHelp, 2, 2);
            tableLayoutPanel1.Controls.Add(dHHelp, 3, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Size = new System.Drawing.Size(493, 92);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Leave += new EventHandler(tableLayoutPanel1_Leave);
            tableLayoutPanel1.Enter += new EventHandler(tableLayoutPanel1_Enter);
            // 
            // label1
            // 
            label1.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 0;
            label1.Text = "Naziv:";
            // 
            // label4
            // 
            label4.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 0;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold);
            label4.Text = "";
            // 
            // dDelCtrl
            // 
            dDelCtrl.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right);
            dDelCtrl.Location = new System.Drawing.Point(463, 4);
            dDelCtrl.Name = "dDelCtrl";
            dDelCtrl.Size = new System.Drawing.Size(27, 23);
            dDelCtrl.TabIndex = 2;
            dDelCtrl.Text = "X";
            dDelCtrl.UseVisualStyleBackColor = true;
            dDelCtrl.Visible = false;
            dDelCtrl.Click += new EventHandler(dDelCtrl_Click);
            // 
            // label2
            // 
            label2.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 0;
            label2.Text = "Putanja:";
            // 
            // label3
            // 
            label3.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 13);
            label3.TabIndex = 0;
            label3.Text = "Parametri:";
            // 
            // tbNaziv
            // 
            tbNaziv.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            tbNaziv.Location = new System.Drawing.Point(74, 5);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new System.Drawing.Size(349, 20);
            tbNaziv.TabIndex = 1;
            // 
            // tbPutanja
            // 
            tbPutanja.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            tbPutanja.Location = new System.Drawing.Point(74, 35);
            tbPutanja.Name = "tbPutanja";
            tbPutanja.Size = new System.Drawing.Size(349, 20);
            tbPutanja.TabIndex = 1;
            // 
            // tbParametri
            // 
            tbParametri.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            tbParametri.Location = new System.Drawing.Point(74, 66);
            tbParametri.Name = "tbParametri";
            tbParametri.Size = new System.Drawing.Size(349, 20);
            tbParametri.TabIndex = 1;
            // 
            // dBrowse
            // 
            dBrowse.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right);
            dBrowse.Location = new System.Drawing.Point(430, 34);
            dBrowse.Name = "dBrowse";
            dBrowse.Size = new System.Drawing.Size(26, 23);
            dBrowse.TabIndex = 2;
            dBrowse.Text = "...";
            dBrowse.UseVisualStyleBackColor = true;
            dBrowse.Click += new EventHandler(dBrowse_Click);
            // 
            // dParHelp
            // 
            dParHelp.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right);
            dParHelp.Location = new System.Drawing.Point(430, 64);
            dParHelp.Name = "dParHelp";
            dParHelp.Size = new System.Drawing.Size(26, 24);
            dParHelp.TabIndex = 2;
            dParHelp.Text = "?";
            dParHelp.UseVisualStyleBackColor = true;
            dParHelp.Click += new EventHandler(dParHelp_Click);
            // 
            // dHHelp
            // 
            dHHelp.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right);
            dHHelp.Location = new System.Drawing.Point(430, 64);
            dHHelp.Name = "dHHelp";
            dHHelp.Size = new System.Drawing.Size(26, 24);
            dHHelp.TabIndex = 2;
            dHHelp.Text = "H";
            dHHelp.UseVisualStyleBackColor = true;
            dHHelp.Click += new EventHandler(dHHelp_Click);

            flpDriveri.Controls.Add(tableLayoutPanel1);
            label4.Text = (flpDriveri.Controls.IndexOf(tableLayoutPanel1) + 1).ToString();
        }

        private void tableLayoutPanel1_Enter(object sender, EventArgs e)
        {
            (sender as TableLayoutPanel).BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void tableLayoutPanel1_Leave(object sender, EventArgs e)
        {
            leavedIndex = flpDriveri.Controls.GetChildIndex((TableLayoutPanel)sender);
            (sender as TableLayoutPanel).BackColor = System.Drawing.SystemColors.Control;
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

        private static void WriteLog(Exception ex, string place)
        {
            //upisivanje u log fajl
            using (StreamWriter sw = File.AppendText("Log.txt"))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(place);
                sw.WriteLine(ex.ToString());
                sw.WriteLine(sw.NewLine);
            }
        }

        /// <summary>
        /// Move TableLayoutPanel Up or Down
        /// </summary>
        /// <param name="UpOrDown">true = Up, false = Down</param>
        private void UpDown(bool UpOrDown)
        {
            try
            {
                TableLayoutPanel tlp = (TableLayoutPanel)flpDriveri.Controls[leavedIndex];

                if (UpOrDown)
                {
                    flpDriveri.Controls.SetChildIndex(flpDriveri.Controls[leavedIndex], leavedIndex - 1);
                }
                else
                {
                    flpDriveri.Controls.SetChildIndex(flpDriveri.Controls[leavedIndex], leavedIndex + 1);
                }

                foreach(TableLayoutPanel t in flpDriveri.Controls)
                {
                    t.Controls["label4"].Text = (flpDriveri.Controls.IndexOf(t) + 1).ToString();
                }

                tlp.Controls["tbNaziv"].Focus();
            }
            catch (Exception ex)
            {
                WriteLog(ex, "UpDown");
            }
        }
    }
}
