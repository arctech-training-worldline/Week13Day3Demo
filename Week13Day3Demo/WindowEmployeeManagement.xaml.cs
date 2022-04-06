using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Week13Day3Demo.Models;
using Week13Day3Demo.Services;

namespace Week13Day3Demo
{
    /// <summary>
    /// Interaction logic for WindowEmployeeManagement.xaml
    /// </summary>
    public partial class WindowEmployeeManagement : Window
    {
        PersonsDbService _personsDbService;

        public WindowEmployeeManagement()
        {
            InitializeComponent();            
        }

        public void Start()
        {
            _personsDbService = new PersonsDbService();
            
            DataContext = _personsDbService;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void ButtonInsert_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.Insert();
            TextBoxName.Focus();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.Update();
        }

        private void ButtonFirst_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.First();
        }

        private void ButtonPrevious_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.Previous();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.Next();
        }

        private void ButtonLast_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.Last();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.Save();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            _personsDbService.StopEditing();
        }        
    }
}
