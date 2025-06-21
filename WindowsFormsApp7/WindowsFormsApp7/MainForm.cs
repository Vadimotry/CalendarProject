using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CalendarProject
{
    public partial class MainForm : Form
    {
        private Dictionary<DateTime, List<string>> events = new Dictionary<DateTime, List<string>>();
        private readonly string dataFilePath = Path.Combine(Application.StartupPath, "events.txt");

        public MainForm()
        {
            InitializeComponent();
            LoadEvents();
            UpdateCalendar();
            InitializeWeatherData();

            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            addEventButton.Click += addEventButton_Click;
            deleteEventButton.Click += deleteEventButton_Click;
            clearDateButton.Click += clearDateButton_Click;
            AdmEvents.Click += AdmEvents_Click;
            cityComboBox.SelectedIndexChanged += CityComboBox_SelectedIndexChanged;
            refreshWeatherButton.Click += RefreshWeatherButton_Click;

            if (cityComboBox.Items.Count > 0)
            {
                cityComboBox.SelectedIndex = 0;
            }
        }

        private void InitializeWeatherData()
        {
            if (cityComboBox.SelectedItem != null)
            {
                LoadWeatherData(cityComboBox.SelectedItem.ToString());
            }
        }

        private async void LoadWeatherData(string city)
        {
            try
            {
                weatherLabel.Text = "Загрузка...";
                weatherLabel.ForeColor = Color.Gray;

                string weather = await GetWeatherAsync(city);

                weatherLabel.Text = $"Погода в {city}:\n{weather}";
                weatherLabel.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                weatherLabel.Text = "Ошибка загрузки погоды";
                weatherLabel.ForeColor = Color.Red;
                Console.WriteLine(ex.Message);
            }
        }

        private async Task<string> GetWeatherAsync(string city)
        {
            try
            {
                string apiKey = "9ac14b5c937fc0fd4ce01de2e0fa4448";
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=ru";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        string temp = Math.Round((double)data.main.temp).ToString();
                        string description = data.weather[0].description;
                        string humidity = data.main.humidity;

                        return $"{temp}°C, {description}\nВлажность: {humidity}%";
                    }
                    return "Нет данных от сервера";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Ошибка подключения к серверу";
            }
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedItem != null)
            {
                LoadWeatherData(cityComboBox.SelectedItem.ToString());
            }
        }

        private void RefreshWeatherButton_Click(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedItem != null)
            {
                LoadWeatherData(cityComboBox.SelectedItem.ToString());
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateLabel.Text = e.Start.ToShortDateString();
            UpdateEventsList();
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(eventTextBox.Text))
            {
                DateTime selectedDate = monthCalendar1.SelectionStart;
                string eventText = eventTextBox.Text;

                if (!events.ContainsKey(selectedDate))
                {
                    events[selectedDate] = new List<string>();
                }

                events[selectedDate].Add(eventText);
                eventTextBox.Clear();
                UpdateEventsList();
                SaveEvents();
            }
            else
            {
                MessageBox.Show("Введите текст события", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            if (eventsListBox.SelectedIndex != -1 && events.ContainsKey(selectedDate))
            {
                events[selectedDate].RemoveAt(eventsListBox.SelectedIndex);
                UpdateEventsList();
                SaveEvents();
            }
        }

        private void UpdateEventsList()
        {
            eventsListBox.Items.Clear();
            DateTime selectedDate = monthCalendar1.SelectionStart;

            if (events.ContainsKey(selectedDate))
            {
                eventsListBox.Items.AddRange(events[selectedDate].ToArray());
            }
        }

        private void UpdateCalendar()
        {
            monthCalendar1.RemoveAllBoldedDates();
            foreach (DateTime date in events.Keys)
            {
                monthCalendar1.AddBoldedDate(date);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void SaveEvents()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dataFilePath))
                {
                    foreach (var pair in events)
                    {
                        foreach (string eventText in pair.Value)
                        {
                            writer.WriteLine($"{pair.Key:yyyy-MM-dd}|{eventText}");
                        }
                    }
                }
                UpdateCalendar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEvents()
        {
            if (File.Exists(dataFilePath))
            {
                try
                {
                    events.Clear();
                    string[] lines = File.ReadAllLines(dataFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                        {
                            if (!events.ContainsKey(date))
                            {
                                events[date] = new List<string>();
                            }
                            events[date].Add(parts[1]);
                        }
                    }
                    UpdateCalendar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearDateButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            if (events.ContainsKey(selectedDate))
            {
                if (MessageBox.Show("Удалить все события на выбранную дату?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    events.Remove(selectedDate);
                    UpdateEventsList();
                    SaveEvents();
                }
            }
        }

        private void AdmEvents_Click(object sender, EventArgs e)
        {
            string eventsFile = Path.Combine(Application.StartupPath, "admin_events.txt");

            if (!File.Exists(eventsFile))
            {
                File.WriteAllText(eventsFile, "");
            }

            string adminEvents = File.ReadAllText(eventsFile);
            MessageBox.Show($"События администратора:\n\n{adminEvents}", "Административные события");
        }
    }
}
