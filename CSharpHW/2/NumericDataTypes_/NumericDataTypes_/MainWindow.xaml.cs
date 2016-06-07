using System;
using System.Windows;
using System.Windows.Controls;


namespace NumericDataTypes_
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

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (type.SelectedItem as ListBoxItem);
            switch (selectedItem.Content.ToString())
            {
                case "sbyte":
                    ShowSbyteValue();
                    break;
                case "short":
                    ShowShortValue();
                    break;
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "byte":
                    ShowByteValue();
                    break;
                case "ushort":
                    ShowUshortValue();
                    break;
                case "uint":
                    ShowUintValue();
                    break;
                case "ulong":
                    ShowUlongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
             
              

            }

        }
        private void ShowSbyteValue()
        {
            minValue.Text = sbyte.MinValue.ToString();
            maxValue.Text = sbyte.MaxValue.ToString();
            defValue.Text = new sbyte().ToString();

        }
        private void ShowShortValue()
        {
            minValue.Text = short.MinValue.ToString();
            maxValue.Text = short.MaxValue.ToString();
            defValue.Text = new short().ToString();

        }
        private void ShowIntValue()
        {
            minValue.Text = int.MinValue.ToString();
            maxValue.Text = int.MaxValue.ToString();
            defValue.Text = new int().ToString();

        }

        private void ShowLongValue()
        {
            minValue.Text = long.MinValue.ToString();
            maxValue.Text = long.MaxValue.ToString();
            defValue.Text = new long().ToString();
        }
        private void ShowByteValue()
        {
            minValue.Text = byte.MinValue.ToString();
            maxValue.Text = byte.MaxValue.ToString();
            defValue.Text = new byte().ToString();
        }

        private void ShowUshortValue()
        {
            minValue.Text = ushort.MinValue.ToString();
            maxValue.Text = ushort.MaxValue.ToString();
            defValue.Text = new ushort().ToString();
        }
        private void ShowUintValue()
        {
            minValue.Text = uint.MinValue.ToString();
            maxValue.Text = ushort.MaxValue.ToString();
            defValue.Text = new ushort().ToString();
        }

        private void ShowUlongValue()
        {
            minValue.Text = ulong.MinValue.ToString();
            maxValue.Text = ulong.MaxValue.ToString();
            defValue.Text = new ulong().ToString();
        }

        private void ShowFloatValue()
        {
            minValue.Text = float.MinValue.ToString();
            maxValue.Text = float.MaxValue.ToString();
            defValue.Text = new float().ToString();
        }

        private void ShowDoubleValue()
        {
            minValue.Text = double.MinValue.ToString();
            maxValue.Text = double.MaxValue.ToString();
            defValue.Text = new double().ToString();
        }

        private void ShowDecimalValue()
        {
            minValue.Text = decimal.MinValue.ToString();
            maxValue.Text = decimal.MaxValue.ToString();
            defValue.Text = new decimal().ToString();
        }

     
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

