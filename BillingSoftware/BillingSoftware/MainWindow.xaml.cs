﻿using BillingSoftware.Model;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BillingSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemContex dbcontex = new ItemContex();
        public MainWindow()
        {
            InitializeComponent();
            var thing = dbcontex.Things.ToList();
            var buysell = dbcontex.BuySells.ToList();
            InitializeDataGrid(myDataGridBuy);
            InitializeDataGrid(myDataGridSell);
            InitializeDataGridTot(myDataGridBuyTot);
            InitializeDataGridSett(myDataGridBuySettings);
            thing = dbcontex.Things.ToList();
            buysell = dbcontex.BuySells.ToList();

            UpdateItemRemoveComboBox();
        }

        private void InitializeDataGridSett(DataGrid dataGrid)
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

            col1.Binding = new Binding("Id");
            col2.Binding = new Binding("Name");
            col3.Binding = new Binding("CountWeight");
            col4.Binding = new Binding("BuyRate");
            col5.Binding = new Binding("SellRate");

            col1.Header = "No";
            col2.Header = "Name";
            col3.Header = "Weight";
            col4.Header = "Buy Rate";
            col5.Header = "Sell Rate";

            #region
            //insert some file generes
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 1,
            //    Name = "இரும்பு",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 2,
            //    Name = "தகரம்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 3,
            //    Name = "அட்டை",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 4,
            //    Name = "தமிழ் பேப்பர்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 5,
            //    Name = "பீர் பாட்டில்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 6,
            //    Name = "பிராந்தி பாட்டில்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 7,
            //    Name = "செம்பு",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 8,
            //    Name = "அலுமினியம்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 9,
            //    Name = "பித்தளை",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 10,
            //    Name = "தண்ணீர்  பாட்டில்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});

            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 11,
            //    Name = "பிளாஸ்டிக்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 12,
            //    Name = "உடைவு பிளாஸ்டிக்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 13,
            //    Name = "P.V.C. பைப்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 14,
            //    Name = "பைப்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 15,
            //    Name = "கருப்பு",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 16,
            //    Name = "இங்கிலீஸ் பேப்பர்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});

            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 17,
            //    Name = "டேபில் பேப்பர்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 18,
            //    Name = "பால் கவர்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 19,
            //    Name = "சில்",
            //    BuyRate = 0.0,
            //    SellRate = 0.0

            //});
            //dbcontex.Things.Add(new Thing()
            //{
            //    Id = 20,
            //    Name = "செரட்டை",
            //    BuyRate = 0.0,
            //    SellRate = 0.0
            //});

            //dbcontex.SaveChanges();
            #endregion
        }

        private void InitializeDataGridTot(DataGrid dataGrid)
        {
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();

            dataGrid.Columns.Add(col1);
            dataGrid.Columns.Add(col2);
            dataGrid.Columns.Add(col3);

            col1.Binding = new Binding("No");
            col2.Binding = new Binding("Item");
            col3.Binding = new Binding("Weight");

            col1.Header = "No";
            col2.Header = "Item";
            col3.Header = "Weight";

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

            string[] str = File.ReadAllLines(@"C:\Users\subash\Desktop\Items.txt");            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Sell item
            if (tabCtrl.SelectedIndex == 0)
            {
                if(cboBoxSell.SelectedItem == null || string.IsNullOrEmpty(txtBoxSell.Text))
                {
                    MessageBox.Show("Please select/enter text in combo or Text box.");
                    return;
                }
                int.TryParse(txtBoxSell.Text, out int iValue);
                var thing = dbcontex.Things.Where(s => s.Name == cboBoxSell.Text).SingleOrDefault();
                double RatePerKg = thing.SellRate / thing.CountWeight;
               
                myDataGridSell.Items.Add(new MyData
                {
                    No = myDataGridSell.Items.Count + 1,
                    Item = cboBoxSell.Text,
                    Weight = iValue,
                    Rate_1kg = RatePerKg,
                    Amount = iValue * RatePerKg
                });
            }
            //Buy Item
            else if(tabCtrl.SelectedIndex == 1)
            {
                if (cboBoxBuy.SelectedItem == null || string.IsNullOrEmpty(txtBoxBuy.Text))
                {
                    MessageBox.Show("Please select/enter text in combo or Text box.");
                    return;
                }
                int.TryParse(txtBoxBuy.Text, out int iValue);
                var thing = dbcontex.Things.Where(s => s.Name == cboBoxBuy.Text).SingleOrDefault();
                double RatePerKg = thing.BuyRate / thing.CountWeight;

                myDataGridBuy.Items.Add(new MyData
                {
                    No = myDataGridBuy.Items.Count + 1,
                    Item = cboBoxBuy.Text,
                    Weight = iValue,
                    Rate_1kg = RatePerKg,
                    Amount = iValue * RatePerKg
                });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Sell item
            if (tabCtrl.SelectedIndex == 0)
            {
            }
            //Buy item
            else if (tabCtrl.SelectedIndex == 1)
            {
            }
        }
        /// <summary>
        /// Add New Item Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var item = dbcontex.Things.Where(s => s.Name == txtBoxAdd.Text).FirstOrDefault();
            if(item == null)
            {
                Thing thing = new Thing();
                thing.Name = txtBoxAdd.Text;
                thing.SellRate = 0.0;
                thing.BuyRate = 0.0;
                dbcontex.Things.Add(thing);
                dbcontex.SaveChanges();
                UpdateItemRemoveComboBox();
                MessageBox.Show($"Item \'{txtBoxAdd.Text}\' is added successfully.");
                txtBoxAdd.Text = "";
            }
        }

        /// <summary>
        /// Remove Existing item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string str = cboRemove.Text;
            var item = dbcontex.Things.Where(s => s.Name == cboRemove.Text).FirstOrDefault();
            if (item != null)
            {
                dbcontex.Things.Remove(item);
                dbcontex.SaveChanges();
                UpdateItemRemoveComboBox();
                MessageBox.Show($"Item \'{str}\' is Removed successfully.");
            }
        }


        private void UpdateItemRemoveComboBox()
        {
            cboRemove.Items.Clear();
            cboBoxSell.Items.Clear();
            cboBoxBuy.Items.Clear();
            myDataGridBuySettings.Items.Clear();

            using (var db = new ItemContex())
            { 
                var lstItem = db.Things.ToList();

                for (int i = 0; i < lstItem.Count; i++)
                {
                    cboRemove.Items.Add(lstItem[i].Name);
                    cboBoxBuy.Items.Add(lstItem[i].Name);
                    cboBoxSell.Items.Add(lstItem[i].Name);
                    myDataGridBuySettings.Items.Add(new Thing
                    {
                        Id = i + 1,
                        Name = lstItem[i].Name,
                        CountWeight = 1,
                        BuyRate = lstItem[i].BuyRate,
                        SellRate = lstItem[i].SellRate
                    });
                }
            }
        }

        /// <summary>
        /// Edit setting page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var obj  =myDataGridBuySettings.SelectedItem;
            Thing thing = obj as Thing;
            EditWindow window = new EditWindow(thing);
            window.ShowDialog();
            thing = window.GetThing();
            window.Close();

            Thing value = dbcontex.Things.Where(s => s.Name == thing.Name).FirstOrDefault();
            value.BuyRate = thing.BuyRate;
            value.SellRate = thing.SellRate;
            value.CountWeight = thing.CountWeight;           
            dbcontex.SaveChanges();

            UpdateItemRemoveComboBox();
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
