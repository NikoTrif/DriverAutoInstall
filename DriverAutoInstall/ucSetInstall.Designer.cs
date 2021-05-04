﻿namespace DriverAutoInstall
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
            this.dImpXml = new System.Windows.Forms.Button();
            this.dSaveXml = new System.Windows.Forms.Button();
            this.dAdd = new System.Windows.Forms.Button();
            this.dInstall = new System.Windows.Forms.Button();
            this.flpDriveri = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsNaziv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // dDown
            // 
            this.dDown.Location = new System.Drawing.Point(527, 135);
            this.dDown.Name = "dDown";
            this.dDown.Size = new System.Drawing.Size(29, 26);
            this.dDown.TabIndex = 3;
            this.dDown.Text = "D";
            this.dDown.UseVisualStyleBackColor = true;
            this.dDown.Click += new System.EventHandler(this.dDown_Click);
            // 
            // dUp
            // 
            this.dUp.Location = new System.Drawing.Point(527, 103);
            this.dUp.Name = "dUp";
            this.dUp.Size = new System.Drawing.Size(29, 26);
            this.dUp.TabIndex = 4;
            this.dUp.Text = "U";
            this.dUp.UseVisualStyleBackColor = true;
            this.dUp.Click += new System.EventHandler(this.dUp_Click);
            // 
            // dExit
            // 
            this.dExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dExit.Location = new System.Drawing.Point(481, 288);
            this.dExit.Name = "dExit";
            this.dExit.Size = new System.Drawing.Size(75, 23);
            this.dExit.TabIndex = 5;
            this.dExit.Text = "Exit";
            this.dExit.UseVisualStyleBackColor = true;
            this.dExit.Click += new System.EventHandler(this.dExit_Click);
            // 
            // dImpXml
            // 
            this.dImpXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dImpXml.Location = new System.Drawing.Point(246, 288);
            this.dImpXml.Name = "dImpXml";
            this.dImpXml.Size = new System.Drawing.Size(75, 23);
            this.dImpXml.TabIndex = 6;
            this.dImpXml.Text = "Import XML";
            this.dImpXml.UseVisualStyleBackColor = true;
            this.dImpXml.Click += new System.EventHandler(this.dImpXml_Click);
            // 
            // dSaveXml
            // 
            this.dSaveXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dSaveXml.Location = new System.Drawing.Point(165, 288);
            this.dSaveXml.Name = "dSaveXml";
            this.dSaveXml.Size = new System.Drawing.Size(75, 23);
            this.dSaveXml.TabIndex = 7;
            this.dSaveXml.Text = "Save XML";
            this.dSaveXml.UseVisualStyleBackColor = true;
            this.dSaveXml.Click += new System.EventHandler(this.dSaveXml_Click);
            // 
            // dAdd
            // 
            this.dAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.dInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.flpDriveri.AutoScroll = true;
            this.flpDriveri.Location = new System.Drawing.Point(3, 3);
            this.flpDriveri.Name = "flpDriveri";
            this.flpDriveri.Size = new System.Drawing.Size(518, 277);
            this.flpDriveri.TabIndex = 2;
            // 
            // cmsNaziv
            // 
            this.cmsNaziv.Name = "cmsNaziv";
            this.cmsNaziv.Size = new System.Drawing.Size(61, 4);
            // 
            // ucSetInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dDown);
            this.Controls.Add(this.dUp);
            this.Controls.Add(this.dExit);
            this.Controls.Add(this.dImpXml);
            this.Controls.Add(this.dSaveXml);
            this.Controls.Add(this.dAdd);
            this.Controls.Add(this.dInstall);
            this.Controls.Add(this.flpDriveri);
            this.Name = "ucSetInstall";
            this.Size = new System.Drawing.Size(577, 332);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dDown;
        private System.Windows.Forms.Button dUp;
        private System.Windows.Forms.Button dExit;
        private System.Windows.Forms.Button dImpXml;
        private System.Windows.Forms.Button dSaveXml;
        private System.Windows.Forms.Button dAdd;
        private System.Windows.Forms.Button dInstall;
        private System.Windows.Forms.FlowLayoutPanel flpDriveri;
        private System.Windows.Forms.ContextMenuStrip cmsNaziv;
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
