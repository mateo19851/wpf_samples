using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ExampleDependencyObject exampleDependencyObject = new ExampleDependencyObject();
        private ExampleModelClass exampleModelClass = new ExampleModelClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeDepProp_OnClick(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                exampleDependencyObject.Id = Guid.NewGuid().ToString();
            }).Wait();
        }

        private void ChangeModelProperty_OnClick(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                this.exampleModelClass.Id = Guid.NewGuid().ToString();
            }).Wait();
        }
    }
}
