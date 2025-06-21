using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class AdminEventsViewForm : Form
    {
        private string eventsFilePath;

        public AdminEventsViewForm(string eventsFile)
        {
            InitializeComponent();

            // Если файла нет - создаем пустой
            if (!File.Exists(eventsFile))
            {
                File.WriteAllText(eventsFile, "");
            }

            this.eventsFilePath = eventsFile;
            LoadEvents();
        }

        private void LoadEvents()
        {
            try
            {
                if (File.Exists(eventsFilePath))
                {
                    string[] events = File.ReadAllLines(eventsFilePath);
                    foreach (string eventLine in events)
                    {
                        string[] eventParts = eventLine.Split('|');
                        if (eventParts.Length >= 3)
                        {
                            ListViewItem item = new ListViewItem(eventParts[0]); // Название
                            item.SubItems.Add(eventParts[1]); // Дата
                            item.SubItems.Add(eventParts[2]); // Описание
                            listViewEvents.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки событий: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminEventsViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}