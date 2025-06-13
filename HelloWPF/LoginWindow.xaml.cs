using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //fake đăng nhập
            //nếu thành công thì vào main window
            //nếu thất bại thì thông báo failed
            if(txtUsername.Text =="obama" && txtPassword.Password == "123")
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                Close();
            }else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
