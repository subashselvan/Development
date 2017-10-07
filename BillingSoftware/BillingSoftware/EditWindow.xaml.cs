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

namespace BillingSoftware
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        ItemContex _contex = new ItemContex();
        private Model.Thing _thing = null;
        public EditWindow(Model.Thing thing)
        {
            InitializeComponent();
            _thing = thing;
            lblEditItem.Content = "Edit the Item " + thing.Name;
            txtBuyRate.Text = thing.BuyRate.ToString();
            txtSellRate.Text = thing.SellRate.ToString();
            txtWeightCount.Text = thing.CountWeight.ToString();
        }

        /// <summary>
        /// Save the edit the item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int.TryParse(txtWeightCount.Text,out int countWeight);
            _thing.CountWeight = countWeight;
            double.TryParse(txtBuyRate.Text, out double buyRate);
            _thing.BuyRate = buyRate;
            double.TryParse(txtSellRate.Text, out double sellRate);
            _thing.SellRate = sellRate;
            this.Close();
        }

        public Model.Thing GetThing()
        {
            return _thing;
        }
    }
}
