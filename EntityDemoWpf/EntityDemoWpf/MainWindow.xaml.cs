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

namespace EntityDemoWpf
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            northwindEntities entities = new northwindEntities();

            var finnishCustomers =  from c in entities.Customers
                                    where c.Country == "Finland"
                                    select c;

            foreach (var cust in finnishCustomers)
            {
                MessageBox.Show(cust.CompanyName);
            }

        }

        private void linqkysely_Click(object sender, RoutedEventArgs e)
        {
            int[] numerot = { 5, 13, 5, 16, 58, 16, 55, 2, 33, 58, 90, 77 };

            // suurempi kuin 5 tulokset lajiteltuna
            //SELECT luku FROM numerot WHERE luku > 5 ORDER BY luku

            var suuretNumerot = from n in numerot
                                where n > 5
                                orderby n
                                select n;

            foreach (var numero in suuretNumerot)
            {
                MessageBox.Show(numero.ToString());
            }
        }
    }
}
