using System.Collections.ObjectModel;
using System.Windows;

namespace BindingDemo
{
    /// <summary>
    /// ItemSourceWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ItemSourceWindow : Window
    {
        private readonly ObservableCollection<Human> humen = new ObservableCollection<Human>()
        {
             new Human(){ Name = "Leon", Age = 18 },
             new Human(){ Name = "Leon1", Age = 19 },
             new Human(){ Name = "Leon2", Age = 20 },
             new Human(){ Name = "Leon3", Age = 21 },
        };

        public ItemSourceWindow()
        {
            this.InitializeComponent();
            this.DataContext = this.humen;
        }
    }
}
