using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ozturk_Batuhan_PE1
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {


            double dBedrag = Convert.ToDouble(txtBedrag.Text);
            int iDagen = Convert.ToInt32(txtDagen.Text);

            double dKorting = dBedrag > 300 ? dBedrag * 0.10 : dBedrag > 200 ? dBedrag * 0.05 : 0;

            double dextrakorting = iDagen <= 5 ? (dBedrag - dKorting) * 0.03 : 0;

            double totaalBedrag = dBedrag - dKorting - dextrakorting;

            lblBedragBetaald.Content = $"Bedrag betaald: {dBedrag} €";
            lblKortingsBedrag.Content = $"KortingsBedrag: {dKorting:F2} €";
            lblExtraKorting.Content = $"Eventuele Extra Korting: {dextrakorting:F2} €";
            lblTotaalBedrag.Content = $"Totaal Bedrag: {totaalBedrag:F2} €";








        }
    }
}