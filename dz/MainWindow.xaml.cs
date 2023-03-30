using ISP22_2;
using System;
using System.Collections;
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

namespace ISP22_2
{
    public partial class MainWindow : Window
    {
        private OurList<int> ourList = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtLab8.Text);
            ourList.Add(n);
            list8.Items.Add(n);
            txtLab8.Clear();
<<<<<<< HEAD
            updateList8();
=======
            upadteList8();
>>>>>>> 61ec8eb883e200c4c6d1fcf4a7015c9cf7568a15
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            int n = ourList.IndexOf(10);
            ourList.Insert(12, n);
            updateList8();
        }
        private void updateList8()
=======

        }
        private void upadteList8()
>>>>>>> 61ec8eb883e200c4c6d1fcf4a7015c9cf7568a15
        {
            list8.Items.Clear();
            foreach (int i in ourList)
            {
                list8.Items.Add(i);
            }
        }
    }
}
