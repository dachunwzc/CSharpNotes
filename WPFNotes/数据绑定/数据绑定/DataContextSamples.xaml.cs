using System.Windows;

namespace 数据绑定
{
    /// <summary>
    /// DataContextSamples.xaml 的交互逻辑
    /// </summary>
    public partial class DataContextSamples : Window
    {
        public DataContextSamples()
        {
            InitializeComponent();

            // 设置窗口的数据上下文
            this.DataContext = this;
        }
    }
}