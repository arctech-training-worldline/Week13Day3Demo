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
using Week13Day3Demo.Models;
using Week13Day3Demo.Services;

namespace Week13Day3Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person _person;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _person = PersonsFileService.LoadFromFile();
            DataContext = _person;

            //TextBoxName.Text = _person.Name;
            //TextBoxAge.Text = _person.Age.ToString();
            //TextBoxComment.Text = _person.Comment;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            //_person.Name = TextBoxName.Text;
            //_person.Age = int.Parse(TextBoxAge.Text);
            //_person.Comment = TextBoxComment.Text;

            PersonsFileService.SaveToFile(_person);
            MessageBox.Show("Data has been saved successfully!", "File Save", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
