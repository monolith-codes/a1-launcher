using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AREA1
{
    public partial class MainWindow : Window
    {
        Border closeButton = null;
        Grid minimizeButton = null;
        SolidColorBrush darkgrey = new SolidColorBrush(Color.FromArgb(255, 40, 40, 40));
        SolidColorBrush lightgrey = new SolidColorBrush(Color.FromArgb(255, 100, 100, 100));

        public MainWindow()
        {
            InitializeComponent();
            Loaded += TopBar_Loaded;

            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double boxWidth = screenWidth * 0.5 / 3 * 0.8;
            double boxHeight = (screenHeight / 2 - 50) * 0.7;

            this.Height = screenHeight * 0.5;
            this.Width = screenWidth * 0.5;
            TopBarFrame.Width = screenWidth * 0.5;

            BoxElement1.Width = boxWidth;
            BoxElement1.Height = boxHeight;
            BoxElement2.Width = boxWidth;
            BoxElement2.Height = boxHeight;
            BoxElement3.Width = boxWidth;
            BoxElement3.Height = boxHeight;
        }

        public void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        public void Minimize(object Sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void Close(object Sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void TopBar_Loaded(object sender, RoutedEventArgs e)
        {
            var pageContent = (FrameworkElement)TopBarFrame.Content;

            minimizeButton = (Grid)pageContent.FindName("MinimizeButton");
            closeButton = (Border)pageContent.FindName("CloseButton");

            closeButton.MouseDown += Close;
            closeButton.MouseEnter += Close_Enter;
            closeButton.MouseLeave += Close_Leave;

            minimizeButton.MouseDown += Minimize;
            minimizeButton.MouseEnter += Minimize_Enter;
            minimizeButton.MouseLeave += Minimize_Leave;
        }

        private void Minimize_Enter(object sender, RoutedEventArgs e)
        {
            minimizeButton.Background = lightgrey;
        }

        private void Minimize_Leave(object sender, RoutedEventArgs e)
        {
            minimizeButton.Background = darkgrey;
        }

        private void Close_Enter(object sender, RoutedEventArgs e)
        {
            closeButton.Background = Brushes.Red;
        }

        private void Close_Leave(object sender, RoutedEventArgs e)
        {
            closeButton.Background = darkgrey;
        }
    }
}
