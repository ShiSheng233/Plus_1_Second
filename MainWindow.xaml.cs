using System.Windows;

namespace _1s
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            
        }

        public static long click_times = 0;

        private void plus_one_second_button_Click(object sender, RoutedEventArgs e)
        {
            if (click_times != -1)
            {

                click_times++;
                show_click_times.Text = click_times.ToString() + "s";

            }

            
        }
    }
}
