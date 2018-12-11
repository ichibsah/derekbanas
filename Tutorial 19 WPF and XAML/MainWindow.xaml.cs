
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
using Microsoft.Win32;

// Windows Presentation Foundation (WPF)
// is used to create graphical user interfaces
// of a traditional format or within a
// browser (XAML Browser Based App / XBAP)

// Using XAML eXtensible Application Markup Language
// you can create the UI using XML
// XAML allows you to define buttons, boxes,
// animations, 2d / 3d graphics and more

// Create a New Project -> Visual C# -> Windows
// Classic Desktop -> WPF App

namespace WpfTut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string usersName = "";

        public MainWindow()
        {
            // Initializes and displays the window
            InitializeComponent();

            // You can set window properties in code
            this.Title = "Hello World";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        // When the button is clicked it closes the window
        private void Button1Clicked(object sender, RoutedEventArgs e)
        {
            // Opens a message box
            MessageBox.Show("The App is Closing");

            // Closes the app
            this.Close();
        }

        // Event handling that posts the mouse x, y position in title
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Opens an open file dialog
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            // Opens a save file dialog
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            //usersName = UsersName.Text;

            //MessageBox.Show($"Hello {usersName}");
        }
    }
}
