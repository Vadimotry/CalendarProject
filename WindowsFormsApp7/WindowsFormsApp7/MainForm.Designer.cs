namespace CalendarProject
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateLabel = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.clearDateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdmEvents = new System.Windows.Forms.Button();
            this.weatherPanel = new System.Windows.Forms.Panel();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.refreshWeatherButton = new System.Windows.Forms.Button();
            this.weatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(18, 190);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата:";
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(250, 40);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventTextBox.TabIndex = 2;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(456, 38);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(100, 23);
            this.addEventButton.TabIndex = 3;
            this.addEventButton.Text = "Добавить дело";
            this.addEventButton.UseVisualStyleBackColor = true;
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(250, 80);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(306, 160);
            this.eventsListBox.TabIndex = 4;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Location = new System.Drawing.Point(456, 246);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(100, 23);
            this.deleteEventButton.TabIndex = 5;
            this.deleteEventButton.Text = "Удалить дело";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            // 
            // clearDateButton
            // 
            this.clearDateButton.Location = new System.Drawing.Point(250, 246);
            this.clearDateButton.Name = "clearDateButton";
            this.clearDateButton.Size = new System.Drawing.Size(200, 23);
            this.clearDateButton.TabIndex = 6;
            this.clearDateButton.Text = "Очистить все дела на выбранную дату";
            this.clearDateButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новое дело:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список дел:";
            // 
            // AdmEvents
            // 
            this.AdmEvents.Location = new System.Drawing.Point(338, 9);
            this.AdmEvents.Name = "AdmEvents";
            this.AdmEvents.Size = new System.Drawing.Size(234, 23);
            this.AdmEvents.TabIndex = 9;
            this.AdmEvents.Text = "События добавленные администратором";
            this.AdmEvents.UseVisualStyleBackColor = true;
            // 
            // weatherPanel
            // 
            this.weatherPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.weatherPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherPanel.Controls.Add(this.weatherIcon);
            this.weatherPanel.Controls.Add(this.weatherLabel);
            this.weatherPanel.Controls.Add(this.cityComboBox);
            this.weatherPanel.Controls.Add(this.refreshWeatherButton);
            this.weatherPanel.Location = new System.Drawing.Point(600, 10);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.Size = new System.Drawing.Size(200, 120);
            this.weatherPanel.TabIndex = 10;
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.Location = new System.Drawing.Point(10, 40);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(50, 50);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon.TabIndex = 2;
            this.weatherIcon.TabStop = false;
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = false;
            this.weatherLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherLabel.Location = new System.Drawing.Point(70, 40);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(120, 70);
            this.weatherLabel.TabIndex = 3;
            this.weatherLabel.Text = "Выберите город";
            this.weatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Москва",
            "Санкт-Петербург",
            "Новосибирск",
            "Красноярск",
            "Екатеринбург",
            "Казань",
            "Нижний Новгород",
            "Челябинск",
            "Самара",
            "Омск",
            "Ростов-на-Дону"});
            this.cityComboBox.Location = new System.Drawing.Point(10, 10);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(140, 23);
            this.cityComboBox.TabIndex = 1;
            // 
            // refreshWeatherButton
            // 
            this.refreshWeatherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshWeatherButton.BackColor = System.Drawing.Color.White;
            this.refreshWeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshWeatherButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.refreshWeatherButton.Location = new System.Drawing.Point(160, 10);
            this.refreshWeatherButton.Name = "refreshWeatherButton";
            this.refreshWeatherButton.Size = new System.Drawing.Size(30, 23);
            this.refreshWeatherButton.TabIndex = 0;
            this.refreshWeatherButton.Text = "⟳";
            this.refreshWeatherButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.weatherPanel);
            this.Controls.Add(this.AdmEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearDateButton);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MainForm";
            this.Text = "Календарь";
            this.weatherPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button clearDateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdmEvents;
        private System.Windows.Forms.Panel weatherPanel;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Button refreshWeatherButton;
    }
}
