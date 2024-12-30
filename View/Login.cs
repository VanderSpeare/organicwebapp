using System;
using System.Windows.Forms;
using BankSystem.Controller; // Nhớ thêm namespace của LoginController

namespace BankSystem.View
{
    public partial class Login : Form
    {
        private LoginController loginController;
        public bool IsAuthenticated { get; private set; } = false;
        public string AuthenticatedUserId { get; private set; }
        public string AuthenticatedUserRole { get; private set; }

        public Login()
        {
            InitializeComponent();
            textBoxId.TabIndex = 0;
            textBoxPassword.TabIndex = 1;
            buttonLogin.TabIndex = 2;
            buttonLogin.Enabled = false;
            this.KeyPreview = true;

            loginController = new LoginController();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập ID và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id.Length > 255)
            {
                MessageBox.Show("ID không được quá 255 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginController.Authenticate(id, password))
            {
                // Đăng nhập thành công, lấy thông tin user
                var employee = loginController.GetEmployeeById(id);
                AuthenticatedUserId = employee.Id;
                AuthenticatedUserRole = employee.Role;
                IsAuthenticated = true;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form đăng nhập
            }
            else
            {
                MessageBox.Show("ID hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Các phương thức còn lại không thay đổi
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxId.Focus();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButtonState();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButtonState();
        }

        private void CheckLoginButtonState()
        {
            buttonLogin.Enabled = !string.IsNullOrEmpty(textBoxId.Text) && !string.IsNullOrEmpty(textBoxPassword.Text);
        }

        private void ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ConfirmExit();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}