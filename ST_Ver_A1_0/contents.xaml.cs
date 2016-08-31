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
using System.Windows.Shapes;

namespace SharkTool_Alpha_1._0
{
    /// <summary>
    /// contents.xaml 的交互逻辑
    /// </summary>
    public partial class contents : Window
    {
        public contents()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void title(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)

                DragMove();

        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mini(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void main(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(
            0x7a,
            0x7a,
            0x7a));
        }

        private void start(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "第一步-这是，我的世界？")
            this.Hide();
            Step_1 form1 = new Step_1();
            form1.ShowDialog();
        }
    }
}
