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

namespace projact_in_coding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void italyBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Col1.Fill = new SolidColorBrush(Colors.Green);
            this.Col2.Fill = new SolidColorBrush(Colors.White);
            this.Col3.Fill = new SolidColorBrush(Colors.Red);
        }

        private void italy_Click()
        {
            this.Col1.Fill = new SolidColorBrush(Colors.Green);
            this.Col2.Fill = new SolidColorBrush(Colors.White);
            this.Col3.Fill = new SolidColorBrush(Colors.Red);
        }

        private void franceBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Col1.Fill = new SolidColorBrush(Colors.Blue);
            this.Col2.Fill = new SolidColorBrush(Colors.White);
            this.Col3.Fill = new SolidColorBrush(Colors.Red);

        }

        private void france_Click()
        {
            this.Col1.Fill = new SolidColorBrush(Colors.Blue);
            this.Col2.Fill = new SolidColorBrush(Colors.White);
            this.Col3.Fill = new SolidColorBrush(Colors.Red);

        }

        private void belgiumBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Col1.Fill = new SolidColorBrush(Colors.Black);
            this.Col2.Fill = new SolidColorBrush(Colors.Yellow);
            this.Col3.Fill = new SolidColorBrush(Colors.Red);

        }

        private void belgium_Click()
        {
            this.Col1.Fill = new SolidColorBrush(Colors.Black);
            this.Col2.Fill = new SolidColorBrush(Colors.Yellow);
            this.Col3.Fill = new SolidColorBrush(Colors.Red);

        }

        private void horizontalFlag()
        {
            this.HorizontalBox.Visibility = Visibility.Collapsed;
            this.VerticalBox.Visibility = Visibility.Visible;

        }

        private void contrycbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = this.contrycbox.SelectedItem as ComboBoxItem;
            //belgium_Click();
           switch (selectedItem.Content.ToString().ToLower() )
            {
                case "italy":
                     
                        horizontalFlag();
                        italy_Click();
                    
                    break;
                    

                case "france":
                    horizontalFlag();
                    france_Click();

                    break;
                case "belgium":
                    horizontalFlag();
                    belgium_Click();

                    break;
                case "germany":



                    break;
                case "austria":



                    break;
                case "bolivia":



                    break;

            }
        }
    }
}
