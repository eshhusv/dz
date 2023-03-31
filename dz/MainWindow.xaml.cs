using dz;
using ISP22_2;
using lab678;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        private NodeStack<Product> stack = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(txtLab8.Text);
                ourList.Add(n);
                list8.Items.Add(n);
                txtLab8.Clear();
                updateList8();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (int i in ourList)
                {
                    if (Math.Abs(i) < 2)
                    {
                        ourList.Insert(15, i - 1);
                        updateList8();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateList8()

        {
            list8.Items.Clear();
            foreach (int i in ourList)
            {
                list8.Items.Add(i);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox6.Text != null)
                {
                    Random r = new();
                    int numOfElements = int.Parse(textBox6.Text);
                    List<double> array6 = new();
                    for (int i = 0; i < numOfElements; i++)
                    {
                        double tempNum = r.NextDouble();
                        array6.Add(tempNum);
                    }
                    foreach (double item in array6)
                    {
                        textBlock6.Text += item.ToString("F2") + " ";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new(productName.Text, double.Parse(productPrice.Text));
                stack.Push(product);
                TreeViewItem item = new();
                item.Tag = "Number " + stack.Count;
                item.Header = "Number " + stack.Count;
                item.Items.Add(product.Name);
                item.Items.Add(product.Price);
                treeList.Items.Add(item);
                productName.Clear();
                productPrice.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
