using System.Windows;
using System.Windows.Controls;

namespace 数据绑定
{
    /// <summary>
    /// UpdateSourceTriggerSamples.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateSourceTriggerSamples : Window
    {
        public UpdateSourceTriggerSamples()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void BtnUpdateSource_OnClick(object sender, RoutedEventArgs e)
        {
            // 通过文本框对象获取绑定表达式对象
            var binding = TxtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            // 手动更新绑定对象
            binding?.UpdateSource();
        }
    }
}