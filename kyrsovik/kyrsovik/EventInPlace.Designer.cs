﻿namespace kyrsovik
{
    partial class EventInPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventInPlace));
            this.listView_evantInPlace = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_evantInPlace
            // 
            this.listView_evantInPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_evantInPlace.Location = new System.Drawing.Point(0, 0);
            this.listView_evantInPlace.Name = "listView_evantInPlace";
            this.listView_evantInPlace.Size = new System.Drawing.Size(511, 482);
            this.listView_evantInPlace.TabIndex = 0;
            this.listView_evantInPlace.UseCompatibleStateImageBehavior = false;
            // 
            // EventInPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 482);
            this.Controls.Add(this.listView_evantInPlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventInPlace";
            this.Text = "EventInPlace";
            this.Load += new System.EventHandler(this.EventInPlace_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_evantInPlace;
    }
}