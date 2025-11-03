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
using FileFlow.Model.Poco;
using FileFlow.ViewModel;

namespace FileFlow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 私有变量

        /// <summary>
        /// 绑定的ViewModel
        /// </summary>
        private MainWindowViewModel _viewModel;

        /// <summary>
        /// 四级目录
        /// </summary>
        private StateFolder[] FourFolder;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;   //绑定ViewModel

            //添加四级目录
            AddFourFolders();
        }

        #region 私有方法

        /// <summary>
        /// 添加四级目录
        /// </summary>
        private void AddFourFolders()
        {
            // 待进行
            StateFolder pendingFolder = new StateFolder("待进行", "", new SolidColorBrush(Color.FromRgb(10, 50, 80)));
            // 进行中
            StateFolder ongoingFolder = new StateFolder("进行中", "", new SolidColorBrush(Color.FromRgb(80, 50, 80)));
            // 已完成 
            StateFolder completedFolder = new StateFolder("已完成", "", new SolidColorBrush(Color.FromRgb(100, 50, 80)));
            // 待删除
            StateFolder deletedFolder = new StateFolder("待删除", "", new SolidColorBrush(Color.FromRgb(10, 200, 80)));

            FourFolder = new StateFolder[4] { pendingFolder, ongoingFolder, completedFolder, deletedFolder };
            _viewModel.StateFolders = FourFolder;
        }


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