using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyProperties
{
    public class ExampleDependencyObject : DependencyObject
    {
        public static readonly DependencyProperty IdProperty = DependencyProperty.Register(nameof(Id), typeof(string), typeof(ExampleDependencyObject));

        public string Id
        {
            get { return this.GetValue(IdProperty) as string; }
            set
            {
                this.SetValue(IdProperty, value);
            }
        }
    }
}
