using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace RAA2_Module_04_OfficeHours
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MyForm : Window
    {
        public ObservableCollection<DataClass> data { get; set; }

        public MyForm()
        {
            InitializeComponent();

            DataClass data1 = new DataClass("A", "A", "A", "A", "A", "A");
            DataClass data2 = new DataClass("A1", "A1", "A1", "A1", "A1", "A1");
            DataClass data3 = new DataClass("A2", "A2", "A2", "A2", "A2", "A2");
            DataClass data4 = new DataClass("A3", "A3", "A3", "A3", "A3", "A3");

            List<DataClass> dataList = new List<DataClass>();
            dataList.Add(data1);
            dataList.Add(data2);
            dataList.Add(data3);
            dataList.Add(data4);

            data = new ObservableCollection<DataClass>(dataList);

            grdData.ItemsSource = data;
            grdDataDetails.ItemsSource = data;
        }

        private void cbxShowDetails_Checked(object sender, RoutedEventArgs e)
        {
                grdData.Visibility = Visibility.Hidden;
                grdDataDetails.Visibility = Visibility.Visible;
        }

        private void cbxShowDetails_Unchecked(object sender, RoutedEventArgs e)
        {
            grdData.Visibility = Visibility.Visible;
            grdDataDetails.Visibility = Visibility.Hidden;
        }
    }

    public class DataClass
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public string Item6 { get; set; }

        public DataClass(string item1, string item2, string item3, string item4, string item5, string item6)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
        }
    }
}
