using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace SharkTool_Alpha_1._0
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            this.Hide();
            contents form1 = new contents();
            form1.ShowDialog();

        }
    }
}
