namespace DriverAutoInstall
{
    partial class ucSetInstall
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dDown = new System.Windows.Forms.Button();
            this.dUp = new System.Windows.Forms.Button();
            this.dExit = new System.Windows.Forms.Button();
            this.dAdd = new System.Windows.Forms.Button();
            this.dInstall = new System.Windows.Forms.Button();
            this.flpDriveri = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsNaziv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uveziXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izveziXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPutanja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promeniPutanjuNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniOvdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniSvudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmsPutanja.SuspendLayout();
            this.SuspendLayout();
            // 
            // dDown
            // 
            this.dDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dDown.Location = new System.Drawing.Point(4, 43);
            this.dDown.Margin = new System.Windows.Forms.Padding(4);
            this.dDown.Name = "dDown";
            this.dDown.Size = new System.Drawing.Size(39, 32);
            this.dDown.TabIndex = 3;
            this.dDown.UseVisualStyleBackColor = true;
            this.dDown.Click += new System.EventHandler(this.dDown_Click);
            // 
            // dUp
            // 
            this.dUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dUp.Location = new System.Drawing.Point(4, 4);
            this.dUp.Margin = new System.Windows.Forms.Padding(4);
            this.dUp.Name = "dUp";
            this.dUp.Size = new System.Drawing.Size(39, 31);
            this.dUp.TabIndex = 4;
            this.dUp.UseVisualStyleBackColor = true;
            this.dUp.Click += new System.EventHandler(this.dUp_Click);
            // 
            // dExit
            // 
            this.dExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dExit.Location = new System.Drawing.Point(641, 354);
            this.dExit.Margin = new System.Windows.Forms.Padding(4);
            this.dExit.Name = "dExit";
            this.dExit.Size = new System.Drawing.Size(100, 28);
            this.dExit.TabIndex = 5;
            this.dExit.Text = "Exit";
            this.dExit.UseVisualStyleBackColor = true;
            this.dExit.Click += new System.EventHandler(this.dExit_Click);
            // 
            // dAdd
            // 
            this.dAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dAdd.Location = new System.Drawing.Point(112, 354);
            this.dAdd.Margin = new System.Windows.Forms.Padding(4);
            this.dAdd.Name = "dAdd";
            this.dAdd.Size = new System.Drawing.Size(100, 28);
            this.dAdd.TabIndex = 8;
            this.dAdd.Text = "Add";
            this.dAdd.UseVisualStyleBackColor = true;
            this.dAdd.Click += new System.EventHandler(this.dAdd_Click);
            // 
            // dInstall
            // 
            this.dInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dInstall.Location = new System.Drawing.Point(4, 354);
            this.dInstall.Margin = new System.Windows.Forms.Padding(4);
            this.dInstall.Name = "dInstall";
            this.dInstall.Size = new System.Drawing.Size(100, 28);
            this.dInstall.TabIndex = 9;
            this.dInstall.Text = "Install";
            this.dInstall.UseVisualStyleBackColor = true;
            this.dInstall.Click += new System.EventHandler(this.dInstall_Click);
            // 
            // flpDriveri
            // 
            this.flpDriveri.AllowDrop = true;
            this.flpDriveri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDriveri.AutoScroll = true;
            this.flpDriveri.Location = new System.Drawing.Point(4, 32);
            this.flpDriveri.Margin = new System.Windows.Forms.Padding(4);
            this.flpDriveri.Name = "flpDriveri";
            this.flpDriveri.Size = new System.Drawing.Size(691, 313);
            this.flpDriveri.TabIndex = 2;
            this.flpDriveri.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDriveri_DragDrop);
            this.flpDriveri.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpDriveri_DragEnter);
            // 
            // cmsNaziv
            // 
            this.cmsNaziv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNaziv.Name = "cmsNaziv";
            this.cmsNaziv.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dUp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dDown, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(703, 114);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(47, 79);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // dRemove
            // 
            this.dRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dRemove.Location = new System.Drawing.Point(220, 354);
            this.dRemove.Margin = new System.Windows.Forms.Padding(4);
            this.dRemove.Name = "dRemove";
            this.dRemove.Size = new System.Drawing.Size(100, 28);
            this.dRemove.TabIndex = 8;
            this.dRemove.Text = "Remove";
            this.dRemove.UseVisualStyleBackColor = true;
            this.dRemove.Click += new System.EventHandler(this.dRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uveziXMLToolStripMenuItem,
            this.izveziXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.zatvoriToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uveziXMLToolStripMenuItem
            // 
            this.uveziXMLToolStripMenuItem.Name = "uveziXMLToolStripMenuItem";
            this.uveziXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.uveziXMLToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.uveziXMLToolStripMenuItem.Text = "Uvezi XML";
            this.uveziXMLToolStripMenuItem.Click += new System.EventHandler(this.uveziXMLToolStripMenuItem_Click);
            // 
            // izveziXMLToolStripMenuItem
            // 
            this.izveziXMLToolStripMenuItem.Name = "izveziXMLToolStripMenuItem";
            this.izveziXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.izveziXMLToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.izveziXMLToolStripMenuItem.Text = "Izvezi XML";
            this.izveziXMLToolStripMenuItem.Click += new System.EventHandler(this.izveziXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // cmsPutanja
            // 
            this.cmsPutanja.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPutanja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promeniPutanjuNalogaToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.cmsPutanja.Name = "cmsPutanja";
            this.cmsPutanja.Size = new System.Drawing.Size(238, 110);
            // 
            // promeniPutanjuNalogaToolStripMenuItem
            // 
            this.promeniPutanjuNalogaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promeniOvdeToolStripMenuItem,
            this.promeniSvudaToolStripMenuItem});
            this.promeniPutanjuNalogaToolStripMenuItem.Name = "promeniPutanjuNalogaToolStripMenuItem";
            this.promeniPutanjuNalogaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.promeniPutanjuNalogaToolStripMenuItem.Text = "Promeni putanju naloga";
            // 
            // promeniOvdeToolStripMenuItem
            // 
            this.promeniOvdeToolStripMenuItem.Name = "promeniOvdeToolStripMenuItem";
            this.promeniOvdeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.promeniOvdeToolStripMenuItem.Text = "Promeni ovde";
            this.promeniOvdeToolStripMenuItem.Click += new System.EventHandler(this.promeniOvdeToolStripMenuItem_Click);
            // 
            // promeniSvudaToolStripMenuItem
            // 
            this.promeniSvudaToolStripMenuItem.Name = "promeniSvudaToolStripMenuItem";
            this.promeniSvudaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.promeniSvudaToolStripMenuItem.Text = "Promeni svuda";
            this.promeniSvudaToolStripMenuItem.Click += new System.EventHandler(this.promeniSvudaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // ucSetInstall
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dExit);
            this.Controls.Add(this.dRemove);
            this.Controls.Add(this.dAdd);
            this.Controls.Add(this.dInstall);
            this.Controls.Add(this.flpDriveri);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSetInstall";
            this.Size = new System.Drawing.Size(769, 409);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsPutanja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ContextMenuStrip cmsNaziv;
        private System.Windows.Forms.Button dAdd;
        private System.Windows.Forms.Button dDown;
        private System.Windows.Forms.Button dExit;
        private System.Windows.Forms.Button dInstall;
        private System.Windows.Forms.Button dRemove;
        private System.Windows.Forms.Button dUp;
        private System.Windows.Forms.FlowLayoutPanel flpDriveri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dDelCtrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbPutanja;
        private System.Windows.Forms.TextBox tbParametri;
        private System.Windows.Forms.Button dBrowse;
        private System.Windows.Forms.Button dParHelp;
        private System.Windows.Forms.Button dHHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uveziXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveziXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPutanja;
        private System.Windows.Forms.ToolStripMenuItem promeniPutanjuNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniOvdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniSvudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}
