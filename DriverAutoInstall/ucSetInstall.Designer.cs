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
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dDown
            // 
            this.dDown.Location = new System.Drawing.Point(3, 35);
            this.dDown.Name = "dDown";
            this.dDown.Size = new System.Drawing.Size(29, 26);
            this.dDown.TabIndex = 3;
            this.dDown.Text = "D";
            this.dDown.UseVisualStyleBackColor = true;
            this.dDown.Click += new System.EventHandler(this.dDown_Click);
            // 
            // dUp
            // 
            this.dUp.Location = new System.Drawing.Point(3, 3);
            this.dUp.Name = "dUp";
            this.dUp.Size = new System.Drawing.Size(29, 26);
            this.dUp.TabIndex = 4;
            this.dUp.Text = "U";
            this.dUp.UseVisualStyleBackColor = true;
            this.dUp.Click += new System.EventHandler(this.dUp_Click);
            // 
            // dExit
            // 
            this.dExit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dExit.Location = new System.Drawing.Point(481, 288);
            this.dExit.Name = "dExit";
            this.dExit.Size = new System.Drawing.Size(75, 23);
            this.dExit.TabIndex = 5;
            this.dExit.Text = "Exit";
            this.dExit.UseVisualStyleBackColor = true;
            this.dExit.Click += new System.EventHandler(this.dExit_Click);
            // 
            // dAdd
            // 
            this.dAdd.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dAdd.Location = new System.Drawing.Point(84, 288);
            this.dAdd.Name = "dAdd";
            this.dAdd.Size = new System.Drawing.Size(75, 23);
            this.dAdd.TabIndex = 8;
            this.dAdd.Text = "Add";
            this.dAdd.UseVisualStyleBackColor = true;
            this.dAdd.Click += new System.EventHandler(this.dAdd_Click);
            // 
            // dInstall
            // 
            this.dInstall.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dInstall.Location = new System.Drawing.Point(3, 288);
            this.dInstall.Name = "dInstall";
            this.dInstall.Size = new System.Drawing.Size(75, 23);
            this.dInstall.TabIndex = 9;
            this.dInstall.Text = "Install";
            this.dInstall.UseVisualStyleBackColor = true;
            this.dInstall.Click += new System.EventHandler(this.dInstall_Click);
            // 
            // flpDriveri
            // 
            this.flpDriveri.AllowDrop = true;
            this.flpDriveri.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.flpDriveri.AutoScroll = true;
            this.flpDriveri.Location = new System.Drawing.Point(3, 3);
            this.flpDriveri.Name = "flpDriveri";
            this.flpDriveri.Size = new System.Drawing.Size(518, 277);
            this.flpDriveri.TabIndex = 2;
            this.flpDriveri.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDriveri_DragDrop);
            this.flpDriveri.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpDriveri_DragEnter);
            // 
            // cmsNaziv
            // 
            this.cmsNaziv.Name = "cmsNaziv";
            this.cmsNaziv.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dUp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dDown, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(527, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(35, 64);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // dRemove
            // 
            this.dRemove.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dRemove.Location = new System.Drawing.Point(165, 288);
            this.dRemove.Name = "dRemove";
            this.dRemove.Size = new System.Drawing.Size(75, 23);
            this.dRemove.TabIndex = 8;
            this.dRemove.Text = "Remove";
            this.dRemove.UseVisualStyleBackColor = true;
            this.dRemove.Click += new System.EventHandler(this.dRemove_Click);
            // 
            // ucSetInstall
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dExit);
            this.Controls.Add(this.dRemove);
            this.Controls.Add(this.dAdd);
            this.Controls.Add(this.dInstall);
            this.Controls.Add(this.flpDriveri);
            this.Name = "ucSetInstall";
            this.Size = new System.Drawing.Size(577, 332);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbPutanja;
        private System.Windows.Forms.TextBox tbParametri;
        private System.Windows.Forms.Button dBrowse;
        private System.Windows.Forms.Button dParHelp;
    }
}
