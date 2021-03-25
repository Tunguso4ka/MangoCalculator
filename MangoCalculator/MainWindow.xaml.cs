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

namespace MangoCalculator
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button ClickedButton = (Button)sender;
            if ((string)ClickedButton.Tag == "Minimize")
            {
                this.WindowState = WindowState.Minimized;
            }
            else if ((string)ClickedButton.Tag == "Maximize")
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                    MaxiBtn.Content = "";
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    MaxiBtn.Content = "";
                }
            }
            else if ((string)ClickedButton.Tag == "Close")
            {
                Application.Current.Dispatcher.Invoke(Application.Current.Shutdown);
            }
            else if ((string)ClickedButton.Tag == "Theme")
            {
                if((string)ClickedButton.Content == "")
                {
                    ClickedButton.Content = "";
                    this.Background = Brushes.Black;
                }
                else
                {
                    ClickedButton.Content = "";
                    this.Background = Brushes.White;
                }
            }
            //
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
