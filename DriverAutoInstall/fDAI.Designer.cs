namespace DriverAutoInstall
{
    partial class fDAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDAI));
            this.pMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(769, 409);
            this.pMain.TabIndex = 0;
            // 
            // fDAI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 409);
            this.Controls.Add(this.pMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fDAI";
            this.Text = "Driver AutoInstall";
            this.Load += new System.EventHandler(this.fDAI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fDAI_KeyDown);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pMain;

        #endregion
    }
}

