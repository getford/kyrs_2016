namespace kyrsovik
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listView_event = new System.Windows.Forms.ListView();
            this.listView_place = new System.Windows.Forms.ListView();
            this.groupBox_event = new System.Windows.Forms.GroupBox();
            this.groupBox_add_event = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_event = new System.Windows.Forms.DateTimePicker();
            this.button_add_event = new System.Windows.Forms.Button();
            this.label_age_event = new System.Windows.Forms.Label();
            this.comboBox_age = new System.Windows.Forms.ComboBox();
            this.label_date_event = new System.Windows.Forms.Label();
            this.label_place = new System.Windows.Forms.Label();
            this.comboBox_event_place = new System.Windows.Forms.ComboBox();
            this.label_type_event = new System.Windows.Forms.Label();
            this.comboBox_type_event = new System.Windows.Forms.ComboBox();
            this.textBox_name_event = new System.Windows.Forms.TextBox();
            this.label_name_event = new System.Windows.Forms.Label();
            this.groupBox_place = new System.Windows.Forms.GroupBox();
            this.groupBox_add_place = new System.Windows.Forms.GroupBox();
            this.label_street = new System.Windows.Forms.Label();
            this.label_time_working = new System.Windows.Forms.Label();
            this.textBox_time_work = new System.Windows.Forms.TextBox();
            this.label_parking = new System.Windows.Forms.Label();
            this.textBox_name_palce = new System.Windows.Forms.TextBox();
            this.label_type_place = new System.Windows.Forms.Label();
            this.label_pay_card = new System.Windows.Forms.Label();
            this.button_add_place = new System.Windows.Forms.Button();
            this.comboBox_type_place = new System.Windows.Forms.ComboBox();
            this.label_house = new System.Windows.Forms.Label();
            this.comboBox_parking = new System.Windows.Forms.ComboBox();
            this.label_name_place = new System.Windows.Forms.Label();
            this.comboBox_pay_card = new System.Windows.Forms.ComboBox();
            this.label_tel = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox_house = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.groupBox_event.SuspendLayout();
            this.groupBox_add_event.SuspendLayout();
            this.groupBox_place.SuspendLayout();
            this.groupBox_add_place.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_event
            // 
            this.listView_event.Location = new System.Drawing.Point(797, 12);
            this.listView_event.Name = "listView_event";
            this.listView_event.Size = new System.Drawing.Size(386, 565);
            this.listView_event.TabIndex = 2;
            this.listView_event.UseCompatibleStateImageBehavior = false;
            this.listView_event.View = System.Windows.Forms.View.Details;
            this.listView_event.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_event_MouseClick);
            // 
            // listView_place
            // 
            this.listView_place.Location = new System.Drawing.Point(12, 300);
            this.listView_place.Name = "listView_place";
            this.listView_place.Size = new System.Drawing.Size(779, 277);
            this.listView_place.TabIndex = 3;
            this.listView_place.UseCompatibleStateImageBehavior = false;
            this.listView_place.View = System.Windows.Forms.View.Details;
            this.listView_place.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_place_MouseClick);
            // 
            // groupBox_event
            // 
            this.groupBox_event.Controls.Add(this.groupBox_add_event);
            this.groupBox_event.Location = new System.Drawing.Point(12, 173);
            this.groupBox_event.Name = "groupBox_event";
            this.groupBox_event.Size = new System.Drawing.Size(779, 121);
            this.groupBox_event.TabIndex = 4;
            this.groupBox_event.TabStop = false;
            this.groupBox_event.Text = "Event";
            // 
            // groupBox_add_event
            // 
            this.groupBox_add_event.Controls.Add(this.dateTimePicker_event);
            this.groupBox_add_event.Controls.Add(this.button_add_event);
            this.groupBox_add_event.Controls.Add(this.label_age_event);
            this.groupBox_add_event.Controls.Add(this.comboBox_age);
            this.groupBox_add_event.Controls.Add(this.label_date_event);
            this.groupBox_add_event.Controls.Add(this.label_place);
            this.groupBox_add_event.Controls.Add(this.comboBox_event_place);
            this.groupBox_add_event.Controls.Add(this.label_type_event);
            this.groupBox_add_event.Controls.Add(this.comboBox_type_event);
            this.groupBox_add_event.Controls.Add(this.textBox_name_event);
            this.groupBox_add_event.Controls.Add(this.label_name_event);
            this.groupBox_add_event.Location = new System.Drawing.Point(6, 19);
            this.groupBox_add_event.Name = "groupBox_add_event";
            this.groupBox_add_event.Size = new System.Drawing.Size(763, 96);
            this.groupBox_add_event.TabIndex = 0;
            this.groupBox_add_event.TabStop = false;
            this.groupBox_add_event.Text = "Add event";
            // 
            // dateTimePicker_event
            // 
            this.dateTimePicker_event.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_event.Location = new System.Drawing.Point(459, 40);
            this.dateTimePicker_event.Name = "dateTimePicker_event";
            this.dateTimePicker_event.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_event.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_event.TabIndex = 18;
            this.dateTimePicker_event.Value = new System.DateTime(2016, 11, 10, 10, 42, 38, 0);
            // 
            // button_add_event
            // 
            this.button_add_event.Location = new System.Drawing.Point(6, 66);
            this.button_add_event.Name = "button_add_event";
            this.button_add_event.Size = new System.Drawing.Size(745, 20);
            this.button_add_event.TabIndex = 11;
            this.button_add_event.Text = "OK";
            this.button_add_event.UseVisualStyleBackColor = true;
            this.button_add_event.Click += new System.EventHandler(this.button_add_event_Click);
            // 
            // label_age_event
            // 
            this.label_age_event.AutoSize = true;
            this.label_age_event.Location = new System.Drawing.Point(605, 24);
            this.label_age_event.Name = "label_age_event";
            this.label_age_event.Size = new System.Drawing.Size(26, 13);
            this.label_age_event.TabIndex = 17;
            this.label_age_event.Text = "Age";
            // 
            // comboBox_age
            // 
            this.comboBox_age.FormattingEnabled = true;
            this.comboBox_age.Location = new System.Drawing.Point(608, 40);
            this.comboBox_age.Name = "comboBox_age";
            this.comboBox_age.Size = new System.Drawing.Size(143, 21);
            this.comboBox_age.TabIndex = 16;
            // 
            // label_date_event
            // 
            this.label_date_event.AutoSize = true;
            this.label_date_event.Location = new System.Drawing.Point(461, 23);
            this.label_date_event.Name = "label_date_event";
            this.label_date_event.Size = new System.Drawing.Size(30, 13);
            this.label_date_event.TabIndex = 14;
            this.label_date_event.Text = "Date";
            // 
            // label_place
            // 
            this.label_place.AutoSize = true;
            this.label_place.Location = new System.Drawing.Point(157, 23);
            this.label_place.Name = "label_place";
            this.label_place.Size = new System.Drawing.Size(34, 13);
            this.label_place.TabIndex = 13;
            this.label_place.Text = "Place";
            // 
            // comboBox_event_place
            // 
            this.comboBox_event_place.FormattingEnabled = true;
            this.comboBox_event_place.Location = new System.Drawing.Point(157, 40);
            this.comboBox_event_place.Name = "comboBox_event_place";
            this.comboBox_event_place.Size = new System.Drawing.Size(143, 21);
            this.comboBox_event_place.TabIndex = 12;
            // 
            // label_type_event
            // 
            this.label_type_event.AutoSize = true;
            this.label_type_event.Location = new System.Drawing.Point(309, 24);
            this.label_type_event.Name = "label_type_event";
            this.label_type_event.Size = new System.Drawing.Size(31, 13);
            this.label_type_event.TabIndex = 11;
            this.label_type_event.Text = "Type";
            // 
            // comboBox_type_event
            // 
            this.comboBox_type_event.FormattingEnabled = true;
            this.comboBox_type_event.Location = new System.Drawing.Point(309, 40);
            this.comboBox_type_event.Name = "comboBox_type_event";
            this.comboBox_type_event.Size = new System.Drawing.Size(143, 21);
            this.comboBox_type_event.TabIndex = 10;
            // 
            // textBox_name_event
            // 
            this.textBox_name_event.Location = new System.Drawing.Point(6, 40);
            this.textBox_name_event.Name = "textBox_name_event";
            this.textBox_name_event.Size = new System.Drawing.Size(143, 20);
            this.textBox_name_event.TabIndex = 9;
            // 
            // label_name_event
            // 
            this.label_name_event.AutoSize = true;
            this.label_name_event.Location = new System.Drawing.Point(8, 23);
            this.label_name_event.Name = "label_name_event";
            this.label_name_event.Size = new System.Drawing.Size(35, 13);
            this.label_name_event.TabIndex = 8;
            this.label_name_event.Text = "Name";
            // 
            // groupBox_place
            // 
            this.groupBox_place.Controls.Add(this.groupBox_add_place);
            this.groupBox_place.Location = new System.Drawing.Point(12, 12);
            this.groupBox_place.Name = "groupBox_place";
            this.groupBox_place.Size = new System.Drawing.Size(779, 155);
            this.groupBox_place.TabIndex = 5;
            this.groupBox_place.TabStop = false;
            this.groupBox_place.Text = "Place";
            // 
            // groupBox_add_place
            // 
            this.groupBox_add_place.Controls.Add(this.label_street);
            this.groupBox_add_place.Controls.Add(this.label_time_working);
            this.groupBox_add_place.Controls.Add(this.textBox_time_work);
            this.groupBox_add_place.Controls.Add(this.label_parking);
            this.groupBox_add_place.Controls.Add(this.textBox_name_palce);
            this.groupBox_add_place.Controls.Add(this.label_type_place);
            this.groupBox_add_place.Controls.Add(this.label_pay_card);
            this.groupBox_add_place.Controls.Add(this.button_add_place);
            this.groupBox_add_place.Controls.Add(this.comboBox_type_place);
            this.groupBox_add_place.Controls.Add(this.label_house);
            this.groupBox_add_place.Controls.Add(this.comboBox_parking);
            this.groupBox_add_place.Controls.Add(this.label_name_place);
            this.groupBox_add_place.Controls.Add(this.comboBox_pay_card);
            this.groupBox_add_place.Controls.Add(this.label_tel);
            this.groupBox_add_place.Controls.Add(this.textBox_street);
            this.groupBox_add_place.Controls.Add(this.textBox_house);
            this.groupBox_add_place.Controls.Add(this.textBox_tel);
            this.groupBox_add_place.Location = new System.Drawing.Point(6, 19);
            this.groupBox_add_place.Name = "groupBox_add_place";
            this.groupBox_add_place.Size = new System.Drawing.Size(763, 130);
            this.groupBox_add_place.TabIndex = 6;
            this.groupBox_add_place.TabStop = false;
            this.groupBox_add_place.Text = "Add place";
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(6, 72);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(35, 13);
            this.label_street.TabIndex = 10;
            this.label_street.Text = "Street";
            // 
            // label_time_working
            // 
            this.label_time_working.AutoSize = true;
            this.label_time_working.Location = new System.Drawing.Point(605, 26);
            this.label_time_working.Name = "label_time_working";
            this.label_time_working.Size = new System.Drawing.Size(70, 13);
            this.label_time_working.TabIndex = 9;
            this.label_time_working.Text = "Time working";
            // 
            // textBox_time_work
            // 
            this.textBox_time_work.Location = new System.Drawing.Point(608, 42);
            this.textBox_time_work.Name = "textBox_time_work";
            this.textBox_time_work.Size = new System.Drawing.Size(143, 20);
            this.textBox_time_work.TabIndex = 8;
            // 
            // label_parking
            // 
            this.label_parking.AutoSize = true;
            this.label_parking.Location = new System.Drawing.Point(456, 26);
            this.label_parking.Name = "label_parking";
            this.label_parking.Size = new System.Drawing.Size(43, 13);
            this.label_parking.TabIndex = 6;
            this.label_parking.Text = "Parking";
            // 
            // textBox_name_palce
            // 
            this.textBox_name_palce.Location = new System.Drawing.Point(6, 43);
            this.textBox_name_palce.Name = "textBox_name_palce";
            this.textBox_name_palce.Size = new System.Drawing.Size(143, 20);
            this.textBox_name_palce.TabIndex = 7;
            // 
            // label_type_place
            // 
            this.label_type_place.AutoSize = true;
            this.label_type_place.Location = new System.Drawing.Point(157, 26);
            this.label_type_place.Name = "label_type_place";
            this.label_type_place.Size = new System.Drawing.Size(31, 13);
            this.label_type_place.TabIndex = 5;
            this.label_type_place.Text = "Type";
            // 
            // label_pay_card
            // 
            this.label_pay_card.AutoSize = true;
            this.label_pay_card.Location = new System.Drawing.Point(306, 26);
            this.label_pay_card.Name = "label_pay_card";
            this.label_pay_card.Size = new System.Drawing.Size(49, 13);
            this.label_pay_card.TabIndex = 4;
            this.label_pay_card.Text = "Pay card";
            // 
            // button_add_place
            // 
            this.button_add_place.Location = new System.Drawing.Point(459, 88);
            this.button_add_place.Name = "button_add_place";
            this.button_add_place.Size = new System.Drawing.Size(292, 20);
            this.button_add_place.TabIndex = 6;
            this.button_add_place.Text = "OK";
            this.button_add_place.UseVisualStyleBackColor = true;
            this.button_add_place.Click += new System.EventHandler(this.button_add_place_Click);
            // 
            // comboBox_type_place
            // 
            this.comboBox_type_place.FormattingEnabled = true;
            this.comboBox_type_place.Location = new System.Drawing.Point(157, 42);
            this.comboBox_type_place.Name = "comboBox_type_place";
            this.comboBox_type_place.Size = new System.Drawing.Size(143, 21);
            this.comboBox_type_place.TabIndex = 0;
            // 
            // label_house
            // 
            this.label_house.AutoSize = true;
            this.label_house.Location = new System.Drawing.Point(157, 72);
            this.label_house.Name = "label_house";
            this.label_house.Size = new System.Drawing.Size(38, 13);
            this.label_house.TabIndex = 5;
            this.label_house.Text = "House";
            // 
            // comboBox_parking
            // 
            this.comboBox_parking.FormattingEnabled = true;
            this.comboBox_parking.Location = new System.Drawing.Point(459, 42);
            this.comboBox_parking.Name = "comboBox_parking";
            this.comboBox_parking.Size = new System.Drawing.Size(143, 21);
            this.comboBox_parking.TabIndex = 2;
            // 
            // label_name_place
            // 
            this.label_name_place.AutoSize = true;
            this.label_name_place.Location = new System.Drawing.Point(8, 26);
            this.label_name_place.Name = "label_name_place";
            this.label_name_place.Size = new System.Drawing.Size(35, 13);
            this.label_name_place.TabIndex = 3;
            this.label_name_place.Text = "Name";
            // 
            // comboBox_pay_card
            // 
            this.comboBox_pay_card.FormattingEnabled = true;
            this.comboBox_pay_card.Location = new System.Drawing.Point(309, 42);
            this.comboBox_pay_card.Name = "comboBox_pay_card";
            this.comboBox_pay_card.Size = new System.Drawing.Size(143, 21);
            this.comboBox_pay_card.TabIndex = 1;
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(306, 72);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(52, 13);
            this.label_tel.TabIndex = 4;
            this.label_tel.Text = "Telphone";
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(6, 88);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(143, 20);
            this.textBox_street.TabIndex = 0;
            // 
            // textBox_house
            // 
            this.textBox_house.Location = new System.Drawing.Point(157, 88);
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(143, 20);
            this.textBox_house.TabIndex = 1;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(309, 88);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(143, 20);
            this.textBox_tel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 594);
            this.Controls.Add(this.groupBox_place);
            this.Controls.Add(this.groupBox_event);
            this.Controls.Add(this.listView_place);
            this.Controls.Add(this.listView_event);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox_event.ResumeLayout(false);
            this.groupBox_add_event.ResumeLayout(false);
            this.groupBox_add_event.PerformLayout();
            this.groupBox_place.ResumeLayout(false);
            this.groupBox_add_place.ResumeLayout(false);
            this.groupBox_add_place.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_event;
        private System.Windows.Forms.GroupBox groupBox_event;
        private System.Windows.Forms.GroupBox groupBox_place;
        private System.Windows.Forms.GroupBox groupBox_add_place;
        private System.Windows.Forms.GroupBox groupBox_add_event;
        public System.Windows.Forms.Label label_age_event;
        public System.Windows.Forms.ComboBox comboBox_age;
        public System.Windows.Forms.Label label_date_event;
        public System.Windows.Forms.Label label_place;
        public System.Windows.Forms.ComboBox comboBox_event_place;
        public System.Windows.Forms.Label label_type_event;
        public System.Windows.Forms.ComboBox comboBox_type_event;
        public System.Windows.Forms.TextBox textBox_name_event;
        public System.Windows.Forms.Label label_name_event;
        public System.Windows.Forms.Button button_add_event;
        private System.Windows.Forms.DateTimePicker dateTimePicker_event;
        public System.Windows.Forms.ListView listView_place;
        private System.Windows.Forms.Label label_house;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_name_place;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_house;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label_parking;
        private System.Windows.Forms.Label label_type_place;
        private System.Windows.Forms.Label label_pay_card;
        private System.Windows.Forms.ComboBox comboBox_parking;
        private System.Windows.Forms.ComboBox comboBox_pay_card;
        private System.Windows.Forms.ComboBox comboBox_type_place;
        private System.Windows.Forms.Button button_add_place;
        private System.Windows.Forms.TextBox textBox_name_palce;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.Label label_time_working;
        private System.Windows.Forms.TextBox textBox_time_work;
    }
}

