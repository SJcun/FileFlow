using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileFlow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 私有变量

        

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region 私有方法

        private void BrowseRootFolder_Click(object sender, RoutedEventArgs e)
        {
            // 实现选择文件夹逻辑
        }

        private void SaveConfig_Click(object sender, RoutedEventArgs e)
        {
            // 保存配置逻辑
        }

        private void InstallContextMenu_Click(object sender, RoutedEventArgs e)
        {
            // 注册右键菜单逻辑
        }

        private void UninstallContextMenu_Click(object sender, RoutedEventArgs e)
        {
            // 卸载右键菜单逻辑
        }

        /// <summary>
        /// 鼠标点击，系统级拖拽效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                // 直接触发系统级拖拽
                DragMove();
            }
        }

        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            // 最小化窗口
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // 关闭窗口
            this.Close();
        }

        #endregion
    }
}