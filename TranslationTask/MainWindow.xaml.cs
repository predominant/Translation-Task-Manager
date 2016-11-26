using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TranslationTaskApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TranslationTask> _tasks;

        public MainWindow()
        {
            InitializeComponent();

            this._tasks = new List<TranslationTask>();
            this._tasks.Add(new TranslationTask()
            {
                Title = "Task 1",
                ElapsedTime = "1:02:03"
            });
            this._tasks.Add(new TranslationTask()
            {
                Title = "ArsonVille",
                ElapsedTime = "0:01:20"
            });

            icTaskList.ItemsSource = this._tasks;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow t = new AddTaskWindow(this);
            this.Topmost = false;
            t.ShowDialog();
        }

        public void AddTaskToList(TranslationTask t)
        {
            this._tasks.Add(t);
            // TODO: This isn't working properly, because dialog.
            //this.Topmost = true;
           
        }
    }
}
