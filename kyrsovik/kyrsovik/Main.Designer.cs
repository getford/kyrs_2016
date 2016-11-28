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
            this.label_check_db_connect = new System.Windows.Forms.Label();
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
            this.groupBox_select_event = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_count_eft = new System.Windows.Forms.Label();
            this.comboBox_type_for_select = new System.Windows.Forms.ComboBox();
            this.button_select = new System.Windows.Forms.Button();
            this.groupBox_bestEvent = new System.Windows.Forms.GroupBox();
            this.radioButton_start_to_end_date_event = new System.Windows.Forms.RadioButton();
            this.radioButton_for_date = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.button_selectBestEvent = new System.Windows.Forms.Button();
            this.radioButton_bestEvent = new System.Windows.Forms.RadioButton();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.label_count_event = new System.Windows.Forms.Label();
            this.label_count_place = new System.Windows.Forms.Label();
            this.label_count_feedback = new System.Windows.Forms.Label();
            this.label_n_select_count = new System.Windows.Forms.Label();
            this.comboBox_show_n_event = new System.Windows.Forms.ComboBox();
            this.button_show_n_event = new System.Windows.Forms.Button();
            this._label_time = new System.Windows.Forms.Label();
            this.label_count_event_date_rate = new System.Windows.Forms.Label();
            this.groupBox_event.SuspendLayout();
            this.groupBox_add_event.SuspendLayout();
            this.groupBox_place.SuspendLayout();
            this.groupBox_add_place.SuspendLayout();
            this.groupBox_select_event.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_bestEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_event
            // 
            this.listView_event.Location = new System.Drawing.Point(12, 315);
            this.listView_event.Name = "listView_event";
            this.listView_event.Size = new System.Drawing.Size(779, 294);
            this.listView_event.TabIndex = 2;
            this.listView_event.UseCompatibleStateImageBehavior = false;
            this.listView_event.View = System.Windows.Forms.View.Details;
            this.listView_event.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_event_MouseClick);
            // 
            // listView_place
            // 
            this.listView_place.Location = new System.Drawing.Point(797, 315);
            this.listView_place.Name = "listView_place";
            this.listView_place.Size = new System.Drawing.Size(387, 294);
            this.listView_place.TabIndex = 3;
            this.listView_place.UseCompatibleStateImageBehavior = false;
            this.listView_place.View = System.Windows.Forms.View.Details;
            this.listView_place.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_place_MouseClick);
            // 
            // groupBox_event
            // 
            this.groupBox_event.Controls.Add(this.groupBox_add_event);
            this.groupBox_event.Location = new System.Drawing.Point(12, 188);
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
            // label_check_db_connect
            // 
            this.label_check_db_connect.AutoSize = true;
            this.label_check_db_connect.Location = new System.Drawing.Point(12, 9);
            this.label_check_db_connect.Name = "label_check_db_connect";
            this.label_check_db_connect.Size = new System.Drawing.Size(92, 13);
            this.label_check_db_connect.TabIndex = 21;
            this.label_check_db_connect.Text = "Соединение с бд";
            // 
            // groupBox_place
            // 
            this.groupBox_place.Controls.Add(this.groupBox_add_place);
            this.groupBox_place.Location = new System.Drawing.Point(12, 27);
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
            this.label_name_place.Location = new System.Drawing.Point(6, 26);
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
            this.label_tel.Size = new System.Drawing.Size(58, 13);
            this.label_tel.TabIndex = 4;
            this.label_tel.Text = "Telephone";
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
            // groupBox_select_event
            // 
            this.groupBox_select_event.Controls.Add(this.groupBox1);
            this.groupBox_select_event.Controls.Add(this.groupBox_bestEvent);
            this.groupBox_select_event.Controls.Add(this.button_refresh);
            this.groupBox_select_event.Location = new System.Drawing.Point(798, 27);
            this.groupBox_select_event.Name = "groupBox_select_event";
            this.groupBox_select_event.Size = new System.Drawing.Size(386, 282);
            this.groupBox_select_event.TabIndex = 6;
            this.groupBox_select_event.TabStop = false;
            this.groupBox_select_event.Text = "Выборка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_count_eft);
            this.groupBox1.Controls.Add(this.comboBox_type_for_select);
            this.groupBox1.Controls.Add(this.button_select);
            this.groupBox1.Location = new System.Drawing.Point(6, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 56);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "По типу мероприятия";
            // 
            // label_count_eft
            // 
            this.label_count_eft.AutoSize = true;
            this.label_count_eft.Location = new System.Drawing.Point(123, 26);
            this.label_count_eft.Name = "label_count_eft";
            this.label_count_eft.Size = new System.Drawing.Size(112, 13);
            this.label_count_eft.TabIndex = 13;
            this.label_count_eft.Text = "Число мероприятий:";
            // 
            // comboBox_type_for_select
            // 
            this.comboBox_type_for_select.FormattingEnabled = true;
            this.comboBox_type_for_select.Location = new System.Drawing.Point(6, 23);
            this.comboBox_type_for_select.Name = "comboBox_type_for_select";
            this.comboBox_type_for_select.Size = new System.Drawing.Size(111, 21);
            this.comboBox_type_for_select.TabIndex = 11;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(286, 21);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(76, 23);
            this.button_select.TabIndex = 12;
            this.button_select.Text = "Показать";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // groupBox_bestEvent
            // 
            this.groupBox_bestEvent.Controls.Add(this.label_count_event_date_rate);
            this.groupBox_bestEvent.Controls.Add(this.radioButton_start_to_end_date_event);
            this.groupBox_bestEvent.Controls.Add(this.radioButton_for_date);
            this.groupBox_bestEvent.Controls.Add(this.dateTimePicker_end);
            this.groupBox_bestEvent.Controls.Add(this.dateTimePicker_start);
            this.groupBox_bestEvent.Controls.Add(this.button_selectBestEvent);
            this.groupBox_bestEvent.Controls.Add(this.radioButton_bestEvent);
            this.groupBox_bestEvent.Location = new System.Drawing.Point(12, 19);
            this.groupBox_bestEvent.Name = "groupBox_bestEvent";
            this.groupBox_bestEvent.Size = new System.Drawing.Size(368, 165);
            this.groupBox_bestEvent.TabIndex = 15;
            this.groupBox_bestEvent.TabStop = false;
            this.groupBox_bestEvent.Text = "Лучшие мероприятия";
            // 
            // radioButton_start_to_end_date_event
            // 
            this.radioButton_start_to_end_date_event.AutoSize = true;
            this.radioButton_start_to_end_date_event.Location = new System.Drawing.Point(93, 48);
            this.radioButton_start_to_end_date_event.Name = "radioButton_start_to_end_date_event";
            this.radioButton_start_to_end_date_event.Size = new System.Drawing.Size(220, 17);
            this.radioButton_start_to_end_date_event.TabIndex = 22;
            this.radioButton_start_to_end_date_event.TabStop = true;
            this.radioButton_start_to_end_date_event.Text = "Мероприятия за промежуток времени";
            this.radioButton_start_to_end_date_event.UseVisualStyleBackColor = true;
            // 
            // radioButton_for_date
            // 
            this.radioButton_for_date.AutoSize = true;
            this.radioButton_for_date.Location = new System.Drawing.Point(187, 25);
            this.radioButton_for_date.Name = "radioButton_for_date";
            this.radioButton_for_date.Size = new System.Drawing.Size(174, 17);
            this.radioButton_for_date.TabIndex = 21;
            this.radioButton_for_date.TabStop = true;
            this.radioButton_for_date.Text = "Лучшие мероприятия по дате";
            this.radioButton_for_date.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_end.Location = new System.Drawing.Point(218, 87);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_end.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_end.TabIndex = 20;
            this.dateTimePicker_end.Value = new System.DateTime(2016, 11, 28, 0, 0, 0, 0);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(6, 87);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_start.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_start.TabIndex = 19;
            this.dateTimePicker_start.Value = new System.DateTime(2016, 11, 28, 0, 0, 0, 0);
            // 
            // button_selectBestEvent
            // 
            this.button_selectBestEvent.Location = new System.Drawing.Point(6, 136);
            this.button_selectBestEvent.Name = "button_selectBestEvent";
            this.button_selectBestEvent.Size = new System.Drawing.Size(355, 23);
            this.button_selectBestEvent.TabIndex = 14;
            this.button_selectBestEvent.Text = "Показать";
            this.button_selectBestEvent.UseVisualStyleBackColor = true;
            this.button_selectBestEvent.Click += new System.EventHandler(this.button_selectBestEvent_Click);
            // 
            // radioButton_bestEvent
            // 
            this.radioButton_bestEvent.AutoSize = true;
            this.radioButton_bestEvent.Location = new System.Drawing.Point(6, 25);
            this.radioButton_bestEvent.Name = "radioButton_bestEvent";
            this.radioButton_bestEvent.Size = new System.Drawing.Size(153, 17);
            this.radioButton_bestEvent.TabIndex = 0;
            this.radioButton_bestEvent.TabStop = true;
            this.radioButton_bestEvent.Text = "Все лучшие мероприятия";
            this.radioButton_bestEvent.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(6, 252);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(374, 23);
            this.button_refresh.TabIndex = 13;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_info.Location = new System.Drawing.Point(26, 636);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(87, 13);
            this.label_info.TabIndex = 7;
            this.label_info.Text = "Инфо о курсаче";
            // 
            // label_count_event
            // 
            this.label_count_event.AutoSize = true;
            this.label_count_event.Location = new System.Drawing.Point(795, 612);
            this.label_count_event.Name = "label_count_event";
            this.label_count_event.Size = new System.Drawing.Size(109, 13);
            this.label_count_event.TabIndex = 8;
            this.label_count_event.Text = "Число мероприятий";
            // 
            // label_count_place
            // 
            this.label_count_place.AutoSize = true;
            this.label_count_place.Location = new System.Drawing.Point(975, 612);
            this.label_count_place.Name = "label_count_place";
            this.label_count_place.Size = new System.Drawing.Size(67, 13);
            this.label_count_place.TabIndex = 9;
            this.label_count_place.Text = "Число мест";
            // 
            // label_count_feedback
            // 
            this.label_count_feedback.AutoSize = true;
            this.label_count_feedback.Location = new System.Drawing.Point(795, 636);
            this.label_count_feedback.Name = "label_count_feedback";
            this.label_count_feedback.Size = new System.Drawing.Size(85, 13);
            this.label_count_feedback.TabIndex = 10;
            this.label_count_feedback.Text = "Число отзывов";
            // 
            // label_n_select_count
            // 
            this.label_n_select_count.AutoSize = true;
            this.label_n_select_count.Location = new System.Drawing.Point(12, 612);
            this.label_n_select_count.Name = "label_n_select_count";
            this.label_n_select_count.Size = new System.Drawing.Size(95, 13);
            this.label_n_select_count.TabIndex = 11;
            this.label_n_select_count.Text = "Показать записи";
            // 
            // comboBox_show_n_event
            // 
            this.comboBox_show_n_event.FormattingEnabled = true;
            this.comboBox_show_n_event.Location = new System.Drawing.Point(113, 612);
            this.comboBox_show_n_event.Name = "comboBox_show_n_event";
            this.comboBox_show_n_event.Size = new System.Drawing.Size(93, 21);
            this.comboBox_show_n_event.TabIndex = 19;
            // 
            // button_show_n_event
            // 
            this.button_show_n_event.Location = new System.Drawing.Point(212, 613);
            this.button_show_n_event.Name = "button_show_n_event";
            this.button_show_n_event.Size = new System.Drawing.Size(89, 20);
            this.button_show_n_event.TabIndex = 19;
            this.button_show_n_event.Text = "Показать";
            this.button_show_n_event.UseVisualStyleBackColor = true;
            this.button_show_n_event.Click += new System.EventHandler(this.button_show_n_event_Click);
            // 
            // _label_time
            // 
            this._label_time.AutoSize = true;
            this._label_time.Location = new System.Drawing.Point(324, 617);
            this._label_time.Name = "_label_time";
            this._label_time.Size = new System.Drawing.Size(105, 13);
            this._label_time.TabIndex = 20;
            this._label_time.Text = "Время выполнения";
            // 
            // label_count_event_date_rate
            // 
            this.label_count_event_date_rate.AutoSize = true;
            this.label_count_event_date_rate.Location = new System.Drawing.Point(90, 117);
            this.label_count_event_date_rate.Name = "label_count_event_date_rate";
            this.label_count_event_date_rate.Size = new System.Drawing.Size(112, 13);
            this.label_count_event_date_rate.TabIndex = 23;
            this.label_count_event_date_rate.Text = "Число мероприятий:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 660);
            this.Controls.Add(this.label_check_db_connect);
            this.Controls.Add(this._label_time);
            this.Controls.Add(this.button_show_n_event);
            this.Controls.Add(this.comboBox_show_n_event);
            this.Controls.Add(this.label_n_select_count);
            this.Controls.Add(this.label_count_feedback);
            this.Controls.Add(this.label_count_place);
            this.Controls.Add(this.label_count_event);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.groupBox_select_event);
            this.Controls.Add(this.groupBox_place);
            this.Controls.Add(this.groupBox_event);
            this.Controls.Add(this.listView_place);
            this.Controls.Add(this.listView_event);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox_event.ResumeLayout(false);
            this.groupBox_add_event.ResumeLayout(false);
            this.groupBox_add_event.PerformLayout();
            this.groupBox_place.ResumeLayout(false);
            this.groupBox_add_place.ResumeLayout(false);
            this.groupBox_add_place.PerformLayout();
            this.groupBox_select_event.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_bestEvent.ResumeLayout(false);
            this.groupBox_bestEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public System.Windows.Forms.ListView listView_event;
        private System.Windows.Forms.GroupBox groupBox_select_event;
        private System.Windows.Forms.RadioButton radioButton_bestEvent;
        public System.Windows.Forms.ComboBox comboBox_type_for_select;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_selectBestEvent;
        private System.Windows.Forms.GroupBox groupBox_bestEvent;
        private System.Windows.Forms.RadioButton radioButton_for_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_start_to_end_date_event;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_count_event;
        private System.Windows.Forms.Label label_count_place;
        private System.Windows.Forms.Label label_count_feedback;
        private System.Windows.Forms.Label label_n_select_count;
        public System.Windows.Forms.ComboBox comboBox_show_n_event;
        public System.Windows.Forms.Button button_show_n_event;
        private System.Windows.Forms.Label _label_time;
        private System.Windows.Forms.Label label_count_eft;
        private System.Windows.Forms.Label label_check_db_connect;
        private System.Windows.Forms.Label label_count_event_date_rate;
    }
}

