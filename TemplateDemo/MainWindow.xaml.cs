using System.Collections.ObjectModel;
using System.Windows;

namespace TemplateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly ObservableCollection<object> source = new ObservableCollection<object>();

        public MainWindow()
        {
            source.Add(new { Year = 2019, Price = 200 });
            source.Add(new { Year = 2018, Price = 180 });
            source.Add(new { Year = 2017, Price = 160 });
            source.Add(new { Year = 2016, Price = 140 });
            source.Add(new { Year = 2015, Price = 120 });

            this.InitializeComponent();
            this.DataContext = source;
        }
    }
}
