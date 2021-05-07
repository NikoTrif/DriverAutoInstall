namespace DriverAutoInstall
{
    partial class fInst
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbInstall = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lCurrentDrv = new System.Windows.Forms.Label();
            this.lNum = new System.Windows.Forms.Label();
            this.dCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lCurrentDrv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbInstall, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lNum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dCancel, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 134);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pbInstall
            // 
            this.pbInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInstall.Location = new System.Drawing.Point(3, 81);
            this.pbInstall.Name = "pbInstall";
            this.pbInstall.Size = new System.Drawing.Size(444, 20);
            this.pbInstall.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Installing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCurrentDrv
            // 
            this.lCurrentDrv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentDrv.AutoSize = true;
            this.lCurrentDrv.Location = new System.Drawing.Point(3, 32);
            this.lCurrentDrv.Name = "lCurrentDrv";
            this.lCurrentDrv.Size = new System.Drawing.Size(444, 13);
            this.lCurrentDrv.TabIndex = 1;
            this.lCurrentDrv.Text = "label1";
            this.lCurrentDrv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lNum
            // 
            this.lNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lNum.AutoSize = true;
            this.lNum.Location = new System.Drawing.Point(3, 58);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(444, 13);
            this.lNum.TabIndex = 1;
            this.lNum.Text = "label1";
            this.lNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dCancel
            // 
            this.dCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dCancel.Location = new System.Drawing.Point(187, 107);
            this.dCancel.Name = "dCancel";
            this.dCancel.Size = new System.Drawing.Size(75, 24);
            this.dCancel.TabIndex = 2;
            this.dCancel.Text = "Cancel";
            this.dCancel.UseVisualStyleBackColor = true;
            this.dCancel.Click += new System.EventHandler(this.dCancel_Click);
            // 
            // fInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dCancel;
            this.ClientSize = new System.Drawing.Size(474, 158);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fInst";
            this.ShowIcon = false;
            this.Text = "Install";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lCurrentDrv;
        public System.Windows.Forms.ProgressBar pbInstall;
        public System.Windows.Forms.Label lNum;
        public System.Windows.Forms.Button dCancel;
    }
}