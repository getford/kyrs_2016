namespace kyrsovik
{
    partial class FeedBackEvent
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
            this.label_name_event = new System.Windows.Forms.Label();
            this.button_add_feedback = new System.Windows.Forms.Button();
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.richTextBox_text_feedback = new System.Windows.Forms.RichTextBox();
            this.textBox_topic = new System.Windows.Forms.TextBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.label_text_feedback = new System.Windows.Forms.Label();
            this.label_topic = new System.Windows.Forms.Label();
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.label_author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name_event
            // 
            this.label_name_event.AutoSize = true;
            this.label_name_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_name_event.Location = new System.Drawing.Point(12, 9);
            this.label_name_event.Name = "label_name_event";
            this.label_name_event.Size = new System.Drawing.Size(164, 17);
            this.label_name_event.TabIndex = 19;
            this.label_name_event.Text = "Название мероприятия";
            // 
            // button_add_feedback
            // 
            this.button_add_feedback.Location = new System.Drawing.Point(95, 307);
            this.button_add_feedback.Name = "button_add_feedback";
            this.button_add_feedback.Size = new System.Drawing.Size(232, 23);
            this.button_add_feedback.TabIndex = 18;
            this.button_add_feedback.Text = "Добавить";
            this.button_add_feedback.UseVisualStyleBackColor = true;
            this.button_add_feedback.Click += new System.EventHandler(this.button_add_feedback_Click);
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Location = new System.Drawing.Point(95, 100);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(232, 21);
            this.comboBox_rate.TabIndex = 17;
            // 
            // richTextBox_text_feedback
            // 
            this.richTextBox_text_feedback.Location = new System.Drawing.Point(95, 182);
            this.richTextBox_text_feedback.Name = "richTextBox_text_feedback";
            this.richTextBox_text_feedback.Size = new System.Drawing.Size(232, 119);
            this.richTextBox_text_feedback.TabIndex = 16;
            this.richTextBox_text_feedback.Text = "";
            // 
            // textBox_topic
            // 
            this.textBox_topic.Location = new System.Drawing.Point(95, 144);
            this.textBox_topic.Name = "textBox_topic";
            this.textBox_topic.Size = new System.Drawing.Size(232, 20);
            this.textBox_topic.TabIndex = 15;
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Location = new System.Drawing.Point(12, 103);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(48, 13);
            this.label_rate.TabIndex = 14;
            this.label_rate.Text = "Рейтинг";
            // 
            // label_text_feedback
            // 
            this.label_text_feedback.AutoSize = true;
            this.label_text_feedback.Location = new System.Drawing.Point(12, 197);
            this.label_text_feedback.Name = "label_text_feedback";
            this.label_text_feedback.Size = new System.Drawing.Size(77, 13);
            this.label_text_feedback.TabIndex = 13;
            this.label_text_feedback.Text = "Текст отзыва";
            // 
            // label_topic
            // 
            this.label_topic.AutoSize = true;
            this.label_topic.Location = new System.Drawing.Point(12, 147);
            this.label_topic.Name = "label_topic";
            this.label_topic.Size = new System.Drawing.Size(34, 13);
            this.label_topic.TabIndex = 12;
            this.label_topic.Text = "Тема";
            // 
            // comboBox_author
            // 
            this.comboBox_author.FormattingEnabled = true;
            this.comboBox_author.Location = new System.Drawing.Point(95, 58);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(232, 21);
            this.comboBox_author.TabIndex = 11;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(12, 61);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(37, 13);
            this.label_author.TabIndex = 10;
            this.label_author.Text = "Автор";
            // 
            // FeedBackEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.label_name_event);
            this.Controls.Add(this.button_add_feedback);
            this.Controls.Add(this.comboBox_rate);
            this.Controls.Add(this.richTextBox_text_feedback);
            this.Controls.Add(this.textBox_topic);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.label_text_feedback);
            this.Controls.Add(this.label_topic);
            this.Controls.Add(this.comboBox_author);
            this.Controls.Add(this.label_author);
            this.Name = "FeedBackEvent";
            this.Text = "FeedBackEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeedBackEvent_FormClosed);
            this.Load += new System.EventHandler(this.FeedBackEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_event;
        private System.Windows.Forms.Button button_add_feedback;
        private System.Windows.Forms.ComboBox comboBox_rate;
        private System.Windows.Forms.RichTextBox richTextBox_text_feedback;
        private System.Windows.Forms.TextBox textBox_topic;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label label_text_feedback;
        private System.Windows.Forms.Label label_topic;
        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.Label label_author;
    }
}