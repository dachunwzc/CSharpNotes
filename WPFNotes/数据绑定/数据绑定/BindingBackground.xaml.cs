using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace 数据绑定
{
    /// <summary>
    /// BindingBackground.xaml 的交互逻辑
    /// </summary>
    public partial class BindingBackground : Window
    {
        public BindingBackground()
        {
            InitializeComponent();

            // 绑定前端控件显示数据
            BindingData();
        }

        private void BindingData()
        {
            //// 创建绑定对象
            //var binding = new Binding("Text");
            //// 设置绑定源
            //binding.Source = TxtBindingSource;
            //// 设置绑定目标
            //LbValue.SetBinding(TextBlock.TextProperty, binding);

            var binding = new Binding("Text")
            {
                Source = TxtBindingSource
            };

            LbValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}