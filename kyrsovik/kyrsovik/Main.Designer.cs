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
            this.groupBox_place = new System.Windows.Forms.GroupBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox_house = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label_street = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_house = new System.Windows.Forms.Label();
            this.groupBox_add_place = new System.Windows.Forms.GroupBox();
            this.groupBox_get_place = new System.Windows.Forms.GroupBox();
            this.comboBox_type_place = new System.Windows.Forms.ComboBox();
            this.comboBox_pay_card = new System.Windows.Forms.ComboBox();
            this.comboBox_parking = new System.Windows.Forms.ComboBox();
            this.label_pay_card = new System.Windows.Forms.Label();
            this.label_type_place = new System.Windows.Forms.Label();
            this.label_parking = new System.Windows.Forms.Label();
            this.groupBox_add_event = new System.Windows.Forms.GroupBox();
            this.button_add_place = new System.Windows.Forms.Button();
            this.button_get_place = new System.Windows.Forms.Button();
            this.groupBox_event.SuspendLayout();
            this.groupBox_place.SuspendLayout();
            this.groupBox_add_place.SuspendLayout();
            this.groupBox_get_place.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_event
            // 
            this.listView_event.Location = new System.Drawing.Point(12, 211);
            this.listView_event.Name = "listView_event";
            this.listView_event.Size = new System.Drawing.Size(248, 403);
            this.listView_event.TabIndex = 2;
            this.listView_event.UseCompatibleStateImageBehavior = false;
            this.listView_event.View = System.Windows.Forms.View.Details;
            // 
            // listView_place
            // 
            this.listView_place.Location = new System.Drawing.Point(266, 211);
            this.listView_place.Name = "listView_place";
            this.listView_place.Size = new System.Drawing.Size(541, 403);
            this.listView_place.TabIndex = 3;
            this.listView_place.UseCompatibleStateImageBehavior = false;
            this.listView_place.View = System.Windows.Forms.View.Details;
            // 
            // groupBox_event
            // 
            this.groupBox_event.Controls.Add(this.groupBox_add_event);
            this.groupBox_event.Location = new System.Drawing.Point(578, 12);
            this.groupBox_event.Name = "groupBox_event";
            this.groupBox_event.Size = new System.Drawing.Size(795, 193);
            this.groupBox_event.TabIndex = 4;
            this.groupBox_event.TabStop = false;
            this.groupBox_event.Text = "Event";
            // 
            // groupBox_place
            // 
            this.groupBox_place.Controls.Add(this.groupBox_get_place);
            this.groupBox_place.Controls.Add(this.groupBox_add_place);
            this.groupBox_place.Location = new System.Drawing.Point(12, 12);
            this.groupBox_place.Name = "groupBox_place";
            this.groupBox_place.Size = new System.Drawing.Size(560, 193);
            this.groupBox_place.TabIndex = 5;
            this.groupBox_place.TabStop = false;
            this.groupBox_place.Text = "Place";
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(9, 36);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(143, 20);
            this.textBox_street.TabIndex = 0;
            // 
            // textBox_house
            // 
            this.textBox_house.Location = new System.Drawing.Point(158, 36);
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(143, 20);
            this.textBox_house.TabIndex = 1;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(307, 36);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(143, 20);
            this.textBox_tel.TabIndex = 2;
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(6, 20);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(35, 13);
            this.label_street.TabIndex = 3;
            this.label_street.Text = "Street";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(304, 20);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(52, 13);
            this.label_tel.TabIndex = 4;
            this.label_tel.Text = "Telphone";
            // 
            // label_house
            // 
            this.label_house.AutoSize = true;
            this.label_house.Location = new System.Drawing.Point(155, 20);
            this.label_house.Name = "label_house";
            this.label_house.Size = new System.Drawing.Size(38, 13);
            this.label_house.TabIndex = 5;
            this.label_house.Text = "House";
            // 
            // groupBox_add_place
            // 
            this.groupBox_add_place.Controls.Add(this.button_add_place);
            this.groupBox_add_place.Controls.Add(this.label_house);
            this.groupBox_add_place.Controls.Add(this.label_street);
            this.groupBox_add_place.Controls.Add(this.label_tel);
            this.groupBox_add_place.Controls.Add(this.textBox_street);
            this.groupBox_add_place.Controls.Add(this.textBox_house);
            this.groupBox_add_place.Controls.Add(this.textBox_tel);
            this.groupBox_add_place.Location = new System.Drawing.Point(6, 19);
            this.groupBox_add_place.Name = "groupBox_add_place";
            this.groupBox_add_place.Size = new System.Drawing.Size(533, 69);
            this.groupBox_add_place.TabIndex = 6;
            this.groupBox_add_place.TabStop = false;
            this.groupBox_add_place.Text = "Add place";
            // 
            // groupBox_get_place
            // 
            this.groupBox_get_place.Controls.Add(this.button_get_place);
            this.groupBox_get_place.Controls.Add(this.label_parking);
            this.groupBox_get_place.Controls.Add(this.label_type_place);
            this.groupBox_get_place.Controls.Add(this.label_pay_card);
            this.groupBox_get_place.Controls.Add(this.comboBox_parking);
            this.groupBox_get_place.Controls.Add(this.comboBox_pay_card);
            this.groupBox_get_place.Controls.Add(this.comboBox_type_place);
            this.groupBox_get_place.Location = new System.Drawing.Point(6, 95);
            this.groupBox_get_place.Name = "groupBox_get_place";
            this.groupBox_get_place.Size = new System.Drawing.Size(533, 73);
            this.groupBox_get_place.TabIndex = 7;
            this.groupBox_get_place.TabStop = false;
            this.groupBox_get_place.Text = "Get place";
            // 
            // comboBox_type_place
            // 
            this.comboBox_type_place.FormattingEnabled = true;
            this.comboBox_type_place.Location = new System.Drawing.Point(6, 46);
            this.comboBox_type_place.Name = "comboBox_type_place";
            this.comboBox_type_place.Size = new System.Drawing.Size(146, 21);
            this.comboBox_type_place.TabIndex = 0;
            // 
            // comboBox_pay_card
            // 
            this.comboBox_pay_card.FormattingEnabled = true;
            this.comboBox_pay_card.Location = new System.Drawing.Point(158, 46);
            this.comboBox_pay_card.Name = "comboBox_pay_card";
            this.comboBox_pay_card.Size = new System.Drawing.Size(143, 21);
            this.comboBox_pay_card.TabIndex = 1;
            // 
            // comboBox_parking
            // 
            this.comboBox_parking.FormattingEnabled = true;
            this.comboBox_parking.Location = new System.Drawing.Point(307, 46);
            this.comboBox_parking.Name = "comboBox_parking";
            this.comboBox_parking.Size = new System.Drawing.Size(143, 21);
            this.comboBox_parking.TabIndex = 2;
            // 
            // label_pay_card
            // 
            this.label_pay_card.AutoSize = true;
            this.label_pay_card.Location = new System.Drawing.Point(155, 30);
            this.label_pay_card.Name = "label_pay_card";
            this.label_pay_card.Size = new System.Drawing.Size(49, 13);
            this.label_pay_card.TabIndex = 4;
            this.label_pay_card.Text = "Pay card";
            // 
            // label_type_place
            // 
            this.label_type_place.AutoSize = true;
            this.label_type_place.Location = new System.Drawing.Point(6, 30);
            this.label_type_place.Name = "label_type_place";
            this.label_type_place.Size = new System.Drawing.Size(31, 13);
            this.label_type_place.TabIndex = 5;
            this.label_type_place.Text = "Type";
            // 
            // label_parking
            // 
            this.label_parking.AutoSize = true;
            this.label_parking.Location = new System.Drawing.Point(304, 30);
            this.label_parking.Name = "label_parking";
            this.label_parking.Size = new System.Drawing.Size(43, 13);
            this.label_parking.TabIndex = 6;
            this.label_parking.Text = "Parking";
            // 
            // groupBox_add_event
            // 
            this.groupBox_add_event.Location = new System.Drawing.Point(6, 19);
            this.groupBox_add_event.Name = "groupBox_add_event";
            this.groupBox_add_event.Size = new System.Drawing.Size(783, 69);
            this.groupBox_add_event.TabIndex = 0;
            this.groupBox_add_event.TabStop = false;
            this.groupBox_add_event.Text = "Add event";
            // 
            // button_add_place
            // 
            this.button_add_place.Location = new System.Drawing.Point(464, 19);
            this.button_add_place.Name = "button_add_place";
            this.button_add_place.Size = new System.Drawing.Size(48, 37);
            this.button_add_place.TabIndex = 6;
            this.button_add_place.Text = "OK";
            this.button_add_place.UseVisualStyleBackColor = true;
            // 
            // button_get_place
            // 
            this.button_get_place.Location = new System.Drawing.Point(464, 30);
            this.button_get_place.Name = "button_get_place";
            this.button_get_place.Size = new System.Drawing.Size(48, 37);
            this.button_get_place.TabIndex = 7;
            this.button_get_place.Text = "OK";
            this.button_get_place.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 644);
            this.Controls.Add(this.groupBox_place);
            this.Controls.Add(this.groupBox_event);
            this.Controls.Add(this.listView_place);
            this.Controls.Add(this.listView_event);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox_event.ResumeLayout(false);
            this.groupBox_place.ResumeLayout(false);
            this.groupBox_add_place.ResumeLayout(false);
            this.groupBox_add_place.PerformLayout();
            this.groupBox_get_place.ResumeLayout(false);
            this.groupBox_get_place.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_event;
        private System.Windows.Forms.ListView listView_place;
        private System.Windows.Forms.GroupBox groupBox_event;
        private System.Windows.Forms.GroupBox groupBox_place;
        private System.Windows.Forms.Label label_house;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_house;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.GroupBox groupBox_get_place;
        private System.Windows.Forms.Label label_parking;
        private System.Windows.Forms.Label label_type_place;
        private System.Windows.Forms.Label label_pay_card;
        private System.Windows.Forms.ComboBox comboBox_parking;
        private System.Windows.Forms.ComboBox comboBox_pay_card;
        private System.Windows.Forms.ComboBox comboBox_type_place;
        private System.Windows.Forms.GroupBox groupBox_add_place;
        private System.Windows.Forms.GroupBox groupBox_add_event;
        private System.Windows.Forms.Button button_get_place;
        private System.Windows.Forms.Button button_add_place;
    }
}

