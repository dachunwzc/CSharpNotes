using DataTemplate.ViewModel;
using System.Windows;

namespace DataTemplate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ComboxNote : Window
    {
        public ComboxNote()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }
    }
}
