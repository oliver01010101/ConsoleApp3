using System.Windows;

namespace welcomeMsg
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Welcome, {txtName.Text}!", "Welcome Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void DatePicker_SelectedDateChanged(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate.HasValue)
            {
                var selectedDate = datePicker.SelectedDate.Value;
                MessageBox.Show($"You selected: {selectedDate.ToShortDateString()}", "Date Selected", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
