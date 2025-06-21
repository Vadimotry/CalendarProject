using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class AdminAddEventForm : Form
    {
        private string usersDirectory = Path.Combine(Application.StartupPath, "users");

        public AdminAddEventForm()
        {
            InitializeComponent();

            // Создаем путь к папке users в директории приложения
            usersDirectory = Path.Combine(Application.StartupPath, "users");

            // Если папки не существует - создаем ее
            if (!Directory.Exists(usersDirectory))
            {
                Directory.CreateDirectory(usersDirectory);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text.Trim();
            string eventDate = dtpEventDate.Value.ToString("yyyy-MM-dd");
            string eventDescription = txtEventDescription.Text.Trim();

            if (string.IsNullOrEmpty(eventName))
            {
                MessageBox.Show("Введите название события");
                return;
            }

            try
            {
                // Проверяем существование папки users
                if (!Directory.Exists(usersDirectory))
                {
                    MessageBox.Show("Папка пользователей не найдена. Создана новая папка.");
                    Directory.CreateDirectory(usersDirectory);
                }

                string adminEventsFile = Path.Combine(Application.StartupPath, "admin_events.txt");
                string eventLine = $"{eventName}|{eventDate}|{eventDescription}";

                // Добавляем событие в общий файл администратора
                File.AppendAllText(adminEventsFile, eventLine + Environment.NewLine);

                // Добавляем событие для всех пользователей
                foreach (string userFolder in Directory.GetDirectories(usersDirectory))
                {
                    string userEventsFile = Path.Combine(userFolder, "events.txt");

                    // Если файла нет - создаем
                    if (!File.Exists(userEventsFile))
                    {
                        File.WriteAllText(userEventsFile, "");
                    }

                    File.AppendAllText(userEventsFile, eventLine + Environment.NewLine);
                }

                MessageBox.Show("Событие успешно добавлено!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n\nПодробности: {ex.StackTrace}");
            }
        }

        private void AdminAddEventForm_Load(object sender, EventArgs e)
        {

        }
    }
}