namespace kyrsovik
{
    partial class InfoPlace
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_pay_card = new System.Windows.Forms.Label();
            this.label_parking = new System.Windows.Forms.Label();
            this.label_working_time = new System.Windows.Forms.Label();
            this.label_name_place = new System.Windows.Forms.Label();
            this.groupBox_address_place = new System.Windows.Forms.GroupBox();
            this.label_country = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_house = new System.Windows.Forms.Label();
            this.label_street = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.label_type_place = new System.Windows.Forms.Label();
            this.linkLabel_events_here = new System.Windows.Forms.LinkLabel();
            this.linkLabel_feedback_place = new System.Windows.Forms.LinkLabel();
            this.label_count_feedback = new System.Windows.Forms.Label();
            this.label_avg_rate = new System.Windows.Forms.Label();
            this.groupBox_address_place.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(6, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "id place";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(12, 243);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(111, 13);
            this.label_count.TabIndex = 1;
            this.label_count.Text = "Количество записей";
            // 
            // label_pay_card
            // 
            this.label_pay_card.AutoSize = true;
            this.label_pay_card.Location = new System.Drawing.Point(6, 82);
            this.label_pay_card.Name = "label_pay_card";
            this.label_pay_card.Size = new System.Drawing.Size(82, 13);
            this.label_pay_card.TabIndex = 2;
            this.label_pay_card.Text = "Оплата картой";
            // 
            // label_parking
            // 
            this.label_parking.AutoSize = true;
            this.label_parking.Location = new System.Drawing.Point(6, 110);
            this.label_parking.Name = "label_parking";
            this.label_parking.Size = new System.Drawing.Size(57, 13);
            this.label_parking.TabIndex = 3;
            this.label_parking.Text = "Парковка";
            // 
            // label_working_time
            // 
            this.label_working_time.AutoSize = true;
            this.label_working_time.Location = new System.Drawing.Point(6, 132);
            this.label_working_time.Name = "label_working_time";
            this.label_working_time.Size = new System.Drawing.Size(80, 13);
            this.label_working_time.TabIndex = 4;
            this.label_working_time.Text = "Время работы";
            // 
            // label_name_place
            // 
            this.label_name_place.AutoSize = true;
            this.label_name_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_name_place.Location = new System.Drawing.Point(21, 9);
            this.label_name_place.Name = "label_name_place";
            this.label_name_place.Size = new System.Drawing.Size(91, 20);
            this.label_name_place.TabIndex = 5;
            this.label_name_place.Text = "Название";
            // 
            // groupBox_address_place
            // 
            this.groupBox_address_place.Controls.Add(this.label_country);
            this.groupBox_address_place.Controls.Add(this.label_city);
            this.groupBox_address_place.Controls.Add(this.label_house);
            this.groupBox_address_place.Controls.Add(this.label_street);
            this.groupBox_address_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_address_place.Location = new System.Drawing.Point(283, 65);
            this.groupBox_address_place.Name = "groupBox_address_place";
            this.groupBox_address_place.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_address_place.Size = new System.Drawing.Size(214, 159);
            this.groupBox_address_place.TabIndex = 6;
            this.groupBox_address_place.TabStop = false;
            this.groupBox_address_place.Text = "Адрес";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(6, 30);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(43, 13);
            this.label_country.TabIndex = 1;
            this.label_country.Text = "Страна";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(6, 54);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(37, 13);
            this.label_city.TabIndex = 2;
            this.label_city.Text = "Город";
            // 
            // label_house
            // 
            this.label_house.AutoSize = true;
            this.label_house.Location = new System.Drawing.Point(6, 110);
            this.label_house.Name = "label_house";
            this.label_house.Size = new System.Drawing.Size(30, 13);
            this.label_house.TabIndex = 4;
            this.label_house.Text = "Дом";
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(6, 82);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(39, 13);
            this.label_street.TabIndex = 3;
            this.label_street.Text = "Улица";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(289, 197);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(52, 13);
            this.label_tel.TabIndex = 5;
            this.label_tel.Text = "Телефон";
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.label_type_place);
            this.groupBox_info.Controls.Add(this.label_id);
            this.groupBox_info.Controls.Add(this.label_pay_card);
            this.groupBox_info.Controls.Add(this.label_parking);
            this.groupBox_info.Controls.Add(this.label_working_time);
            this.groupBox_info.Location = new System.Drawing.Point(12, 65);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(229, 159);
            this.groupBox_info.TabIndex = 7;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Информация";
            // 
            // label_type_place
            // 
            this.label_type_place.AutoSize = true;
            this.label_type_place.Location = new System.Drawing.Point(6, 54);
            this.label_type_place.Name = "label_type_place";
            this.label_type_place.Size = new System.Drawing.Size(38, 13);
            this.label_type_place.TabIndex = 5;
            this.label_type_place.Text = "id type";
            // 
            // linkLabel_events_here
            // 
            this.linkLabel_events_here.AutoSize = true;
            this.linkLabel_events_here.Location = new System.Drawing.Point(328, 245);
            this.linkLabel_events_here.Name = "linkLabel_events_here";
            this.linkLabel_events_here.Size = new System.Drawing.Size(169, 13);
            this.linkLabel_events_here.TabIndex = 8;
            this.linkLabel_events_here.TabStop = true;
            this.linkLabel_events_here.Text = "Мероприятия в этом заведении";
            // 
            // linkLabel_feedback_place
            // 
            this.linkLabel_feedback_place.AutoSize = true;
            this.linkLabel_feedback_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_feedback_place.Location = new System.Drawing.Point(511, 243);
            this.linkLabel_feedback_place.Name = "linkLabel_feedback_place";
            this.linkLabel_feedback_place.Size = new System.Drawing.Size(45, 15);
            this.linkLabel_feedback_place.TabIndex = 9;
            this.linkLabel_feedback_place.TabStop = true;
            this.linkLabel_feedback_place.Text = "Отзыв";
            this.linkLabel_feedback_place.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_feedback_place_LinkClicked);
            // 
            // label_count_feedback
            // 
            this.label_count_feedback.AutoSize = true;
            this.label_count_feedback.Location = new System.Drawing.Point(411, 14);
            this.label_count_feedback.Name = "label_count_feedback";
            this.label_count_feedback.Size = new System.Drawing.Size(112, 13);
            this.label_count_feedback.TabIndex = 10;
            this.label_count_feedback.Text = "Количество отзывов";
            // 
            // label_avg_rate
            // 
            this.label_avg_rate.AutoSize = true;
            this.label_avg_rate.Location = new System.Drawing.Point(179, 243);
            this.label_avg_rate.Name = "label_avg_rate";
            this.label_avg_rate.Size = new System.Drawing.Size(72, 13);
            this.label_avg_rate.TabIndex = 12;
            this.label_avg_rate.Text = "AVG рейтинг";
            // 
            // InfoPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 265);
            this.Controls.Add(this.label_avg_rate);
            this.Controls.Add(this.label_count_feedback);
            this.Controls.Add(this.linkLabel_feedback_place);
            this.Controls.Add(this.linkLabel_events_here);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox_address_place);
            this.Controls.Add(this.label_name_place);
            this.Controls.Add(this.label_count);
            this.Name = "InfoPlace";
            this.Text = "InfoPlace";
            this.Load += new System.EventHandler(this.InfoPlace_Load);
            this.groupBox_address_place.ResumeLayout(false);
            this.groupBox_address_place.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_pay_card;
        private System.Windows.Forms.Label label_parking;
        private System.Windows.Forms.Label label_working_time;
        private System.Windows.Forms.GroupBox groupBox_address_place;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_house;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.LinkLabel linkLabel_events_here;
        private System.Windows.Forms.LinkLabel linkLabel_feedback_place;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_count_feedback;
        public System.Windows.Forms.Label label_name_place;
        public System.Windows.Forms.Label label_type_place;
        private System.Windows.Forms.Label label_avg_rate;
    }
}