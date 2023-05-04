using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets_System.Common.Util;
using Timesheets_System.Controllers;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Views
{
    public partial class frmChangePassword : Form
    {
        private string _current_user_id = frmLogin.loggedUser.Username;
        UserController _userController = new UserController();

        public frmChangePassword()
        {
            InitializeComponent();
        }

        // Đổi mật khẩu
        private void btChangePassword_Click(object sender, EventArgs e)
        {
            UserDTO user = _userController.GetUserByID(_current_user_id);
            if (String.IsNullOrEmpty(txbNewPassword.Text) || String.IsNullOrEmpty(txbOldPassword.Text) || String.IsNullOrEmpty(txbNewPasswordConfirm.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!StringUtil.Encrytion(txbOldPassword.Text).Equals(user.Password))
            {
                MessageBox.Show("Sai mật khẩu. Xin hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txbNewPassword.Text.Equals(txbNewPasswordConfirm.Text))
            {
                MessageBox.Show("Mật khẩu mới không khớp. Xin hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var encrypted = StringUtil.Encrytion(txbNewPassword.Text);
                _userController.ChangePassword(_current_user_id, encrypted);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Đăng xuất 
                frmLogin.loggedUser = null;
                frmLogin frm = new frmLogin();
                frm.Show();
                List<Form> openForms = new List<Form>();

                // Close all form except the login form
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    if (f.Name != "frmLogin")
                        f.Close();
                }
            }
        }
    }
}
