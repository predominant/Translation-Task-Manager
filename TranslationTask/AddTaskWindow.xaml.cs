using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace TranslationTaskApp
{
    /// <summary>
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        private TranslationTask _task;
        private MainWindow _mainWindow;

        /// <summary>
        /// Constructor for AddTaskWindow
        /// </summary>
        /// <param name="mainWindow"></param>
        public AddTaskWindow(MainWindow mainWindow)
        {
            this._mainWindow = mainWindow;
            InitializeComponent();

            this._task = new TranslationTask();
            this.AddTaskWindow_Grid.DataContext = this._task;
        }

        private void AddTaskWindow_AddButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    this._task.WordCount = Int32.Parse(this.WordCount.Text);
            //}
            //catch (Exception)
            //{
            //    e.Handled = true;
            //    // TODO: Thats more words than a dictionary.
            //}

            this._mainWindow.AddTaskToList(this._task);
            this.Close();
        }

        private void AddTaskWindow_CancelButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var r = new Regex(@"\d+");
            e.Handled = !r.IsMatch(e.Text);
        }
    }
}
