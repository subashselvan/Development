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

namespace BillingSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            InitializeDataGrid(myDataGridBuy);
            InitializeDataGrid(myDataGridSell);
        }

        private void InitializeDataGrid(DataGrid dataGrid)
        {
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            DataGridTextColumn col4 = new DataGridTextColumn();
            DataGridTextColumn col5 = new DataGridTextColumn();
            dataGrid.Columns.Add(col1);
            dataGrid.Columns.Add(col2);
            dataGrid.Columns.Add(col3);
            dataGrid.Columns.Add(col4);
            dataGrid.Columns.Add(col5);
            col1.Binding = new Binding("No");
            col2.Binding = new Binding("Item");
            col3.Binding = new Binding("Weight");
            col4.Binding = new Binding("Rate_1kg");
            col5.Binding = new Binding("Amount");
            col1.Header = "No";
            col2.Header = "Item";
            col3.Header = "Weight";
            col4.Header = "Rate_1kg";
            col5.Header = "Amount";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (tabCtrl.SelectedIndex == 0)
            {
                int.TryParse(txtBoxSell.Text, out int iValue);
                myDataGridSell.Items.Add(new MyData { No = myDataGridSell.Items.Count + 1, Item = cboBoxSell.Text, Weight = iValue, Rate_1kg = 12, Amount = iValue * 12 });
            }
            else if(tabCtrl.SelectedIndex == 1)
            {
                int.TryParse(txtBoxBuy.Text, out int iValue);
                myDataGridBuy.Items.Add(new MyData { No = myDataGridBuy.Items.Count + 1, Item = cboBoxBuy.Text, Weight = iValue, Rate_1kg = 12, Amount = iValue * 12 });
            }
        }

        private void cboBoxBuy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class MyData
    {
        public int No { get; set; }
        public string Item { get; set; }
        public int Weight { get; set; }
        public double Rate_1kg { get; set; }
        public double Amount { get; set; }
    }
    
}
