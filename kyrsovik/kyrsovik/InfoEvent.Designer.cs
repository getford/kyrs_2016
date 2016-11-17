namespace kyrsovik
{
    partial class InfoEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEvent));
            this.label_name_event = new System.Windows.Forms.Label();
            this.label_feedback_count = new System.Windows.Forms.Label();
            this.label_rate_event = new System.Windows.Forms.Label();
            this.linkLabel_feedback_event = new System.Windows.Forms.LinkLabel();
            this.label_type_event = new System.Windows.Forms.Label();
            this.label_date_event = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.linkLabel_place_event = new System.Windows.Forms.LinkLabel();
            this.label_all_event_count = new System.Windows.Forms.Label();
            this.label_id_event = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name_event
            // 
            this.label_name_event.AutoSize = true;
            this.label_name_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_name_event.Location = new System.Drawing.Point(12, 9);
            this.label_name_event.Name = "label_name_event";
            this.label_name_event.Size = new System.Drawing.Size(91, 20);
            this.label_name_event.TabIndex = 0;
            this.label_name_event.Text = "Название";
            // 
            // label_feedback_count
            // 
            this.label_feedback_count.AutoSize = true;
            this.label_feedback_count.Location = new System.Drawing.Point(441, 13);
            this.label_feedback_count.Name = "label_feedback_count";
            this.label_feedback_count.Size = new System.Drawing.Size(85, 13);
            this.label_feedback_count.TabIndex = 1;
            this.label_feedback_count.Text = "Число отзывов";
            // 
            // label_rate_event
            // 
            this.label_rate_event.AutoSize = true;
            this.label_rate_event.Location = new System.Drawing.Point(441, 43);
            this.label_rate_event.Name = "label_rate_event";
            this.label_rate_event.Size = new System.Drawing.Size(48, 13);
            this.label_rate_event.TabIndex = 2;
            this.label_rate_event.Text = "Рейтинг";
            // 
            // linkLabel_feedback_event
            // 
            this.linkLabel_feedback_event.AutoSize = true;
            this.linkLabel_feedback_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Italic);
            this.linkLabel_feedback_event.Location = new System.Drawing.Point(603, 263);
            this.linkLabel_feedback_event.Name = "linkLabel_feedback_event";
            this.linkLabel_feedback_event.Size = new System.Drawing.Size(50, 16);
            this.linkLabel_feedback_event.TabIndex = 3;
            this.linkLabel_feedback_event.TabStop = true;
            this.linkLabel_feedback_event.Text = "Отзыв";
            // 
            // label_type_event
            // 
            this.label_type_event.AutoSize = true;
            this.label_type_event.Location = new System.Drawing.Point(12, 70);
            this.label_type_event.Name = "label_type_event";
            this.label_type_event.Size = new System.Drawing.Size(27, 13);
            this.label_type_event.TabIndex = 4;
            this.label_type_event.Text = "тип ";
            // 
            // label_date_event
            // 
            this.label_date_event.AutoSize = true;
            this.label_date_event.Location = new System.Drawing.Point(12, 97);
            this.label_date_event.Name = "label_date_event";
            this.label_date_event.Size = new System.Drawing.Size(30, 13);
            this.label_date_event.TabIndex = 5;
            this.label_date_event.Text = "дата";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(12, 126);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(48, 13);
            this.label_age.TabIndex = 6;
            this.label_age.Text = "возраст";
            // 
            // linkLabel_place_event
            // 
            this.linkLabel_place_event.AutoSize = true;
            this.linkLabel_place_event.Location = new System.Drawing.Point(306, 265);
            this.linkLabel_place_event.Name = "linkLabel_place_event";
            this.linkLabel_place_event.Size = new System.Drawing.Size(102, 13);
            this.linkLabel_place_event.TabIndex = 7;
            this.linkLabel_place_event.TabStop = true;
            this.linkLabel_place_event.Text = "Место проведения";
            // 
            // label_all_event_count
            // 
            this.label_all_event_count.AutoSize = true;
            this.label_all_event_count.Location = new System.Drawing.Point(12, 265);
            this.label_all_event_count.Name = "label_all_event_count";
            this.label_all_event_count.Size = new System.Drawing.Size(172, 13);
            this.label_all_event_count.TabIndex = 8;
            this.label_all_event_count.Text = "Количество мероприятий в базе";
            // 
            // label_id_event
            // 
            this.label_id_event.AutoSize = true;
            this.label_id_event.Location = new System.Drawing.Point(12, 43);
            this.label_id_event.Name = "label_id_event";
            this.label_id_event.Size = new System.Drawing.Size(45, 13);
            this.label_id_event.TabIndex = 9;
            this.label_id_event.Text = "id event";
            // 
            // InfoEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 287);
            this.Controls.Add(this.label_id_event);
            this.Controls.Add(this.label_all_event_count);
            this.Controls.Add(this.linkLabel_place_event);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_date_event);
            this.Controls.Add(this.label_type_event);
            this.Controls.Add(this.linkLabel_feedback_event);
            this.Controls.Add(this.label_rate_event);
            this.Controls.Add(this.label_feedback_count);
            this.Controls.Add(this.label_name_event);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoEvent";
            this.Text = "InfoEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoEvent_FormClosed);
            this.Load += new System.EventHandler(this.InfoEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_event;
        private System.Windows.Forms.Label label_feedback_count;
        private System.Windows.Forms.Label label_rate_event;
        private System.Windows.Forms.LinkLabel linkLabel_feedback_event;
        private System.Windows.Forms.Label label_type_event;
        private System.Windows.Forms.Label label_date_event;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.LinkLabel linkLabel_place_event;
        private System.Windows.Forms.Label label_all_event_count;
        private System.Windows.Forms.Label label_id_event;
    }
}