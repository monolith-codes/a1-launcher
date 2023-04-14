using System.Windows;
using System.Windows.Controls;


namespace AREA1.Components
{
    /// <summary>
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : Page
    {
        public TopBar()
        {
            InitializeComponent();

            double windowsize = (System.Windows.SystemParameters.PrimaryScreenWidth / 2);

            this.Width = windowsize;

            TopBarGrid.Width = windowsize;
            TopBarLeft.Width = windowsize*0.3;
            TopBarCenter.Width = windowsize * 0.4;
            TopBarRight.Width = windowsize * 0.3;
            TopBarRight.HorizontalAlignment = HorizontalAlignment.Right;
        }
    }
}
