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

namespace Ozturk_Batuhan_PE1
{
    /// <summary>
    /// Interaction logic for Vraag22.xaml
    /// </summary>
    public partial class Vraag22 : Window
    {
        public Vraag22()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            int Datum = Convert.ToInt32(txtDatum.Text);

            int dag = (int)(Datum / 1000000);
            int maand = (int)((Datum / 1000000) % 100);
            int jaar = (int)(Datum % 1000000);

            int SinterKlaasDag = 6;
            int SinterKlaasMaand = 12;

            const int DAGEN_IN_MAAND = 30;

            int iTotaalDagen = ((SinterKlaasMaand - (maand + 1)) * DAGEN_IN_MAAND) + (SinterKlaasDag - dag);

            lblResultaat.Content = $"Het is nog {iTotaalDagen} dagen voor het Sinterklaas is";
        }
    }
}
