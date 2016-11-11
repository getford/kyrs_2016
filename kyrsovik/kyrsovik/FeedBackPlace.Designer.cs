namespace kyrsovik
{
    partial class FeedBackPlace
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
            this.label_author = new System.Windows.Forms.Label();
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.label_topic = new System.Windows.Forms.Label();
            this.label_text_feedback = new System.Windows.Forms.Label();
            this.label_rate = new System.Windows.Forms.Label();
            this.textBox_topic = new System.Windows.Forms.TextBox();
            this.richTextBox_text_feedback = new System.Windows.Forms.RichTextBox();
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.button_add_feedback = new System.Windows.Forms.Button();
            this.label_name_place = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(12, 71);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(37, 13);
            this.label_author.TabIndex = 0;
            this.label_author.Text = "Автор";
            // 
            // comboBox_author
            // 
            this.comboBox_author.FormattingEnabled = true;
            this.comboBox_author.Location = new System.Drawing.Point(95, 68);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(232, 21);
            this.comboBox_author.TabIndex = 1;
            // 
            // label_topic
            // 
            this.label_topic.AutoSize = true;
            this.label_topic.Location = new System.Drawing.Point(12, 157);
            this.label_topic.Name = "label_topic";
            this.label_topic.Size = new System.Drawing.Size(34, 13);
            this.label_topic.TabIndex = 2;
            this.label_topic.Text = "Тема";
            // 
            // label_text_feedback
            // 
            this.label_text_feedback.AutoSize = true;
            this.label_text_feedback.Location = new System.Drawing.Point(12, 207);
            this.label_text_feedback.Name = "label_text_feedback";
            this.label_text_feedback.Size = new System.Drawing.Size(77, 13);
            this.label_text_feedback.TabIndex = 3;
            this.label_text_feedback.Text = "Текст отзыва";
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Location = new System.Drawing.Point(12, 113);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(48, 13);
            this.label_rate.TabIndex = 4;
            this.label_rate.Text = "Рейтинг";
            // 
            // textBox_topic
            // 
            this.textBox_topic.Location = new System.Drawing.Point(95, 154);
            this.textBox_topic.Name = "textBox_topic";
            this.textBox_topic.Size = new System.Drawing.Size(232, 20);
            this.textBox_topic.TabIndex = 5;
            // 
            // richTextBox_text_feedback
            // 
            this.richTextBox_text_feedback.Location = new System.Drawing.Point(95, 192);
            this.richTextBox_text_feedback.Name = "richTextBox_text_feedback";
            this.richTextBox_text_feedback.Size = new System.Drawing.Size(232, 119);
            this.richTextBox_text_feedback.TabIndex = 6;
            this.richTextBox_text_feedback.Text = "";
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Location = new System.Drawing.Point(95, 110);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(232, 21);
            this.comboBox_rate.TabIndex = 7;
            // 
            // button_add_feedback
            // 
            this.button_add_feedback.Location = new System.Drawing.Point(95, 317);
            this.button_add_feedback.Name = "button_add_feedback";
            this.button_add_feedback.Size = new System.Drawing.Size(232, 23);
            this.button_add_feedback.TabIndex = 8;
            this.button_add_feedback.Text = "Добавить";
            this.button_add_feedback.UseVisualStyleBackColor = true;
            this.button_add_feedback.Click += new System.EventHandler(this.button_add_feedback_Click);
            // 
            // label_name_place
            // 
            this.label_name_place.AutoSize = true;
            this.label_name_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_name_place.Location = new System.Drawing.Point(12, 19);
            this.label_name_place.Name = "label_name_place";
            this.label_name_place.Size = new System.Drawing.Size(146, 17);
            this.label_name_place.TabIndex = 9;
            this.label_name_place.Text = "Название заведения";
            // 
            // FeedBackPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 364);
            this.Controls.Add(this.label_name_place);
            this.Controls.Add(this.button_add_feedback);
            this.Controls.Add(this.comboBox_rate);
            this.Controls.Add(this.richTextBox_text_feedback);
            this.Controls.Add(this.textBox_topic);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.label_text_feedback);
            this.Controls.Add(this.label_topic);
            this.Controls.Add(this.comboBox_author);
            this.Controls.Add(this.label_author);
            this.Name = "FeedBackPlace";
            this.Text = "FeedBackPlace";
            this.Load += new System.EventHandler(this.FeedBack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.Label label_topic;
        private System.Windows.Forms.Label label_text_feedback;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.TextBox textBox_topic;
        private System.Windows.Forms.RichTextBox richTextBox_text_feedback;
        private System.Windows.Forms.ComboBox comboBox_rate;
        private System.Windows.Forms.Button button_add_feedback;
        private System.Windows.Forms.Label label_name_place;
    }
}