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

namespace Fody_Example
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new TestViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TestViewModel).ChangeName(Properties.Settings.Default.TestVAl);


            Properties.Settings.Default.TestVAl = "TTTTTT";
            Properties.Settings.Default.Save();
        }
    }
}
