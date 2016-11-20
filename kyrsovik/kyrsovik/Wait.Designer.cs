namespace kyrsovik
{
    partial class Wait
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
            System.Windows.Forms.PictureBox pictureBox_waitLoaded;
            pictureBox_waitLoaded = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox_waitLoaded)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_waitLoaded
            // 
            pictureBox_waitLoaded.BackColor = System.Drawing.SystemColors.Window;
            pictureBox_waitLoaded.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            pictureBox_waitLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox_waitLoaded.ErrorImage = global::kyrsovik.Properties.Resources.wait;
            pictureBox_waitLoaded.Image = global::kyrsovik.Properties.Resources.wait;
            pictureBox_waitLoaded.InitialImage = global::kyrsovik.Properties.Resources.wait;
            pictureBox_waitLoaded.Location = new System.Drawing.Point(0, 0);
            pictureBox_waitLoaded.Name = "pictureBox_waitLoaded";
            pictureBox_waitLoaded.Size = new System.Drawing.Size(69, 69);
            pictureBox_waitLoaded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_waitLoaded.TabIndex = 0;
            pictureBox_waitLoaded.TabStop = false;
            pictureBox_waitLoaded.WaitOnLoad = true;
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(69, 69);
            this.ControlBox = false;
            this.Controls.Add(pictureBox_waitLoaded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wait";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wait";
            ((System.ComponentModel.ISupportInitialize)(pictureBox_waitLoaded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}