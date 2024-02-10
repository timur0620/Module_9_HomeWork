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
using System.Diagnostics;
using System.Xml.Linq;

namespace Module_9_HomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonOne(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(enterText.Text))
            {
                MessageBox.Show("You haven't entered any offers", this.Title,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }
            foreach (string word in enterText.Text.Split(' '))
            {
                listBoxAnswer.Items.Add(word);
            }
        }
        private void ButtonTwo(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(enterTextTask2.Text))
            {
                MessageBox.Show("You haven't entered any offers", this.Title,
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                return;
            }
            string[] textMassive = enterTextTask2.Text.Split(' ');

            int lengthText = textMassive.Length;

            for (int i = lengthText - 1; i > -1; i--)
            {
                listBoxAnswerTask2.Items.Add(textMassive[i]);
            }
        }
    }
}
